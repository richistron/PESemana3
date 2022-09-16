namespace PESemana3;

public class NumeroMasGrandeIfElse
{
    private int[] numeros;

    public NumeroMasGrandeIfElse()
    {
        numeros = new int[3] { LeeNumero(), LeeNumero(), LeeNumero() };
    }

    public void ComparaNumeros()
    {
        if (numeros[0] >= numeros[1] && numeros[0] >= numeros[2])
        {
            NumeroMasGrandeMensaje(numeros[0]);
            return;
        }
        else if (numeros[1] >= numeros[0] && numeros[1] >= numeros[2])
        {
            NumeroMasGrandeMensaje(numeros[1]);
            return;
        }

        NumeroMasGrandeMensaje(numeros[2]);
    }

    private void NumeroMasGrandeMensaje(int numero)
    {
        Console.WriteLine("El número más grade es {0}", numero);
    }

    private int LeeNumero()
    {
        string? entrada;
        bool valido = false;
        int numero = 0;

        while (!valido)
        {
            Console.WriteLine("Escribe un número");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero))
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("El valor '{0}' es inválido", entrada);
            }
        }

        return numero;
    }
}