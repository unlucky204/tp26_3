using tp26_3;
using static System.Runtime.InteropServices.JavaScript.JSType;


int Op = 1;
List<Participante> Parti = new List<Participante>();
List<int> categoria = new List<int>();
while (Op != 0)
{
    Console.WriteLine("ingrese el num. de participante");
    Console.WriteLine("ingrese 0 si quiere salir");
    int NumParti  = int.Parse(Console.ReadLine());
    if (NumParti != 0)
    {

        Participante participantes = new Participante();
        participantes.carga(NumParti);
        foreach (int cat in categoria)
        {
            if (participantes.Categoria != cat)
            {
                categoria.Add(participantes.Categoria);
            }
        }
        Parti.Add(new Participante());
    }
    else
    {
        Op = 0;
    }

}
Participante? participanteMenorTiempo;
foreach ( Participante p in Parti)
{
    int tiempoAux = int.MaxValue;
    if (p.Tiempo < tiempoAux)
    {
        participanteMenorTiempo = p;
    }
}

