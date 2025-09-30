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
            Pacientes[] Paciente = new Pacientes[tamanho];
            while (true)
            { 
                Console.Write("Menu Atendimento\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q\n\nEscolha: ");
                escolher = Console.ReadLine();
                switch (escolher)
                {
                    case "1":
                        if (auxiliar < tamanho)
                        {
                            Pacientes NovoPaciente = new Pacientes();
                            NovoPaciente.CadastrarPaciente();
                            NovoPaciente.numeropaciente = auxiliar + 1;
                            if (NovoPaciente.preferencial >= 2)
                            {
                                for (int i = auxiliar; i > 0; i--)
                                {
                                    Paciente[i] = Paciente[i - 1];
                                }
                                Paciente[0] = NovoPaciente;
                            }
                            else
                            {
                                Paciente[auxiliar] = NovoPaciente;
                            }
                            auxiliar++;
                            Console.WriteLine("\nPaciente cadastrado com sucesso!\n");
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
                            for (int i = 0; i < auxiliar; i++)
                            {
                                Console.Write(i + 1 + " - ");
                                Paciente[i].MostrarDados();
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
                            Console.WriteLine("\nAtendendo" + Paciente[0].nome);
                            for (int i = 0; i < auxiliar - 1; i++)
                            {
                                Paciente[i] = Paciente[i + 1];
                            }
                            Paciente[auxiliar - 1] = null; auxiliar--;
                        }
                        break;
                    case "4":
                        Console.Write("\nDigite o número do paciente para alterar:\n");
                        int posição = int.Parse(Console.ReadLine()) - 1;
                        if (posição < auxiliar)
                        {
                            Paciente[posição].CadastrarPaciente();
                            Console.WriteLine("\nDados alterados com sucesso\n");
                        }
                        else
                        {
                            Console.WriteLine("\nPaciente não encontrado\n");
                        }
                        break;
                    case "Q":
                        Console.WriteLine("\nDepuração Finalizada\n");
                        return;
                    case "q":
                        Console.WriteLine("\nDepuração Finalizada\n");
                        return;
                    default:
                        Console.WriteLine("\nOpção incorreta, Digite outra Opção\n");
                        break;
                }
            }
        }
    }
}
