using System.Runtime.CompilerServices;

public abstract class Processo
{
    public abstract string Title { get; }
}

public abstract class ProcessoDemissao : Processo
{
    public abstract void Apply(ArgsDemissao args);
}

public abstract class ProcessoPagamentoSalario : Processo
{
    public abstract void Apply(ArgsPagamentoSalario args);
}

public abstract class ProcessoContratacao : Processo
{
    public abstract void Apply(ArgsContratacao args);
}