using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBebidas;

public class Refrigerante : Bebidas
{
    public Boolean Vidro { get; set; }

    public void ImprimirDados()
    {
        if (Vidro){
            Console.WriteLine($"O produto com ID {Id} se chama {NomeBebida}. É um refrigerante de {Mililitro} ml em embalagem de vidro");
        }else{
            Console.WriteLine($"O produto com ID {Id} se chama {NomeBebida}. É um refrigerante de {Mililitro} ml em embalagem de plástico");

        }
    }
}