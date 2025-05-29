using System;

namespace console.mentoria3;

/// <summary>
/// Classe que demonstra o uso de estruturas condicionais if/else if/else para determinar
/// a estação do ano baseada no mês informado pelo usuário.
/// </summary>
public static class VerificadorEstacao
{
    /// <summary>
    /// Executa o exemplo de verificação de estação do ano.
    /// Solicita ao usuário um número de mês (1-12) e exibe a estação correspondente.
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("=== Verificador de Estação do Ano ===");
        Console.Write("Digite o número do mês (1-12): ");

        if (int.TryParse(Console.ReadLine(), out int mes))
        {
            string estacao = VerificarEstacao(mes);
            Console.WriteLine($"A estação correspondente é: {estacao}");
        }
        else
        {
            Console.WriteLine("Entrada inválida! Por favor, digite um número entre 1 e 12.");
        }
    }

    /// <summary>
    /// Verifica qual estação do ano corresponde ao mês informado.
    /// Retorna: Verão (dez-jan-fev), Outono (mar-abr-mai), 
    /// Inverno (jun-jul-ago), Primavera (set-out-nov) ou "Mês inválido".
    /// </summary>
    /// <param name="mes">Número do mês (1-12)</param>
    /// <returns>Nome da estação do ano correspondente</returns>
    private static string VerificarEstacao(int mes)
    {
        if (mes == 12 || mes == 1 || mes == 2)
            return "Verão";
        else if (mes == 3 || mes == 4 || mes == 5)
            return "Outono";
        else if (mes == 6 || mes == 7 || mes == 8)
            return "Inverno";
        else if (mes == 9 || mes == 10 || mes == 11)
            return "Primavera";
        else
            return "Mês inválido!";
    }
}