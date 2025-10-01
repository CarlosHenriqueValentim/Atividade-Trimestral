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
            int auxiliar = 0;
            Pacientes[] IndiceFila = new Pacientes[tamanho];

            while (true)
            {
                Console.Write("Menu Atendimento\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q\n\nEscolha:");
                escolher = Console.ReadLine();

                switch (escolher)
                {
                    case "1":
                        if (auxiliar < tamanho)
                        {
                            Pacientes NovoPaciente = new Pacientes();
                            NovoPaciente.CadastrarPaciente();
                            NovoPaciente.numeropaciente = auxiliar + 1;

                            int PosiçãodoIndice = auxiliar; 

                            for (int A = 0; A < auxiliar; A++)
                            {
                                if (IndiceFila[A].preferencial < NovoPaciente.preferencial)
                                {
                                    PosiçãodoIndice = A;
                                    break;
                                }
                            }

                            for (int A = auxiliar; A > PosiçãodoIndice; A--)
                            {
                                IndiceFila[A] = IndiceFila[A - 1];
                            }

                            IndiceFila[PosiçãodoIndice] = NovoPaciente;

                            auxiliar++;
                            Console.WriteLine("\nPaciente Cadastrado\n");
                        }
                        else
                        {
                            Console.WriteLine("\nFila cheia.\n");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nLista de Pacientes");
                        if (auxiliar == 0)
                        {
                            Console.WriteLine("\nNenhum paciente cadastrado\n");
                        }
                        else
                        {
                            for (int B = 0; B < auxiliar; B++)
                            {
                                Console.Write(B + 1 + " - ");
                                IndiceFila[B].MostrarDados();
                            }
                        }
                        break;

                    case "3":
                        if (auxiliar == 0)
                        {
                            Console.WriteLine("\nNenhum paciente na fila.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nAtendendo " + IndiceFila[0].nome);

                            for (int C = 0; C < auxiliar - 1; C++)
                            {
                                IndiceFila[C] = IndiceFila[C + 1];
                            }

                            IndiceFila[auxiliar - 1] = null;
                            auxiliar--;
                        }
                        break;

                    case "4":
                        Console.Write("\nDigite o número do paciente para alterar:");
                        int NumeroDoIndice = int.Parse(Console.ReadLine()) - 1;

                        if (NumeroDoIndice >= 0)
                        {
                            if (NumeroDoIndice < auxiliar)
                            {
                                Pacientes PacienteAlterado = IndiceFila[NumeroDoIndice];
                                PacienteAlterado.CadastrarPaciente();

                                for (int i = NumeroDoIndice; i < auxiliar - 1; i++)
                                {
                                    IndiceFila[i] = IndiceFila[i + 1];
                                }

                                IndiceFila[auxiliar - 1] = null;
                                auxiliar--;

                                int posicao = auxiliar;

                                for (int i = 0; i < auxiliar; i++)
                                {
                                    if (IndiceFila[i].preferencial < PacienteAlterado.preferencial)
                                    {
                                        posicao = i;
                                        break;
                                    }
                                }

                                for (int i = auxiliar; i > posicao; i--)
                                {
                                    IndiceFila[i] = IndiceFila[i - 1];
                                }

                                IndiceFila[posicao] = PacienteAlterado;
                                auxiliar++;

                                Console.WriteLine("\nDados alterados com sucesso\n");
                            }
                            else
                            { Console.WriteLine("\nPaciente não encontrado\n"); }
                        }
                        break;
                    case "Q":
                        Console.WriteLine("\nSoftware Finalizado");
                        return;
                    case "q":
                        Console.WriteLine("\nSoftware Finalizado");
                        return;
                    default:
                        Console.WriteLine("\nOpção incorreta, Digite outra Opção\n");
                        break;
                }
            }
        }
    }
}
