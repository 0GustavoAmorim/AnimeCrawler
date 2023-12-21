namespace AnimeCrawler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Episodio = new DataGridViewTextBoxColumn();
            Player = new DataGridViewTextBoxColumn();
            Atualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Episodio, Player });
            dataGridView1.Location = new Point(1, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(873, 613);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Episodio
            // 
            Episodio.HeaderText = "Episodio";
            Episodio.Name = "Episodio";
            Episodio.Width = 300;
            // 
            // Player
            // 
            Player.HeaderText = "Player";
            Player.Name = "Player";
            // 
            // Atualizar
            // 
            Atualizar.BackColor = SystemColors.ControlDark;
            Atualizar.Cursor = Cursors.Hand;
            Atualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Atualizar.Location = new Point(12, 12);
            Atualizar.Name = "Atualizar";
            Atualizar.RightToLeft = RightToLeft.No;
            Atualizar.Size = new Size(194, 55);
            Atualizar.TabIndex = 1;
            Atualizar.Text = "Atualizar\r\n Lista";
            Atualizar.UseVisualStyleBackColor = false;
            Atualizar.Click += Atualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 696);
            Controls.Add(Atualizar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Atualizar;
        private DataGridViewTextBoxColumn Episodio;
        private DataGridViewTextBoxColumn Player;
    }
}