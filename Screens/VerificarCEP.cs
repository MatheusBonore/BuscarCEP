using BuscaCEP.Functions;
using BuscaCEP.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace BuscaCEP
{
    public partial class BuscarCEP : Form
    {
        public FileInfo PathFileCEPs;
        public FileInfo PathFileResultados;

        public BuscarCEP()
        {
            InitializeComponent();
        }

        private void btnProcurarListaCEP_Click(object sender, EventArgs e)
        {
            OpenFileDialog BrowserDialog = new OpenFileDialog();
            BrowserDialog.Filter = "Planilha (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";
            DialogResult locRes = BrowserDialog.ShowDialog();
            if (locRes == DialogResult.OK)
            {
                txtFileListaCEP.Text = BrowserDialog.FileName;
                PathFileCEPs = new FileInfo(@txtFileListaCEP.Text);
            }
        }

        private void btnProcurarPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowserDialog = new FolderBrowserDialog();
            DialogResult locRes = BrowserDialog.ShowDialog();
            if (locRes == DialogResult.OK)
            {
                txtFileResultados.Text = BrowserDialog.SelectedPath + "\\Resultados.xlsx";
                PathFileResultados = new FileInfo(@txtFileResultados.Text);
            }
        }

        private void VerificarCEP_Click(object sender, EventArgs e)
        {
            Endereco endereco = Consultar.RetornarEndereco(17512883);
            if (endereco != null)
            {
                Planilha.GravarArquivo(PathFileResultados, 1, 1, "Logradouro");
                Planilha.GravarArquivo(PathFileResultados, 1, 2, "Bairro");
                Planilha.GravarArquivo(PathFileResultados, 1, 3, "UF");
                Planilha.GravarArquivo(PathFileResultados, 1, 4, "CEP");

                Planilha.GravarArquivo(PathFileResultados, 2, 1, endereco.Logradouro);
                Planilha.GravarArquivo(PathFileResultados, 2, 2, endereco.Bairro);
                Planilha.GravarArquivo(PathFileResultados, 2, 3, endereco.UF);
                Planilha.GravarArquivo(PathFileResultados, 2, 4, endereco.CEP);

                MessageBox.Show("Terminou", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
