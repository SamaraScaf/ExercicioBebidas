using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBebidas;

public class Menu : Bebidas
{
    public static int MostrarMenu()
    {
        int op;
        try
        {
            Console.WriteLine("Menu Bebidas");
            Console.WriteLine("1 - Adicionar bebida");
            Console.WriteLine("2 - Alterar bebida");
            Console.WriteLine("3 - Remover bebida");
            Console.WriteLine("4 - Listar bebidas");
            Console.WriteLine("5 - Sair do menu");

            return op = int.Parse(Console.ReadLine());

        }
        catch (Exception)
        {
            Console.WriteLine("Digite uma opção válida!");
        }

        return MostrarMenu();
    }
}