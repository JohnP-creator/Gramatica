using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Manejadores
{
    public class ManejadorGramatica
    {
        public static List<Tokens> tokens = new List<Tokens>();
        HashSet<int> lineasComentarios = new HashSet<int>();

        public int linea = 0;
        string rs = "";

        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.DataSource = tokens.ToList();
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void LlenarTabla(TextBox Codigo)
        {
            tokens.Clear();
            int contadorGlobal = 1;

            String[] Lineas = Codigo.Text.Split(new[] { '\n' }, StringSplitOptions.None);
            for (linea = 0; linea < Lineas.Length; linea++)
            {
                string[] palabras = Lineas[linea].Split(new[] { ' ', '\n' });

                foreach (var item in palabras)
                {
                    if (!string.IsNullOrWhiteSpace(item.Trim()))
                    {
                        rs = "";
                        string clasificacion = VerificarPalabra(item.Trim(), linea +1);
                        tokens.Add(new Tokens(contadorGlobal, item, clasificacion, linea + 1));
                        contadorGlobal++;
                    }
                }
            }
        }

        public string VerificarPalabra(string palabra, int linea)
        {
            palabra = palabra.TrimEnd('\n', '\r');
            if (rs.Equals(""))
            {
                rs = PalabrasReservadas(palabra);
            }
            if (rs.Equals(""))
            {
                rs = Comentario(palabra, linea);
            }
            if (rs.Equals(""))
            {
                rs = Identificador(palabra);
            }
            if (rs.Equals(""))
            {
                rs = Expresion(palabra);
            }
            if (rs.Equals(""))
            {
                rs = Valor(palabra);
            }
            if (rs.Equals(""))
            {
                rs = Signo(palabra);
            }
            if (rs.Equals(""))
                rs = "No identificada";
       
            return rs;
        }


        string PalabrasReservadas(string token)
        {
            if (Regex.IsMatch(token, @"\A(>:End|GirarArriba|GirarAbajo|Encender|Apagar|Start<:|EstadoInicio|EstadoFinal|Speed)\Z"))
                return "Palabra Reservada";
            else
                return "";
        }

        string Comentario(string token, int liena)
        {
            if (Regex.IsMatch(token, @"\A(#([A-Za-z]|[0-9])([A-Za-z]|[0-9])*)\Z") || lineasComentarios.Contains(linea))
            {
                lineasComentarios.Add(linea);
                return "Comentario.";
            }
            return "";
        }

        string Identificador(string token) => Regex.IsMatch(token, @"^[A-Za-z]+[A-Za-z0-9]*$") ? "Identificador" : "";
        string Expresion(string token) => Regex.IsMatch(token, @"^\(\d+(?:,\d+)*\)") ? "Expresion" : "";
        string Valor(string token) => Regex.IsMatch(token, @"\A[0-9]*\Z") ? "Valor" : "";
        string Signo(string token) => Regex.IsMatch(token, @"\A(>:|<:|=)\Z") ? "Signo" : "";


    }
}