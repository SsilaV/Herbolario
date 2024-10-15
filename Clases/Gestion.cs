using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbolarioViolero.Clases
{
    [Serializable]
    class Gestion
    {
        private static List<Producto> productos;

        public Gestion()
        {
            productos = new List<Producto>();
        }

        public static void Insertar(Producto producto)
        {
            productos.Add(producto);
        }

        public static Producto Buscar(int id)
        {
            Producto producto = null;

            foreach (Producto p in productos)
            {
                if (id == p.GetId())
                {
                    producto = p;
                }
            }

            return producto;
        }

        public static Producto Editar(Producto aModificar)
        {
            Producto producto;
            producto = aModificar;
            productos.Remove(aModificar);
            productos.Add(producto);
            return producto;
        }

        public static int CalcularId()
        {
            int id = 0;
            
            foreach (var item in productos)
            {
                if (item.GetId() > id)
                {
                    id = item.GetId();
                }
            }

            return id + 1;
        }

        public static List<Producto> Listar()
        {
            return productos;
        }

        public static void Eliminar(int id)
        {
            for(int i = 0; i < productos.Count; i++)
            {
                if (id == productos[i].GetId())
                {
                    productos.Remove(productos[i]);
                }
            }
        }

        public static List<Producto> Filtrar(string tipo)
        {
            List<Producto> listaFiltrada = new List<Producto>();

            foreach (Producto p in productos)
            {
                Type t = p.GetType();

                switch (tipo)
                {
                    case "Alimentación":
                        if (t.Name == "PAlimentacion")
                        {
                            listaFiltrada.Add(p);
                        }
                        break;
                    
                    case "Ecológico":
                        if (t.Name == "PEcologico")
                        {
                            listaFiltrada.Add(p);
                        }
                        break;

                    case "Adelgazante":
                        if (t.Name == "PAAdelgazante")
                        {
                            listaFiltrada.Add(p);
                        }
                        break;

                    case "Intolerancia":
                        if (t.Name == "PAIntolerancia")
                        {
                            listaFiltrada.Add(p);
                        }
                        break;

                    case "Corporal":
                        if (t.Name == "PCorporal")
                        {
                            listaFiltrada.Add(p);
                        }
                        break;

                    case "Deporte":
                        if (t.Name == "PDeporte")
                        {
                            listaFiltrada.Add(p);
                        }
                        break;

                    case "Suplemento":
                        if (t.Name == "PSuplemento")
                        {
                            listaFiltrada.Add(p);
                        }
                        break;
                }
            }

            return listaFiltrada;
        }
    }
}
