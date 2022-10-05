using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichBox_Kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtxtUpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCitaj_Click(object sender, EventArgs e)
        {
            rtxtUpis.LoadFile(@"C:TempProba.rtf");
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            rtxtUpis.SaveFile(@"C:TempProba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            rtxtUpis.Clear();
        }
    }
}
