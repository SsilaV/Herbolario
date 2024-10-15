
/* Clase hija de "Producto" para la clasificación de los productos
 * corporales. */

using HerbolarioViolero.Clases; // dejo using, es por namespaces???
using System;

[Serializable]

class PCorporal : Producto
{
    private string modoEmpleo;

    public PCorporal(int id, string nombre, string descripcion, 
        string modoEmpleo) : base(id, nombre, descripcion)
    {
        this.modoEmpleo = modoEmpleo;
    }

    public PCorporal(int id, string nombre, string descripcion, 
        CasaComercial casa,string modoEmpleo)
        : base(id, nombre, descripcion, casa)
    {
        this.modoEmpleo = modoEmpleo;
    }

    public string GetModoEmpleo()
    {
        return modoEmpleo;
    }

    public void SetModoEmpleo(string modoEmpleo)
    {
        this.modoEmpleo = modoEmpleo;
    }

    public override string MostrarSinCasa()
    {
        return base.MostrarSinCasa() + "Modo de empleo: " + modoEmpleo;
    }

    public override string ToString()
    {
        return base.ToString() + " - " + modoEmpleo;
    }
}

