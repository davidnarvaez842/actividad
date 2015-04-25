using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Animal
/// </summary>

namespace LogicaNegocio
{
    public class Animal
    {
        private int id_animal;
        private int id_tipo_animal;
        private string id_usuario;
        private int id_estado;
        private int id_animal_genero;
        private string ani_nombre;
        private string ani_edad;
        private string ani_tamano;

        public Animal(){

        }

        public Animal(int id_tipo_animal, string id_usuario, int id_estado, int id_animal_genero, string ani_nombre, string ani_edad, string ani_tamano)
        {
            this.id_tipo_animal = id_tipo_animal;
            this.id_usuario = id_usuario;
            this.id_estado = id_estado;
            this.id_animal_genero = id_animal_genero;
            this.ani_nombre = ani_nombre;
            this.ani_edad = ani_edad;
            this.ani_tamano = ani_tamano;
        }

        public int Id_animal
        {
            get{return id_animal;}
            set{id_animal = value;}
        }

        public int Id_tipo_animal
        {
            get{return id_tipo_animal;}
            set {id_tipo_animal = value; }
        }

        public string Id_usuario
        {
            get{return id_usuario;}
            set{id_usuario = value;}
        }

        public int Id_estado
        {
            get{return id_estado;}
            set{id_estado = value;}
        }

        public int Id_animal_genero
        {
            get{return id_animal_genero;}
            set {id_animal_genero = value; }
        }

        public string Ani_nombre
        {
            get{return ani_nombre;}
            set{ani_nombre = value;}
        }

        public string Ani_edad
        {
            get{return ani_edad;}
            set{ani_edad = value;}
        }

        public string Ani_tamano
        {
            get{return ani_tamano;}
            set{ani_tamano = value;}
        }
    }
}