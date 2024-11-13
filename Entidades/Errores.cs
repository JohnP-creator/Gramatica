using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Errores
    {
        public Errores(string codigo, string descripcion, int linea)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.linea = linea;
        }

        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int linea { get; set; }
    }
}
