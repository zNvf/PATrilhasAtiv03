using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o primeiro número: ");
float numero = Convert.ToSingle(Console.ReadLine());				
if (numero % 2 == 0)
{ 
Console.WriteLine("\n\rO número é par");
}
else{
Console.WriteLine("\n\rO número é ímpar");
}
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
