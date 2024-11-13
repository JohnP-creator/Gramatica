using Entidades;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using Manejadores;
using System.IO;

public class ManejadoSintactico
{
        Dictionary<string, string>Error = new Dictionary<string, string>();
        List<Errores> errores = new List<Errores>();

    public void VerificarErrores(DataGridView Tabla)
    {
        try
        {
            CargarErrores();
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                string token = Tabla.Rows[i].Cells[1].Value.ToString();
                string errores = "";

                switch (token)
                {
                    case "GirarArriba":
                        {
                            string tipo = Tabla.Rows[i + 1].Cells[2].Value.ToString();
                            if (!tipo.Equals("Expresion") || tipo.Equals(null))
                            {
                                errores += $"{Error["EE1"]}";
                                int linea = int.Parse(Tabla.Rows[i].Cells[3].Value.ToString());
                                string mensaje = Error["EE1"];
                                MessageBox.Show($"EE1: {mensaje}, en linea: {linea}", "Ha ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "GirarAbajo":
                        {
                            string tipo = Tabla.Rows[i + 1].Cells[2].Value.ToString();
                            if (!tipo.Equals("Expresion") || tipo.Equals(null))
                            {
                                errores += $"{Error["EE1"]}";
                                int linea = int.Parse(Tabla.Rows[i].Cells[3].Value.ToString());
                                string mensaje = Error["EE1"];
                                MessageBox.Show($"EE1: {mensaje}, en linea: {linea}", "Ha ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "Apagar":
                        {
                            string tipo = Tabla.Rows[i + 1].Cells[2].Value.ToString();
                            if (!tipo.Equals("Expresion") || tipo.Equals(null))
                            {
                                errores += $"{Error["EE1"]}";
                                int linea = int.Parse(Tabla.Rows[i].Cells[3].Value.ToString());
                                string mensaje = Error["EE1"];
                                MessageBox.Show($"EE1: {mensaje}, en linea: {linea}", "Ha ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "Encender":
                        {
                            string tipo = Tabla.Rows[i + 1].Cells[2].Value.ToString();
                            if (!tipo.Equals("Expresion") || tipo.Equals(null))
                            {
                                errores += $"{Error["EE1"]}";
                                int linea = int.Parse(Tabla.Rows[i].Cells[3].Value.ToString());
                                string mensaje = Error["EE1"];
                                MessageBox.Show($"EE1: {mensaje}, en linea: {linea}", "Ha ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        break;
                    case "Speed":

                        {
                            int pos = i + 1;
                            string tipo = Tabla.Rows[pos].Cells[2].Value.ToString();
                            string comp = Tabla.Rows[pos+1].Cells[2].Value.ToString();
                            if (tipo.Equals("Signo") && comp.Equals("Valor"))
                            {
                              
                            }
                            else
                            {
                                
                            }
                            
                        }
                        break;
                }
            }
          
        }
       
        catch
        {
            MessageBox.Show("Ha ocurrido un error al verificar, se esperaba suficientes parametros.", "Error Sintactico.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    public void CargarErrores()
    {
        string[] error = null;
        StreamReader sr = null;
        try
        {
            sr = new StreamReader("Errores.txt");
            string linea = "";
            while((linea = sr.ReadLine()) != null)
            {
                error = linea.Split('#');
                Error.Add(error[0], error[1]);
            }
            sr.Close();
        }
        catch (Exception)
        {
            sr.Close();
        }
    }
}

    
