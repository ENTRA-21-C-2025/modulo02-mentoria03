namespace console.mentoria3;

/// <summary>
/// Classe que demonstra o uso de estruturas condicionais if/else if/else para classificar
/// a idade do usuário em diferentes categorias: menor de idade, adulto ou idoso.
/// </summary>
public static class VerificadorIdade
{
    /// <summary>
    /// Executa o exemplo de verificação de idade.
    /// Solicita ao usuário sua idade e exibe a categoria correspondente
    /// (menor de idade, adulto ou idoso).
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("=== Verificador de Idade ===");
        Console.Write("Digite sua idade: ");

        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            string resultado = VerificarIdade(idade);
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro.");
        }
    }

    /// <summary>
    /// Verifica e classifica a idade informada em categorias.
    /// Retorna: "menor de idade" (< 18), "adulto" (18-64), 
    /// "idoso" (65-101) ou "idade inválida" (< 0 ou > 101).
    /// </summary>
    /// <param name="idade">Idade a ser verificada</param>
    /// <returns>Mensagem indicando a categoria da idade</returns>
    private static string VerificarIdade(int idade)
    {
        if (idade < 0 || idade > 101)
            return "Idade inválida!";
        else if (idade < 18)
            return "Você é menor de idade";
        else if (idade < 65)
            return "Você é adulto";
        else
            return "Você é idoso";
    }
}
