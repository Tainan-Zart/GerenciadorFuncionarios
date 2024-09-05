using System.Runtime.InteropServices;

namespace GerenciadorFuncionarios;
public class Menu
{
    private List<Funcionario> Funcionarios { get; set; }
    private void Layout()
    {
        Console.WriteLine("=== Sistema de Gerenciamento de Funcionários === ");
        Console.WriteLine("1. Cadastrar Funcionário CLT");
        Console.WriteLine("2. Cadastrar Funcionário PJ");
        Console.WriteLine("3. Cadastrar Estagiário");
        Console.WriteLine("4. Listar Funcionários");
        Console.WriteLine("5. Sair");
        Console.WriteLine("Escolha uma opção:");
    }

    public void MenuGerenciador()
    {
        Layout();
        int opcao = int.Parse(Console.ReadLine());

        while (true)
        {
            switch (opcao)
            {
                case 1:
                    CadastrarCLT();
                    break;
                case 2:
                    CadastrarPJ();
                    break;
                case 3:
                    CadastrarEstagiario();
                    break;
                case 4:
                    ListarFuncionarios();
                    break;
                case 5:
                    return;


            }
        }


    }

    private void CadastrarCLT()
    {
        var funcionarioCLT = new FuncionarioCLT();

        Console.WriteLine("=== Cadastro de Funcionário CLT ===");
        
        Console.WriteLine("Nome: ");
        funcionarioCLT.Nome = Console.ReadLine();

        Console.WriteLine("CPF: ");
        funcionarioCLT.CPF = Console.ReadLine();

        Console.WriteLine("Salário: ");
        funcionarioCLT.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Vale Transporte: ");
        funcionarioCLT.ValeTransporte = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Vale Refeição: ");
        funcionarioCLT.ValeAlimentacao = decimal.Parse(Console.ReadLine());

        Funcionarios.Add(funcionarioCLT);

        Console.WriteLine("Funcionário CLT cadastrado com sucesso!");

        Console.ReadKey();
    }

    private void CadastrarPJ()
    {
        var funcionarioPJ = new FuncionarioPJ();

        Console.WriteLine("=== Cadastro de Funcionário PJ ===");

        Console.WriteLine("Nome: ");
        funcionarioPJ.Nome = Console.ReadLine();

        Console.WriteLine("CPF: ");
        funcionarioPJ.CPF = Console.ReadLine();

        Console.WriteLine("Horas Trabalhadas:");
        funcionarioPJ.HorasTrabalhadas = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor por Hora:");
        funcionarioPJ.ValorHora = decimal.Parse(Console.ReadLine());

        Funcionarios.Add(funcionarioPJ);

        Console.WriteLine("Funcionário PJ cadastrado com sucesso!");

        Console.ReadKey();
    }

    private void CadastrarEstagiario()
    {
        var estagiario = new Estagiario();

        Console.WriteLine("=== Cadastro de Estagiário ===");

        Console.WriteLine("Nome: ");
        estagiario.Nome = Console.ReadLine();

        Console.WriteLine("CPF: ");
        estagiario.CPF = Console.ReadLine();

        Console.WriteLine("Bolsa Auxílio: ");
        estagiario.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Vale Transporte:");
        estagiario.ValeTransporte = decimal.Parse(Console.ReadLine());

        Funcionarios.Add(estagiario);

        Console.ReadKey();
    }

    private void ListarFuncionarios()
    {

    }
}
