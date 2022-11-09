using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class formPrograma1 : Form
    {
        public formPrograma1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_MouseClick(object sender, MouseEventArgs e)
        {
            string txt;

            txt = inDatos.Text;
            outDatos.Text = txt;
        }
    }
}
