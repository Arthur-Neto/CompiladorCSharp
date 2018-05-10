using Compilador.Infra;
using Compilador.Infra.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador.WinApp
{
    public partial class FormPrincipal : Form
    {
        LexicalAnalyzer analisadorLexico;

        public FormPrincipal()
        {
            InitializeComponent();
            analisadorLexico = new LexicalAnalyzer();
        }

        private void buttonCompilar_Click(object sender, EventArgs e)
        {
            analisadorLexico.AnalyzeCode(textBoxCode.Text);
            dataGridViewTableSymbol.DataSource = TableSymbol.Table;
            dataGridViewTableTokens.DataSource = TableToken.Table;
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog arquivo = new OpenFileDialog();

            arquivo.InitialDirectory = "c:\\";
            arquivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            arquivo.FilterIndex = 2;
            arquivo.RestoreDirectory = true;

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = arquivo.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            textBoxCode.Text = File.ReadAllText(arquivo.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
