public class ProcessoDemissaoArgentina : ProcessoDemissao
{
    public override string Title => "Despido de Empleados";

    public override void Apply(ArgsDemissao args)
        => args.Empresa.Dinheiro -= 3 * args.Empregado.Salario;
}

public class ProcessoPagamentoSalarioArgentina : ProcessoPagamentoSalario
{
    public override string Title => "Pagamento de Salarito";
    public override void Apply(ArgsPagamentoSalario args)
        => args.Empresa.Dinheiro -= 1.65m * args.Empregado.Salario + 700;
}

public class ProcessoContratacaoArgentina : ProcessoContratacao
{
    public override string Title => "Contratando Argentino";
    public override void Apply(ArgsContratacao args)
        => args.Empresa.Dinheiro -= 1.3m * args.Empregado.Salario + 600;
}

public class FabricaProcessoArgentina : IFabricaProcesso
{
    public ProcessoDemissao CriarProcessoDemissao()
        => new ProcessoDemissaoArgentina();

    public ProcessoPagamentoSalario CriarProcessoPagamentoSalario()
        => new ProcessoPagamentoSalarioArgentina();

    public ProcessoContratacao CriarProcessoContratacao()
        => new ProcessoContratacaoArgentina();
}