﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp26_3
{
    public class Participante()
    {
        public int NumParti {  get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public double Tiempo { get; set; }
        public int Altura { get; set; }
        public int Categoria { get; set; }

        //public DateOnly FechaNac {  get; set; }
        //public int Edad 
        //{
        //    get
        //    {
        //        return DateTime.Now.Year - FechaNac.Year;
        //    } 
        //}

        public void carga(int numParti)
        {
            NumParti = numParti;
            Console.WriteLine("ingrese el nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("ingrese el apellido");
            Apellido = Console.ReadLine();
            Console.WriteLine("ingrese el tiempo");
            Tiempo = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura");
            Altura = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la categoria");
            Categoria = int.Parse(Console.ReadLine());
        }
    }
}
