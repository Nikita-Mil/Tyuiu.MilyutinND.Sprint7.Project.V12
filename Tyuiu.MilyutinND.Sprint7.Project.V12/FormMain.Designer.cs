namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonInfo_NMD = new Button();
            groupBoxSearch_MND = new GroupBox();
            textBoxFind_MND = new TextBox();
            pictureBoxPC_MND = new PictureBox();
            buttonFirma_MND = new Button();
            buttonADD_MND = new Button();
            panelDown_MND = new Panel();
            buttonStat_MND = new Button();
            buttonSortYEAR_MND = new Button();
            buttonSortAlp_MND = new Button();
            buttonSave_MND = new Button();
            groupBoxData_MND = new GroupBox();
            dataGridViewIn_MND = new DataGridView();
            groupBoxSearch_MND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPC_MND).BeginInit();
            panelDown_MND.SuspendLayout();
            groupBoxData_MND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MND).BeginInit();
            SuspendLayout();
            // 
            // buttonInfo_NMD
            // 
            buttonInfo_NMD.BackColor = Color.DarkTurquoise;
            buttonInfo_NMD.BackgroundImage = (Image)resources.GetObject("buttonInfo_NMD.BackgroundImage");
            buttonInfo_NMD.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_NMD.FlatStyle = FlatStyle.Popup;
            buttonInfo_NMD.Font = new Font("Pobeda", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_NMD.ForeColor = SystemColors.ButtonHighlight;
            buttonInfo_NMD.Location = new Point(50, 476);
            buttonInfo_NMD.Name = "buttonInfo_NMD";
            buttonInfo_NMD.Size = new Size(86, 35);
            buttonInfo_NMD.TabIndex = 0;
            buttonInfo_NMD.Text = "Справка";
            buttonInfo_NMD.TextAlign = ContentAlignment.MiddleRight;
            buttonInfo_NMD.UseVisualStyleBackColor = false;
            buttonInfo_NMD.Click += buttonInfo_NMD_Click;
            // 
            // groupBoxSearch_MND
            // 
            groupBoxSearch_MND.BackgroundImage = (Image)resources.GetObject("groupBoxSearch_MND.BackgroundImage");
            groupBoxSearch_MND.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxSearch_MND.Controls.Add(textBoxFind_MND);
            groupBoxSearch_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxSearch_MND.ForeColor = SystemColors.ButtonHighlight;
            groupBoxSearch_MND.ImeMode = ImeMode.On;
            groupBoxSearch_MND.Location = new Point(50, 12);
            groupBoxSearch_MND.Name = "groupBoxSearch_MND";
            groupBoxSearch_MND.RightToLeft = RightToLeft.Yes;
            groupBoxSearch_MND.Size = new Size(227, 90);
            groupBoxSearch_MND.TabIndex = 1;
            groupBoxSearch_MND.TabStop = false;
            groupBoxSearch_MND.Text = "поиск";
            // 
            // textBoxFind_MND
            // 
            textBoxFind_MND.BackColor = Color.MediumTurquoise;
            textBoxFind_MND.ForeColor = SystemColors.ButtonHighlight;
            textBoxFind_MND.Location = new Point(6, 27);
            textBoxFind_MND.Multiline = true;
            textBoxFind_MND.Name = "textBoxFind_MND";
            textBoxFind_MND.Size = new Size(215, 57);
            textBoxFind_MND.TabIndex = 0;
            textBoxFind_MND.TextChanged += textBoxFind_MND_TextChanged;
            // 
            // pictureBoxPC_MND
            // 
            pictureBoxPC_MND.BackgroundImage = (Image)resources.GetObject("pictureBoxPC_MND.BackgroundImage");
            pictureBoxPC_MND.Location = new Point(50, 534);
            pictureBoxPC_MND.Name = "pictureBoxPC_MND";
            pictureBoxPC_MND.Size = new Size(251, 231);
            pictureBoxPC_MND.TabIndex = 2;
            pictureBoxPC_MND.TabStop = false;
            pictureBoxPC_MND.Click += pictureBox1_Click;
            // 
            // buttonFirma_MND
            // 
            buttonFirma_MND.BackgroundImage = (Image)resources.GetObject("buttonFirma_MND.BackgroundImage");
            buttonFirma_MND.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFirma_MND.FlatStyle = FlatStyle.Popup;
            buttonFirma_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFirma_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonFirma_MND.Location = new Point(50, 294);
            buttonFirma_MND.Name = "buttonFirma_MND";
            buttonFirma_MND.Size = new Size(227, 61);
            buttonFirma_MND.TabIndex = 3;
            buttonFirma_MND.Text = "ФИРМЫ";
            buttonFirma_MND.UseVisualStyleBackColor = true;
            buttonFirma_MND.Click += buttonFirma_MND_Click;
            // 
            // buttonADD_MND
            // 
            buttonADD_MND.BackgroundImage = (Image)resources.GetObject("buttonADD_MND.BackgroundImage");
            buttonADD_MND.FlatStyle = FlatStyle.Popup;
            buttonADD_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonADD_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonADD_MND.Location = new Point(50, 125);
            buttonADD_MND.Name = "buttonADD_MND";
            buttonADD_MND.Size = new Size(227, 61);
            buttonADD_MND.TabIndex = 4;
            buttonADD_MND.Text = "ДОБАВИТЬ ФАЙЛ";
            buttonADD_MND.UseVisualStyleBackColor = true;
            buttonADD_MND.Click += buttonADD_MND_Click;
            // 
            // panelDown_MND
            // 
            panelDown_MND.BackgroundImage = (Image)resources.GetObject("panelDown_MND.BackgroundImage");
            panelDown_MND.Controls.Add(buttonStat_MND);
            panelDown_MND.Controls.Add(buttonSortYEAR_MND);
            panelDown_MND.Controls.Add(buttonSortAlp_MND);
            panelDown_MND.Location = new Point(324, 662);
            panelDown_MND.Name = "panelDown_MND";
            panelDown_MND.Size = new Size(1021, 103);
            panelDown_MND.TabIndex = 5;
            // 
            // buttonStat_MND
            // 
            buttonStat_MND.BackgroundImage = (Image)resources.GetObject("buttonStat_MND.BackgroundImage");
            buttonStat_MND.FlatStyle = FlatStyle.Popup;
            buttonStat_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStat_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonStat_MND.Location = new Point(59, 16);
            buttonStat_MND.Name = "buttonStat_MND";
            buttonStat_MND.Size = new Size(171, 73);
            buttonStat_MND.TabIndex = 6;
            buttonStat_MND.Text = "Статистика";
            buttonStat_MND.UseVisualStyleBackColor = true;
            // 
            // buttonSortYEAR_MND
            // 
            buttonSortYEAR_MND.BackgroundImage = (Image)resources.GetObject("buttonSortYEAR_MND.BackgroundImage");
            buttonSortYEAR_MND.FlatStyle = FlatStyle.Popup;
            buttonSortYEAR_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSortYEAR_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonSortYEAR_MND.Location = new Point(777, 16);
            buttonSortYEAR_MND.Name = "buttonSortYEAR_MND";
            buttonSortYEAR_MND.Size = new Size(171, 73);
            buttonSortYEAR_MND.TabIndex = 8;
            buttonSortYEAR_MND.Text = "Отсортировать по году";
            buttonSortYEAR_MND.UseVisualStyleBackColor = true;
            buttonSortYEAR_MND.Click += button3_Click;
            // 
            // buttonSortAlp_MND
            // 
            buttonSortAlp_MND.BackgroundImage = (Image)resources.GetObject("buttonSortAlp_MND.BackgroundImage");
            buttonSortAlp_MND.FlatStyle = FlatStyle.Popup;
            buttonSortAlp_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSortAlp_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonSortAlp_MND.Location = new Point(563, 16);
            buttonSortAlp_MND.Name = "buttonSortAlp_MND";
            buttonSortAlp_MND.Size = new Size(171, 73);
            buttonSortAlp_MND.TabIndex = 7;
            buttonSortAlp_MND.Text = "Отсортировать по алфавиту";
            buttonSortAlp_MND.UseVisualStyleBackColor = true;
            buttonSortAlp_MND.Click += button2_Click;
            // 
            // buttonSave_MND
            // 
            buttonSave_MND.BackgroundImage = (Image)resources.GetObject("buttonSave_MND.BackgroundImage");
            buttonSave_MND.FlatStyle = FlatStyle.Popup;
            buttonSave_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonSave_MND.Location = new Point(50, 211);
            buttonSave_MND.Name = "buttonSave_MND";
            buttonSave_MND.Size = new Size(227, 61);
            buttonSave_MND.TabIndex = 9;
            buttonSave_MND.Text = "СОхранить";
            buttonSave_MND.UseVisualStyleBackColor = true;
            // 
            // groupBoxData_MND
            // 
            groupBoxData_MND.BackgroundImage = (Image)resources.GetObject("groupBoxData_MND.BackgroundImage");
            groupBoxData_MND.Controls.Add(dataGridViewIn_MND);
            groupBoxData_MND.Font = new Font("Pobeda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData_MND.ForeColor = SystemColors.ButtonHighlight;
            groupBoxData_MND.Location = new Point(324, 12);
            groupBoxData_MND.Name = "groupBoxData_MND";
            groupBoxData_MND.Size = new Size(1021, 631);
            groupBoxData_MND.TabIndex = 10;
            groupBoxData_MND.TabStop = false;
            groupBoxData_MND.Text = "ДАННЫЕ:";
            // 
            // dataGridViewIn_MND
            // 
            dataGridViewIn_MND.BackgroundColor = Color.MediumTurquoise;
            dataGridViewIn_MND.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_MND.Location = new Point(19, 27);
            dataGridViewIn_MND.Name = "dataGridViewIn_MND";
            dataGridViewIn_MND.RowHeadersWidth = 51;
            dataGridViewIn_MND.Size = new Size(986, 587);
            dataGridViewIn_MND.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1368, 790);
            Controls.Add(groupBoxData_MND);
            Controls.Add(panelDown_MND);
            Controls.Add(buttonSave_MND);
            Controls.Add(buttonInfo_NMD);
            Controls.Add(buttonADD_MND);
            Controls.Add(buttonFirma_MND);
            Controls.Add(pictureBoxPC_MND);
            Controls.Add(groupBoxSearch_MND);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            Text = "Спринт 7 | Проект | Вариант 12 | Милютин Н. Д.";
            Load += Form1_Load;
            groupBoxSearch_MND.ResumeLayout(false);
            groupBoxSearch_MND.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPC_MND).EndInit();
            panelDown_MND.ResumeLayout(false);
            groupBoxData_MND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MND).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInfo_NMD;
        private GroupBox groupBoxSearch_MND;
        private TextBox textBoxFind_MND;
        private PictureBox pictureBoxPC_MND;
        private Button buttonFirma_MND;
        private Button buttonADD_MND;
        private Panel panelDown_MND;
        private Button buttonStat_MND;
        private Button buttonSortAlp_MND;
        private Button buttonSortYEAR_MND;
        private Button buttonSave_MND;
        private GroupBox groupBoxData_MND;
        private DataGridView dataGridViewIn_MND;
    }
}
