using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_03
{
    internal class NoLista<TAD>
    {
        // atributos
        private NoLista<TAD> previo;
        private TAD info;
        private NoLista<TAD> next;
        // metodos
        public NoLista()
        {

        }
        public NoLista(TAD valor)
        {
            previo = null;
            info = valor;
            next = null;
        }

        public TAD Info { get => info; set => info = value; }
        internal NoLista<TAD> Previo { get => previo; set => previo = value; }
        internal NoLista<TAD> Next { get => next; set => next = value; }
    }
}
