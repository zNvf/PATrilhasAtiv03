using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o primeiro número: ");
float numero = Convert.ToSingle(Console.ReadLine());			
if (numero < 0){ 
Console.WriteLine("\n\rO número é negativo");
}			
else if (numero ==0) {
Console.WriteLine("\n\rO número é nulo");
}			
else{
Console.WriteLine("\n\rO número é positivo");
}
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
