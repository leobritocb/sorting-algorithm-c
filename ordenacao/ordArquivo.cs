using ordenacao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ordenacao
{
    public partial class ordArquivo : Form
    {

        public static int quantDados = 100000;
        public Double[,] vetor = new Double[2, quantDados];
        public ordArquivo()
        {
            InitializeComponent();
        }

        private void ordArquivo_Load(object sender, EventArgs e)
        {

        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Temp\\Coordenadas\\Desordenado";
            openFileDialog1.Filter = "IO Files (*.io)|*.io";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = openFileDialog1.FileName;
            }

            String strArquivo = lblPath.Text;
            int index = 0;
            Dados dados = new Dados();
            List<Coordenadas> coordenadas;
            coordenadas = new List<Coordenadas>();
            lbLat.Items.Clear();
            lbLong.Items.Clear();
            //dados.CreateDadosTxt(strArquivo);
            coordenadas = (dados.DadosTxt(strArquivo));
            vetor = new Double[2, coordenadas.Count];
            coordenadas.ForEach(delegate (Coordenadas c)
            {
                vetor[0, index] = c.Latitude;
                vetor[1,index] = c.Longitude;  
                index++;
            });
            for (int i = 0; i < vetor.GetLength(1) / 100; i++)
            {
                lbLat.Items.Add(vetor[0, i * 100].ToString("N5"));
                lbLong.Items.Add(vetor[1, i * 100].ToString("N5"));
            }
            lblNdados.Text =Convert.ToString(vetor.Length/2) ;
        }

        private void lbLat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLong.SelectedIndex = lbLat.SelectedIndex;
        }

        private void lbLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLat.SelectedIndex = lbLat.SelectedIndex;
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            Ordenar ordenar = new Ordenar();
            Double[,] array;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            array = ordenar.BubbleSort(vetor);
            stopwatch.Stop();
            lblTempo.Text = $"{stopwatch.Elapsed}";
            lbLat.Items.Clear();
            lbLong.Items.Clear();
            for (int i = 0; i < vetor.GetLength(1) / 100; i++)
            {
                lbLat.Items.Add(vetor[0, i * 100].ToString("N5"));
                lbLong.Items.Add(vetor[1, i * 100].ToString("N5"));
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            Ordenar ordenar = new Ordenar();
            Double[,] array;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            array = ordenar.SelectionSort(vetor);
            stopwatch.Stop();
            lblTempo.Text = $"{stopwatch.Elapsed}";
            lbLat.Items.Clear();
            lbLong.Items.Clear();
            for (int i = 0; i < vetor.GetLength(1) / 100; i++)
            {
                lbLat.Items.Add(vetor[0, i * 100].ToString("N5"));
                lbLong.Items.Add(vetor[1, i * 100].ToString("N5"));
            }
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            Ordenar ordenar = new Ordenar();
            Double[,] array;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            array = ordenar.InsertionSort(vetor);
            stopwatch.Stop();
            lblTempo.Text = $"{stopwatch.Elapsed}";
            lbLat.Items.Clear();
            lbLong.Items.Clear();
            for (int i = 0; i < vetor.GetLength(1)/100; i++)
            {
                lbLat.Items.Add(vetor[0, i * 100].ToString("N5"));
                lbLong.Items.Add(vetor[1, i * 100].ToString("N5"));
            }
        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            //dados.CreateDadosTxt("C:\\Temp\\Coordenadas\\Desordenado\\dados.io");
            dados.SalvaDadosTxt("C:\\Temp\\Coordenadas\\Ordenado\\dados.io", vetor);
        }
    }
}
