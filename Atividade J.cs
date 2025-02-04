using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o número: ");
float numero = Convert.ToSingle(Console.ReadLine());		 			 	
if (numero == 0){
Console.WriteLine("\n\rO número é igual a zero");
}
else {
Console.WriteLine("\n\rO número é diferente de zero");
}			
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
