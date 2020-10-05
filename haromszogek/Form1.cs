using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haromszogek
{
    public partial class frmfo : Form
    {
        private int aOldal;
        private int bOldal;
        private int cOldal;

        public frmfo()
        {
            aOldal = 0;
            bOldal = 0;
            cOldal = 0;
            InitializeComponent();
            tbAoldal.Text = aOldal.ToString();
            tbBoldal.Text = bOldal.ToString();
            tbColdal.Text = cOldal.ToString();
            lbHaromszogLista.Items.Clear();
        }

        private void btnkilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSzamol_Click(object sender, EventArgs e)
        {
            aOldal = Convert.ToInt32(tbAoldal.Text);
            bOldal = Convert.ToInt32(tbBoldal.Text);
            cOldal = Convert.ToInt32(tbColdal.Text);
            StringBuilder szoveg = new StringBuilder();
            szoveg.Append("a: ");
            szoveg.Append(aOldal.ToString());
            szoveg.Append("b: ");
            szoveg.Append(bOldal.ToString());
            szoveg.Append("c: ");
            szoveg.Append(cOldal.ToString());
           
            if (aOldal == 0 ||bOldal==0||cOldal==0)
            {
                MessageBox.Show("Nullánál nagyobb számot adj meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var h = new haromszog(aOldal, bOldal, cOldal);
                List<string> adatok = h.AdatokSzoveg();
                foreach (var a in adatok)
                {
                    lbHaromszogLista.Items.Add(a);
                }
                
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHaromszogLista.Items.Count > 0)
            {
                lbHaromszogLista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Ne basszad már meg az anyádat.");
            }     
        }
    }
}
