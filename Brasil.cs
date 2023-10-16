public class ProcessoDemissaoBrasil : ProcessoDemissao
{
    public override string Title => "Demissão de Funcionario";

    public override void Apply(ArgsDemissao args)
        => args.Empresa.Dinheiro -= 2 * args.Empregado.Salario;
}

public class ProcessoPagamentoSalarioBrasil : ProcessoPagamentoSalario
{
    public override string Title => "Pagamento de Salário";
    public override void Apply(ArgsPagamentoSalario args)
        => args.Empresa.Dinheiro -= 1.45m * args.Empregado.Salario + 500;
}

public class ProcessoContratacaoBrasil : ProcessoContratacao
{
    public override string Title => "Contratando Brasileiro";
    public override void Apply(ArgsContratacao args)
        => args.Empresa.Dinheiro -= 1.7m * args.Empregado.Salario + 10000;
}

public class FabricaProcessoBrasil : IFabricaProcesso
{
    public ProcessoDemissao CriarProcessoDemissao()
        => new ProcessoDemissaoBrasil();

    public ProcessoPagamentoSalario CriarProcessoPagamentoSalario()
        => new ProcessoPagamentoSalarioBrasil();

    public ProcessoContratacao CriarProcessoContratacao()
        => new ProcessoContratacaoBrasil();
}