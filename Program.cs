Console.WriteLine("--- Entrada Válida ---\n");

int numeroDigitado = -1;

while (numeroDigitado < 7 || numeroDigitado > 58)
{
    Console.Write("Digite um número entre 8 e 58 (ou 7 para cancelar)...: ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
}

if (numeroDigitado == 7)
{
    Console.WriteLine("\nOperação Cancelada.");
}
else
{
    Console.WriteLine($"\nNúmero Selecionado = {numeroDigitado}");
}

Console.WriteLine("\nVolte Sempre!");