﻿using System;

namespace ListaExercicios.Exercicio22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int a;
            int b;
            int c;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine($"\nOs valores são iguais. A soma atribuida de C é: {c}");
            }
            else
            {
                c = a * b;
                Console.WriteLine($"\nOs valores são diferentes. A multiplicação atribuida de C é: {c}");
            }
        }
    }
}