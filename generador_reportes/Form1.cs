using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generador_reportes
{
    // Developer ==> Marco Antonio Rico Valadez
    // Message   ==> @CopyRigth 
    // Message   ==> </>
    // WebSite   ==> https://theofsystem.github.io/Portafolio-/
    // Project   ==> HipotCheck development 05/07/2023

    public partial class frm_reports : Form
    {
        public frm_reports()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisiteLink();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        private void VisiteLink(){
            // Habilitar el color que visito el link
            linkLabel1.LinkVisited = true;
            // Abrir link
            System.Diagnostics.Process.Start("https://theofsystem.github.io/Portafolio-/");
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            img_check.Visible = false;
            img_load.Visible = true;
            string[] all_file = all_items();
            bar_load.Visible = true;
            bar_load.Value = 1;
            bar_load.Step = 1;
            bar_load.Minimum = 1;
            bar_load.Maximum = all_file.Length;
            string encabezado = "Numero_Serie, HIPOT, CONTINITY, GROUND";

            // Archivo CSV 
            StreamWriter HipotCheck = File.CreateText("HipotCheck.csv");
            HipotCheck.WriteLine(encabezado);
            for (int i = 0; i < all_file.Length; i++)
            {
                // Extraer datos
                try
                {
                    string datos = read_file(i);
                    Console.WriteLine(datos);
                    HipotCheck.WriteLine(datos);
                    bar_load.PerformStep();
                }
                catch (Exception)
                {
                    string datos = "ERROR, ERROR, ERROR, ERROR";
                    HipotCheck.WriteLine(datos);
                    bar_load.PerformStep();
                }
               
            }
            HipotCheck.Close();
            img_load.Visible = false;
            img_check.Visible = true;          
        }

        static string[] all_items()
        {
            string rootdirs = @"C:\HipotOmnia\eti\logs"; // Ruta de extraccion de datos
            
            // Busca todos los archivos .out
            string[] dirs = Directory.GetFileSystemEntries(rootdirs, "*PROCESS*.out", SearchOption.AllDirectories);    // Obtenemos los directorios que estan en la ruta
    
            return dirs; 
        }

        static string read_file(int iterar)
        {
            string[] ficheros = all_items();
            string[] serialNumber;
            string[] hipotState;
            string[] ContinityState;
            string[] GroundState;
            string Numero_Serie;
            string Estado_Hipot;
            string Continuidad;
            string Ground;
            string intro_datos;
            // Abrir archivo para leerlo
            StreamReader archivo_extraccion = File.OpenText(ficheros[iterar]);
            string leer_archivo = archivo_extraccion.ReadToEnd();

            // Extraemos el dato que nos interesa
            string[] extraer_datos = leer_archivo.Split(' ');

            // Variables que obtendran los datos
            try
            {
                serialNumber = extraer_datos[6].Split('{');
                hipotState = extraer_datos[5].Split(',');
                ContinityState = extraer_datos[3].Split(',');
                GroundState = extraer_datos[4].Split(',');
                // Datos Obteneidos
                Numero_Serie = serialNumber[0];
                Estado_Hipot = hipotState[4];
                Continuidad = ContinityState[4];
                Ground = GroundState[4];
                // Escribir los datos en el Archivo
                intro_datos = $"{Numero_Serie.TrimEnd()}, PASS_{Estado_Hipot}, PASS_{Continuidad}, PASS_{Ground}";
            }
            catch (Exception)
            {
                // Datos Obteneidos
                Numero_Serie = "ERROR DATA";
                Estado_Hipot = "ERROR DATA";
                Continuidad = "ERROR DATA";
                Ground = "ERROR DATA";
                // Escribir los datos en el Archivo
                intro_datos = $"{Numero_Serie.TrimEnd()}, 404_{Estado_Hipot}, 404_{Continuidad}, 404_{Ground}";
            }

            // Cerramos el archivo
            archivo_extraccion.Close();
            return intro_datos;
        }
    }
}
