namespace console.mentoria3;

/// <summary>
/// Classe que demonstra o uso de operador ternário para verificação simples de CNH.
/// O método Executar solicita ao usuário se possui CNH e retorna uma mensagem apropriada
/// baseada na resposta, utilizando o operador ternário para simplificar a lógica condicional.
/// </summary>
public static class VerificadorCNH
{
    /// <summary>
    /// Executa o exemplo de verificação de CNH.
    /// Solicita uma entrada do usuário (sim/não) e utiliza operador ternário
    /// para determinar se o usuário pode ou não dirigir.
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("=== Verificador de CNH ===");
        Console.Write("Você possui CNH? (sim/não): ");
        string? resposta = Console.ReadLine()?.Trim().ToLower();

        string resultado = (resposta == "sim") ? "Você pode dirigir." : "Você NÃO pode dirigir.";

        Console.WriteLine(resultado);
    }
}
