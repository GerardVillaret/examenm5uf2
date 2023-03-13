using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_M5
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btAnimal_Click(object sender, EventArgs e)
        {
            FormAnimals formAnimals = new FormAnimals();
            formAnimals.ShowDialog();
        }

        private void btVintage_Click(object sender, EventArgs e)
        {
            FormVintage formVintage = new FormVintage();
            formVintage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenjar formMenjar = new FormMenjar();
            formMenjar.ShowDialog();
        }
    }
}
