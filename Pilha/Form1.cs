using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilha
{
    public partial class Form1 : Form
    {
        private Stack<int> pilha; //Pilha de numeros inteiros
        private int topo; //Variavel q vai receber a posição atual do topo
        private int capacidade; //Variavel que define o tamanho da pilha

        public Form1()
        {
            InitializeComponent();
        }
        /*
        void Delay(int tempo)
        {
            //await Task.Delay(tempo);
            Thread.Sleep(5000);
        }*/
        
        async Task Delay(int tempo)
        {
            await Task.Delay(tempo);
        }

        //Metodo para criar a pilha
        void CriarPilha(int tamanho)
        {
            //define a capacidade da pilha
            capacidade = tamanho;

            //Cria a pilha em memoria
            pilha = new Stack<int>();

            //Define a pilha vazia
            topo = -1;

            lstLog.Items.Add("Pilha criada.");
            lstLog.Items.Add("Tamanho: " + capacidade.ToString());
        }

        //Funcao para verificar lista cheia
        bool ListaCheia()
        {
            return topo == capacidade - 1;
        }

        //Funcao para verificar lista vazia
        bool ListaVazia()
        {
            return topo == -1;
        }

        //Funcao para retorno o valor do topo(ultimo valor)
        int ValotTopo()
        {
            return pilha.Peek();
        }

        //Metodo para Desempilhar a Pilha
        async void Desempilhar()
        {
            lstDesPilha.Items.Clear();

            lstLog.Items.Add("Desempilhar");
            //Enquanto a pilha não estiver vazia
            //sera despilhada
            while (!ListaVazia())
            {
                //Captura o ultimo valor da pilha e apresenta na lista DesPilha
                lstDesPilha.Items.Add(ValotTopo().ToString());
                //Remove o ultimo valor
                Pop();
                await Delay(1000);
            }
        }

        //Metodo para inserir um valor na pilha
        void Push(int valor)
        {
            //Validamos se a pilha esta cheia
            //ou seja se o topo é igual a capacidade - 1
            //o menos um é nescessario devido a pilha iniciar na posição zero
            if(ListaCheia())
            {
                lstLog.Items.Add("Pilha cheia!");
            }
            else
            {
                //insere o valor na pilha
                pilha.Push(valor);
                //atualiza o topo com a posiçaõ atual
                topo++;
                txtTopo.Text = topo.ToString();

                lstLog.Items.Add("Push");
                lstLog.Items.Add("Posição: " + topo.ToString() + " Valor: " + valor.ToString());

                atualizarListaPilha();
            }
        }

        //Metodo para remover um valor da pilha
        void Pop()
        {
            //Validamos se a pilha esta vazia
            if (ListaVazia())
            {
                lstLog.Items.Add("Pilha vazia!");
            }
            else
            {
                int ultimoValor = ValotTopo();
                //Remove o ultimo valro da pilha
                pilha.Pop();

                lstLog.Items.Add("Pop");
                lstLog.Items.Add("Posição: " + topo.ToString() + " Valor: " + ultimoValor.ToString());

                //atualiza o topo com a posiçaõ atual
                topo--;
                txtTopo.Text = topo.ToString();

                atualizarListaPilha();
            }
        }

        //Metodo para atualizar a lista com os valores da pilha
        void atualizarListaPilha()
        {
            //Limpa a lista
            lstPilha.Items.Clear();

            //Percorro a lista de acordo com o topo
            for (int i = topo; i >= 0; i--)
            {
                //Adicionar o elemento da pilha a lista
                lstPilha.Items.Add(pilha.ElementAt(i).ToString());
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();

            CriarPilha(int.Parse(txtCapacidade.Text));

            txtValor.Enabled = true;
            btnInserir.Enabled = true;
            btnRemover.Enabled = true;
            btnDespilhar.Enabled = true;

            txtCapacidade.Enabled = false;
            btnCriar.Enabled = false;
            txtValor.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Push(int.Parse(txtValor.Text));
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Pop();
            txtValor.Focus();
        }

        private void btnDespilhar_Click(object sender, EventArgs e)
        {
            Desempilhar();

            txtValor.Enabled = false;
            btnInserir.Enabled = false;
            btnRemover.Enabled = false;
            btnDespilhar.Enabled = false;

            txtCapacidade.Enabled = true;
            btnCriar.Enabled = true;
            txtCapacidade.Clear();
            txtCapacidade.Focus();
        }

        private async void btnAutomatizar_ClickAsync(object sender, EventArgs e)
        {
            Random randon = new Random();
            int randomico;

            randomico = randon.Next(3, 10);
            txtCapacidade.Text = randomico.ToString();
            btnCriar.PerformClick();

            //for(int i = 0; i < randomico + 1; i++)
            while(!ListaCheia())
            {
                await Delay(500);
               // await Task.Run(() => Thread.Sleep(500));
                txtValor.Text = randon.Next(10).ToString();
                btnInserir.PerformClick();
                // Task.Run(() => Thread.Sleep(500));
                await Delay(500);

                if (randon.Next(2) == 0)
                {
                    btnRemover.PerformClick();
                    // await Task.Run(() => Thread.Sleep(500));
                    await Delay(500);
                }
            }
            Push(0);
        }
    }
}
