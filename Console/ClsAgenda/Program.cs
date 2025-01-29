using Scrum.Application.Interfaces;
using Scrum.Core;
using Systekna.Agenda.One;
using Systekna.Scrum.Application;
using Systekna.Scrum.Code;
using System;

namespace Systekna.Scrum;

public class Program
{
    public static void AgendaMain()
    {
        Agenda.One.Agenda agenda = new Agenda.One.Agenda();
        ConsoleAgenda.Build(agenda);
    }

    public static void Main()
    {
        IBbScrum scrum = new BbScrum();
        IBbSprint sprint = new BbSprint();

        {
            scrum.Add(new Epicos(0, "Entrada do Projeto", "Entrada de novo projeto na fila.", ItemStatus.Done)); //  sprint:1
            scrum.Add(new Epicos(1, "Criação do Banco de dados", "Criação de nova base de dados.", ItemStatus.Done)); //  sprint:2
            scrum.Add(new Epicos(2, "Acesso do usuario na base", "Permissão de acesso na base de dados.", ItemStatus.Done)); //  sprint:2
            scrum.Add(new Epicos(3, "Criaçao do repositorio", "Criação do Repositório no AzureDevOps ou Github.", ItemStatus.Done)); //  sprint:2
        } // 00-03 Criação de Tarefas

        #region Scrum de desenvolvimento

        {
            scrum.Add(new Epicos(4, "Funcionalidade de Baixa Definiva", "Desenvolver funcionalidade de 'Baixa Definiva'.", ItemStatus.ToDo)); //  sprint:3
            scrum.ClearTask(4);
            scrum.AddTask(4, new ToDo(0, "Importação Garantias Excel", "Importação de arquivo de Garantias de Baixa para envio OCFO."));
            scrum.AddTask(4, new ToDo(1, "Consulta Baixas OCFO", "Consulta Baixas no OCFO para validação"));
            scrum.AddTask(4, new ToDo(2, "Envio OCFO Baixa", "Envia 'Baixa gravame' para fila de envio de baixa OCFO."));
            scrum.AddTask(4, new ToDo(3, "Envio OCFO Cancelamento", "Envia 'Baixa gravame' para fila de envio de cancelamento OCFO."));
            scrum.AddTask(4, new ToDo(4, "Criação Tela Baixa Definitiva", "Criação da tela de 'Baixa Definitiva'"));
        } // 04 [epico] Funcionalidade 'Baixa definitiva'

        {
            scrum.Add(new Epicos(5, "Criação procedure de 'LEITURA OCFO'", "Criação procedure de Leitura OCFO.", ItemStatus.ToDo)); //  sprint:3
            scrum.ClearTask(5);
            scrum.AddTask(5, new ToDo(0, "Envio Consulta de Baixa", "Envia Contratos para 'consulta' de Baixa OCFO."));
            scrum.AddTask(5, new ToDo(1, "Envio Consulta de Inclusão", "Envia Contratos para 'consulta' de Inclusão OCFO."));
            scrum.AddTask(5, new ToDo(2, "Envio 'Garantia' para Baixa", "Envia 'Contrato' para 'BAIXA' OCFO."));
            scrum.AddTask(5, new ToDo(3, "Envio 'Garantia' para Cancelamento", "Envia 'Contrato' para Cancelamento OCFO."));
            scrum.AddTask(5, new ToDo(4, "Envio 'Garantia' para Inclusão", "Envia 'Contrato' para Inclusão OCFO."));
        } // 05 [epico] Criação procedure de LEITURA OCFO

        {
            scrum.Add(new Epicos(6, "Funcionalidade de Baixa Temporaria", "Desenvolver funcionalidade de Baixa Temporaria.", ItemStatus.ToDo)); //  sprint:3
            scrum.ClearTask(6);
            scrum.AddTask(6, new ToDo(0, "Importação Garantias Excel", "Importação de arquivo de Garantias de Baixa para envio OCFO."));
            scrum.AddTask(6, new ToDo(1, "Consulta Baixas OCFO", "Consulta Baixas no OCFO para validação"));
            scrum.AddTask(6, new ToDo(2, "Envio OCFO Baixa", "Envia 'Baixa gravame' para fila de envio de baixa OCFO."));
            scrum.AddTask(6, new ToDo(3, "Envio OCFO Cancelamento", "Envia 'Baixa gravame' para fila de envio de cancelamento OCFO."));
            scrum.AddTask(6, new ToDo(4, "Criação Tela Baixa Temporaria", "Criação da tela de 'Baixa Temporaria'"));
        } // 06 [epico] Funcionalidade 'Baixa temporaria'

        {
            scrum.Add(new Epicos(7, "Funcionalidade de Inclusão de Baixa", "Funcionalidade de Inclusão de Baixa.", ItemStatus.ToDo)); //  sprint:3
                                                                                                                                      //scrum.AddTask(6, new ToDo(0, "Funcionalidade de Inclusão de Baixa", ""));
        } // 07 [epico] Funcionalidade de 'Inclusão de Baixa'

        {
            scrum.Add(new Epicos(8, "Funcionalidade de Pendencias de Baixa", "Funcionalidade de Pendencias de Baixa.", ItemStatus.ToDo)); //  sprint:3
            //scrum.AddTask(7, new ToDo(0, "Funcionalidade de Pendencias de Baixa", ""));
        } // 08 [epico] Funcionalidade de 'Pendencias de Baixa'

        {
            scrum.Add(new Epicos(8, "Funcionalidade de Relatório Geral", "Funcionalidade de Relatório Geral.", ItemStatus.ToDo)); //  sprint:3
            scrum.ClearTask(8);
            scrum.AddTask(8, new ToDo(0, "Relatório Geral", "Consulta Relatório Geral."));
            scrum.AddTask(8, new ToDo(1, "Relatório Geral", "Exportação para o Excel do relatório."));
        } // 09 [epico] Relatorio Geral

        {
            scrum.Add(new Epicos(10, "Homologação do Projeto", "Homologação do projeto.", ItemStatus.ToDo)); //  sprint:4
            scrum.ClearTask(10);
            scrum.AddTask(10, new ToDo(0, "Tela Baixa Definiva", "testa do pelo usuario: Tela Baixa Definiva"));
            scrum.AddTask(10, new ToDo(1, "Tela Baixa Temporaria", "testa do pelo usuario: Tela Baixa Temporaria"));
            scrum.AddTask(10, new ToDo(2, "Tela Inclusão de Baixa", "testa do pelo usuario: Tela Inclusão de Baixa"));
            scrum.AddTask(10, new ToDo(3, "Tela Pendencias de Baixa", "testa do pelo usuario: Tela Pendencias de Baixa"));
            scrum.AddTask(10, new ToDo(4, "Tela Relatório Geral", "testa do pelo usuario: Tela Relatório Geral"));
        } // 10 [epico] Homologação do Projeto

        #endregion

        #region Criação de Sprints

        {
            sprint.Add(
                new Sprint(0, "Entrada do Projeto", "Entrada de novo projeto na fila.", DateTime.Now.AddDays(6), 1)
                .Add(scrum.GetByID(0))
                );
            sprint.Add(new Sprint(1, "Entrada do Projeto", "Permissões de Acesso e criação da base.", DateTime.Now.AddDays(6), 9)
                .Add(scrum.GetByID(1))
                .Add(scrum.GetByID(2))
                .Add(scrum.GetByID(3))
                );
        } // Sprints de 'Entrada do Projeto'

        {
            // Abertura de Sprint (janela)
            sprint.Add(

                new Sprint(2,
                "Desenvolvimento 'Baixa Definitiva e Temporaria'",
                "Desenvolvimento das Funcionalidades de 'Baixa Definitiva e Temporaria'.",
                DateTime.Now.AddDays(6),
                2
                )
                .Add(scrum.GetByID(4)) // criação do epico agregado...
                .Add(scrum.GetByID(6)) // criação do epico agregado...
            );

            sprint.Add(
                new Sprint(4, "PROCEDURE LEITURA OCFO", "Desenvolvimento da procedure 'LEITURA OCFO'.", DateTime.Now, 15)
                .Add(scrum.GetByID(5))
                );

            sprint.Add(new Sprint(5, "PROCEDURE RETORNO CONSULTA OCFO", "Desenvolvimento da procedure 'RETORNO DE CONSULTA (baixa, inclusão) OCFO'.", DateTime.Now, 15));
            sprint.Add(new Sprint(6, "PROCEDURE RETORNO ENVIO OCFO", "Desenvolvimento da procedure 'RETORNO DE ENVIO(baixa, cancelamento e inclusão) OCFO'.", DateTime.Now, 15));

            sprint.Add(
                new Sprint(7, "Funcionalidade 'Fila de Inclusão'", "Desenvolvimento da Funcionalidade de 'Fila de Inclusão'.", DateTime.Now, 15)
                .Add(scrum.GetByID(7)));

            sprint.Add(
                new Sprint(8, "Funcionalidade 'Fila de Pendencias'", "Desenvolvimento da Funcionalidade de 'Fila de Pendencias de baixa e inclusão'.", DateTime.Now, 15)
                .Add(scrum.GetByID(8))
                );

        } // Sprints de 'Desenvolvimento do projeto...'

        // Sprint de Homologação.
        sprint.Add(new Sprint(9, "Homologação do Projeto", "Homologação do projeto.", DateTime.Now, 15).Add(scrum.GetByID(10)));

        #endregion

        {
            var result1 = scrum.GetAll();
            var result2 = sprint.GetAll();

            Console.WriteLine("\t=================================================================");
            Console.WriteLine("\t\t # SCRUM DO PROJETO");
            Console.WriteLine("\t=================================================================");
            Console.WriteLine();

            ViewBlockLog(result1);

            ViewSprints(result2);

            foreach (var i in result2)
            {
                if (i.Epicos.Where(x => x.Status != ItemStatus.Done).ToList().Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tSprint [{i.ID}] - {i.Title}");
                    Console.WriteLine($"\t * {i.Description}");
                    Console.WriteLine();
                    Console.WriteLine($"\tData Inicial: {i.StartDate}");
                    Console.WriteLine($"\tData Final: {i.EndDate}");
                    Console.WriteLine();
                    Console.WriteLine("\t******************************************************************");
                    foreach (var j in i.Epicos)
                    {
                        if (j.Status != ItemStatus.Done)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"\t[EPICO] {j.Description}");
                            Console.WriteLine();
                            if (j.Tasks.Count > 1)
                            {
                                foreach (var k in j.Tasks)
                                {
                                    Console.WriteLine($"\t - {k.Description}");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    Console.WriteLine("\t******************************************************************");
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }

            ViewBlockLog(result1);

        } // Exibição na Tela
    }

    private static void ViewSprints(IEnumerable<Sprint> result2)
    {
        Console.WriteLine();
        Console.WriteLine("\t=================================================================");
        Console.WriteLine("\t SPRINTS DO PROJETO");
        Console.WriteLine("\t=================================================================");
        Console.WriteLine();
        foreach (var i in result2)
        {
            if (i.Epicos.Where(x => x.Status != ItemStatus.Done).ToList().Count > 0)
            {
                Console.WriteLine($"\tSprint [{i.ID}] - {i.Title} [Data de Entrega: {i.EndDate}]");
                Console.WriteLine($"\t * {i.Description}");
                Console.WriteLine();
            }
        }
        Console.WriteLine("\t=================================================================");
        Console.WriteLine();
        Console.ReadKey();
    }

    private static void ViewBlockLog(IEnumerable<Epicos> result1)
    {
        Console.WriteLine("\t================================================================= ");
        Console.WriteLine($"\t\tBLOCKLOG [Hoje: {DateTime.Now}]");
        Console.WriteLine("\t=================================================================");
        Console.WriteLine("");
        foreach (var i in result1)
        {
            if (i.Status == ItemStatus.Done)
                Console.WriteLine($"\t X {i.Description}");
            else if (i.Status != ItemStatus.Done)
                Console.WriteLine($"\t - {i.Description}");
        }
        Console.WriteLine("");
        Console.WriteLine("\t=================================================================");
        Console.WriteLine("");
    }
}