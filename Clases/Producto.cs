
// Clase padre y abstracta "Producto".

using HerbolarioViolero.Clases;
using System;

[Serializable]

abstract public class Producto
{

    protected int id;
    protected string nombre;
    protected string descripcion;
    protected CasaComercial casa;

    public Producto(int id, string nombre, string descripcion)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
    }

    public Producto 
        (int id, string nombre, string descripcion, CasaComercial casa)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.casa = casa;
    }

    public int GetId()
    {
        return id;
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string GetDescripcion()
    {
        return descripcion;
    }

    public void SetDescripcion(string descripcion)
    {
        this.descripcion = descripcion;
    }

    public CasaComercial GetCasa()
    {
        return casa;
    }

    public void SetCasa(CasaComercial casa)
    {
        this.casa = casa;
    }

    public virtual string MostrarSinCasa()  
    {
        return 
            
            "Id: " + id + "Nombre: " + nombre + "Descripcion: " + descripcion;
    }

    public override string ToString()
    {
        return

            id + " - " +
            nombre + " - " +
            descripcion + " - " +
            casa;
    }
}

