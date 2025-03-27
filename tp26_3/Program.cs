using tp26_3;

int Op = 1;
List<Participante> Parti = new List<Participante>();
List<int> categoria = new List<int>();
while (Op != 0)
{
    Console.WriteLine("ingrese el num. de participante");
    Console.WriteLine("ingrese 0 si quiere salir");
    int NumParti = int.Parse(Console.ReadLine());
    if (NumParti != 0)
    {

        Participante participante = new Participante();
        participante.carga(NumParti);

        foreach (int cat in categoria)
        {
            if (participante.Categoria != cat)
            {
                categoria.Add(participante.Categoria);
            }
        }

        Parti.Add(participante);
    }
    else
    {
        Op = 0;
    }
}

Participante? participanteMenorTiempo = null;
foreach ( Participante p in Parti)
{
    double tiempoAux = int.MaxValue;
    if (p.Tiempo < tiempoAux)
    {
        tiempoAux = p.Tiempo;
        participanteMenorTiempo = p;
    }
}
Console.WriteLine("el participante con menor tiempo es :");
Console.WriteLine($"nombre: {participanteMenorTiempo.Tiempo}");
Console.WriteLine($"nombre: {participanteMenorTiempo.Nombre}");
Console.WriteLine($"nombre: {participanteMenorTiempo.Apellido}");
Console.WriteLine($"nombre: {participanteMenorTiempo.NumParti}");
Console.WriteLine($"nombre: {participanteMenorTiempo.Altura}");

