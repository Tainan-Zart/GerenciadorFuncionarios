namespace GerenciadorFuncionarios;
public class Estagiario : Funcionario, IBeneficio
{
    public decimal ValeTransporte { get; set; }

    public decimal CalcularBeneficio()
    {
        return ValeTransporte;
    }

    public override decimal CalcularSalario()
    {
        return Salario;
    }
}
