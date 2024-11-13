using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tokens
    {
        public Tokens(int no, string plabra, string tipo, int linea)
        {
            No = no;
            Plabra = plabra;
            Tipo = tipo;
            Linea = linea;

        }

        public int No {  get; set; }
        public string Plabra { get; set; }
        public string Tipo { get; set; }
        public int Linea { get; set; }
    }
}
