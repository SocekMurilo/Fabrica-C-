public class ProcessoDemissaoArgelia : ProcessoDemissao
{
    public override string Title => "Demissão Slimani";

    public override void Apply(ArgsDemissao args)
        => args.Empresa.Dinheiro -= 5 * args.Empregado.Salario + 2000; 
}

public class ProcessoPagamentoSalarioArgelia : ProcessoPagamentoSalario
{
    public override string Title => "Pagando o Slimani";

    public override void Apply(ArgsPagamentoSalario args)
        => args.Empresa.Dinheiro -= 2.5m * args.Empregado.Salario + 40000;
}

public class ProcessoContratacaoArgelia : ProcessoContratacao
{
    public override string Title => "Contratando Slimani";

    public override void Apply(ArgsContratacao args)
        => args.Empresa.Dinheiro -= 3 * args.Empregado.Salario + 1000;
}

public class FabricaProcessoArgelia : IFabricaProcesso
{
    public ProcessoDemissao CriarProcessoDemissao()
        => new ProcessoDemissaoArgelia();

    public ProcessoPagamentoSalario CriarProcessoPagamentoSalario()
        => new ProcessoPagamentoSalarioArgelia();

    public ProcessoContratacao CriarProcessoContratacao()
        => new ProcessoContratacaoArgelia();
}