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
        }

        private void buttonCompilar_Click(object sender, EventArgs e)
        {
            analisadorLexico = new LexicalAnalyzer();
            analisadorLexico.AnalyzeCode(textBoxCode.Text);
            ClearGrids();
        }

        private void ClearGrids()
        {
            dataGridViewTableSymbol.DataSource = null;
            dataGridViewTableTokens.DataSource = null;
            dataGridViewTableSymbol.Rows.Clear();
            dataGridViewTableTokens.Rows.Clear();
            dataGridViewTableSymbol.DataSource = TableSymbol.Table;
            dataGridViewTableTokens.DataSource = TableToken.Table;
            dataGridViewTableSymbol.Refresh();
            dataGridViewTableTokens.Refresh();
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
