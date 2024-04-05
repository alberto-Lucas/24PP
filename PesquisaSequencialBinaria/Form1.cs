using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesquisaSequencialBinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;

        int Sequencial(int[] array, int target)
        {
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;

                txtResultado.Text += 
                    ($"{array[i]}  = {target} : {(array[i] == target ? "Sim" : "Não")}" ) + Environment.NewLine;

                if (array[i] == target)
                {
                    return array[i]; // Retorna o índice onde o elemento foi encontrado
                }
                
            }
            return -1; // Retorna -1 se o elemento não foi encontrado
        }

        private void btnSequencial_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int target = int.Parse(txtValor.Text);
            int result = Sequencial(array, target);

            if (result != -1)
            {
                txtResultado.Text += "\n" + ($"Executado {count} vez(es)") + Environment.NewLine;
            }
            else
            {
                txtResultado.Text += "\n" + ($"Executado {count} vez(es)") + Environment.NewLine;
                txtResultado.Text += "\n" + ($"Elemento {target} não encontrado no array") + Environment.NewLine;
            }
        }

        int BinarySearchAlgorithm(int[] array, int target)
        {
            count = 0;
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                count++;
                
                int mid = left + (right - left) / 2;

                txtResultado.Text +=
                    ($"{array[mid]}  = {target} : {(array[mid] == target ? "Sim" : "Não")}") + Environment.NewLine;

                if (array[mid] == target)
                {
                    return mid; // Retorna o índice onde o elemento foi encontrado
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1; // Retorna -1 se o elemento não foi encontrado
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int target = int.Parse(txtValor.Text);
            int result = BinarySearchAlgorithm(array, target);

            if (result != -1)
            {
                txtResultado.Text += "\n" + ($"Executado {count} vez(es)") + Environment.NewLine;
            }
            else
            {
                txtResultado.Text += "\n" + ($"Executado {count} vez(es)") + Environment.NewLine;
                txtResultado.Text += "\n" + ($"Elemento {target} não encontrado no array") + Environment.NewLine;
            }
        }
    }
}
