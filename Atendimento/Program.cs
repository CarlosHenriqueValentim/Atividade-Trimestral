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
            Pacientes[] TamanhodoPaciente = new Pacientes[tamanho];
            while (true) // Loop Infinito do Menu 
            {
                Console.Write("Menu Atendimento\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q\n\nEscolha: ");
                escolher = Console.ReadLine();
                switch (escolher)
                {
                    case "1": // Opcão Cadastrar Paciente
                        if (auxiliar < tamanho)
                        {
                            Pacientes NovoPaciente = new Pacientes();
                            NovoPaciente.CadastrarPaciente();
                            NovoPaciente.numeropaciente = auxiliar + 1;
                            if (NovoPaciente.preferencial >= 2)
                            {
                                for (int i = auxiliar; i > 0; i--)
                                {
                                    TamanhodoPaciente[i] = TamanhodoPaciente[i - 1];
                                }
                                TamanhodoPaciente[0] = NovoPaciente;
                            }
                            else
                            {
                                TamanhodoPaciente[auxiliar] = NovoPaciente;
                            }
                            auxiliar++;
                            Console.WriteLine("\nPaciente cadastrado!\n");
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
                                TamanhodoPaciente[i].MostrarDados();
                            }
                        }
                        break;
                    case "3": // Atender o Paciente do Array
                        if (auxiliar == 0)
                        {
                            Console.WriteLine("\nNenhum paciente na fila.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nAtendendo" + TamanhodoPaciente[0].nome);
                            for (int i = 0; i < auxiliar - 1; i++)
                            {
                                TamanhodoPaciente[i] = TamanhodoPaciente[i + 1];
                            }
                            TamanhodoPaciente[auxiliar - 1] = null; auxiliar--;
                        }
                        break;
                    case "4": // Aterar os Dados do Paciente de acordo da Posição dele pelo indice 
                        Console.Write("\nDigite o número do paciente para alterar:\n");
                        int posição = int.Parse(Console.ReadLine()) - 1;
                        if (posição < auxiliar)
                        {
                            TamanhodoPaciente[posição].CadastrarPaciente();
                            Console.WriteLine("\nDados alterados com sucesso\n");
                        }
                        else
                        {
                            Console.WriteLine("\nPaciente não encontrado\n");
                        }
                        break;
                    case "Q": // Sair com Q maiusculo 
                        Console.WriteLine("\nDepuração Finalizada\n");
                        return;
                    case "q": // Sair com q minusculo
                        Console.WriteLine("\nDepuração Finalizada\n");
                        return;
                    default: // digitar qualquer tecla exceto 1,2,3,4,Q,q
                        Console.WriteLine("\nOpção incorreta, Digite outra Opção\n");
                        break;
                }
            }
        }
    }
}
