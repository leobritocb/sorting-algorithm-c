using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ordenacao.Modelo;
using System.Reflection;
using System.Diagnostics;

namespace ordenacao
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            
            ordArquivo arq = new ordArquivo();
            arq.Show();
        }

        private void btnAutomatica_Click(object sender, EventArgs e)
        {
            ordAuto auto = new ordAuto();
            auto.Show();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

    }
}
