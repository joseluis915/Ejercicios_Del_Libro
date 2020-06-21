using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercicios_Del_Libro.Entidades
{
    public class Estudiantes
    {
        [Key]
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Curso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public DateTime FechaEgreso { get; set; }
        public float Calificacion { get; set; }
        public ArrayList RecordCalificaciones { get; set; }
        public string NombreMadre { get; set; }
        public string NombrePadre { get; set; }
        public string NombreTutor { get; set; }
    }
}
