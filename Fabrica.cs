using System.Runtime.CompilerServices;

class Fabrica
{
    public static IVivencia GetHabita(int opc)
    {
        if(opc == 1)
        {
            return new Cuadrupedo();
        }
        else if(opc == 2)
        {
            return new Pez();
        }
        else
        {
            return new Ave();
        }
    }
}