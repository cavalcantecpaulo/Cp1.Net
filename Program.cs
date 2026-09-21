using Checkpoint1Console;

public class Program
{
    public static void Main(string[] args) {
        
        Pessoa? pessoa = Pessoa.InserirDados();
        if (pessoa is null)
            return;

        pessoa.Value.ExibicaoCompleta();
    }
}

