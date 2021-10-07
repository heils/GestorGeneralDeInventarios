using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZambranito.Modelo
{
    class Persona
    {
        int id;
        String nick;
        String nombre;
        String contrasenia;
        String rol;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public String getNick()
        {
            return nick;
        }
        public void setNick(String nick)
        {
            this.nick = nick;
        }

        public String getNombre()
        {
            return nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getContrasenia()
        {
            return contrasenia;
        }
        public void setContrsenia(String contrasenia)
        {
            this.contrasenia = contrasenia;
        }

        public String getRol()
        {
            return rol;
        }
        public void setRol(String rol)
        {
            this.rol = rol;
        }






    }
}
