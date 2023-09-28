using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Medico : Funcionario
    {
        public string CRM { get ; set; }
        public double HoraExtra { get; set; }
        public string Especialidade { get; set; }
        public double Salario { get; set; }

        public Medico(string nome, string cpf, string matricula, DateTime datanascimento, string sexo, double salario, string cRM, double horaExtra, string especialidade)
        : base(nome,cpf,matricula,datanascimento,sexo,salario)
        {
            CRM = cRM;
            HoraExtra = horaExtra;
            Especialidade = especialidade;
            Salario = salario;

        }

        public void AuxilioPericulosidade()
        {
            Salario = Salario + (Salario * 0.22);
        }
    }
}
