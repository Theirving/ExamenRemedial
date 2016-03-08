using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenRemedial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Archivo A1 = new Archivo();

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.Guardar(richTextBox1);

            abrir2ArchivoToolStripMenuItem.Enabled = false;
            abrir3ArchivoToolStripMenuItem.Enabled = false;
            combinar2ArchivosToolStripMenuItem.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.Abrir(richTextBox2);
            abrir2ArchivoToolStripMenuItem.Enabled = true;
            abrir3ArchivoToolStripMenuItem.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;
            combinar2ArchivosToolStripMenuItem.Enabled = true;
           
           
            
        }

        private void combinar2ArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.CombinarArchivos(richTextBox2, richTextBox3);
            abrir2ArchivoToolStripMenuItem.Enabled = false;
            abrir3ArchivoToolStripMenuItem.Enabled = true;
            guardarToolStripMenuItem.Enabled = false;
            abrirToolStripMenuItem.Enabled = false;
         
            
        }

        private void abrirOtroArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.Abrir(richTextBox3);
           
        }

        private void abrirArchivoCombinadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.Abrir(richTextBox4);
            abrir2ArchivoToolStripMenuItem.Enabled = false;
            abrir3ArchivoToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            combinar2ArchivosToolStripMenuItem.Enabled = false;
        }

        private void abrir2ArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.Abrir(richTextBox3);
            combinar2ArchivosToolStripMenuItem.Enabled = true;
            abrir3ArchivoToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
        }

        private void abrir3ArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.Abrir(richTextBox4);
            abrir2ArchivoToolStripMenuItem.Enabled = false;
            abrir3ArchivoToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            combinar2ArchivosToolStripMenuItem.Enabled = false;
        }

    }
}
