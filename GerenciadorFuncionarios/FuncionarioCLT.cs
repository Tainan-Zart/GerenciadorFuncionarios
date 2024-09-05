namespace GerenciadorFuncionarios;
public class FuncionarioCLT : Funcionario, IBeneficio
{
    public decimal ValeTransporte { get; set; }

    public decimal ValeAlimentacao { get; set; }

    public decimal CalcularBeneficio()
    {
        return ValeTransporte + ValeAlimentacao;
    }

    public override decimal CalcularSalario()
    {
        return Salario;
    }
}
