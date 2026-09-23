namespace Checkpoint1Console;

public struct Pessoa
{
    public string Nome { get; init; } = string.Empty;
    public DateOnly DataNascimento { get; init; }

    public Pessoa(string nome, DateOnly dataNascimento)
    {
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
    }

    private int CalcularIdade()
    {
        DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
        var anoNascimento = DataNascimento.Year;
        var anoAtual = hoje.Year;

        //Anos completos, ainda precisa validar se já fez aniversário esse ano
        if (DataNascimento > hoje)
        {
            Console.WriteLine("Data inválida, dia futuro.");
            return 0;
        }
            
        var idade = anoAtual - anoNascimento;

        var dataReferencia = DataNascimento.AddYears(idade);
        
        //Se já fez aniversário esse ano:
        if (dataReferencia <= hoje)
            return idade;

        //Senão, reduz 1 no valor.
        return idade - 1;
    }

    private string MaiorIdade()
    {
        var idade = CalcularIdade();

        if (idade >= 18)
            return "Maior de Idade, pode iniciar o processo para tirar a CNH.";

        return "Menor de Idade, não pode tirar a CNH!";
    }

    public static Pessoa? InserirDados()
    {
        Console.WriteLine("Insira o nome completo: ");
        var nome = Console.ReadLine();

        Console.WriteLine("Insira a data de nascimento: (dd/MM/yyyy)");
        var data = Console.ReadLine();

        if(DateOnly.TryParse(data, out DateOnly dataCorreta))
        {
            if (dataCorreta > DateOnly.FromDateTime(DateTime.Now))
            {
                Console.WriteLine("Data inválida");
                return null;
            }
           if(nome is not null)
                return new Pessoa(nome, dataCorreta);

           return null;     
        }
        Console.WriteLine("Não foi possível converter data.");
        return null;
    }

    private void ExibirPessoa()
    {
        Console.WriteLine("\n\n" + Nome + ", data de nascimento: " + DataNascimento.ToString());
    }

    public void ExibicaoCompleta()
    {
        ExibirPessoa();

        Console.WriteLine("Idade: " + CalcularIdade() + " anos");
        Console.WriteLine(MaiorIdade());
    }
}
