using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>

namespace LogicaNegocio
{
    public class Usuario
    {
        private int id_usuario;
        private int id_genero;
        private string usu_contrasena;
        private string usu_nombre;
        private string usu_apellido;
        private string usu_fecha_nacimiento;
        private string usu_telefono;
        private string usu_ubicacion;
        private string usu_facebook;
        private string usu_twitter;

        public Usuario()
        {

        }

        public Usuario(int id_usuario, int id_genero, string usu_contrasena, string usu_nombre, string usu_apellido, string usu_fecha_nacimiento, string usu_telefono, string usu_ubicacion, string usu_facebook, string usu_twitter)
        {
            this.id_usuario = id_usuario;
            this.id_genero = id_genero;
            this.usu_contrasena = usu_contrasena;
            this.usu_nombre = usu_nombre;
            this.usu_apellido = usu_apellido;
            this.usu_fecha_nacimiento = usu_fecha_nacimiento;
            this.usu_telefono = usu_telefono;
            this.usu_ubicacion = usu_ubicacion;
            this.usu_facebook = usu_facebook;
            this.usu_twitter = usu_twitter;
        }

        public int Id_usuario
        {
            get{return id_usuario;}
            set{id_usuario = value;}
        }

        public int Id_genero
        {
            get{return id_genero;}
            set{id_genero = value;}
        }

        public string Usu_contrasena
        {
            get{return usu_contrasena;}
            set{usu_contrasena = value;}
        }

        public string Usu_nombre
        {
            get{return usu_nombre;}
            set{usu_nombre = value;}
        }

        public string Usu_apellido
        {
            get{return usu_apellido;}
            set{usu_apellido = value;}
        }

        public string Usu_fecha_nacimiento
        {
            get{return usu_fecha_nacimiento;}
            set{usu_fecha_nacimiento = value;}
        }

        public string Usu_telefono
        {
            get{return usu_telefono;}
            set{usu_telefono = value;}
        }

        public string Usu_ubicacion
        {
            get{return usu_ubicacion;}
            set{usu_ubicacion = value;}
        }

        public string Usu_facebook
        {
            get{return usu_facebook;}
            set{usu_facebook = value;}
        }

        public string Usu_twitter
        {
            get{return usu_twitter;}
            set{usu_twitter = value;}
        }
    }
}