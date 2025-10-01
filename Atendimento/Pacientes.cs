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
        public int numeropaciente;
        public int idade;
        public int preferencial;

        public void CadastrarPaciente()
        {
            Console.Write("\nDigite o Nome do Paciente:");
            nome = Console.ReadLine();

            Console.Write("\nDigite a Idade do Paciente:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o nivel Preferencial do Paciente\n1 - Baixo\n2- Médio\n3 - Alto");
            preferencial = int.Parse(Console.ReadLine());
        }

        public void MostrarDados()
        {
            Console.WriteLine("{0}, {1} anos, Nivel Preferêncial: {2}", nome, idade, preferencial);
        }

        public void Atendimento()

        {
            Console.WriteLine("Atendendo Paciente {0}", nome);
        }

    }
}
