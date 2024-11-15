using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessRol
    {
        private DataRol objCapaData = new DataRol();
        public List<Rol> ListarRol()
        {
            return objCapaData.ListarRol();
        }


        public int Registrar(Rol obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "La descripcion de la categoria no puede ser vacio";
            }



            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCapaData.Registrar(obj, out Mensaje);

            }
            else
            {

                return 0;
            }
        }

        public bool Editar(Rol obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "La descripcion de la categoria no puede ser vacio";
            }


            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCapaData.Editar(obj, out Mensaje);
            }
            else
            {
                return false;
            }
        }



        public bool Eliminar(int id, out string Mensaje)
        {
            return objCapaData.Eliminar(id, out Mensaje);
        }
      
    }
}
