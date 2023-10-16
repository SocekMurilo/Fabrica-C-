var builder = Empresa.GetBuilder();

builder 
    .SetNome("Mercado Libre")
    .NaArgelia()
    .SetCapitalInicial(20_000_000);

builder
    .AddEmpregado("Marquinhos Guapo", 50_000)
    .AddEmpregado("Paulinho Mocelin", 20_000);

Empresa.New(builder);

foreach (var emp in Empresa.Current.Empregados)
{
    Console.WriteLine(emp.Nome);
    Console.WriteLine(emp.Salario);
}
Console.WriteLine(Empresa.Current.Dinheiro);

Empregado empregado = new Empregado();
empregado.Nome = "Fabricio Daniel";
empregado.Salario = 30_000;


Empresa.Current.Contratar(empregado);

Empresa.Current.Demitir("Marquinhos Guapo");

Empresa.Current.PagarSalarios();

foreach (var emp in Empresa.Current.Empregados)
{
    Console.WriteLine(emp.Nome);
    Console.WriteLine(emp.Salario);
}
Console.WriteLine(Empresa.Current.Dinheiro);
