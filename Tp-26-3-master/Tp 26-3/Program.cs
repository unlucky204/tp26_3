using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tp_26_3
{
    public class Participante
    {
        public int NroParticipante;
        public string Nombre;
        public string Apellido;
        public int Tiempo;
        public int Altura;
        public int Categoria;
        public int i = 0;

        public void Carga(int nroParticipante)
        {
            NroParticipante = nroParticipante;
            Console.WriteLine("Ingrese el nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo");
            Tiempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura en centimetros");
            Altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la categoria");
            Categoria = int.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Participante> participantes = new List<Participante>();
            List<int> tiempoCategoria = new List<int>();
            List<int> categoriascomp = new List<int>();
            int j = 1;
            do
            {
                Console.WriteLine("Ingrese el numero del participante");
                Console.WriteLine("0 para salir");
                var nroParticipante = int.Parse(Console.ReadLine());
                if (nroParticipante != 0)
                {
                    Participante participante = new Participante();
                    participante.Carga(nroParticipante);
                    foreach(int categoria in categoriascomp)
                    {
                        if(participante.Categoria != categoria)
                        {
                            categoriascomp.Add(participante.Categoria);
                            tiempoCategoria.Add(participante.Tiempo);
                            break;
                        }
                        else
                        {
                            tiempoCategoria.Add(participante.Tiempo);
                        }
                        /*foreach (int c in tiempoCategoria)
                        {
                            int tiempoAux = int.MaxValue;

                            if (c < tiempoAux)
                            {
                                tiempoAux = p.Tiempo;
                                participanteMenorTiempo = p;
                            }
                    }*/
                    }
                    participantes.Add(participante);
                }
                else
                {
                    j = 0;
                }
            }
            while (j != 0);

            Participante participanteMenorTiempo = null;

            foreach (Participante p in participantes)
            {
                int tiempoAux = int.MaxValue;                

                if (p.Tiempo < tiempoAux)
                {
                    tiempoAux = p.Tiempo;
                    participanteMenorTiempo = p;
                }
            }
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("El participante con el menor tiempo es: ");
            Console.WriteLine("Numero De Participante:" + participanteMenorTiempo.NroParticipante);
            Console.WriteLine("Nombre:" + participanteMenorTiempo.Nombre);
            Console.WriteLine("Apellido:" + participanteMenorTiempo.Apellido);
            Console.WriteLine("Tiempo!:" + participanteMenorTiempo.Tiempo);
            Console.WriteLine("=====================================================================================");
            
        }
    }
}
