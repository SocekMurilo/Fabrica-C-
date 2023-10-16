public static class ExtencaoEmpresaBuilder
{
    public static Empresa.EmpresaBuilder NoBrasil(this Empresa.EmpresaBuilder builder)
    {
        builder.SetFabrica(new FabricaProcessoBrasil());
        return builder;
    }

    public static Empresa.EmpresaBuilder NaArgentina(this Empresa.EmpresaBuilder builder)
    {
        builder.SetFabrica(new FabricaProcessoArgentina());
        return builder;
    }

    public static Empresa.EmpresaBuilder NaArgelia(this Empresa.EmpresaBuilder builder)
    {
        builder.SetFabrica(new FabricaProcessoArgelia());
        return builder;
    }
}