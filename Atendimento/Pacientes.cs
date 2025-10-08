using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento15Pacientes
{
    class Pacientes
    {
        public string nome;
        public int numerodafila, preferencial;
        
        public void CadastrarPaciente()
        {
        Console.Write("\nDigite o Nome do Paciente:");
        nome = Console.ReadLine();

        Console.Write("\nDigite o nivel Preferencial do Paciente\n\n1 - Baixo\n2- Médio\n3 - Alto\n\nEscolha:");
        preferencial = int.Parse(Console.ReadLine());

        if (preferencial < 1 || preferencial > 3)
        {
        Console.WriteLine("\n(Opção inválida Digite novamente)");
        CadastrarPaciente();
        }

        }
        public void MostrarDados()
        {
            Console.WriteLine("{0} - Nivel Preferêncial: {1}\n", nome, preferencial);
        }
 
        public void Atendimento()
        {
            Console.WriteLine("\n(Atendendo o(a) Paciente {0})\n", nome);
        }
    }
}
