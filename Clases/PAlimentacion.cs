using HerbolarioViolero.Clases;
using System;

[Serializable]

class PAlimentacion : Producto
{
    protected string alergeno;

    public PAlimentacion(int id, string nombre, string descripcion, 
        string alergeno) 
        : base(id, nombre, descripcion)
    {
        this.alergeno = alergeno;
    }

    public PAlimentacion(int id, string nombre, string descripcion,
        CasaComercial casa, string alergeno)
        : base(id, nombre, descripcion, casa)
    {
        this.alergeno = alergeno;
    }

    public string GetAlergeno()
    {
        return alergeno;
    }

    public void SetAlergeno(string alergeno)
    {
        this.alergeno = alergeno;
    }

    public override string MostrarSinCasa()
    {
        return base.MostrarSinCasa() + "Alérgenos principales: " + alergeno;
    }
    public override string ToString()
    {
        return base.ToString() + " - " + alergeno;
    }
}
