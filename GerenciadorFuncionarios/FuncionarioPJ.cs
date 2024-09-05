namespace GerenciadorFuncionarios;
public class FuncionarioPJ : Funcionario
{
    public int HorasTrabalhadas {  get; set; }

    public decimal ValorHora { get; set; }

    public override decimal CalcularSalario()
    {
       return ValorHora * HorasTrabalhadas;
    }
}
