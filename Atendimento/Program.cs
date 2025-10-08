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
            int tam = 15, aux = 0;

            Pacientes[] array = new Pacientes[tam];

            while (true)
            {
                Console.Write("Menu\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q\n\nEscolha:");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                if (aux >= tam)
                {Console.WriteLine("\n(Fila cheia.)\n"); break;}

                Pacientes novopaciente = new Pacientes();

                novopaciente.CadastrarPaciente();
                novopaciente.numerodafila = aux + 1;

                int posSegundaria = aux;

                for (int i = 0; i < aux; i++)
                        {
                            if (novopaciente.preferencial > array[i].preferencial)
                            {
                                posSegundaria = i; break;
                            }
                        }

                for (int i = aux; i > posSegundaria; i--)
                        {
                            array[i] = array[i - 1];
                        }

                array[posSegundaria] = novopaciente;
                aux++;
                Console.WriteLine("\n(Paciente Cadastrado)\n");
                break;


                    case "2":

                if (aux <= 0)

                {Console.WriteLine("\n(Nenhum paciente cadastrado)\n"); break;}

                if (aux < tam)

                Console.WriteLine("\nLista de Pacientes\n");

                for (int i = 0; i < aux; i++)
                {Console.Write(i + 1 + " - "); array[i].MostrarDados();}
                break;



                case "3":

                if (aux < 0)
                {
                    Console.WriteLine("\n(Nenhum paciente na fila.)\n"); break;
                }

                array[0].Atendimento();

                for (int i = 0; i < aux - 1; i++)

                   {
                    array[i] = array[i + 1];
                   }

                array[aux - 1] = null;
                aux--;
                break;


                    case "4":

                Console.Write("\nDigite o número do paciente para alterar:");
                int iP = int.Parse(Console.ReadLine()) - 1;

                if (iP >= aux)
                {
                 Console.WriteLine("\n(Paciente não encontrado)\n"); break;
                }

                if (iP < aux)
                {
                 Pacientes pE = array[iP];
                 pE.CadastrarPaciente();

                for (int i = iP; i < aux - 1; i++)
                      {
                       array[i] = array[i + 1];
                      }
                      aux--;

                      int novaPosi = aux;

                for (int i = 0; i < aux; i++)
                      {
                       if (array[i].preferencial <= pE.preferencial)
                          {
                           novaPosi = i; break;
                          }
                      }

                for (int i = aux; i > novaPosi; i--)
                      {
                       array[i] = array[i - 1];
                      }

                    array[novaPosi] = pE;
                    aux++;
                    Console.WriteLine("\n(Dados alterados com sucesso)\n");
                }
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
