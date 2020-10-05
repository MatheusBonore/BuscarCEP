using BuscaCEP.Functions;
using BuscaCEP.Models;
using System;
using System.Collections.Generic;
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
            if (txtFileListaCEP.Text.Length != 0)
            {
                if (txtFileResultados.Text.Length != 0)
                {
                    List<CEP> ceps = new List<CEP>();
                    List<Endereco> enderecos = new List<Endereco>();
                    Endereco endereco = new Endereco();

                    Planilha.LerArquivo(PathFileCEPs, ceps);

                    foreach (CEP cep in ceps)
                    {
                        for (double NumeroCEP = Double.Parse(cep.CEPInicial); NumeroCEP <= Double.Parse(cep.CEPFinal); NumeroCEP++)
                        {
                            //Endereco endereco = Consultar.RetornarEndereco(NumeroCEP);

                            endereco.Bairro = "Bairro";
                            endereco.CEP = NumeroCEP.ToString();
                            endereco.Logradouro = "Logradouro";
                            endereco.UF = "UF";

                            if (endereco != null)
                                enderecos.Add(endereco);
                        }
                    }

                    Planilha.GerarArquivo(PathFileResultados, "Sheet1", enderecos);

                    ceps.Clear();
                    enderecos.Clear();

                    MessageBox.Show("Terminou", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Primeiro selecione o caminho que será salvo os Resultados", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primeiro selecione a planilha com o CEPs", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
