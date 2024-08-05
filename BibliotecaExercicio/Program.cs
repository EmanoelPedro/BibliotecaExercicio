
List<string> livros = new List<string>();

while(true)
{
    Console.WriteLine("[1] Adicionar livro a biblioteca");
    Console.WriteLine("[2] Remover livro da biblioteca");
    Console.WriteLine("[3] Ver todos os livros adicionados");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nDigite o nome do livro");
            string livro = Console.ReadLine();
            livros.Add(livro);
            break;
        case 2:
            Console.WriteLine("\nDigite o id no livro a ser removido");
            int livroId = Convert.ToInt32(Console.ReadLine());

            break;
        case 3:

            break;
        default:
            Console.WriteLine("\n Opção invalida");
            break;
    }
}