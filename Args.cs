public class ArgumentosProcessos
{
    private static ArgumentosProcessos empty = new ArgumentosProcessos();
    public static ArgumentosProcessos Empty => empty;
}
public class ArgsDemissao : ArgumentosProcessos
{
    public Empresa Empresa { get; set; }
    public Empregado Empregado { get; set; }
}

public class ArgsPagamentoSalario : ArgumentosProcessos
{
    public Empresa Empresa {get; set; }
    public Empregado Empregado {get; set; }
}

public class ArgsContratacao : ArgumentosProcessos
{
    public Empresa Empresa { get; set; }
    public Empregado Empregado { get; set; }
}