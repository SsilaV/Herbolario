
/* Clase para el registro de casas comerciales a las que se
 * piden productos. */

using System;
using System.Collections.Generic;
using System.IO;

namespace HerbolarioViolero.Clases
{
    [Serializable]
    public class CasaComercial
    {
        private const string FICHERO = "casas.txt";

        private string cif;
        private string nombreCasa;
        private Contacto contacto;

        public CasaComercial(string cif, string nombreCasa, Contacto datos)
        {
            this.cif = cif;
            this.nombreCasa = nombreCasa;
            this.contacto.tlf = datos.tlf;
            this.contacto.email = datos.email;
            this.contacto.direccion = datos.direccion;
        }

        public string GetCif()
        {
            return cif;
        }

        public void SetCif(string cif)
        {
            this.cif = cif;
        }
        public string GetNombreCasa()
        {
            return nombreCasa;
        }

        public void SetNombreCasa(string nombreCasa)
        {
            this.nombreCasa = nombreCasa;
        }

        public Contacto GetTlf()
        {
            return contacto;
        }

        public void SetTlf(Contacto tlf)
        {
            this.contacto = tlf;
        }

        public Contacto GetEmail()
        {
            return contacto;
        }

        public void SetEmail(Contacto email)
        {
            this.contacto = email;
        }
        
        public Contacto GetDireccionl()
        {
            return contacto;
        }

        public void SetDireccion(Contacto direccion)
        {
            this.contacto = direccion;
        }

        public static List<CasaComercial> CargarCasas()
        {
            List<CasaComercial> casas = new List<CasaComercial>();
            string linea;

            if (File.Exists(FICHERO))
            {
                using (StreamReader fichero = new StreamReader(FICHERO))
                {
                    do
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                        {
                            string[] campo = linea.Split(';');
                            Contacto datos;
                            datos.tlf = campo[2];
                            datos.email = campo[3];
                            datos.direccion = campo[4];

                            casas.Add(new CasaComercial(campo[0],
                                campo[1], datos));
                        }
                    } while (linea != null);
                }
            }

            return casas;
        }

        public override string ToString()
        {
            return nombreCasa + " (" + cif + ")\n" 
                + contacto.email
                + "Tlf: " + contacto.tlf
                + "Direccion: " + contacto.direccion;
        }
    }
}