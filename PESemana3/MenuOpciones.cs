namespace PESemana3;

public class MenuOpciones
{
    private bool valido = false;

    public void Iniciar()
    {
        while (!valido)
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("\t 1) Adivina el número");
            Console.WriteLine("\t 2) Encuentra el número más grande");
            Opciones();
        }
    }

    private void Opciones()
    {
        string? opt = Console.ReadLine();


        // TODO, numero mas grande recursion
        // TODO, numero mas grande switch statement
        // TODO, numero mas grande array dinámico 

        switch (opt)
        {
            case "1":
                valido = true;
                AdivinaElNumero adivinador = new AdivinaElNumero();
                adivinador.Adivina();
                break;

            case "2":
                valido = true;
                NumeroMasGrande numeroMasGrande = new NumeroMasGrande();
                numeroMasGrande.ComparaNumeros();
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}