using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento15Pacientes
{
    internal class Pacientes
    {
        public string nome;
        public int numpaciente;
        public int idade;       
        public int preferencial;

        public void CadastrarPaciente()
        {
            Console.Write("Digite o Nome do Paciente: ");
            nome = Console.ReadLine();

            Console.Write("Digite a Idade do Paciente: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o nivel Preferencial do Paciente\n0 - Baixo\n1- Médio\n2 - Alto\n3 - Muito Alto\n");
            preferencial = int.Parse(Console.ReadLine());
        }

        public void MostrarDados()
        {
            string[] niveis = { "Baixo", "Médio", "Alto", "Muito Alto" };
            Console.WriteLine("{0}, {1} anos, Preferência: {2}", nome, idade, preferencial);
        }     
        public void Atendimento()
        {
            Console.WriteLine("Atendendo paciente {0}",nome);
        }     
    }
}
