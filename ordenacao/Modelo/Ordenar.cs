using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ordenacao.Modelo
{
    public class Ordenar
    {
        public Double[,] BubbleSort(Double[,] array)
        {
            int tamanho = array.Length/2;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[0,j] > array[0,j + 1])
                    {
                        Double tempx = array[0,j];
                        Double tempy = array[1,j];
                        array[0,j] = array[0,j + 1];
                        array[1,j] = array[1,j + 1];
                        array[0,j + 1] = tempx;
                        array[1,j + 1] = tempy;
                    }
                }
            }
            return array;
        }
        public Double[,] InsertionSort(Double[,] array)
        {
            for (var i = 1; i < array.Length / 2; i++)
            {
                Double tempx = array[0, i];
                Double tempy = array[1, i];
                int j = i - 1;
                while (j >= 0 && array[0, j] > tempx)
                {
                    array[0, j + 1] = array[0, j];
                    array[1, j + 1] = array[1, j]; 
                    j -= 1;
                }
                array[0, j + 1] = tempx;
                array[1, j + 1] = tempy;
            }
            return array;

        }
        public Double[,] InsertionSortdecre(Double[,] array)
        {
            for (var i = 1; i < array.Length / 2; i++)
            {
                Double tempx = array[0, i];
                Double tempy = array[1, i];
                int j = i - 1;
                while (j >= 0 && array[0, j] < tempx)
                {
                    array[0, j + 1] = array[0, j];
                    array[1, j + 1] = array[1, j];
                    j -= 1;
                }
                array[0, j + 1] = tempx;
                array[1, j + 1] = tempy;
            }
            return array;

        }
        public Double[,] SelectionSort(Double[,] array)
        {
            int min;
            Double aux;
            for (int i = 0; i < array.Length/2 - 1; i++)
            {
                min = i;
                for (int j = (i + 1); j < array.Length/2; j++)
                {
                    if (array[0,j] < array[0,min])
                    {
                        min = j;

                    }
                }
                if (array[0,i] != array[0,min])
                {
                    aux = array[0,i];
                    array[0,i] = array[0,min];
                    array[1,i] = array[1,min];
                    array[0,min] = aux;
                }
            }
            return array;
        }


    }
}
