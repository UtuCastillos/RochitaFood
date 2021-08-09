using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Usuario
    {
        // Creamos los atributos de la clase usuario

        private int idUsuario;
        private string accion;
        private string nombre;
        private string password;
        private string loginStatus;
        private DateTime registerDate;

        // Creamos el constructor y dejamos los atributos privados visibles
        public Usuario(int idUsuario, string nombre, string password, string loginStatus, DateTime registerDate, string accion)
        {

            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.password = password;
            this.loginStatus = loginStatus;
            this.registerDate = registerDate;
            this.accion = accion;




        }

        
      
        // Creamos los metodos que vamos a utilizar
        public bool verifyLogin()
        {
            return true;

        }


    }
}
