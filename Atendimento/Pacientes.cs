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
        public int numpaciente;
        public int idade;       
        public int preferencial;

        public void CadastrarPaciente()
        {
            Console.Write("Digite o Nome do Paciente: ");
            nome = Console.ReadLine();

            Console.Write("Digite a Idade do Paciente: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o nivel Preferencial do Paciente\n1 - Baixo\n2- Médio\n3 - Alto\n");
            preferencial = int.Parse(Console.ReadLine());
        }

        public void MostrarDados()
        {
            Console.WriteLine("{0}, {1} anos, Nivel Preferêncial: {2}", nome, idade, preferencial);
        }     
        public void Atendimento()
        {
            Console.WriteLine("Atendendo paciente {0}",nome);
        }     
    }
}
