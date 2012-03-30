using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exerAulaLPC
{
    public partial class formularioPrincial : Form
    {
        public formularioPrincial()
        {
            InitializeComponent();
        }

        private void formularioPrincial_Load(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows/System32/Calc.exe");
        }

        private void utilitáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }  

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows/System32/notepad.exe");
        }

        private void googleChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users/Ramon Alves/AppData/Local/Google/Chrome/Application/chrome.exe");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formulárioPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Alves, Ramon - Exercício LPC 23/03/2012", "Sobre");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoFormularioPrincipal newNovoFormularioPrincipal = new novoFormularioPrincipal();
            newNovoFormularioPrincipal.ShowDialog();
        }
        }
    }
