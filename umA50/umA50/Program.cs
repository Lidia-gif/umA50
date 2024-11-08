using System;
    //Exercício 2
public class umA50
{
    public static void Main(string[] args)
    {   //Somar os números ímpares 1 a 50
        int soma = 0;
        for (int contador = 1; contador <= 50; contador++)
        {
            if (contador % 2 != 0)
            {
                soma = soma + contador;
            }
        }
            Console.WriteLine("O total da soma dos números ímpares é igual a: " + soma);
    }
}