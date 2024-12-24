namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxFind_MND_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxFind_MND.Text.ToLower(); //чувствительность 

            foreach (DataGridViewRow row in dataGridViewIn_MND.Rows)
            {
                if (row.IsNewRow) continue; // проверка строк которые были добавлены 

                bool found = false; // булл переменная

                for (int j = 0; j < dataGridViewIn_MND.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found; // видимость и невидимость строк
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonADD_MND_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_NMD_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void buttonFirma_MND_Click(object sender, EventArgs e)
        {

        }
    }
}
