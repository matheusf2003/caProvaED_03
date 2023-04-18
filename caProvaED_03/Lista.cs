using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_03
{
    internal class Lista<TAD>
    {
        private NoLista<TAD> inicio;
        private NoLista<TAD> fim;
        // metodos
        public Lista()
        {
            inicio = null;
            fim = null;
        }
        public bool estaVazia()
        {
            return inicio == null;
        }
        public void insere(TAD n)
        {
            if (estaVazia())
            {
                inicio = new NoLista<TAD>(n);
                fim = inicio;
            }
            else
            {
                NoLista<TAD> novoNo = new NoLista<TAD>(n);
                novoNo.Previo = fim;
                fim.Next = novoNo;
                fim = novoNo;
            }
        }
        public void remove(TAD n)
        {
            if(!estaVazia())
            {
                Console.WriteLine("A lista esta vazia");
            }
            else
            {
                fim = fim.Previo;
            }
        }
        public void imprime()
        {
            NoLista<TAD> temp = new NoLista<TAD>();
            while(temp != null)
            {
                Console.WriteLine();
            }
        }
        // getterns and setters
        internal NoLista<TAD> Inicio { get => inicio; set => inicio = value; }
        internal NoLista<TAD> Fim { get => fim; set => fim = value; }
    }
}
