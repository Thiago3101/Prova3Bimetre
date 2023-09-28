using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Administrativo : Funcionario
    {
        public double Salario { get; set; }
        public Administrativo(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario)
        :base(nome, cpf, matricula, dataNascimento, sexo, salario) 
        {
            Salario = salario;
        }

        public void ValeAlimentacao()
        {
            Salario = Salario + (Salario * 0.17);
        }
        public void ValeTransporte()
        {
            Salario = Salario + 250;
        }
    }
}
