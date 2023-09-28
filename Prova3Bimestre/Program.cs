using Prova3Bimestre;
using System;
class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> listaFuncionario = new List<Funcionario>();
        List<Administrativo> listaAdministrativo = new List<Administrativo>();
        List<Medico> listaMedico = new List<Medico>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo!!");
            Console.WriteLine("\nQual o tipo do funcionario que você deseja cadastrar?\n1-Médico.\n2-Administração.\n3-Outro.\n4-imprimir funcionarios acima de 2000.\n\n5-Sair.");
            try
            {
                int opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao == 5) {break; }

                if (opcao == 4)
                {
                    Console.WriteLine("Medicos:");
                    foreach (Medico medico1 in listaMedico)
                    {
                        if (medico1.salario > 2000)
                        {
                            Console.WriteLine($"nome: {medico1.nome}");
                            Console.WriteLine($"salario: {(medico1.Salario).ToString("C2")}");
                        }
                    }
                    Console.WriteLine("Administração:");
                    foreach (Administrativo adm in listaAdministrativo)
                    {
                        if (adm.salario > 2000)
                        {
                            Console.WriteLine($"nome: {adm.nome}");
                            Console.WriteLine($"salario: {(adm.Salario).ToString("C2")}");
                        }
                    }
                    Console.WriteLine("Outros:");
                    foreach (Funcionario funcionario1 in listaFuncionario)
                    {
                        if (funcionario1.salario > 2000)
                        {
                            Console.WriteLine($"nome: {funcionario1.nome}");
                            Console.WriteLine($"salario: {(funcionario1.salario).ToString("C2")}");
                        }
                    }
                }
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite sua matricula: ");
                string matricula = Console.ReadLine();
                Console.WriteLine("Digite sua data de nascimento");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu sexo: ");
                string sexo = Console.ReadLine();
                

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o CRM: ");
                        string CRM = Console.ReadLine();
                        Console.WriteLine("Digite o valor a hora extra: ");
                        double horaExtra = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Especialidade: ");
                        string especialidade = Console.ReadLine();
                        Console.WriteLine("Digite seu salario: ");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Medico medico = new Medico(nome, cpf, matricula, dataNascimento, sexo, salario, CRM, horaExtra, especialidade);
                        medico.AuxilioPericulosidade();
                        listaMedico.Add(medico);
                        break;

                    
                    case 2:
                        Console.WriteLine("Digite seu salário: ");
                        double salario2 = Convert.ToDouble(Console.ReadLine());
                        Administrativo administrativo = new Administrativo(nome, cpf, matricula, dataNascimento, sexo, salario2);
                        administrativo.ValeAlimentacao();
                        administrativo.ValeTransporte();
                        listaAdministrativo.Add(administrativo);
                        break;

                    case 3:
                        Console.WriteLine("Digite seu salário: ");
                        double salario3 = Convert.ToDouble(Console.ReadLine());
                        Funcionario funcionario = new Funcionario(nome, cpf, matricula, dataNascimento, sexo, salario3);
                        listaFuncionario.Add(funcionario);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}