
/* Clase hija de "PAlimentacion" para la clasificacion de los alimentos
 * ecológicos. */

using HerbolarioViolero.Clases;
using System;

[Serializable]

class PAEcologico : PAlimentacion
{  

    private string certificacion;
    
    public PAEcologico(int id, string nombre, string descripcion, 
        string alergeno, string certificacion) 
        : base(id, nombre, descripcion, alergeno)
    {
        this.certificacion = certificacion;
    }

    public PAEcologico(int id, string nombre, string descripcion,
        CasaComercial casa, string alergeno, string certificacion)
        : base(id, nombre, descripcion, casa, alergeno)
    {
        this.certificacion = certificacion;
    }

    public string GetCertificacion()
    {
        return certificacion;
    }

    public void SetCertificacion(string certifiacion)
    {
        this.certificacion = certifiacion;
    }

    public override string MostrarSinCasa()
    {
        return base.MostrarSinCasa() + "Certificado como ecológico: " 
            + certificacion;
    }
    public override string ToString()
    {
        return base.ToString() + " Certificación: " + certificacion;
    }
}
