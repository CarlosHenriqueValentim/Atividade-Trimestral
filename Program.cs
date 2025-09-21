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
            string escolher;
            int tamanho = 15;
            int auxilio = 0;
            Pacientes[] Paciente = new Pacientes[tamanho];

            
            {
                Console.WriteLine("Menu Atendimento\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q");
                Console.Write("\nEscolha: ");
                escolher = Console.ReadLine();

                switch (escolher)

                {
                    case "1":

                        if (auxilio < tamanho)

                        {
                            Pacientes Novo = new Pacientes();
                            Novo.CadastrarPaciente();
                            Novo.numpaciente = auxilio + 1;

                            if (Novo.preferencial >= 2)

                            {
                                for (int i = auxilio; i > 0; i--)
                                {
                                    Paciente[i] = Paciente[i - 1];
                                }
                                Paciente[0] = Novo;
                            }

                            else

                            {
                                Paciente[auxilio] = Novo;
                            }

                            auxilio++;
                            Console.WriteLine("Paciente cadastrado com sucesso!");
                        }

                        else

                        {
                            Console.WriteLine("Fila cheia.");
                        }                        
                        break;

                    case "2":
                        Console.WriteLine("\nLista de Pacientes");
                        if (auxilio == 0)

                        {
                            Console.WriteLine("Nenhum paciente cadastrado");
                        }
                        else

                        {
                            for (int i = 0; i < auxilio; i++)

                            {
                                Console.Write($"{i + 1} - ");
                                Paciente[i].MostrarDados();
                            }
                        }

                        break;

                    case "3":

                        if (auxilio == 0)

                        {
                            Console.WriteLine("Nenhum paciente na fila.");
                        }

                        else

                        {
                            Console.WriteLine($"Atendendo {Paciente[0].nome}");

                            for (int i = 0; i < auxilio - 1; i++)

                            {
                                Paciente[i] = Paciente[i + 1];
                            }

                            Paciente[auxilio - 1] = null; auxilio--;
                        }

                        break;

                    case "4":

                        Console.Write("Digite o número do paciente para alterar:");
                        int posição = int.Parse(Console.ReadLine()) - 1;
                        
                        if (posição < auxilio) 

                        {
                            Paciente[posição].CadastrarPaciente();
                            Console.WriteLine("Dados alterados com sucesso");
                        }

                        else

                        {
                            Console.WriteLine("Paciente não encontrado.");
                        }

                        break;

                    case "Q":

                        break;

                    default:

                        Console.WriteLine("Opção incorreta.");

                        break;
                }
            } 
        }
    }
}