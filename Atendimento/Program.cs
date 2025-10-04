using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTEPACINETS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolher;
            int tamanho = 15, auxiliar = 0;

            Pacientes[] IndiceFila = new Pacientes[tamanho];

            while (true)
            {
                Console.Write("\nMenu Atendimento\n\nCadastrar - 1\nLista de Pacientes - 2 \nAtender - 3\nAlterar Dados - 4\nSair - Q\n\nEscolha:");
                escolher = Console.ReadLine();

                switch (escolher)
                {
                    case "1":

                        if (auxiliar >= tamanho)
                        {Console.WriteLine("\nFila cheia.\n"); break;}

                        Pacientes NovoPaciente = new Pacientes();

                        NovoPaciente.CadastrarPaciente();
                        NovoPaciente.numeropaciente = auxiliar + 1;

                        int FimdaFila = auxiliar;
                        for (int i = 0; i < auxiliar; i++)
                        {
                            if (NovoPaciente.preferencial > IndiceFila[i].preferencial)
                            { 
                             FimdaFila = i; break; 
                            }
                        }

                        for (int i = auxiliar; i > FimdaFila; i--)
                        {
                         IndiceFila[i] = IndiceFila[i - 1]; 
                        }

                        IndiceFila[FimdaFila] = NovoPaciente;
                        auxiliar++;
                        Console.WriteLine("\nPaciente Cadastrado\n");
                        break;


                    case "2":

                        if (auxiliar <= 0)
                        {Console.WriteLine("\nNenhum paciente cadastrado\n"); break;}

                        if (auxiliar < tamanho)
                        Console.WriteLine("\nLista de Pacientes\n");

                        for (int i = 0; i < auxiliar; i++)
                        {Console.Write(i + 1 + " - "); IndiceFila[i].MostrarDados();}
                        break;


                    case "3":

                        if (auxiliar <= 0)
                        {Console.WriteLine("\nNenhum paciente na fila.\n"); break;}

                        Console.WriteLine("\nAtendendo " + IndiceFila[0].nome);

                        for (int i = 0; i < auxiliar - 1; i++)
                        { 
                         IndiceFila[i] = IndiceFila[i + 1]; 
                        }

                        IndiceFila[auxiliar - 1] = null;
                        auxiliar--;
                        break;

                    case "4":

                        Console.Write("\nDigite o número do paciente para alterar:");
                        int NumeroDoIndice = int.Parse(Console.ReadLine()) - 1;

                        if (NumeroDoIndice >= auxiliar)
                        {Console.WriteLine("\nPaciente não encontrado\n"); break;}

                        Pacientes PacienteSelecionado = IndiceFila[NumeroDoIndice];
                        PacienteSelecionado.CadastrarPaciente();

                        for (int i = NumeroDoIndice; i < auxiliar - 1; i++)
                        { IndiceFila[i] = IndiceFila[i + 1]; }
                        auxiliar--;

                        int UltimoFila = auxiliar;

                        for (int i = 0; i < auxiliar; i++)
                        {
                            if (IndiceFila[i].preferencial < PacienteSelecionado.preferencial)
                            { 
                             UltimoFila = i; break; 
                            }
                        }

                        for (int i = auxiliar; i > UltimoFila; i--)
                        { 
                         IndiceFila[i] = IndiceFila[i - 1]; 
                        }

                        IndiceFila[UltimoFila] = PacienteSelecionado;
                        auxiliar++;
                        Console.WriteLine("\nDados alterados com sucesso\n");
                        break;


                    case "Q":

                    case "q":

                        Console.WriteLine("\nSoftware Finalizado");
                        return;


                    default:

                        Console.WriteLine("\nOpção incorreta, Digite as opções do Menu\n");
                        break;
                }
            }
        }
    }
}
