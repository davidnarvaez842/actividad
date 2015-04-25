using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Entidad
/// </summary>

namespace LogicaNegocio
{
    public class Entidad
    {
        private int id_entidad;
        private int id_tipo_entidad;
        private int id_usuario;
        private string ent_nombre;
        private string ent_ubicacion;
        private string ent_telefono;
        private string ent_facebook;
        private string ent_twitte;

        public Entidad(int id_entidad, int id_tipo_entidad, int id_usuario, string ent_nombre, string ent_ubicacion, string ent_telefono, string ent_facebook, string ent_twitte)
        {
            this.id_entidad = id_entidad;
            this.id_tipo_entidad = id_tipo_entidad;
            this.id_usuario = id_usuario;
            this.ent_nombre = ent_nombre;
            this.ent_ubicacion = ent_ubicacion;
            this.ent_telefono = ent_telefono;
            this.ent_facebook = ent_facebook;
            this.ent_twitte = ent_twitte; 
        }

        public int Id_entidad
        {
            get{return id_entidad;}
            set{id_entidad = value;}
        }

        public int Id_tipo_entidad
        {
            get{return id_tipo_entidad;}
            set{id_tipo_entidad = value;}
        }

        public int Id_usuario
        {
            get{return id_usuario;}
            set{id_usuario = value;}
        }

        public string Ent_nombre
        {
            get{return ent_nombre;}
            set{ent_nombre = value;}
        }

        public string Ent_ubicacion
        {
            get{return ent_ubicacion;}
            set{ent_ubicacion = value;}
        }

        public string Ent_telefono
        {
            get{return ent_telefono;}
            set{ent_telefono = value;}
        }

        public string Ent_facebook
        {
            get{return ent_facebook;}
            set{ent_facebook = value;}
        }

        public string Ent_twitte
        {
            get{return ent_twitte;}
            set{ent_twitte = value;}
        }
    }
}