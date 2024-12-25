using System.Diagnostics.Metrics;
using System.Text;
using System.Text.RegularExpressions;
using Tyuiu.MilyutinND.Sprint7.Project.V12.Lib;
namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void IntelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_MND.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)Intel");

            foreach (DataGridViewRow row in dataGridViewData_MND.Rows)
            {
                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[4].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_MND.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_MND.Rows.Add(filteredRow);
            }
        }
        private void AppleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_MND.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)Apple"); // Регистронезависимый поиск 

            foreach (DataGridViewRow row in dataGridViewData_MND.Rows)
            {
                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[6].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }


            dataGridViewData_MND.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_MND.Rows.Add(filteredRow);
            }
        }
        private void WindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_MND.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)Windows");

            foreach (DataGridViewRow row in dataGridViewData_MND.Rows)
            {
                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[6].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_MND.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_MND.Rows.Add(filteredRow);
            }
        }
        private int counter = 33;
        private int currentRowIndex = 32;

        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int cols;
        static string[,] matrix;
        private void buttonAdd_MND_Click(object sender, EventArgs e)
        {
            string nameValue = textBoxName_MND.Text;
            string timeValue = textBoxHZ3_MND.Text;
            string weighValue = textBoxHZ_MND.Text;
            string FormatValue = textBoxOZU_MND.Text;
            string CategoryValue = textBoxHDD_MND.Text;
            string GenreValue = textBoxOC_MND.Text;
            string YearValue = textBoxYear1_MND.Text;
            string MoneyValue = textBoxFirma_MND.Text;
            string DirectorValue = textBoxCountry_MND.Text;

            string formattedNameValue = $"\"\"\"{nameValue}\"\"\"";

            if (string.IsNullOrWhiteSpace(textBoxName_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxHZ3_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxHZ_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxOZU_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxHDD_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxOC_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxYear1_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxFirma_MND.Text)
        || string.IsNullOrWhiteSpace(textBoxCountry_MND.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            int rowIndex = dataGridViewData_MND.Rows.Add();

            dataGridViewData_MND.Rows[rowIndex].Cells[1].Value = formattedNameValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[2].Value = timeValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[3].Value = weighValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[4].Value = FormatValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[5].Value = CategoryValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[6].Value = GenreValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[7].Value = YearValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[8].Value = MoneyValue;
            dataGridViewData_MND.Rows[rowIndex].Cells[9].Value = DirectorValue;

            if (currentRowIndex < dataGridViewData_MND.Rows.Count)
            {
                dataGridViewData_MND.Rows[currentRowIndex].Cells[0].Value = counter + 0;
                counter++;
                currentRowIndex++;
            }
            else
            {
                MessageBox.Show("Все строки заполнены или их нет.");
                dataGridViewData_MND.Rows.Add();
                currentRowIndex = 33;
            }

            textBoxName_MND.Clear();
            textBoxOC_MND.Clear();
            textBoxOZU_MND.Clear();
            textBoxYear1_MND.Clear();
            textBoxHDD_MND.Clear();
            textBoxOC6_MND.Clear();
            textBoxFirma_MND.Clear();
            textBoxFirma8_MND.Clear();
            textBoxCountry_MND.Clear();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewData_MND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_MND_Click(object sender, EventArgs e)
        {
            saveFileDialogData_MND.FileName = "ProjectSprint7_MND.csv";
            saveFileDialogData_MND.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogData_MND.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialogData_MND.FileName;

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                int rows = dataGridViewData_MND.RowCount;
                int columns = dataGridViewData_MND.ColumnCount;

                StringBuilder strBuilder = new StringBuilder();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        strBuilder.Append(dataGridViewData_MND.Rows[i].Cells[j].Value);

                        if (j != columns - 1)
                        {
                            strBuilder.Append(";");
                        }
                    }

                    strBuilder.AppendLine();
                }

                File.WriteAllText(path, strBuilder.ToString(), Encoding.UTF8);

                MessageBox.Show("Файл сохранен", "Операция прошла успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOpen_MND_Click(object sender, EventArgs e)
        {
            // увеличиваем колонны
            dataGridViewData_MND.Columns[1].Width = 200;
            dataGridViewData_MND.Columns[5].Width = 200;
            dataGridViewData_MND.Columns[9].Width = 150;

            // Уменьшаем колонны
            dataGridViewData_MND.Columns[0].Width = 30;
            dataGridViewData_MND.Columns[2].Width = 50;
            dataGridViewData_MND.Columns[3].Width = 100;
            dataGridViewData_MND.Columns[7].Width = 50;
            dataGridViewData_MND.Columns[8].Width = 70;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
                    openFileDialog.Title = "Выберите CSV файл";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // Читаем данные из CSV файла
                        var lines = File.ReadAllLines(filePath);
                        foreach (var line in lines)
                        {
                            // Используем метод Split для деления строки на значения
                            var values = line.Split(';', StringSplitOptions.RemoveEmptyEntries);

                            // Добавляем строку в dataGridView
                            dataGridViewData_MND.Rows.Add(values);
                        }
                        MessageBox.Show("Данные загружены", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonBackMenu_MND_Click(object sender, EventArgs e)
        {
            using (FormMenu Formmenu = new FormMenu())
            {
                Formmenu.TopMost = true;
                Formmenu.ShowDialog();
            }

            this.Close();
        }

        private void groupBoxData_MND_Enter(object sender, EventArgs e)
        {

        }

        private void buttonClear_MND_Click(object sender, EventArgs e)
        {
            dataGridViewData_MND.Rows.Clear();
        }

        private void жанрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CPUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHZ3_MND_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirma_MND_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHZ_MND_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
