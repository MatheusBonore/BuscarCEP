using BuscaCEP.Models;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BuscaCEP.Functions
{
    class Consultar
    {
        public static Endereco RetornarEndereco(double CEP)
        {
            Endereco endereco = new Endereco();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
            request.AllowAutoRedirect = false;

            HttpWebResponse verificarServidor;


            try
            {
                verificarServidor = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                Console.WriteLine(CEP);
                //MessageBox.Show("Servidor indisponível ou Requisição incorreta \n Detalhes: " + e.Status, "Erro ao consultar CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            using (Stream webStream = verificarServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    //MessageBox.Show("CEP não encontrado");
                                    return null;
                                }
                                endereco.CEP = valor[1];
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                endereco.Logradouro = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                endereco.Bairro = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                endereco.UF = valor[1];
                            }

                            cont++;
                        }
                    }
                }
            }

            return endereco;
        }
    }
}
