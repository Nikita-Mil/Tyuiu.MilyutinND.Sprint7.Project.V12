using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using GroupBox = System.Windows.Forms.GroupBox;
using TextBox = System.Windows.Forms.TextBox;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            buttonBackMenu_MND = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonSave_MND = new Button();
            buttonClear_MND = new Button();
            buttonOpen_MND = new Button();
            groupBoxData_MND = new GroupBox();
            dataGridViewData_MND = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            openFileDialogData_MND = new OpenFileDialog();
            saveFileDialogData_MND = new SaveFileDialog();
            groupBox1 = new GroupBox();
            button6 = new Button();
            textBoxHDD_MND = new TextBox();
            textBoxOZU_MND = new TextBox();
            buttonAdd_MND = new Button();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBoxCountry_MND = new TextBox();
            textBoxFirma_MND = new TextBox();
            textBoxHZ_MND = new TextBox();
            textBoxYear1_MND = new TextBox();
            textBoxHZ3_MND = new TextBox();
            textBoxOC_MND = new TextBox();
            textBox2 = new TextBox();
            textBoxName_MND = new TextBox();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            FilterToolStripMenuItem = new ToolStripMenuItem();
            OCToolStripMenuItem = new ToolStripMenuItem();
            AppleToolStripMenuItem = new ToolStripMenuItem();
            WindowsToolStripMenuItem = new ToolStripMenuItem();
            OtherToolStripMenuItem = new ToolStripMenuItem();
            textBoxFirma8_MND = new TextBox();
            textBoxOC6_MND = new TextBox();
            panel1.SuspendLayout();
            groupBoxData_MND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_MND).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBackMenu_MND
            // 
            buttonBackMenu_MND.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBackMenu_MND.BackColor = Color.White;
            buttonBackMenu_MND.BackgroundImage = (Image)resources.GetObject("buttonBackMenu_MND.BackgroundImage");
            buttonBackMenu_MND.FlatStyle = FlatStyle.Popup;
            buttonBackMenu_MND.Font = new Font("Rimma_sans Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBackMenu_MND.ForeColor = SystemColors.HighlightText;
            buttonBackMenu_MND.Location = new Point(19, 220);
            buttonBackMenu_MND.Margin = new Padding(3, 4, 3, 4);
            buttonBackMenu_MND.Name = "buttonBackMenu_MND";
            buttonBackMenu_MND.Size = new Size(261, 64);
            buttonBackMenu_MND.TabIndex = 0;
            buttonBackMenu_MND.Text = "Назад в меню";
            buttonBackMenu_MND.UseVisualStyleBackColor = false;
            buttonBackMenu_MND.Click += buttonBackMenu_MND_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonBackMenu_MND);
            panel1.Controls.Add(buttonSave_MND);
            panel1.Controls.Add(buttonClear_MND);
            panel1.Controls.Add(buttonOpen_MND);
            panel1.Location = new Point(1566, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 333);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(91, 291);
            button4.Name = "button4";
            button4.Size = new Size(39, 33);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(285, 231);
            button3.Name = "button3";
            button3.Size = new Size(43, 44);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(18, 161);
            button2.Name = "button2";
            button2.Size = new Size(43, 44);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(18, 17);
            button1.Name = "button1";
            button1.Size = new Size(43, 44);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSave_MND
            // 
            buttonSave_MND.BackColor = Color.White;
            buttonSave_MND.BackgroundImage = (Image)resources.GetObject("buttonSave_MND.BackgroundImage");
            buttonSave_MND.FlatStyle = FlatStyle.Popup;
            buttonSave_MND.Font = new Font("Rimma_sans Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_MND.ForeColor = SystemColors.Window;
            buttonSave_MND.Location = new Point(67, 148);
            buttonSave_MND.Margin = new Padding(3, 4, 3, 4);
            buttonSave_MND.Name = "buttonSave_MND";
            buttonSave_MND.Size = new Size(261, 64);
            buttonSave_MND.TabIndex = 3;
            buttonSave_MND.Text = "Сохранить файл";
            buttonSave_MND.UseVisualStyleBackColor = false;
            buttonSave_MND.Click += buttonSave_MND_Click;
            // 
            // buttonClear_MND
            // 
            buttonClear_MND.BackColor = Color.White;
            buttonClear_MND.BackgroundImage = (Image)resources.GetObject("buttonClear_MND.BackgroundImage");
            buttonClear_MND.FlatStyle = FlatStyle.Popup;
            buttonClear_MND.Font = new Font("Rimma_sans Bold", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClear_MND.ForeColor = SystemColors.ButtonFace;
            buttonClear_MND.Location = new Point(136, 291);
            buttonClear_MND.Name = "buttonClear_MND";
            buttonClear_MND.Size = new Size(192, 33);
            buttonClear_MND.TabIndex = 6;
            buttonClear_MND.Text = "Очистить";
            buttonClear_MND.UseVisualStyleBackColor = false;
            buttonClear_MND.Click += buttonClear_MND_Click;
            // 
            // buttonOpen_MND
            // 
            buttonOpen_MND.BackColor = Color.White;
            buttonOpen_MND.BackgroundImage = (Image)resources.GetObject("buttonOpen_MND.BackgroundImage");
            buttonOpen_MND.FlatStyle = FlatStyle.Popup;
            buttonOpen_MND.Font = new Font("Rimma_sans Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpen_MND.ForeColor = SystemColors.Window;
            buttonOpen_MND.Location = new Point(67, 4);
            buttonOpen_MND.Margin = new Padding(3, 4, 3, 4);
            buttonOpen_MND.Name = "buttonOpen_MND";
            buttonOpen_MND.Size = new Size(261, 64);
            buttonOpen_MND.TabIndex = 0;
            buttonOpen_MND.Text = "Открыть файл";
            buttonOpen_MND.UseVisualStyleBackColor = false;
            buttonOpen_MND.Click += buttonOpen_MND_Click;
            // 
            // groupBoxData_MND
            // 
            groupBoxData_MND.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxData_MND.BackColor = Color.White;
            groupBoxData_MND.BackgroundImage = (Image)resources.GetObject("groupBoxData_MND.BackgroundImage");
            groupBoxData_MND.Controls.Add(dataGridViewData_MND);
            groupBoxData_MND.Font = new Font("Pobeda", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData_MND.ForeColor = SystemColors.Window;
            groupBoxData_MND.Location = new Point(12, 13);
            groupBoxData_MND.Margin = new Padding(3, 4, 3, 4);
            groupBoxData_MND.Name = "groupBoxData_MND";
            groupBoxData_MND.Padding = new Padding(3, 4, 3, 4);
            groupBoxData_MND.Size = new Size(1527, 1029);
            groupBoxData_MND.TabIndex = 2;
            groupBoxData_MND.TabStop = false;
            groupBoxData_MND.Text = "Данные";
            groupBoxData_MND.Enter += groupBoxData_MND_Enter;
            // 
            // dataGridViewData_MND
            // 
            dataGridViewData_MND.BackgroundColor = Color.DarkCyan;
            dataGridViewData_MND.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Pobeda", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewData_MND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewData_MND.ColumnHeadersHeight = 29;
            dataGridViewData_MND.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle12.Font = new Font("Pobeda", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle12.ForeColor = SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewData_MND.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewData_MND.Dock = DockStyle.Fill;
            dataGridViewData_MND.GridColor = Color.Gainsboro;
            dataGridViewData_MND.Location = new Point(3, 24);
            dataGridViewData_MND.Margin = new Padding(3, 4, 3, 4);
            dataGridViewData_MND.Name = "dataGridViewData_MND";
            dataGridViewData_MND.ReadOnly = true;
            dataGridViewData_MND.RowHeadersVisible = false;
            dataGridViewData_MND.RowHeadersWidth = 51;
            dataGridViewData_MND.Size = new Size(1521, 1001);
            dataGridViewData_MND.TabIndex = 0;
            dataGridViewData_MND.CellContentClick += dataGridViewData_MND_CellContentClick;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = Color.LightSeaGreen;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.BackColor = Color.LightSeaGreen;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "Название";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.BackColor = Color.LightSeaGreen;
            Column3.DefaultCellStyle = dataGridViewCellStyle4;
            Column3.HeaderText = "Тип процессора";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.BackColor = Color.LightSeaGreen;
            Column4.DefaultCellStyle = dataGridViewCellStyle5;
            Column4.HeaderText = "Тактовая частота";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.BackColor = Color.LightSeaGreen;
            Column5.DefaultCellStyle = dataGridViewCellStyle6;
            Column5.HeaderText = "Объем ОЗУ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            dataGridViewCellStyle7.BackColor = Color.LightSeaGreen;
            Column6.DefaultCellStyle = dataGridViewCellStyle7;
            Column6.HeaderText = "SDD/HDD";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            dataGridViewCellStyle8.BackColor = Color.LightSeaGreen;
            Column7.DefaultCellStyle = dataGridViewCellStyle8;
            Column7.HeaderText = "OC";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            dataGridViewCellStyle9.BackColor = Color.LightSeaGreen;
            Column8.DefaultCellStyle = dataGridViewCellStyle9;
            Column8.HeaderText = "Дата выпуска";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            dataGridViewCellStyle10.BackColor = Color.LightSeaGreen;
            Column9.DefaultCellStyle = dataGridViewCellStyle10;
            Column9.HeaderText = "Фирма изготовитель";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            dataGridViewCellStyle11.BackColor = Color.LightSeaGreen;
            Column10.DefaultCellStyle = dataGridViewCellStyle11;
            Column10.HeaderText = "Адрес";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // openFileDialogData_MND
            // 
            openFileDialogData_MND.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(textBoxHDD_MND);
            groupBox1.Controls.Add(textBoxOZU_MND);
            groupBox1.Controls.Add(buttonAdd_MND);
            groupBox1.Controls.Add(textBox16);
            groupBox1.Controls.Add(textBox15);
            groupBox1.Controls.Add(textBox14);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(textBoxCountry_MND);
            groupBox1.Controls.Add(textBoxFirma_MND);
            groupBox1.Controls.Add(textBoxHZ_MND);
            groupBox1.Controls.Add(textBoxYear1_MND);
            groupBox1.Controls.Add(textBoxHZ3_MND);
            groupBox1.Controls.Add(textBoxOC_MND);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBoxName_MND);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Font = new Font("Rimma_sans Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(1566, 354);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(346, 694);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button6
            // 
            button6.BackColor = Color.WhiteSmoke;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(274, 558);
            button6.Name = "button6";
            button6.Size = new Size(43, 44);
            button6.TabIndex = 21;
            button6.UseVisualStyleBackColor = false;
            // 
            // textBoxHDD_MND
            // 
            textBoxHDD_MND.Location = new Point(24, 374);
            textBoxHDD_MND.Name = "textBoxHDD_MND";
            textBoxHDD_MND.Size = new Size(229, 25);
            textBoxHDD_MND.TabIndex = 20;
            // 
            // textBoxOZU_MND
            // 
            textBoxOZU_MND.Location = new Point(22, 304);
            textBoxOZU_MND.Name = "textBoxOZU_MND";
            textBoxOZU_MND.Size = new Size(231, 25);
            textBoxOZU_MND.TabIndex = 19;
            // 
            // buttonAdd_MND
            // 
            buttonAdd_MND.FlatStyle = FlatStyle.Popup;
            buttonAdd_MND.Image = (Image)resources.GetObject("buttonAdd_MND.Image");
            buttonAdd_MND.Location = new Point(260, 610);
            buttonAdd_MND.Name = "buttonAdd_MND";
            buttonAdd_MND.Size = new Size(69, 60);
            buttonAdd_MND.TabIndex = 18;
            buttonAdd_MND.Text = "Добавить";
            buttonAdd_MND.UseVisualStyleBackColor = true;
            buttonAdd_MND.Click += buttonAdd_MND_Click;
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.LightSeaGreen;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox16.ForeColor = SystemColors.MenuBar;
            textBox16.Location = new Point(26, 610);
            textBox16.Margin = new Padding(3, 4, 3, 4);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(197, 27);
            textBox16.TabIndex = 17;
            textBox16.Text = " Адрес:";
            // 
            // textBox15
            // 
            textBox15.BackColor = Color.LightSeaGreen;
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox15.ForeColor = SystemColors.MenuBar;
            textBox15.Location = new Point(24, 270);
            textBox15.Margin = new Padding(3, 4, 3, 4);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(197, 27);
            textBox15.TabIndex = 16;
            textBox15.Text = " Объем ОЗУ:";
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.LightSeaGreen;
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox14.ForeColor = SystemColors.MenuBar;
            textBox14.Location = new Point(26, 542);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(197, 27);
            textBox14.TabIndex = 15;
            textBox14.Text = " Фирма:";
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.LightSeaGreen;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox13.ForeColor = SystemColors.MenuBar;
            textBox13.Location = new Point(20, 68);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(197, 26);
            textBox13.TabIndex = 14;
            textBox13.Text = " Название:";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.LightSeaGreen;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Rimma_sans Bold", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox12.ForeColor = SystemColors.MenuBar;
            textBox12.Location = new Point(22, 202);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(197, 27);
            textBox12.TabIndex = 13;
            textBox12.Text = " Тактовая частота:";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.LightSeaGreen;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox11.ForeColor = SystemColors.MenuBar;
            textBox11.Location = new Point(26, 474);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(197, 27);
            textBox11.TabIndex = 12;
            textBox11.Text = " Дата выпуска:";
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.LightSeaGreen;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Rimma_sans Bold", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox10.ForeColor = SystemColors.MenuBar;
            textBox10.Location = new Point(22, 134);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(197, 27);
            textBox10.TabIndex = 11;
            textBox10.Text = " Тип процессора:";
            // 
            // textBoxCountry_MND
            // 
            textBoxCountry_MND.BackColor = Color.White;
            textBoxCountry_MND.ForeColor = SystemColors.Desktop;
            textBoxCountry_MND.Location = new Point(26, 645);
            textBoxCountry_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxCountry_MND.Name = "textBoxCountry_MND";
            textBoxCountry_MND.Size = new Size(227, 25);
            textBoxCountry_MND.TabIndex = 10;
            // 
            // textBoxFirma_MND
            // 
            textBoxFirma_MND.BackColor = Color.White;
            textBoxFirma_MND.ForeColor = SystemColors.Desktop;
            textBoxFirma_MND.Location = new Point(26, 577);
            textBoxFirma_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxFirma_MND.Name = "textBoxFirma_MND";
            textBoxFirma_MND.Size = new Size(227, 25);
            textBoxFirma_MND.TabIndex = 5;
            textBoxFirma_MND.TextChanged += textBoxFirma_MND_TextChanged;
            // 
            // textBoxHZ_MND
            // 
            textBoxHZ_MND.BackColor = Color.White;
            textBoxHZ_MND.ForeColor = SystemColors.Desktop;
            textBoxHZ_MND.Location = new Point(22, 237);
            textBoxHZ_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxHZ_MND.Name = "textBoxHZ_MND";
            textBoxHZ_MND.Size = new Size(231, 25);
            textBoxHZ_MND.TabIndex = 7;
            textBoxHZ_MND.TextChanged += textBoxHZ_MND_TextChanged;
            // 
            // textBoxYear1_MND
            // 
            textBoxYear1_MND.BackColor = Color.White;
            textBoxYear1_MND.ForeColor = SystemColors.Desktop;
            textBoxYear1_MND.Location = new Point(26, 509);
            textBoxYear1_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxYear1_MND.Name = "textBoxYear1_MND";
            textBoxYear1_MND.Size = new Size(227, 25);
            textBoxYear1_MND.TabIndex = 6;
            textBoxYear1_MND.TextChanged += textBox4_TextChanged;
            // 
            // textBoxHZ3_MND
            // 
            textBoxHZ3_MND.BackColor = Color.White;
            textBoxHZ3_MND.ForeColor = SystemColors.Desktop;
            textBoxHZ3_MND.Location = new Point(22, 169);
            textBoxHZ3_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxHZ3_MND.Name = "textBoxHZ3_MND";
            textBoxHZ3_MND.Size = new Size(231, 25);
            textBoxHZ3_MND.TabIndex = 5;
            textBoxHZ3_MND.TextChanged += textBoxHZ3_MND_TextChanged;
            // 
            // textBoxOC_MND
            // 
            textBoxOC_MND.BackColor = Color.White;
            textBoxOC_MND.ForeColor = SystemColors.Desktop;
            textBoxOC_MND.Location = new Point(26, 441);
            textBoxOC_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxOC_MND.Name = "textBoxOC_MND";
            textBoxOC_MND.Size = new Size(225, 25);
            textBoxOC_MND.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSeaGreen;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.ForeColor = SystemColors.MenuBar;
            textBox2.Location = new Point(26, 406);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = " OC:";
            // 
            // textBoxName_MND
            // 
            textBoxName_MND.Location = new Point(22, 101);
            textBoxName_MND.Name = "textBoxName_MND";
            textBoxName_MND.Size = new Size(231, 25);
            textBoxName_MND.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSeaGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Rimma_sans Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.MenuBar;
            textBox1.Location = new Point(24, 338);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = " HDD:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FilterToolStripMenuItem });
            menuStrip1.Location = new Point(3, 22);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(340, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FilterToolStripMenuItem
            // 
            FilterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OCToolStripMenuItem });
            FilterToolStripMenuItem.Font = new Font("Rimma_sans Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FilterToolStripMenuItem.ForeColor = Color.White;
            FilterToolStripMenuItem.Name = "FilterToolStripMenuItem";
            FilterToolStripMenuItem.Size = new Size(98, 22);
            FilterToolStripMenuItem.Text = "Фильтр";
            // 
            // OCToolStripMenuItem
            // 
            OCToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AppleToolStripMenuItem, WindowsToolStripMenuItem, OtherToolStripMenuItem });
            OCToolStripMenuItem.Name = "OCToolStripMenuItem";
            OCToolStripMenuItem.Size = new Size(115, 26);
            OCToolStripMenuItem.Text = "OC";
            OCToolStripMenuItem.Click += жанрToolStripMenuItem_Click;
            // 
            // AppleToolStripMenuItem
            // 
            AppleToolStripMenuItem.Name = "AppleToolStripMenuItem";
            AppleToolStripMenuItem.Size = new Size(189, 26);
            AppleToolStripMenuItem.Text = "Apple";
            AppleToolStripMenuItem.Click += AppleToolStripMenuItem_Click;
            // 
            // WindowsToolStripMenuItem
            // 
            WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem";
            WindowsToolStripMenuItem.Size = new Size(189, 26);
            WindowsToolStripMenuItem.Text = "Windows";
            WindowsToolStripMenuItem.Click += WindowsToolStripMenuItem_Click;
            // 
            // OtherToolStripMenuItem
            // 
            OtherToolStripMenuItem.Name = "OtherToolStripMenuItem";
            OtherToolStripMenuItem.Size = new Size(189, 26);
            OtherToolStripMenuItem.Text = "Other";
            // 
            // textBoxFirma8_MND
            // 
            textBoxFirma8_MND.BackColor = Color.White;
            textBoxFirma8_MND.ForeColor = SystemColors.Desktop;
            textBoxFirma8_MND.Location = new Point(24, 305);
            textBoxFirma8_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxFirma8_MND.Name = "textBoxFirma8_MND";
            textBoxFirma8_MND.Size = new Size(225, 27);
            textBoxFirma8_MND.TabIndex = 9;
            // 
            // textBoxOC6_MND
            // 
            textBoxOC6_MND.BackColor = Color.White;
            textBoxOC6_MND.ForeColor = SystemColors.Desktop;
            textBoxOC6_MND.Location = new Point(20, 102);
            textBoxOC6_MND.Margin = new Padding(3, 4, 3, 4);
            textBoxOC6_MND.Name = "textBoxOC6_MND";
            textBoxOC6_MND.Size = new Size(227, 27);
            textBoxOC6_MND.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxData_MND);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            groupBoxData_MND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_MND).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBackMenu_MND;
        private Panel panel1;
        private Button buttonOpen_MND;
        private Button buttonSave_MND;
        private GroupBox groupBoxData_MND;
        private DataGridView dataGridViewData_MND;
        private OpenFileDialog openFileDialogData_MND;
        private SaveFileDialog saveFileDialogData_MND;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FilterToolStripMenuItem;
        private ToolStripMenuItem OCToolStripMenuItem;
        private ToolStripMenuItem AppleToolStripMenuItem;
        private ToolStripMenuItem WindowsToolStripMenuItem;
        private ToolStripMenuItem OtherToolStripMenuItem;
        private Button buttonClear_MND;
        private TextBox textBoxOC_MND;
        private TextBox textBox2;
        
        private TextBox textBox1;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBoxCountry_MND;
        private TextBox textBoxFirma8_MND;
        private TextBox textBoxFirma_MND;
        private TextBox textBoxOC6_MND;
        private TextBox textBoxHZ_MND;
        private TextBox textBoxYear1_MND;
        private TextBox textBoxHZ3_MND;
        
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button buttonAdd_MND;
        private TextBox textBoxName_MND;
        private TextBox textBoxHDD_MND;
        private TextBox textBoxOZU_MND;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
    }
}
