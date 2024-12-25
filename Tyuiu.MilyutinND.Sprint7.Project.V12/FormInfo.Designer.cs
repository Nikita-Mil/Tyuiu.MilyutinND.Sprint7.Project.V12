namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            labelInfo_MND = new Label();
            pictureBoxInfo_MND = new PictureBox();
            buttonClose_MND = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_MND).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_MND
            // 
            labelInfo_MND.AutoSize = true;
            labelInfo_MND.BackColor = Color.DarkTurquoise;
            labelInfo_MND.FlatStyle = FlatStyle.Popup;
            labelInfo_MND.Font = new Font("Pobeda", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInfo_MND.ForeColor = SystemColors.ButtonHighlight;
            labelInfo_MND.Location = new Point(304, 40);
            labelInfo_MND.Name = "labelInfo_MND";
            labelInfo_MND.Size = new Size(352, 198);
            labelInfo_MND.TabIndex = 0;
            labelInfo_MND.Text = "Разработчик: Милютин Н. Д.\r\nГруппа: СМАРТб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет  \r\nВысшая школа цифровых технологий \r\n2024\r\n \r\n";
            labelInfo_MND.Click += labelInfo_MND_Click;
            // 
            // pictureBoxInfo_MND
            // 
            pictureBoxInfo_MND.BackgroundImage = (Image)resources.GetObject("pictureBoxInfo_MND.BackgroundImage");
            pictureBoxInfo_MND.Location = new Point(12, 64);
            pictureBoxInfo_MND.Name = "pictureBoxInfo_MND";
            pictureBoxInfo_MND.Size = new Size(257, 269);
            pictureBoxInfo_MND.TabIndex = 1;
            pictureBoxInfo_MND.TabStop = false;
            // 
            // buttonClose_MND
            // 
            buttonClose_MND.BackColor = Color.DarkTurquoise;
            buttonClose_MND.FlatStyle = FlatStyle.Popup;
            buttonClose_MND.Font = new Font("Pobeda", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClose_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonClose_MND.Location = new Point(393, 267);
            buttonClose_MND.Name = "buttonClose_MND";
            buttonClose_MND.Size = new Size(169, 83);
            buttonClose_MND.TabIndex = 2;
            buttonClose_MND.Text = "OK";
            buttonClose_MND.UseVisualStyleBackColor = true;
            buttonClose_MND.Click += buttonClose_MND_Click;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(680, 410);
            Controls.Add(buttonClose_MND);
            Controls.Add(pictureBoxInfo_MND);
            Controls.Add(labelInfo_MND);
            Name = "FormInfo";
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_MND).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_MND;
        private PictureBox pictureBoxInfo_MND;
        private Button buttonClose_MND;
    }
}