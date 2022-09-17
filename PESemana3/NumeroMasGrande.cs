namespace PESemana3;

public class NumeroMasGrande
{
    protected int[] numeros;

    public NumeroMasGrande()
    {
        numeros = new int[3] { LeeNumero(), LeeNumero(), LeeNumero() };
    }

    public void ComparaNumeros()
    {
        Array.Sort(numeros);
        Array.Reverse(numeros);
        Console.WriteLine("El número más grade es {0}", numeros[0]);
    }

    private int LeeNumero()
    {
        bool validNumber = false;
        int num = 0;
        string input;
        while (!validNumber)
        {
            Console.WriteLine("Ingresa un número entero");
            input = Console.ReadLine();

            if (int.TryParse(input, out num)) validNumber = true;
            else
            {
                if (input == null) Console.WriteLine("Debes ingresar un número");
                else Console.WriteLine("'{0}' no es un número válido", input);
            }
        }

        return num;
    }
}