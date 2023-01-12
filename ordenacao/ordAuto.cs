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
    public partial class ordAuto : Form
    {
        
        public static int quantDados=100000;
        public Double[,] vetor = new Double[2, quantDados];
        public ordAuto()
        {
            InitializeComponent();
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

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();            
            var strFormat = new System.Text.StringBuilder();
            vetor = dados.GeraDados(quantDados);
            lbLat.Items.Clear();
            lbLong.Items.Clear();

            for (int i = 0; i < vetor.Length/2/100; i++)
            {

                lbLat.Items.Add
                (
                    vetor[0, i*100].ToString("N5")
                );
                lbLong.Items.Add
                (
                    vetor[1, i*100].ToString("N5")
                ); 
            }
            lblNDados.Text = Convert.ToString( vetor.Length / 2);
        }

        private void lbLat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbLong.Items;
        }

        private void ordAuto_Load(object sender, EventArgs e)
        {
            
        }

        private void lbLat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbLong.SelectedIndex = lbLat.SelectedIndex;
        }

        private void lbLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLat.SelectedIndex = lbLong.SelectedIndex;
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
            for (int i = 0; i < vetor.GetLength(1)/100; i++)
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
            for (int i = 0; i < vetor.GetLength(1) / 100; i++)
            {
                lbLat.Items.Add(vetor[0, i * 100].ToString("N5"));
                lbLong.Items.Add(vetor[1, i * 100].ToString("N5"));
            }
        }
    }
}
