
namespace Calculadora.Menus
{
    public class Menu
    {

        
        public void Menus()
        {

            Dictionary <short, Menu> opcoes = new();
            opcoes.Add(1, new MenuSoma());
            opcoes.Add(2, new MenuDivisao());
            opcoes.Add(3, new MenuSubtracao());
            opcoes.Add(4, new MenuMutiplicacao());
            opcoes.Add(5, new MenuPorcentamem());

            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("Escolha a opção a baixo:");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Divisão");
            Console.WriteLine("3- Subtração");
            Console.WriteLine("4- Mutiplicaçao");
            Console.WriteLine("5- Porcentamem\n");
            short cal = short.Parse(Console.ReadLine()!);
            
            if (opcoes.ContainsKey(cal))
            {
                Menu menuASerExibido = opcoes[cal];
                menuASerExibido.Executar();
                
            }
            else
            {
                Console.WriteLine("Opção inválida");
                Thread.Sleep(4000);
                Menus();
            }
        }
        public virtual void Executar() { }
    }
}
