using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        //int dato = 0;
        int[] array = new int[1000];

        private void button1_Click(object sender, EventArgs e)
        {
            llenadoArray();
        }

        public void llenadoArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10000);
                txtArray.Text = txtArray.Text + ", " + array[i].ToString();
            }
        }

        public void llenadoArrayOrden(int[] bubble)
        {
            txtOrden.Text = "";
            for (int i = 0; i < bubble.Length; i++)
            {
                txtOrden.Text = txtOrden.Text + " " + bubble[i].ToString();
            }
        }

        public void llenadoArrayQuick(int[] quick)
        {
            txtQuick.Text = "";
            for (int i = 0; i < quick.Length; i++)
            {
                txtQuick.Text = txtQuick.Text + " " + quick[i].ToString();
            }
        }

        public void llenadoArrayInsercion(int[] insercion)
        {
            txtInsercion.Text = "";
            for (int i = 0; i < insercion.Length; i++)
            {
                txtInsercion.Text = txtInsercion.Text + " " + insercion[i].ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] bubble = BubbleSort(array);
            stopwatch.Stop();
            String tiempo = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            llenadoArrayOrden(array);
            txtTimeBubble.Text = tiempo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] quick = QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();
            String tiempo = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            llenadoArrayQuick(quick);
            txtTimeQuick.Text = tiempo;
        }

        private void btnInsercion_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] insercion = Insercion(array);
            stopwatch.Stop();
            String tiempo = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            llenadoArrayInsercion(insercion);
            txtTimeInsercion.Text = tiempo;
        }

        public int[] BubbleSort(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public int[] QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = arr[leftIndex];

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(arr, leftIndex, j);

            if (i < rightIndex)
                QuickSort(arr, i, rightIndex);

            return arr;
        }

        public int[] Insercion(int[] arr)
        {
            int temp;
            int j;

            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = array[j];
                    j--;
                }
                arr[j + 1] = temp;
            }

            return arr;
        }

        public int binarySearch(int seekElement)
        {
            int[] insercion = Insercion(array);
            int startIndex = 0;
            int endIndex = insercion.Length - 1;

            while(startIndex <= endIndex)
            {
                int middleIndex = startIndex + ((endIndex - startIndex) / 2);

                if (insercion[middleIndex] == seekElement)
                {
                    return middleIndex;
                }

                if (insercion[middleIndex] < seekElement)
                {
                    startIndex = middleIndex + 1;
                }
                else
                {
                    endIndex = middleIndex - 1;
                }
            }

            return -1;
        }

        public int secuentialSearch(int seekElement)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (seekElement == array[i])
                {
                    return i;
                }
            }

            return -1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            int seekElement = int.Parse(txtSeekElement.Text);
            
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int binaryResult = binarySearch(seekElement);
            stopwatch.Stop();
            String tiempo = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            txtBinaryTime.Text = tiempo;

            if (binaryResult == -1)
            {
                txtBinaryIndex.Text = "EL DATO NO SE ENCUENTRA EN EL VECTOR";
            }
            else
            {
                txtBinaryIndex.Text = "EL DATO ESTA EN EL INDEX: " + binaryResult.ToString();
            }

            stopwatch.Start();
            int secuentialResult = secuentialSearch(seekElement);
            stopwatch.Stop();
            tiempo = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            txtSecuentialTime.Text = tiempo;

            if (secuentialResult == -1)
            {
                txtSecuentialIndex.Text = "EL DATO NO SE ENCUENTRA EN EL VECTOR";
            }
            else
            {
                txtSecuentialIndex.Text = "EL DATO ESTA EN EL INDEX: " + secuentialResult.ToString();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
