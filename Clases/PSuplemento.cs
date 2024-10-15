
/* Clase hija de "Producto" para la clasificación de los productos
 * que sirven como suplemento alimenticio. */

using HerbolarioViolero.Clases;
using System;

[Serializable]

class PSuplemento : Producto
{
    private string composicionQuimica;

    public PSuplemento(int id, string nombre, string descripcion,
        string composicionQuimica) : base(id, nombre, descripcion)
    {
        this.composicionQuimica = composicionQuimica;
    }

    public PSuplemento(int id, string nombre, string descripcion,
        CasaComercial casa, string composicionQuimica) 
        : base(id, nombre, descripcion, casa)
    {
        this.composicionQuimica = composicionQuimica;
    }

    public string GetComposicionQuimica()
    {
        return composicionQuimica;
    }

    public void SetComposicionQuimica(string composicionQuimica)
    {
        this.composicionQuimica = composicionQuimica;
    }

    public override string MostrarSinCasa()
    {
        return base.MostrarSinCasa() + "Composición química: " 
            + composicionQuimica;
    }

    public override string ToString()
    {
        return base.ToString() + " - " + composicionQuimica;
    }
}

