
/* Clase hija de "PAlimentacion" para la clasificacion de los productos
 * destinados al control del peso. */

using HerbolarioViolero.Clases;
using System;

[Serializable]

class PAAdelgazante : PAlimentacion
{
    public PAAdelgazante(int id, string nombre, string descripcion, 
        string alergeno) : base(id, nombre, descripcion, alergeno)
    {
    }

    public PAAdelgazante(int id, string nombre, string descripcion, 
        CasaComercial casa, string modoEmpleo) 
        : base(id, nombre, descripcion, casa, modoEmpleo)
    {
    }

    public override string MostrarSinCasa()
    {
        return base.MostrarSinCasa() + "(De bajo aporte calórico)";
    }
    public override string ToString()
    {
        return base.ToString() + " - Bajo en calorías";
    }
}
