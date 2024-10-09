
namespace Calculadora.Menus
{
    public class MenuDivisao : Menu
    {
        public override void Executar()
        {

            Console.Clear();

            Console.WriteLine("Digite o segundo número:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sengundo número:");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");

            float r = n1 / n2;
            Console.WriteLine($"O Resultado da Divisão: {n1} / {n2} = {r}");
        }
    }
}
