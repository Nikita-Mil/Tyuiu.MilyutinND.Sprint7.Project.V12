namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    partial class FormGuides
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuides));
            textBoxGuidesMenu_MND = new TextBox();
            buttonGuidesClose_MND = new Button();
            textBoxGroup_MND = new TextBox();
            buttonMenu_MND = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxGuidesMenu_MND
            // 
            textBoxGuidesMenu_MND.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxGuidesMenu_MND.BackColor = Color.Teal;
            textBoxGuidesMenu_MND.BorderStyle = BorderStyle.None;
            textBoxGuidesMenu_MND.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxGuidesMenu_MND.ForeColor = SystemColors.Window;
            textBoxGuidesMenu_MND.Location = new Point(13, 13);
            textBoxGuidesMenu_MND.Margin = new Padding(4);
            textBoxGuidesMenu_MND.Multiline = true;
            textBoxGuidesMenu_MND.Name = "textBoxGuidesMenu_MND";
            textBoxGuidesMenu_MND.ReadOnly = true;
            textBoxGuidesMenu_MND.Size = new Size(633, 604);
            textBoxGuidesMenu_MND.TabIndex = 0;
            textBoxGuidesMenu_MND.TabStop = false;
            textBoxGuidesMenu_MND.TextChanged += textBoxGuidesMenu_MND_TextChanged;
            // 
            // buttonGuidesClose_MND
            // 
            buttonGuidesClose_MND.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonGuidesClose_MND.BackColor = Color.Black;
            buttonGuidesClose_MND.BackgroundImage = (Image)resources.GetObject("buttonGuidesClose_MND.BackgroundImage");
            buttonGuidesClose_MND.FlatStyle = FlatStyle.Popup;
            buttonGuidesClose_MND.Font = new Font("Rimma_sans Bold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGuidesClose_MND.ForeColor = Color.White;
            buttonGuidesClose_MND.Location = new Point(681, 559);
            buttonGuidesClose_MND.Margin = new Padding(4);
            buttonGuidesClose_MND.Name = "buttonGuidesClose_MND";
            buttonGuidesClose_MND.Size = new Size(311, 58);
            buttonGuidesClose_MND.TabIndex = 1;
            buttonGuidesClose_MND.Text = "Выход";
            buttonGuidesClose_MND.UseVisualStyleBackColor = false;
            buttonGuidesClose_MND.Click += buttonGuidesClose_MND_Click;
            // 
            // textBoxGroup_MND
            // 
            textBoxGroup_MND.BackColor = Color.Teal;
            textBoxGroup_MND.BorderStyle = BorderStyle.None;
            textBoxGroup_MND.Font = new Font("Rimma_sans Bold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxGroup_MND.ForeColor = SystemColors.ButtonHighlight;
            textBoxGroup_MND.Location = new Point(681, 85);
            textBoxGroup_MND.Margin = new Padding(4);
            textBoxGroup_MND.Multiline = true;
            textBoxGroup_MND.Name = "textBoxGroup_MND";
            textBoxGroup_MND.Size = new Size(311, 84);
            textBoxGroup_MND.TabIndex = 2;
            textBoxGroup_MND.Text = "\r\n   Руководство:";
            // 
            // buttonMenu_MND
            // 
            buttonMenu_MND.BackColor = Color.White;
            buttonMenu_MND.BackgroundImage = (Image)resources.GetObject("buttonMenu_MND.BackgroundImage");
            buttonMenu_MND.FlatStyle = FlatStyle.Popup;
            buttonMenu_MND.Font = new Font("Rimma_sans Bold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMenu_MND.ForeColor = SystemColors.ButtonHighlight;
            buttonMenu_MND.Image = (Image)resources.GetObject("buttonMenu_MND.Image");
            buttonMenu_MND.Location = new Point(681, 197);
            buttonMenu_MND.Margin = new Padding(4);
            buttonMenu_MND.Name = "buttonMenu_MND";
            buttonMenu_MND.Size = new Size(311, 67);
            buttonMenu_MND.TabIndex = 3;
            buttonMenu_MND.Text = "МЕНЮ\r\n";
            buttonMenu_MND.UseVisualStyleBackColor = false;
            buttonMenu_MND.Click += buttonMenu_MND_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Rimma_sans Bold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(681, 294);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(311, 67);
            button1.TabIndex = 4;
            button1.Text = "Приложение";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormGuides
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1029, 630);
            Controls.Add(button1);
            Controls.Add(buttonMenu_MND);
            Controls.Add(textBoxGroup_MND);
            Controls.Add(buttonGuidesClose_MND);
            Controls.Add(textBoxGuidesMenu_MND);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormGuides";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGuides";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGuidesMenu_MND;
        private Button buttonGuidesClose_MND;
        private TextBox textBoxGroup_MND;
        private Button buttonMenu_MND;
        private Button button1;
    }
}