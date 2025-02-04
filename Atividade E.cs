using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o primeiro número: ");
float numero = Convert.ToSingle(Console.ReadLine());			
Console.Write("Digite o segundo número: ");
float numero2 = Convert.ToSingle(Console.ReadLine());				
if (numero > numero2)
{ 
Console.WriteLine("\n\rO primeiro número é maior que o segundo");
}
else if (numero == numero2)
{
Console.WriteLine("\n\rOs números são iguais");
}
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
