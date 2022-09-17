namespace PESemana3;

public class MenuOpciones
{
    private bool valido;
    private bool terminado;

    public void Iniciar()
    {
        string? input;
        while (!valido && !terminado)
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("\t 1) Adivina el número");
            Console.WriteLine("\t 2) Encuentra el número más grande con sort");
            Console.WriteLine("\t 3) Encuentra el número más grande con if y else");
            Console.WriteLine("\t 4) Encuentra el número más grande con N cantidad de valores");
            Console.WriteLine("\t c) Cancelar");
            input = Console.ReadLine();
            Opciones(input);
        }
    }

    private void Opciones(string? input)
    {
        char opt = '_';
        char.TryParse(input, out opt);

        switch (opt)
        {
            case '1':
                valido = true;
                AdivinaElNumero adivinador = new AdivinaElNumero();
                adivinador.Adivina();
                break;

            case '2':
                valido = true;
                NumeroMasGrande numeroMasGrande = new NumeroMasGrande();
                numeroMasGrande.ComparaNumeros();
                break;

            case '3':
                valido = true;
                NumeroMasGrandeIfElse numeroMasGrandeIfElse = new NumeroMasGrandeIfElse();
                numeroMasGrandeIfElse.ComparaNumeros();
                break;

            case '4':
                valido = true;
                NumeroMasGrandeIlimitado numeroMasGrandeIlimitado = new NumeroMasGrandeIlimitado();
                numeroMasGrandeIlimitado.ComparaNumeros();
                break;

            case 'C':
            case 'c':
                terminado = true;
                break;

            default:
                Console.Clear();
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}