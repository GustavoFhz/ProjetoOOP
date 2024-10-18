using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOOP
{
    internal class Crud : Padrao
    {
        public override void Alterar()
        {
            Console.WriteLine("Informe o nome do aluno que deseja alterar:");
            // Exibe a lista de alunos
            for (int i = 0; i < Armazenamento.Alunos.Count; i++) 
            {
                Console.WriteLine($"{i+1}) {Armazenamento.Alunos[i].Nome}");
            }
            string nome = Console.ReadLine();

            Aluno aluno = new();

            // Localizar o aluno pelo nome
            var alunoExistente = Armazenamento.Alunos.FirstOrDefault(aluno => aluno.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (alunoExistente != null)
            {
                // Obter o novo nome, nota1 e nota2
                Console.WriteLine("Informe o novo nome:");
                alunoExistente.Nome = Console.ReadLine();

                Console.WriteLine("Informe a nova nota 1:");
                alunoExistente.Nota1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a nova nota 2:");
                alunoExistente.Nota2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dados alterados com sucesso.");
            }
            else
            {
                Console.WriteLine($"Aluno com o nome {nome} não foi encontrado.");
            }

        }
        public override void Cadastrar()
        {
            Aluno aluno = new();

            Console.WriteLine("Informe o nome do aluno:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("informe a nota 1:");
            aluno.Nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a nota 2:");
            aluno.Nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aluno cadastrado com sucesso\n");

            Armazenamento.Alunos.Add(aluno);
        }
        public override void Selecionar()
        {
            
            for (int i = 0; i < Armazenamento.Alunos.Count; i++) 
            {
                Console.WriteLine($"Nome: {Armazenamento.Alunos[i].Nome}");
                Console.WriteLine($"Nota 1: {Armazenamento.Alunos[i].Nota1}");
                Console.WriteLine($"Nota 1: {Armazenamento.Alunos[i].Nota2}");
                Console.WriteLine($"Media: {Armazenamento.Alunos[i].Mensagem}");
                Console.WriteLine("");
            }
        }
        public override void Remover()
        {
            // Listar o índice e o nome das pessoas
            Console.WriteLine("Informe o nome da pessoa que deseja remover os dados");
            for (int i = 0; i < Armazenamento.Alunos.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Armazenamento.Alunos[i].Nome}");
            }
            string nome = Console.ReadLine();

            var aluno = Armazenamento.Alunos.FirstOrDefault(aluno => aluno.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (aluno != null)
            {
                Armazenamento.Alunos.Remove(aluno);
                Console.WriteLine($"{nome} foi removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Aluno com o nome {nome} não foi encontrado.");
            }

        }


    }
}
