using LogicaServicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CrudAnimal
/// </summary>

namespace LogicaNegocio
{
	public class CrudAnimal
	{
		BD dataBase = new BD();

        public bool RegistrarAnimal(Animal animal)
        {
            string lsql = "INSERT animal " +
                "(id_tipo_animal, id_usuario, id_estado, id_animal_genero, ani_nombre, ani_edad, ani_tamano) VALUES ("+
            	animal.Id_tipo_animal +", '" +
            	animal.Id_usuario +"', " +
                animal.Id_estado +", " +
                animal.Id_animal_genero +", '" +
                animal.Ani_nombre +"', " +
                animal.Ani_edad +", " +
                animal.Ani_tamano +")";
            return dataBase.EjecutarDML(lsql);
        }

        public bool ModificarAnimal(int id_animal, Animal animal)
        {
        	string lsql = "UPDATE animal SET "+
					"id_tipo_animal = "+ animal.Id_tipo_animal +", "+
					"id_usuario = '"+ animal.Id_usuario +"', "+
					"id_estado = "+ animal.Id_estado +", "+
					"id_animal_genero = "+ animal.Id_animal_genero +", "+
					"ani_nombre = '"+ animal.Ani_nombre +"', "+
					"ani_edad = "+ animal.Ani_edad +", "+
					"ani_tamano = "+ animal.Ani_tamano +
                    "WHERE  id_animal = " + id_animal;
			return dataBase.EjecutarDML(lsql);
        }

        public bool EliminarAnimal(int id_animal)
        {
			return dataBase.EjecutarDML("DELETE FROM animal WHERE id_animal="+id_animal);
        }

        public bool AnimalAdoptado(int id_animal, string id_usuario){
    		string lsql = "UPDATE animal SET "+
					"id_usuario = '"+ id_usuario +"', "+
					"id_estado = 2 "+
                    "WHERE  id_animal = " + id_animal;
			return dataBase.EjecutarDML(lsql);
        }

        public DataSet AnimalesAdoptados(){
        	return BD.EjecutarSelect("select * from animal where id_estado = 2");
		}

		public DataSet AnimalesAdoptadosTipo(int id_tipo_animal){
        	return BD.EjecutarSelect("select * from animal where id_estado = 2 and id_tipo_animal = "+id_tipo_animal);
		}

		public DataSet AnimalesPorAdoptar(){
			return BD.EjecutarSelect("select * from animal where id_estado = 1");
		}

		public DataSet AnimalesPorAdoptarBusquedaAvanzada(string id_tipo_animal, string ani_edad, string id_animal_genero, string ani_tamano)
		{
			string lsql = "select * from animal where id_estado = 2 ";
			if(id_tipo_animal != ""){
				lsql += "and id_tipo_animal = " + id_tipo_animal;
			}
			if(ani_edad != ""){
				lsql += "and ani_edad = " + ani_edad;
			}
			if(id_animal_genero != ""){
				lsql += "and id_animal_genero = " + id_animal_genero;
			}
			if(ani_tamano != ""){
				lsql += "and ani_tamano = " + ani_tamano;
			}
            return BD.EjecutarSelect(lsql);
		}
	}
}