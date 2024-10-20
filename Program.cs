using c_.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial;
decimal precoPorHora;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento c = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
Console.Clear();
Console.WriteLine("Sistema de Estacionamento");
Console.WriteLine("Digite sua opção: ");
Console.WriteLine("1 - Cadastrar Veículo");
Console.WriteLine("2 - Remover Veículo");
Console.WriteLine("3 - Listar Veículos");
Console.WriteLine("4 - Encerrar");

opcao = Console.ReadLine();

switch(opcao){
    case "1": 
    Console.Clear();
    c.Adicionar();
    break;

    case "2": 
        Console.Clear();
    c.Remover();
    break;

    case "3": 
        Console.Clear();
    c.Listar();
    break;

    case "4": 
    Console.Clear();
    exibirMenu = false;
    Console.WriteLine("Encerrando sistema...");
    Environment.Exit(0);
    break;

    default:
    Console.WriteLine("Opção inválida! Tente novamente");
    break;
}

Console.WriteLine("Pressione uma tecla para continuar: ");
Console.ReadLine();

}



