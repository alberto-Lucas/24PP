using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPilha
{
    public partial class Form1 : Form
    {
        //Aqui são variaveis globais

        //Pilha de numeros inteiros
        Stack<int> pilha;

       //Pilhar aulixari apenas para demonstração
        Stack<int> pilhaAux;

        //Variavel que vai receber a posição atual do topo
        int topo;
        int topoAux;

        //Variavale que define o tamanho da pilha
        int capacidade;
        int capacidadeAux;

        public Form1()
        {
            InitializeComponent();
        }

        //Metodo para atualizar a lista com os valores da pilha
        void AtualizarListaPilha()
        {
            //Limpa a lista
            lstPilha.Items.Clear();

            //Percorro a pilha de acordo o topo
            //e insiro o valor na lista
            for(int i = 0; i <= topo; i++)
            {
                //Adicionar o elemento atual da pilha a lista
                int elemento = pilha.ElementAt(i);

                lstPilha.Items.Add(elemento.ToString());
            }
        }

        //Metodo para criar a pilha
        void CriarPilha(int tamanho)
        {
            //definir a capacidade da pilha
            capacidade = tamanho;

            //Criar a pilha em memoria
            pilha = new Stack<int>();

            //Definie a pilha vazia
            topo = -1;

            lstLog.Items.Add("Pilha Criada");
            lstLog.Items.Add("Capacidade: " + capacidade.ToString());
        }

        //Funcao para retornar se a pilha esta cheia
        bool PilhaCheia()
        {
            //Precisamos remover 1 do valor
            //Pois a pilha começa na posição zero
            //Portanto numa pilha de 5 elementos
            //O o quinto e ultimo elemento
            //estara na posição 4
            //ou seja capacidade - i
            //Portanto se a posiação do topo
            //for igual a capacidade -1  a pilha esta cheia
            return topo == (capacidade - 1);
        }

        //Funcao para retornar se a pilha esta vazia
        bool PilhaVazia()
        {
            return topo == -1;
        }

        //Funcao para retornoar o ultimo valor
        int UltimoValor()
        {
            return pilha.Peek();
        }

        //Metodo para inserir um valor na pilha
        void Push(int valor)
        {
            //Validar se a pilha esta cheia
            if(PilhaCheia())
            {
                lstLog.Items.Add("Pilha Cheia!");
            }
            else
            {
                //isnerir o valor na pilha
                pilha.Push(valor);

                //Atualizar o topo com a posiação atual
                topo++;
                txtTopo.Text = topo.ToString();

                lstLog.Items.Add("Push");
                lstLog.Items.Add("Posição: " + topo.ToString() + " - Valor: " + valor.ToString());

                AtualizarListaPilha();
            }
        }

        //Metodo para remover um valor da pilha(sempre o ultimo)
        void Pop()
        {
            //Validar se a pilha esta vazia
            if(PilhaVazia())
            {
                lstLog.Items.Add("Pilha Vazia!");
            }
            else
            {
                //Recuperar ultimo valor da pilha
                int ultimoValor = UltimoValor();

                //Remover o ultimo valor da pilha
                pilha.Pop();

                lstLog.Items.Add("Pop");
                lstLog.Items.Add("Posição: " + topo.ToString() + " - Valor: " + ultimoValor.ToString());

                //Atualizar o topo com a posição atual
                topo--;
                txtTopo.Text = topo.ToString();

                AtualizarListaPilha();
            }
        }

        //Metodo para desempilhar a pilha
        void Desempilhar()
        {
            //Inserir na pilha auxiliar o ultima valor da pilha principal
            //Depois remover o valor da pilha principal
            PushAux(UltimoValor());
            Pop();
        }

        //Metodo para Empilhar a pilha novamente
        void VoltarParaPilha()
        {
            //Inserir na pilha principal o ultima valor da pilha auxiliar
            //Depois remover o valor da pilha auxiliar
            Push(UltimoValorAux());
            PopAux();
        }


        //********************************************************************************************//
        #region Pilha Auxiliar

        void AtualizarListaPilhaAux()
        {
            lstAux.Items.Clear();

            for (int i = 0; i <= topoAux; i++)
            {
                int elemento = pilhaAux.ElementAt(i);
                lstAux.Items.Add(elemento.ToString());
            }
        }

        void CriarPilhaAux(int tamanho)
        {
            capacidadeAux = tamanho;
            pilhaAux = new Stack<int>();
            topoAux = -1;
        }

        bool PilhaCheiaAux()
        {
            return topoAux == (capacidadeAux - 1);
        }

        bool PilhaVaziaAux()
        {
            return topoAux == -1;
        }

        int UltimoValorAux()
        {
            return pilhaAux.Peek();
        }

        void PushAux(int valor)
        {
            //Validar se a pilha esta cheia
            if (!PilhaCheiaAux())
            {
                pilhaAux.Push(valor);
                topoAux++;
                AtualizarListaPilhaAux();
            }
        }

        void PopAux()
        {

            if (!PilhaVaziaAux())
            {
                pilhaAux.Pop();
                topoAux--;

                AtualizarListaPilhaAux();
            }
        }
        #endregion
        //********************************************************************************************//


        private void btnCriar_Click(object sender, EventArgs e)
        {
            //Limpar a lista da pilha
            lstPilha.Items.Clear();

            CriarPilha(int.Parse(txtCapacidade.Text));

            lstAux.Items.Clear();

            CriarPilhaAux(int.Parse(txtCapacidade.Text));
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Push(int.Parse(txtValor.Text));
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Pop();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarParaPilha();
        }

        private void btnDesempilhar_Click(object sender, EventArgs e)
        {
            Desempilhar();
        }

        private void btnRemoverAux_Click(object sender, EventArgs e)
        {
            PopAux();
        }
    }
}
