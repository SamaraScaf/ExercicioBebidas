using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBebidas;

public class Suco : Bebidas
{
    public string Embalagem { get; set; }

    public void ImprimirDados()
    {
        Console.WriteLine($"O produto com ID {Id} é um suco com embalagem de {Embalagem} contendo {Mililitro} ml");
    }
}