namespace PESemana3;

class AdivinaElNumero
{
    private int numeroComputadora;
    private int numeroUsuario = -1;

    public AdivinaElNumero()
    {
        Random rand = new Random();
        numeroComputadora = rand.Next(1, 10);
        Console.WriteLine("Adivina el número de 1 al 10...");
    }

    public void Random()
    {
        while (numeroComputadora != numeroUsuario)
        {
            Console.WriteLine("Dime un número");
            leeNumeroUsuario();
            if (numeroComputadora == numeroUsuario)
            {
                Console.WriteLine("Ganaste, has derrotado a la matrix");
            }
            else
            {
                if (numeroUsuario > 10 || numeroUsuario < 1)
                {
                    Console.WriteLine("El número tiene que ser entre 1 y 10");
                }
                else
                {
                    Console.WriteLine("Jajaja, no puedes contra el algoritmo del ritmo");
                }
            }
        }
    }

    private void leeNumeroUsuario()
    {
        var input = Console.ReadLine();

        try
        {
            numeroUsuario = int.Parse(input);
        }
        catch
        {
            Console.WriteLine("El número {0} is inválido", input);
            numeroUsuario = -1;
        }
    }
}