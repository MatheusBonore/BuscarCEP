using BuscaCEP.Models;
using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace BuscaCEP.Functions
{
    class Planilha
    {
        private static void FecharArquivo(ref ExcelPackage arquivoExcel)
        {
            arquivoExcel.Dispose();
        }

        private static void ApagarArquivoExistente(FileInfo PathFile)
        {
            if (File.Exists(PathFile.ToString()))
                File.Delete(PathFile.ToString());
        }

        private static void GravarArquivo(ref ExcelPackage arquivoExcel, ref ExcelWorksheet planilha, List<Endereco> enderecos)
        {
            // linhas e colunas das células começam no 1
            int linha = 1;
            int coluna = 1;

            planilha.Protection.IsProtected = false;
            planilha.Protection.AllowSelectLockedCells = false;

            // Escrevendo cabecalho tabela
            planilha.Cells[linha, coluna++].Value = "Logradouro";
            planilha.Cells[linha, coluna++].Value = "Bairro";
            planilha.Cells[linha, coluna++].Value = "UF";
            planilha.Cells[linha, coluna++].Value = "CEP";
            linha++;

            // Escrevendo tabela
            foreach (Endereco endereco in enderecos)
            {
                coluna = 1;
                planilha.Cells[linha, coluna++].Value = endereco.Logradouro;
                planilha.Cells[linha, coluna++].Value = endereco.Bairro;
                planilha.Cells[linha, coluna++].Value = endereco.UF;
                planilha.Cells[linha, coluna++].Value = Double.Parse(endereco.CEP);
                linha++;
            }

            arquivoExcel.Save();
        }

        public static void GerarArquivo(FileInfo PathFile, string SheetName, List<Endereco> enderecos)
        {
            ApagarArquivoExistente(PathFile);

            ExcelPackage arquivoExcel = new ExcelPackage(PathFile);
            ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets.Add(SheetName);

            GravarArquivo(ref arquivoExcel, ref planilha, enderecos);

            FecharArquivo(ref arquivoExcel);
        }
    
        public static void LerArquivo(FileInfo PathFile, List<CEP> ceps)
        {
            using (var excelWorkbook = new XLWorkbook(PathFile.ToString()))
            {
                var nonEmptyDataRows = excelWorkbook.Worksheet(1).RowsUsed();

                foreach (var dataRow in nonEmptyDataRows)
                {
                    if (dataRow.RowNumber() >= 2 && dataRow.RowNumber() <= 2)
                    {
                        ceps.Add(new CEP() { 
                            FaixaDeCEP = dataRow.Cell(1).Value.ToString(), 
                            CEPInicial = dataRow.Cell(2).Value.ToString(), 
                            CEPFinal = dataRow.Cell(3).Value.ToString()
                        });
                    }
                }
            }
        }
    }
}
