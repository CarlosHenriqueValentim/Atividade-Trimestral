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
            int tamanho = 15;   // Espaço Maximo de Pacientes
            int auxiliar = 0;   // Contador dos Pacientes
            Pacientes[] Indice = new Pacientes[tamanho];

            while (true)        // Loop Infinito Menu 
            {
                Console.Write("Menu Atendimento\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q\n\nEscolha:");
                escolher = Console.ReadLine();

                switch (escolher)
                {
                    case "1":    // Cadastrar Paciente
                        if (auxiliar < tamanho)
                        {
                            Pacientes NovoPaciente = new Pacientes();
                            NovoPaciente.CadastrarPaciente();
                            NovoPaciente.numeropaciente = auxiliar + 1;

                            if (NovoPaciente.preferencial >= 2)
                            {
                                for (int A = auxiliar; A > 0; A--)  
                                {
                                    Indice[A] = Indice[A - 1];
                                }
                                Indice[0] = NovoPaciente;   
                            }
                            else
                            {
                                Indice[auxiliar] = NovoPaciente;  
                            }

                            auxiliar++;
                            Console.WriteLine("\nPaciente Cadastrado\n");
                        }
                        else
                        {
                            Console.WriteLine("\nFila cheia.\n");
                        }
                        break;

                    case "2":   // Lista de Pacientes na fila
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
                                Indice[B].MostrarDados();
                            }
                        }
                        break;

                    case "3":    // Atender o Paciente 
                        if (auxiliar == 0)
                        {
                            Console.WriteLine("\nNenhum paciente na fila.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nAtendendo " + Indice[0].nome);
                            
                            for (int C = 0; C < auxiliar - 1; C++)
                            {
                                Indice[C] = Indice[C + 1];
                            }

                            Indice[auxiliar - 1] = null;
                            auxiliar--;
                        }
                        break;

                    case "4":   // Altera os dados do Paciente de acordo da Posição dele do indice 
                        Console.Write("\nDigite o número do paciente para alterar:");
                        int NumeroDoIndice = int.Parse(Console.ReadLine()) - 1;

                        if (NumeroDoIndice < auxiliar)
                        {
                            Indice[NumeroDoIndice].CadastrarPaciente();
                            Console.WriteLine("\nDados alterados com sucesso\n");
                        }
                        else
                        {
                            Console.WriteLine("\nPaciente não encontrado\n");
                        }
                        break;

                    case "Q":   // Sair com Q maiusculo 
                        Console.WriteLine("\nSoftware Finalizado");
                        return;
                    case "q":   // Sair com q minusculo
                        Console.WriteLine("\nSoftware Finalizado");
                        return;
                    default:    // Digitar qualquer tecla exceto 1,2,3,4,Q,q
                        Console.WriteLine("\nOpção incorreta, Digite outra Opção\n");
                        break;
                }
            }
        }
    }
}
