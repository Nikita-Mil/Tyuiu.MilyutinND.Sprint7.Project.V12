using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonClose_MND_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbout_MND_Click(object sender, EventArgs e)
        {
            FormInfo formAbout = new FormInfo();
            formAbout.TopMost = true;
            formAbout.ShowDialog();
        }

        private void buttonStart_MND_Click(object sender, EventArgs e)
        {
            FormMain formGeneral = new FormMain();
            formGeneral.TopMost = true;
            formGeneral.ShowDialog();
            this.Hide();
        }

        private void buttonGuide_MND_Click(object sender, EventArgs e)
        {
            FormGuides formGuides = new FormGuides();
            formGuides.TopMost = true;
            formGuides.ShowDialog();
        }

        private void buttonStart_MND_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxName_MND_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
