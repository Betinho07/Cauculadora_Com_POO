
namespace Calculadora.Menus
{
    public class MenuPorcentamem : Menu
    {
        public override void Executar()
        {
            Console.Clear();

            Console.WriteLine("digete valor da porcentagem ");
            float p1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor do produto");
            float p2 = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");
            float resultado = p1 * p2 / 100;
            Console.WriteLine($"O Resultado da Porcentamem: {p1}% De {p2} = {resultado}");

        }
    }
}
