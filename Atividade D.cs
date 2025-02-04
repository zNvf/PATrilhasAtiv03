using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o primeiro número: ");
int numero = Convert.ToInt32(Console.ReadLine());			
Console.Write("Digite o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());			
Console.Write("Digite o terceiro número: ");
int numero3 = Convert.ToInt32(Console.ReadLine());			
if (numero2 > numero && numero > numero3)
{ 
Console.WriteLine("\n\rO primeiro número é menor que o segundo número e maior que o terceiro número.");
}
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
