using System;
using System.Runtime.CompilerServices;

public class Prova
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();
        Medico m = new Medico();
        Adm a = new Adm();


        while (true)
        {
            Console.WriteLine("Que tipo de funcionario deseja cadastrar?");
            Console.WriteLine("1-Funcionario\n2-Medico\n3-Funcionario Adm");
            int opcao = Convert.ToInt32(Console.ReadLine());
            double porcento = 0;

            //Console.WriteLine("Deseja continuar cadastros? 1-Sim 2-Não");
            //int sair = Convert.ToInt32(Console.ReadLine());

            
                    switch (opcao)
                    {
                        case 1:

                            Console.WriteLine("Digite o nome para cadastro:");
                            f.nome = Console.ReadLine();
                            Console.WriteLine("Digite o cpf para cadastro:");
                            f.cpf = Console.ReadLine();
                            Console.WriteLine("Digite a matricula para cadastro:");
                            f.matricula = Console.ReadLine();
                            Console.WriteLine("Digite a data para cadastro:");
                            f.dataNasc = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o sexo do funcionario para cadastro:");
                            f.sexo = Console.ReadLine();
                            Console.WriteLine("Digite o salario para cadastro:");
                            f.salario = Convert.ToDouble(Console.ReadLine());
                            
                            Console.WriteLine($"Salario total: {f.salario}");

                            List<Funcionario> listaFuncionario = new List<Funcionario>();
                            listaFuncionario.Add(f);

                            break;


                        case 2:

                            Console.WriteLine("Digite o nome para cadastro:");
                            m.nome = Console.ReadLine();
                            Console.WriteLine("Digite o cpf para cadastro:");
                            m.cpf = Console.ReadLine();
                            Console.WriteLine("Digite a matricula para cadastro:");
                            m.matricula = Console.ReadLine();
                            Console.WriteLine("Digite a data para cadastro:");
                            m.dataNasc = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o sexo do funcionario para cadastro:");
                            m.sexo = Console.ReadLine();
                            Console.WriteLine("Digite o salario para cadastro:");
                            m.salario = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite o CMR deste funcionario:");
                            m.cmr = Console.ReadLine();
                            porcento = 0.22 * m.salario;
                           Console.WriteLine($"Salario total: {m.salario + porcento} (adiconais envolvidos: {porcento})");

                            List<Medico> listaMedico = new List<Medico>();
                            listaMedico.Add(m);

                            break;


                        case 3:

                            Console.WriteLine("Digite o nome para cadastro:");
                            a.nome = Console.ReadLine();
                            Console.WriteLine("Digite o cpf para cadastro:");
                            a.cpf = Console.ReadLine();
                            Console.WriteLine("Digite a matricula para cadastro:");
                            a.matricula = Console.ReadLine();
                            Console.WriteLine("Digite a data para cadastro:");
                            a.dataNasc = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o sexo do funcionario para cadastro:");
                            a.sexo = Console.ReadLine();
                            Console.WriteLine("Digite o salario para cadastro:");
                            a.salario = Convert.ToDouble(Console.ReadLine());
                            porcento = 0.17 * a.salario;
                            Console.WriteLine($"Salario total: {a.salario + porcento + 250} (adiconais envolvidos: {porcento + 250})");
                            List<Adm> listaAdm = new List<Adm>();
                            listaAdm.Add(a);

                            break;
                            Console.Clear();



                    }
                    break;

                
        }
        Console.ReadKey();
    }
}