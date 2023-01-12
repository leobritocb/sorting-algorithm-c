using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace ordenacao.Modelo
{
    public class Coordenadas
    {
        public Coordenadas() { }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Coordenadas(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
    class Dados
    {
        public Double[,] GeraDados(int quantDados = 1)
        {
            int iLat, iLong;
            Double dLat, dLong;
            String strLat, strLong;
            iLat = 90;
            iLong = 180;
            int linhasDados = quantDados;
            int colDados = 2;

            Random ranNum = new Random();
            Double[,] retornoDados = new Double[colDados, linhasDados];

            for (int i = 0; i < linhasDados; i++)
            {
                dLat = Math.Round(ranNum.NextDouble(), 5); 
                dLong = Math.Round(ranNum.NextDouble(),5); 
                strLat = String.Format("{0:0.#####}", dLat * (iLat + iLat) - iLat);
                strLong = String.Format("{0:0.#####}", dLong * (iLong + iLong) - iLong);
                dLat = Convert.ToDouble(strLat);
                dLong = Convert.ToDouble(strLong);
                retornoDados[0, i] = dLat;
                retornoDados[1, i] = dLong;

            }
            return retornoDados;
        }
        public Double[,] VetorListBox(ListBox lbLat, ListBox lbLong)
        {
            Double dLat, dLong;
            String strLat, strLong;
            int linhasDados = lbLat.Items.Count;
            int colDados = 2;
            Double[,] retornoDados = new Double[colDados, linhasDados];

            for (int i = 0; i < linhasDados; i++)
            {
                strLat = lbLat.Items[i].ToString();
                strLong = lbLong.Items[i].ToString();
                dLat = Convert.ToDouble(strLat);
                dLong = Convert.ToDouble(strLong);
                retornoDados[0, i] = dLat;
                retornoDados[1, i] = dLong;

            }
            return retornoDados;
        }
        public List<Coordenadas> DadosTxt(String arquivo)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(arquivo);
            string linha;
            int linhasDados = 100000;
            int colDados = 2;
            List<Coordenadas> coordenadas;
            coordenadas = new List<Coordenadas>();

            Double[] latitude = new Double[colDados];
            Double[] longitude = new Double[colDados];

            Double[,] resultado = new Double[colDados, linhasDados];
            while ((linha = reader.ReadLine()) != null)
            {
                string[] dados = linha.Split(' '); 
                coordenadas.Add(new Coordenadas(Double.Parse(dados[0]),Double.Parse(dados[1])));
            }

            reader.Close();
            return coordenadas;
        }
        public void CreateDadosTxt(String arquivo)
        {
            int iLat, iLong;
            Double dLat, dLong;
            String strLat, strLong;
            iLat = 90;
            iLong = 180;
            int linhasDados = 100000;

            Random ranNum = new Random();
            System.IO.StreamWriter writer = new System.IO.StreamWriter(arquivo);
            for (int i = 0; i < linhasDados; i++)
            {
                dLat = ranNum.NextDouble();
                dLong = ranNum.NextDouble();
                dLat = dLat * (iLat + iLat) - iLat;
                strLat = dLat.ToString("N5");
                strLong = String.Format("{0:0.00000}", dLong * (iLong + iLong) - iLong);
                writer.WriteLine($"{strLat} {strLong}");


            }
            writer.Close();
        }
        public void SalvaDadosTxt(String arquivo, Double[,] array)
        {

            
            System.IO.StreamWriter writer = new System.IO.StreamWriter(arquivo);
            for (int i = 0; i < array.Length/2; i++)
            {
                writer.WriteLine($"{array[0,i]} {array[1,i]}");
            }
            writer.Close();
        }
    }
}