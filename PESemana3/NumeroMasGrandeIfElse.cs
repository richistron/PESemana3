namespace PESemana3;

public class NumeroMasGrandeIfElse : NumeroMasGrande
{
    public void ComparaNumeros()
    {
        if (EsMasGrande(numeros[0], numeros[1], numeros[2]))
        {
            NumeroMasGrandeMensaje(numeros[0]);
            return;
        }
        else if (EsMasGrande(numeros[1], numeros[0], numeros[2]))
        {
            NumeroMasGrandeMensaje(numeros[1]);
            return;
        }

        NumeroMasGrandeMensaje(numeros[2]);
    }

    private bool EsMasGrande(int a, int b, int c)
    {
        if (a >= b && a >= c) return true;
        return false;
    }

    private void NumeroMasGrandeMensaje(int numero)
    {
        Console.WriteLine("El número más grade es {0}", numero);
    }
}