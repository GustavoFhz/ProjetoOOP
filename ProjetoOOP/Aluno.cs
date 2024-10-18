using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOOP
{
    internal class Aluno
    {
        public string? Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        
        

        private double Media()
        {
            return (Nota1 + Nota2) / 2;
            
        }  

        private string Situacao(double media)
        {
            return media >= 7 ? "Aprovado" : "Reprovado";
        } 
        public void Mensagem()
        {
            double obterMedia = Media();
            string obterSituacao = Situacao(obterMedia);
            Console.WriteLine($"A média do aluno {Nome} foi de {obterMedia}, sendo assim ele ficou {obterSituacao}");
        }
        
    }
}
