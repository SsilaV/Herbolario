
/* Clase hija de "Producto" para la clasificación de los productos
 * de deporte. */

using HerbolarioViolero.Clases;
using System;

[Serializable]

class PDeporte : Producto
{
    private string deporte;

    public PDeporte(int id, string nombre, string descripcion,
        string deporte) : base(id, nombre, descripcion)
    {
        this.deporte = deporte;
    }

    public PDeporte(int id, string nombre, string descripcion, 
        CasaComercial casa, string deporte)
        : base(id, nombre, descripcion, casa)
    {
        this.deporte = deporte;
    }

    public string GetDeporte()
    {
        return deporte;
    }

    public void SetDeporte(string deporte)
    {
        this.deporte = deporte;
    }

    public override string MostrarSinCasa()
    {
        return base.MostrarSinCasa() + "Deporte: " + deporte;
    }
    public override string ToString()
    {
        return base.ToString() + " - " + deporte;
    }
}

