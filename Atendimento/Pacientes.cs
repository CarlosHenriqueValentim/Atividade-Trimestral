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
        public int preferencial;

        public void CadastrarPaciente()
        {Console.Write("\nDigite o Nome do Paciente:");
         nome = Console.ReadLine();

         Console.Write("\nDigite o nivel Preferencial do Paciente\n\n1 - Baixo\n2- Médio\n3 - Alto\n\nEscolha:");
         preferencial = int.Parse(Console.ReadLine());}

        public void MostrarDados()
        {Console.WriteLine("{0} - Nivel Preferêncial: {1}", nome, preferencial);}

        public void Atendimento()
        {Console.WriteLine("Atendendo Paciente {0}", nome);}
    }
}
