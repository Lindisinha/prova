public class Funcionario
{
    public string nome { get; set; }
    public string cpf { get; set;}
    public string matricula { get; set;}
    public DateTime dataNasc { get; set;}
    public string sexo { get; set;}
    public double salario { get; set;}

    /*public Funcionario()
    {

    }
    public Funcionario(string nome, string cpf, string matricula, DateTime dataNasc, string sexo, double salario)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.matricula = matricula;
        this.dataNasc = dataNasc;
        this.sexo = sexo;
        this.salario = salario;

        /*Console.WriteLine("Digite o salario para cadastro:");
        salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Salario total: {fsalario}");
    }*/
}