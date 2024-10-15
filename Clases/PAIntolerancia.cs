
/* Clase hija de "PAlimentacion" para la clasificacion de los productos
 * para personas con intolerancias alimenticias. */

using HerbolarioViolero.Clases;
using System;

[Serializable]

class PAIntolerancia : PAlimentacion
{
    private string intoleranciaCliente;
   
    public PAIntolerancia(int id, string nombre, string descripcion, 
        string alergeno, string intoleranciaCliente)
        : base(id, nombre, descripcion, alergeno)
    {
        this.intoleranciaCliente = intoleranciaCliente;
    }

    public PAIntolerancia(int id, string nombre, string descripcion,
        CasaComercial casa, string alergeno, string intoleranciaCliente)
        : base(id, nombre, descripcion, casa, alergeno)
    {
        this.intoleranciaCliente = intoleranciaCliente;
    }

    public string GetIntolerancia()
    {
        return intoleranciaCliente;
    }

    public void SetIntolerancia(string intoleranciaCliente)
    {
        this.intoleranciaCliente = intoleranciaCliente;
    }

    public override string MostrarSinCasa()
    {
        return base.MostrarSinCasa() + 
            "Alimento apto las intolerancias que se decriben a continuación:" + 
            intoleranciaCliente;
    }
    public override string ToString()
    {
        return base.ToString() + " - Intolerancia: " + intoleranciaCliente;
    }

}




