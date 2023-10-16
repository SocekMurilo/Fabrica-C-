using System.Runtime.CompilerServices;

public class Empresa
{
    // Estrutura Singleton
    private Empresa() {}
    private static Empresa crr = null;
    public static Empresa Current => crr;

    public string Nome { get; set; }
    public decimal Dinheiro { get; set; }

    private List<Empregado> empregados = new List<Empregado>();
    public IEnumerable<Empregado> Empregados => empregados;

    private ProcessoDemissao processoDemissao = null;
    private ProcessoPagamentoSalario processoPagamentoSalario = null;
    private ProcessoContratacao processoContratacao= null;

    public void Contratar(Empregado empregado)
    {
        if (empregado == null)
            return;

        ArgsContratacao args = new ArgsContratacao();
        args.Empregado = empregado;
        args.Empresa = this;

        processoContratacao.Apply(args);

        empregados.Add(empregado);
    }
    public void Demitir(string nome)
    {
        var empregado = this.Empregados.FirstOrDefault(e => e.Nome == nome);

        if (empregado == null)
            return;

        ArgsDemissao args = new ArgsDemissao();
        args.Empregado = empregado;
        args.Empresa = this;

        processoDemissao.Apply(args);

        empregados.Remove(empregado);
    }

    public void PagarSalarios()
    {
        foreach(var empregado in this.Empregados)
        {
            ArgsPagamentoSalario args = new ArgsPagamentoSalario();
            args.Empregado = empregado;
            args.Empresa = this;

            processoPagamentoSalario.Apply(args);
        }
    }

    public class EmpresaBuilder
    {
        private Empresa empresa = new Empresa();

        public Empresa Build()
            =>this.empresa; 

        public EmpresaBuilder SetNome(string nome)
        {
            empresa.Nome = nome;
            return this;
        }


        public EmpresaBuilder SetFabrica(IFabricaProcesso fabrica)
        {
            empresa.processoDemissao = fabrica.CriarProcessoDemissao();
            empresa.processoPagamentoSalario = fabrica.CriarProcessoPagamentoSalario();
            empresa.processoContratacao = fabrica.CriarProcessoContratacao();

            return this;
        }

        public EmpresaBuilder SetCapitalInicial(decimal dinheiro)
        {
            empresa.Dinheiro = dinheiro;
            return this;
        }

        public EmpresaBuilder AddEmpregado(string nome, decimal salario)
        {
            Empregado empregado = new Empregado();
            empregado.Nome = nome;
            empregado.Salario = salario;
            empresa.Contratar(empregado);
            return this;
        }
    }

    public static EmpresaBuilder GetBuilder()
        => new EmpresaBuilder();

    public static void New(EmpresaBuilder builder)
        => crr = builder.Build();
}