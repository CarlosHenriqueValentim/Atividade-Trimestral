using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento15Pacientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            int tamanho = 15, auxiliar = 0;

            Pacientes[] filaPacientes = new Pacientes[tamanho];

            while (true)
            {
                Console.Write("Menu Atendimento\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q\n\nEscolha:");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        if (auxiliar >= tamanho)
                        { Console.WriteLine("\n(Fila cheia.)\n"); break; }

                        Pacientes novoPaciente = new Pacientes();

                        novoPaciente.CadastrarPaciente();
                        novoPaciente.numeropaciente = auxiliar + 1;

                        int posicaoPreferencial = auxiliar;
                        for (int i = 0; i < auxiliar; i++)
                        {
                            if (novoPaciente.preferencial > filaPacientes[i].preferencial)
                            {
                                posicaoPreferencial = i; break;
                            }
                        }

                        for (int i = auxiliar; i > posicaoPreferencial; i--)
                        {
                            filaPacientes[i] = filaPacientes[i - 1];
                        }

                        filaPacientes[posicaoPreferencial] = novoPaciente;
                        auxiliar++;
                        Console.WriteLine("\n(Paciente Cadastrado)\n");
                        break;


                    case "2":

                        if (auxiliar <= 0)
                        { Console.WriteLine("\n(Nenhum paciente cadastrado)\n"); break; }

                        if (auxiliar < tamanho)
                            Console.WriteLine("\nLista de Pacientes\n");

                        for (int i = 0; i < auxiliar; i++)
                        { Console.Write(i + 1 + " - "); filaPacientes[i].MostrarDados(); }
                        break;


                    case "3":

                        if (auxiliar <= 0)
                        { Console.WriteLine("\n(Nenhum paciente na fila.)\n"); break; }

                        Console.WriteLine("\nAtendendo " + filaPacientes[0].nome);

                        for (int i = 0; i < auxiliar - 1; i++)
                        {
                            filaPacientes[i] = filaPacientes[i + 1];
                        }

                        filaPacientes[auxiliar - 1] = null;
                        auxiliar--;
                        break;

                    case "4":

                        Console.Write("\nDigite o número do paciente para alterar:");
                        int indicePaciente = int.Parse(Console.ReadLine()) - 1;

                        if (indicePaciente > auxiliar)
                        { Console.WriteLine("\n(Paciente não encontrado)\n"); break; }

                        Pacientes pacienteEditado = filaPacientes[indicePaciente];
                        pacienteEditado.CadastrarPaciente();

                        for (int i = indicePaciente; i < auxiliar - 1; i++)
                        {
                            filaPacientes[i] = filaPacientes[i + 1];
                        }
                        auxiliar--;

                        int novaPosicao = auxiliar;

                        for (int i = 0; i < auxiliar; i++)
                        {
                            if (filaPacientes[i].preferencial < pacienteEditado.preferencial)
                            {
                                novaPosicao = i; break;
                            }
                        }

                        for (int i = auxiliar; i > novaPosicao; i--)
                        {
                            filaPacientes[i] = filaPacientes[i - 1];
                        }

                        filaPacientes[novaPosicao] = pacienteEditado;
                        auxiliar++;
                        Console.WriteLine("\n(Dados alterados com sucesso)\n");
                        break;


                    case "Q":
                    case "q":
                        Console.WriteLine("\nSoftware Finalizado :)");
                        return;


                    default:
                        Console.WriteLine("\n(Opção incorreta, Digite as opções do Menu)\n");
                        break;
                }
            }
        }
    }
}
