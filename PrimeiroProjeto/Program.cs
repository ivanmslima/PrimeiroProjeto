﻿using System;

namespace Course { 
    class Program {
        static void Main(string[] args) { 
        

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            string[] frutaVetor = s.Split(' ');
            string a = frutaVetor[0];
            string b = frutaVetor[1];
            string c = frutaVetor[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}