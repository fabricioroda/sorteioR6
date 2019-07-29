using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                Random randNum = new Random();
                string qtde1 = txtBoxQtde.Text;
                int qtde2 = Convert.ToInt16(qtde1);
                    //MessageBox.Show("Resultado do Sorteio é " + randNum.Next(qtde2).ToString());
                    lblResultado.Text = "Numero do Membro do R6 Sorteado é " + (randNum.Next(1, qtde2).ToString());
                    lblResultado.Visible = true;
              

            
        }
    }
}
