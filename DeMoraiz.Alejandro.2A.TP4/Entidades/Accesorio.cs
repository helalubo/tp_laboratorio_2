using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Accesorio : Producto
    {

        private EGama gama;
        private ETipo tipo;



        public Accesorio()
        {
            
        }


        public Accesorio(int id, string nombre, float precio, int cantidad, EGama gama,ETipo tipo): base( id,  nombre,  precio,  cantidad)
        {
            this.gama = gama;
            this.tipo = tipo;
        }






        public enum EGama
        {
            baja,
            media,
            mediaAlta,
            alta,
            otro


        }

        public enum ETipo
        {
            AccesorioGuitarra,
            AccesorioBateria,
            AccesorioTeclado,
            AccesorioBajo,
            Accesoriootro


        }

    }
}
