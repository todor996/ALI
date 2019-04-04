namespace Chess
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BoardContainer = new System.Windows.Forms.Panel();
            this.Board = new System.Windows.Forms.FlowLayoutPanel();
            this.InfoContainer = new System.Windows.Forms.Panel();
            this.LayoutPanel1 = new System.Windows.Forms.Panel();
            this.LayoutPanel2 = new System.Windows.Forms.Panel();
            this.LayoutPanel3 = new System.Windows.Forms.Panel();
            this.MovesList = new System.Windows.Forms.ListBox();
            this.InfoTable = new System.Windows.Forms.DataGridView();
            this.Evaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamesContainer = new System.Windows.Forms.Panel();
            this.NameBlack = new System.Windows.Forms.Label();
            this.NameWhite = new System.Windows.Forms.Label();
            this.ImagesContainer = new System.Windows.Forms.Panel();
            this.ImageBlack = new System.Windows.Forms.Panel();
            this.ImageWhite = new System.Windows.Forms.Panel();
            this.TimersContainer = new System.Windows.Forms.Panel();
            this.TimerWhite = new System.Windows.Forms.Label();
            this.TimerBlack = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BoardContainer.SuspendLayout();
            this.InfoContainer.SuspendLayout();
            this.LayoutPanel1.SuspendLayout();
            this.LayoutPanel2.SuspendLayout();
            this.LayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).BeginInit();
            this.NamesContainer.SuspendLayout();
            this.ImagesContainer.SuspendLayout();
            this.TimersContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoardContainer
            // 
            this.BoardContainer.BackColor = System.Drawing.Color.White;
            this.BoardContainer.Controls.Add(this.Board);
            this.BoardContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoardContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.BoardContainer.Location = new System.Drawing.Point(0, 0);
            this.BoardContainer.Name = "BoardContainer";
            this.BoardContainer.Size = new System.Drawing.Size(494, 450);
            this.BoardContainer.TabIndex = 0;
            // 
            // Board
            // 
            this.Board.Location = new System.Drawing.Point(22, 0);
            this.Board.Margin = new System.Windows.Forms.Padding(0);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(450, 450);
            this.Board.TabIndex = 0;
            // 
            // InfoContainer
            // 
            this.InfoContainer.BackColor = System.Drawing.Color.White;
            this.InfoContainer.Controls.Add(this.LayoutPanel1);
            this.InfoContainer.Controls.Add(this.TimersContainer);
            this.InfoContainer.Controls.Add(this.panel3);
            this.InfoContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoContainer.Location = new System.Drawing.Point(500, 0);
            this.InfoContainer.Name = "InfoContainer";
            this.InfoContainer.Size = new System.Drawing.Size(300, 450);
            this.InfoContainer.TabIndex = 3;
            // 
            // LayoutPanel1
            // 
            this.LayoutPanel1.Controls.Add(this.LayoutPanel2);
            this.LayoutPanel1.Controls.Add(this.ImagesContainer);
            this.LayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.LayoutPanel1.Name = "LayoutPanel1";
            this.LayoutPanel1.Size = new System.Drawing.Size(300, 425);
            this.LayoutPanel1.TabIndex = 4;
            // 
            // LayoutPanel2
            // 
            this.LayoutPanel2.Controls.Add(this.LayoutPanel3);
            this.LayoutPanel2.Controls.Add(this.NamesContainer);
            this.LayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.LayoutPanel2.Name = "LayoutPanel2";
            this.LayoutPanel2.Size = new System.Drawing.Size(300, 375);
            this.LayoutPanel2.TabIndex = 1;
            // 
            // LayoutPanel3
            // 
            this.LayoutPanel3.Controls.Add(this.MovesList);
            this.LayoutPanel3.Controls.Add(this.InfoTable);
            this.LayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel3.Location = new System.Drawing.Point(0, 16);
            this.LayoutPanel3.Name = "LayoutPanel3";
            this.LayoutPanel3.Size = new System.Drawing.Size(300, 359);
            this.LayoutPanel3.TabIndex = 1;
            // 
            // MovesList
            // 
            this.MovesList.BackColor = System.Drawing.Color.White;
            this.MovesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovesList.FormattingEnabled = true;
            this.MovesList.ItemHeight = 16;
            this.MovesList.Location = new System.Drawing.Point(0, 0);
            this.MovesList.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.MovesList.Name = "MovesList";
            this.MovesList.Size = new System.Drawing.Size(300, 312);
            this.MovesList.TabIndex = 5;
            // 
            // InfoTable
            // 
            this.InfoTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InfoTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InfoTable.BackgroundColor = System.Drawing.Color.White;
            this.InfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.InfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evaluation,
            this.Depth,
            this.NPS});
            this.InfoTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoTable.Location = new System.Drawing.Point(0, 312);
            this.InfoTable.MultiSelect = false;
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.ReadOnly = true;
            this.InfoTable.RowHeadersVisible = false;
            this.InfoTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.InfoTable.Size = new System.Drawing.Size(300, 47);
            this.InfoTable.TabIndex = 4;
            // 
            // Evaluation
            // 
            this.Evaluation.Frozen = true;
            this.Evaluation.HeaderText = "Evaluation";
            this.Evaluation.Name = "Evaluation";
            this.Evaluation.ReadOnly = true;
            this.Evaluation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Evaluation.Width = 99;
            // 
            // Depth
            // 
            this.Depth.Frozen = true;
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            this.Depth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Depth.Width = 71;
            // 
            // NPS
            // 
            this.NPS.Frozen = true;
            this.NPS.HeaderText = "NPS";
            this.NPS.Name = "NPS";
            this.NPS.ReadOnly = true;
            this.NPS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NPS.Width = 61;
            // 
            // NamesContainer
            // 
            this.NamesContainer.Controls.Add(this.NameBlack);
            this.NamesContainer.Controls.Add(this.NameWhite);
            this.NamesContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamesContainer.Location = new System.Drawing.Point(0, 0);
            this.NamesContainer.Name = "NamesContainer";
            this.NamesContainer.Size = new System.Drawing.Size(300, 16);
            this.NamesContainer.TabIndex = 0;
            // 
            // NameBlack
            // 
            this.NameBlack.AutoSize = true;
            this.NameBlack.Dock = System.Windows.Forms.DockStyle.Right;
            this.NameBlack.Location = new System.Drawing.Point(300, 0);
            this.NameBlack.Name = "NameBlack";
            this.NameBlack.Size = new System.Drawing.Size(0, 17);
            this.NameBlack.TabIndex = 1;
            // 
            // NameWhite
            // 
            this.NameWhite.AutoSize = true;
            this.NameWhite.Location = new System.Drawing.Point(0, 0);
            this.NameWhite.Name = "NameWhite";
            this.NameWhite.Size = new System.Drawing.Size(0, 17);
            this.NameWhite.TabIndex = 0;
            // 
            // ImagesContainer
            // 
            this.ImagesContainer.Controls.Add(this.ImageBlack);
            this.ImagesContainer.Controls.Add(this.ImageWhite);
            this.ImagesContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImagesContainer.Location = new System.Drawing.Point(0, 0);
            this.ImagesContainer.Name = "ImagesContainer";
            this.ImagesContainer.Size = new System.Drawing.Size(300, 50);
            this.ImagesContainer.TabIndex = 0;
            // 
            // ImageBlack
            // 
            this.ImageBlack.BackColor = System.Drawing.Color.Transparent;
            this.ImageBlack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageBlack.BackgroundImage")));
            this.ImageBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageBlack.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImageBlack.Location = new System.Drawing.Point(250, 0);
            this.ImageBlack.Name = "ImageBlack";
            this.ImageBlack.Size = new System.Drawing.Size(50, 50);
            this.ImageBlack.TabIndex = 31;
            // 
            // ImageWhite
            // 
            this.ImageWhite.BackColor = System.Drawing.Color.Transparent;
            this.ImageWhite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageWhite.BackgroundImage")));
            this.ImageWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageWhite.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImageWhite.Location = new System.Drawing.Point(0, 0);
            this.ImageWhite.Name = "ImageWhite";
            this.ImageWhite.Size = new System.Drawing.Size(50, 50);
            this.ImageWhite.TabIndex = 30;
            // 
            // TimersContainer
            // 
            this.TimersContainer.Controls.Add(this.TimerWhite);
            this.TimersContainer.Controls.Add(this.TimerBlack);
            this.TimersContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimersContainer.Location = new System.Drawing.Point(0, 0);
            this.TimersContainer.Name = "TimersContainer";
            this.TimersContainer.Size = new System.Drawing.Size(300, 25);
            this.TimersContainer.TabIndex = 3;
            // 
            // TimerWhite
            // 
            this.TimerWhite.AutoSize = true;
            this.TimerWhite.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimerWhite.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimerWhite.Location = new System.Drawing.Point(0, 0);
            this.TimerWhite.Name = "TimerWhite";
            this.TimerWhite.Size = new System.Drawing.Size(0, 24);
            this.TimerWhite.TabIndex = 35;
            // 
            // TimerBlack
            // 
            this.TimerBlack.AutoSize = true;
            this.TimerBlack.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimerBlack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimerBlack.Location = new System.Drawing.Point(300, 0);
            this.TimerBlack.Name = "TimerBlack";
            this.TimerBlack.Size = new System.Drawing.Size(0, 24);
            this.TimerBlack.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            this.panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoContainer);
            this.Controls.Add(this.BoardContainer);
            this.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Name = "MainForm";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.BoardContainer.ResumeLayout(false);
            this.InfoContainer.ResumeLayout(false);
            this.InfoContainer.PerformLayout();
            this.LayoutPanel1.ResumeLayout(false);
            this.LayoutPanel2.ResumeLayout(false);
            this.LayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).EndInit();
            this.NamesContainer.ResumeLayout(false);
            this.NamesContainer.PerformLayout();
            this.ImagesContainer.ResumeLayout(false);
            this.TimersContainer.ResumeLayout(false);
            this.TimersContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel BoardContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel LayoutPanel1;
        private System.Windows.Forms.Panel LayoutPanel2;
        private System.Windows.Forms.Panel LayoutPanel3;
        private System.Windows.Forms.ListBox MovesList;
        private System.Windows.Forms.DataGridView InfoTable;
        private System.Windows.Forms.Panel NamesContainer;
        private System.Windows.Forms.Label NameBlack;
        private System.Windows.Forms.Label NameWhite;
        private System.Windows.Forms.Panel ImagesContainer;
        private System.Windows.Forms.Panel ImageBlack;
        private System.Windows.Forms.Panel ImageWhite;
        private System.Windows.Forms.Panel TimersContainer;
        private System.Windows.Forms.Label TimerWhite;
        private System.Windows.Forms.Label TimerBlack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPS;
        private System.Windows.Forms.FlowLayoutPanel Board;
        private System.Windows.Forms.Panel InfoContainer;
    }
}