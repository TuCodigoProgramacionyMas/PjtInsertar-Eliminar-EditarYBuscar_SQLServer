using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjtInsertar_Eliminar_EditarYBuscar
{
    class clsDatos
    {
    }

    public class Articulos
    {
        int idArticulo;
        string Nombre;
        string Precio;

        public Articulos(int idArticulo, string nombre, string precio)
        {
            this.idArticulo = idArticulo;
            Nombre = nombre;
            Precio = precio;
        }
        public Articulos()
        {
            
        }
        public int IdArticulo { get => idArticulo; set => idArticulo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Precio1 { get => Precio; set => Precio = value; }
    }
}
