using TaskManager.Services;

class Program
{
    static void Main()
    {
        var service = new TaskService();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("==== GERENCIADOR DE TAREFAS ====");
            foreach (var task in service.GetAll())
            {
                Console.WriteLine(task);
            }

            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Alternar status");
            Console.WriteLine("3 - Remover tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Digite o título da tarefa: ");
                    var title = Console.ReadLine() ?? "";
                    service.Add(title);
                    break;
                case "2":
                    Console.Write("Digite o ID da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int toggleId))
                        service.Toggle(toggleId);
                    break;
                case "3":
                    Console.Write("Digite o ID da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int removeId))
                        service.Remove(removeId);
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
