public interface IFabricaProcesso
{
    public ProcessoPagamentoSalario CriarProcessoPagamentoSalario();
    public ProcessoDemissao CriarProcessoDemissao();
    public ProcessoContratacao CriarProcessoContratacao();
}