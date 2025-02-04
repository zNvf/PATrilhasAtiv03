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
if (numero == numero2)
{ 
Console.WriteLine("\n\rOs números são iguais");
}
else 
{
Console.WriteLine("\n\rOs números não são iguais");
}
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
