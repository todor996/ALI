using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class MainForm : Form
    {
        #region Atributes
        const int frame = 16, delimiter = 6;
        const float tableSignFontSizeDiv = 50F, tablePieceDiv = 8.4F;
        float containerWidthRatio, infoContainerFontSizeRatio, timerFontSizeRatio, imagesFontSizeRatio;
        int oldInfoTableFontHeight;
        string imagesPath;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            Init();
            imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Resources\\");
            FillWithTestData();
        }

        #region Responsive Design
        private void Init()
        {
            containerWidthRatio = BoardContainer.Width / (float)Width;
            infoContainerFontSizeRatio = InfoContainer.Font.Size / Height;
            timerFontSizeRatio = TimerWhite.Font.Size / InfoContainer.Width;
            imagesFontSizeRatio = ImageWhite.Height / (float)InfoContainer.Width;
            oldInfoTableFontHeight = InfoTable.Font.Height;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Adjust((int)(containerWidthRatio * Width));
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (ValidateCursorPosition(e.X))
            {
                Adjust(e.X);
                containerWidthRatio = BoardContainer.Width / (float)Width;
            }
        }

        private bool ValidateCursorPosition(int x)
        {
            return x >= 0 && x <= Width - frame - delimiter;
        }

        private void Adjust(int size)
        {
            AdjustContainers(size);
            CheckFontSize();

            ResizeBoard();
            CentralizeBoard();

            AdjustInfoContainer();
        }

        private void AdjustContainers(int size)
        {
            BoardContainer.Width = size;
            InfoContainer.Width = Width - frame - delimiter - size;
            InfoContainer.Location = new Point(size + 6);
        }

        private void CheckFontSize()
        {
            float fontSize = infoContainerFontSizeRatio * InfoContainer.Width;
            if (Math.Abs(fontSize - InfoContainer.Font.Size) > 1)
                InfoContainer.Font = new Font(InfoContainer.Font.FontFamily.Name, fontSize);
        }

        private int Round8(int number)
        {
            return number % 8 == 0 ? number : Round8(number - 1);
        }

        private void ResizeBoard()
        {
            int size = Round8(Math.Min(BoardContainer.Width, BoardContainer.Height));
            if (size != Board.Width && size != Board.Height)
            {
                Board.Size = new Size(size, size);
                AdjustBoard((int)(size / tablePieceDiv));
            }
        }

        private void AdjustBoard(int size)
        {
            foreach (Control c in Board.Controls)
            {
                if ((c.GetType() == typeof(Field)))
                    c.Size = new Size(size, size);
                else
                {
                    c.Font = new Font(c.Font.FontFamily, Board.Width / tableSignFontSizeDiv);
                    int tmp;
                    if (!int.TryParse(c.Text, out tmp))
                        c.Margin = new Padding(0, 0, size - c.Font.Height - 1, 0);
                }    
            }
        }

        private void CentralizeBoard()
        {
            int x = (BoardContainer.Width - Board.Width) / 2;
            int y = (BoardContainer.Height - Board.Height) / 2;
            Board.Location = new Point(x, y);
        }

        private void AdjustInfoContainer()
        {
            float fontSize = infoContainerFontSizeRatio * Height;
            InfoContainer.Font = new Font(InfoContainer.Font.FontFamily.Name, fontSize);

            TimerWhite.Font = TimerBlack.Font = new Font(TimerWhite.Font.FontFamily.Name, timerFontSizeRatio * InfoContainer.Width);
            TimersContainer.Height = TimerWhite.Font.Height;

            int imageSize = (int)(imagesFontSizeRatio * InfoContainer.Width);
            ImageWhite.Size = ImageBlack.Size = new Size(imageSize, imageSize);
            ImagesContainer.Height = imageSize;

            NamesContainer.Height = NameWhite.Font.Height;

            InfoTable.Height += 2 * (InfoTable.Font.Height - oldInfoTableFontHeight);
            oldInfoTableFontHeight = InfoTable.Font.Height;
        }
        #endregion

        private void FillWithTestData()
        {
            FillBoard("tsldkl.tpppp.ppp.....s......p.......P........S..PPPP.PPPTSLDKL.T", 
                      new Point(1, 7), new Point(3, 6));
            SetTimers("0:15:40", "0:18:33");
            DisableWhiteTimer(true);
            SetNames("GM Marko Markovic", "GM Petar Petrovic");
            SetInfoTableParams("+ 3.45", "24", "3.4 Mnps");
            List<string> moves = new List<string>();
            moves.Add("1. e2e4 e7e5");
            moves.Add("2. Sf3 Sf6");
            FillMovesList(moves);
        }

        private void SetTimers(string timerWhite, string timerBlack)
        {
            TimerWhite.Text = timerWhite;
            TimerBlack.Text = timerBlack;
        }

        private void DisableWhiteTimer(bool white)
        {
            if (white)
            {
                TimerWhite.ForeColor = SystemColors.AppWorkspace;
                TimerWhite.BackColor = Color.WhiteSmoke;

                TimerBlack.ForeColor = SystemColors.ControlText;
                TimerBlack.BackColor = Color.White;
            }
            else
            {
                TimerBlack.ForeColor = SystemColors.AppWorkspace;
                TimerBlack.BackColor = Color.WhiteSmoke;

                TimerWhite.ForeColor = SystemColors.ControlText;
                TimerWhite.BackColor = Color.White;
            }
        }

        private void SetNames(string nameWhite, string nameBlack)
        {
            NameWhite.Text = nameWhite;
            NameBlack.Text = nameBlack;
        }

        private void FillMovesList(List<string> moves)
        {
            MovesList.Items.Clear();
            foreach(string move in moves)
                MovesList.Items.Add(move);
            MovesList.SelectedIndex = moves.Count - 1;
        }

        private void SetInfoTableParams(string evaluation, string depth, string nps)
        {
            InfoTable.Rows[0].Cells[0].Value = evaluation;
            InfoTable.Rows[0].Cells[1].Value = depth;
            InfoTable.Rows[0].Cells[2].Value = nps;
        }

        private void FillBoard(string control, Point oldPosition, Point currentPosition)
        {
            int counter = 0, size = (int)(Board.Width / tablePieceDiv);
            int old = --oldPosition.X * 8 + --oldPosition.Y;
            int current = --currentPosition.X * 8 + --currentPosition.Y;

            Board.Controls.Clear();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board.Controls.Add(new Field(size,
                                                 counter == old || counter == current,
                                                 GetImageFolder(i, j) + Decode(control[counter++])));
                }
                Board.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Text = (8 - i).ToString(),
                    Font = new Font(Font.FontFamily, Board.Width / tableSignFontSizeDiv)
                });
            }
            char sign = 'A';
            for (int i = 0; i < 8; i++)
            {
                Board.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Text = sign++.ToString(),
                    Margin = new Padding(0, 0, size - Font.Height - 1, 0),
                    Font = new Font(Font.FontFamily, Board.Width / tableSignFontSizeDiv)
                });
            }
        }

        private string GetImageFolder(int row, int column)
        {
            string fieldColor;
            if ((row + column) % 2 == 0)
                fieldColor = "L\\";
            else
                fieldColor = "D\\";
            return imagesPath + fieldColor;
        }

        private string Decode(char c)
        {
            switch(c)
            {
                case 't':
                    return "BR.bmp";
                case 'T':
                    return "WR.bmp";

                case 's':
                    return "BN.bmp";
                case 'S':
                    return "WN.bmp";

                case 'l':
                    return "BB.bmp";
                case 'L':
                    return "WB.bmp";

                case 'd':
                    return "BQ.bmp";
                case 'D':
                    return "WQ.bmp";

                case 'k':
                    return "BK.bmp";
                case 'K':
                    return "WK.bmp";

                case 'p':
                    return "BP.bmp";
                case 'P':
                    return "WP.bmp";

                default:
                    return "E.bmp";
            }
        }
    }

    public class Field : Button
    {
        public Field(int size, bool selected, string image)
        {
            Size = new Size(size, size);
            Margin = new Padding(0);

            FlatStyle = FlatStyle.Flat;
            if (selected)
                FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            else
                FlatAppearance.BorderSize = 0;

            BackgroundImage = new Bitmap(image);
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}