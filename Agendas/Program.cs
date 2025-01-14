using Systekna.Scrum.Application;

class Program
{
    static void Main(string[] args)
    {
        AppSprint app = new AppSprint();
        string command = string.Empty;

        while (command != "exit")
        {
            Console.WriteLine("Digite um comando (addSprint/addTask/updateTask/removeTask/listTasks/progress/exit): ");
            command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "addsprint":
                    app.AddSprint();
                    break;
                case "addtask":
                    app.AddTask();
                    break;
                case "updatetask":
                    app.UpdateTask();
                    break;
                case "removetask":
                    app.RemoveTask();
                    break;
                case "listtasks":
                    app.ListTasks();
                    break;
                case "progress":
                    app.ShowProgress();
                    break;
                case "exit":
                    Console.WriteLine("Encerrando o sistema...");
                    break;
                default:
                    Console.WriteLine("Comando inválido. Tente novamente.");
                    break;
            }
        }
    }
}
