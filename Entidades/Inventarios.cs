using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercicios_Del_Libro.Entidades
{
    public class Inventarios
    {
        [Key]
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public double Costo { get; set; }
        public double ValorInventario { get; set; }
    }
}
