namespace PESemana3;

public class NumeroMasGrandeIlimitado
{
    private int[] numeros;
    private bool terminado;

    public NumeroMasGrandeIlimitado()
    {
        int numero;
        List<int> lista = new List<int>();

        while (!terminado)
        {
            numero = LeeNumero();
            if (!terminado)
                lista.Add(numero);
        }

        numeros = lista.ToArray();
    }

    public void ComparaNumeros()
    {
        Array.Sort(numeros);
        Array.Reverse(numeros);
        Console.WriteLine("El número más grade es {0}", numeros[0]);
    }

    private int LeeNumero()
    {
        string? entrada;
        bool valido = false;
        int numero = 0;

        while (!valido)
        {
            Console.WriteLine("Escribe un número o presiona 'c' para continuar");
            entrada = Console.ReadLine();
            if (entrada == "c")
            {
                terminado = true;
                valido = true;
            }

            if (int.TryParse(entrada, out numero))
            {
                valido = true;
            }
            else
            {
                if (!terminado) Console.WriteLine("El valor '{0}' es inválido", entrada);
            }
        }

        return numero;
    }
}