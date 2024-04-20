using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFila
{
    public partial class Form1 : Form
    {
        Queue<int> fila; //Fila de numeros inteiros
        int capacidade; //Capacidade de elementos da fila

        public Form1()
        {
            InitializeComponent();
        }

        //Método para criação da fila
        void CriarFila(int elementos)
        {
            //Define a quantidad de elementos na fila
            capacidade = elementos;

            //Criar a fila em memoria
            fila = new Queue<int>();

            lstLog.Items.Add("Fila criada");
            lstLog.Items.Add("Capacidade: " + capacidade.ToString());
        }

        //Função para verificar se a fila está cheia
        bool FilaCheia()
        {
            //Retorna se quantidade de elementos na fila é igual a capacidade
            return fila.Count == capacidade;
        }

        //Função para verificar se a fila está vazia
        bool FilaVazia()
        {
            //Verifica se a quantidade de elemesnto na fila é zero
            return fila.Count == 0;
        }

        //Metodo para atualizar a fila para o usuario
        void AtualizarListaFila()
        {
            //Limpa a lista
            lstFila.Items.Clear();

            //Isso aqui não funciona
            //pois o primeiro elemento não nescessariamente
            //estara na posição zero
            //ou seja o primeiro elemento tem sua posição variada
            /*
            for(int i = 0; i <= fila.Count; i++)
            {
                int elemento = fila[i];
            }*/

            //Portanto precisamos utilizar
            //Laço de repetição, para percorrer os elementos
            //e não a posição deles
            foreach(var elemento in fila)
            {
                lstFila.Items.Add(elemento.ToString());
            }
        }

        //Metodo para inserir um valor na fila
        void Enqueue(int valor)
        {
            //Validmos se a fila esta cheia
            //ou seja se a quantidade de elementos é igual a capacidade
            if (FilaCheia())
                lstLog.Items.Add("Fila Cheia!");
            else
            {
                //Inserirmos o valor na Fila]
                fila.Enqueue(valor);

                //Apresentamos o log
                lstLog.Items.Add("Enqueue");
                lstLog.Items.Add("Valor: " + valor.ToString());

                AtualizarListaFila();
            }
        }

        //Metodo para remover um valor da fila
        void Dequeue()
        {
            //Validar se a fila esta vazia
            if (FilaVazia())
                lstLog.Items.Add("Fila Vazia!");
            else
            {
                //Remover o primeiro elemento da fila
                //e exibir no log
                int primeiroElemento = fila.Dequeue();
                lstLog.Items.Add("Dequeue");
                lstLog.Items.Add("Valor: " + primeiroElemento.ToString());

                AtualizarListaFila();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            lstFila.Items.Clear();
            CriarFila(int.Parse(txtCapacidade.Text));
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Enqueue(int.Parse(txtValor.Text));
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Dequeue();
        }
    }
}
