namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    partial class FormMenu
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            pictureBoxLogo_MND = new PictureBox();
            textBoxName_MND = new TextBox();
            buttonClose_MND = new Button();
            buttonInfo_MND = new Button();
            buttonStart_MND = new Button();
            buttonGuide_MND = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_MND).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo_MND
            // 
            pictureBoxLogo_MND.BackgroundImage = (Image)resources.GetObject("pictureBoxLogo_MND.BackgroundImage");
            pictureBoxLogo_MND.Location = new Point(609, 138);
            pictureBoxLogo_MND.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo_MND.Name = "pictureBoxLogo_MND";
            pictureBoxLogo_MND.Padding = new Padding(1);
            pictureBoxLogo_MND.Size = new Size(245, 250);
            pictureBoxLogo_MND.TabIndex = 0;
            pictureBoxLogo_MND.TabStop = false;
            // 
            // textBoxName_MND
            // 
            textBoxName_MND.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxName_MND.BackColor = Color.MediumTurquoise;
            textBoxName_MND.BorderStyle = BorderStyle.None;
            textBoxName_MND.Font = new Font("Rimma_sans Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxName_MND.ForeColor = SystemColors.Window;
            textBoxName_MND.Location = new Point(-26, 76);
            textBoxName_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxName_MND.Multiline = true;
            textBoxName_MND.Name = "textBoxName_MND";
            textBoxName_MND.ReadOnly = true;
            textBoxName_MND.Size = new Size(558, 85);
            textBoxName_MND.TabIndex = 0;
            textBoxName_MND.TabStop = false;
            textBoxName_MND.Text = "      Персональные ЭВМ\r\n";
            textBoxName_MND.TextAlign = HorizontalAlignment.Center;
            textBoxName_MND.TextChanged += textBoxName_MND_TextChanged;
            // 
            // buttonClose_MND
            // 
            buttonClose_MND.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose_MND.BackColor = Color.Cyan;
            buttonClose_MND.BackgroundImage = (Image)resources.GetObject("buttonClose_MND.BackgroundImage");
            buttonClose_MND.FlatStyle = FlatStyle.Popup;
            buttonClose_MND.Font = new Font("Rimma_sans Bold", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClose_MND.ForeColor = SystemColors.Window;
            buttonClose_MND.Location = new Point(83, 444);
            buttonClose_MND.Margin = new Padding(3, 4, 3, 4);
            buttonClose_MND.Name = "buttonClose_MND";
            buttonClose_MND.Size = new Size(375, 78);
            buttonClose_MND.TabIndex = 2;
            buttonClose_MND.Text = "Выход";
            buttonClose_MND.UseVisualStyleBackColor = false;
            buttonClose_MND.Click += buttonClose_MND_Click;
            // 
            // buttonInfo_MND
            // 
            buttonInfo_MND.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonInfo_MND.BackColor = Color.Cyan;
            buttonInfo_MND.BackgroundImage = (Image)resources.GetObject("buttonInfo_MND.BackgroundImage");
            buttonInfo_MND.FlatStyle = FlatStyle.Popup;
            buttonInfo_MND.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_MND.ForeColor = SystemColors.Window;
            buttonInfo_MND.Location = new Point(278, 356);
            buttonInfo_MND.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_MND.Name = "buttonInfo_MND";
            buttonInfo_MND.Size = new Size(180, 62);
            buttonInfo_MND.TabIndex = 4;
            buttonInfo_MND.Text = "Справка";
            buttonInfo_MND.UseVisualStyleBackColor = false;
            buttonInfo_MND.Click += buttonAbout_MND_Click;
            // 
            // buttonStart_MND
            // 
            buttonStart_MND.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStart_MND.BackColor = Color.Cyan;
            buttonStart_MND.BackgroundImage = (Image)resources.GetObject("buttonStart_MND.BackgroundImage");
            buttonStart_MND.FlatStyle = FlatStyle.Popup;
            buttonStart_MND.Font = new Font("Rimma_sans Bold", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStart_MND.ForeColor = SystemColors.Window;
            buttonStart_MND.Location = new Point(83, 251);
            buttonStart_MND.Margin = new Padding(3, 4, 3, 4);
            buttonStart_MND.Name = "buttonStart_MND";
            buttonStart_MND.Size = new Size(375, 76);
            buttonStart_MND.TabIndex = 5;
            buttonStart_MND.Text = "Старт";
            buttonStart_MND.UseVisualStyleBackColor = false;
            buttonStart_MND.Click += buttonStart_MND_Click;
            buttonStart_MND.Enter += buttonStart_MND_Enter;
            // 
            // buttonGuide_MND
            // 
            buttonGuide_MND.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGuide_MND.BackColor = Color.Cyan;
            buttonGuide_MND.BackgroundImage = (Image)resources.GetObject("buttonGuide_MND.BackgroundImage");
            buttonGuide_MND.FlatStyle = FlatStyle.Popup;
            buttonGuide_MND.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGuide_MND.ForeColor = SystemColors.Window;
            buttonGuide_MND.Location = new Point(83, 356);
            buttonGuide_MND.Margin = new Padding(3, 4, 3, 4);
            buttonGuide_MND.Name = "buttonGuide_MND";
            buttonGuide_MND.Size = new Size(180, 62);
            buttonGuide_MND.TabIndex = 3;
            buttonGuide_MND.Text = "Руководство";
            buttonGuide_MND.UseVisualStyleBackColor = false;
            buttonGuide_MND.Click += buttonGuide_MND_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(buttonStart_MND);
            Controls.Add(buttonInfo_MND);
            Controls.Add(buttonGuide_MND);
            Controls.Add(buttonClose_MND);
            Controls.Add(textBoxName_MND);
            Controls.Add(pictureBoxLogo_MND);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClipVaultS";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_MND).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBoxLogo_MND;
        private TextBox textBoxName_MND;
        private Button buttonClose_MND;
        private Button buttonInfo_MND;
        private Button buttonStart_MND;
        private Button buttonGuide_MND;
    }
}