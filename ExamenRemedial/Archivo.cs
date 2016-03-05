using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace ExamenRemedial
{
    class Archivo
    {
        public string ar1 { set; get; }
        public string ar2 { set; get; }

        

        public void Guardar(RichTextBox R1) {

            SaveFileDialog SF = new SaveFileDialog();

            // guarda el archivo de texto con la extension .txt
            SF.Filter = " text |*.txt";


             // cambia el rotulo de la interfaz cuando se salva el archivo
            SF.Title = "Archivo";

            
            // en la condicional se agregara el texto que se ingrese en el RichTexbox 


            if (SF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                using (var savef = new System.IO.StreamWriter(SF.FileName + ".txt"))

                { savef.Write(R1.Text); }

            }


            R1.Clear();
            MessageBox.Show("Archivo Guardado");
        
        
        
        }

        public void Abrir(RichTextBox R2) {

            OpenFileDialog OPn = new OpenFileDialog();

           
            R2.Text = "Contenido de Archivo ";
            OpenFileDialog openfle1 = new OpenFileDialog();
            
            OPn.Title = "Abrir Archivo";

            //Fitro para archivos con extension txt
            openfle1.Filter = "Texto|*.txt";

            if (openfle1.ShowDialog() == DialogResult.OK)
            {
                var archivo = openfle1.FileName;
                using (StreamReader leer = new StreamReader(archivo))
                { R2.Text = leer.ReadToEnd(); }
            }
        
        
        
        }

        public void CombinarArchivos(RichTextBox R3, RichTextBox R4) {

            SaveFileDialog SF = new SaveFileDialog();

            
            SF.Filter = " text |*.txt";


          
            SF.Title = "Archivo";


           

            if (SF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                using (var savef = new System.IO.StreamWriter(SF.FileName + ".txt"))

                { savef.Write(R3.Text);
                savef.Write(R4.Text);
                
                }

            }


           
            MessageBox.Show("Archivo Guardado");
           
        
        }
    

    
    }// fin de clase
}// fin de namespace
