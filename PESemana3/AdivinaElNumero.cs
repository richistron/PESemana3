namespace PESemana3;

class AdivinaElNumero
{
    private int numeroComputadora;
    private int numeroUsuario;
    private bool adivinado;

    public AdivinaElNumero()
    {
        Random rand = new Random();
        numeroComputadora = rand.Next(1, 10);
    }

    public void Adivina()
    {
        while (!adivinado)
        {
            numeroUsuario = CapturaNumero();
            if (numeroComputadora == numeroUsuario)
            {
                adivinado = true;
                Console.WriteLine("Ganaste, has derrotado a la matrix");
            }
            else
            {
                Console.WriteLine("Jaja, no puedes contra el algoritmo del ritmo");
            }
        }
    }

    private int CapturaNumero()
    {
        string? entrada;
        int numero = 0;
        bool numeroValido = false;

        while (!numeroValido)
        {
            Console.WriteLine("Dime un número de 1 al 10");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero))
            {
                if (numero < 10 && numero > 0)
                {
                    numeroValido = true;
                }
                else
                {
                    Console.WriteLine("el dato '{0}' ingresado no está en el rando del 1 al 10", numero);
                }
            }
            else
            {
                Console.WriteLine("el dato '{0}' ingresado no es un número entero", entrada);
            }
        }

        return numero;
    }
}