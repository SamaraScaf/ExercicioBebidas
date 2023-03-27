using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBebidas;

public class Bebidas
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public decimal Mililitro { get; set; }
    public string NomeBebida { get; set; }
    public decimal ValorCompra { get; set; }
    
    public void Comprar()
    {
        Console.WriteLine($"Valor da compra do produto com ID {Id} alterado para: R${ValorCompra}");
    }
}