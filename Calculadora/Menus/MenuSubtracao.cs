﻿

namespace Calculadora.Menus
{
    public class MenuSubtracao : Menu
    {
        public override void Executar()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");

            float r = n1 - n2;
            Console.WriteLine($"O Resultado da Subtração: {n1} - {n2} = {r}");
        }
    }
}
