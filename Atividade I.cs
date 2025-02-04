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
int resultado = numero - numero2;		 	
if (resultado < 10){
Console.WriteLine("\n\rO número é menor que dez");
}			
else if (resultado == 10) {
Console.WriteLine("\n\rO número é igual a 10");
}
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
