using ProjetoOOP;

int acao;

Crud crud = new();

do
{
    Console.WriteLine("1º Cadastrar");
    Console.WriteLine("2º Selecionar");
    Console.WriteLine("3º Alterar");
    Console.WriteLine("4º Remover");
    Console.WriteLine("5º Finalizar");
    acao = Convert.ToInt32(Console.ReadLine());

    switch (acao)
    {
        case 1: crud.Cadastrar(); break;
        case 2: crud.Selecionar(); break;
        case 3: crud.Alterar(); break;
        case 4: crud.Remover(); break;
        case 5: Console.WriteLine("Finalizando sistema"); Environment.Exit(0); break;
        default: Console.WriteLine("Opção inválida"); break;
    }
}
while (acao !=5);