using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    CrudAnimal cudAnimal = new CrudAnimal();
    
    [WebMethod]
    public bool RegistrarAnimal(int id_tipo_animal, string id_usuario, int id_estado, int id_animal_genero, string ani_nombre, string ani_edad, string ani_tamano)
    {
        return cudAnimal.RegistrarAnimal(new Animal(id_tipo_animal, id_usuario, id_estado, id_animal_genero, ani_nombre, ani_edad, ani_tamano));
    }

    [WebMethod]
    public bool ModificarAnimal(int id_animal,int id_tipo_animal, string id_usuario, int id_estado, int id_animal_genero, string ani_nombre, string ani_edad, string ani_tamano)
    {
        return cudAnimal.ModificarAnimal(id_animal, new Animal(id_tipo_animal, id_usuario, id_estado, id_animal_genero, ani_nombre, ani_edad, ani_tamano));
    }

    [WebMethod]
    public bool EliminarAnimal(int id_animal)
    {
        return cudAnimal.EliminarAnimal(id_animal);
    }

    [WebMethod]
    public bool AnimalAdoptado(int id_animal, string id_usuario)
    {
        return cudAnimal.AnimalAdoptado(id_animal, id_usuario);
    }

    [WebMethod]
    public DataSet AnimalesAdoptados()
    {
        return cudAnimal.AnimalesAdoptados();
    }

    [WebMethod]
    public DataSet AnimalesAdoptadosTipo(int id_tipo_animal)
    {
        return cudAnimal.AnimalesAdoptadosTipo(id_tipo_animal);
    }

    [WebMethod]
    public DataSet AnimalesPorAdoptar()
    {
        return cudAnimal.AnimalesPorAdoptar();
    }

    [WebMethod]
    public DataSet AnimalesPorAdoptarBusquedaAvanzada(string id_tipo_animal, string ani_edad, string id_animal_genero, string ani_tamano)
    {
        return cudAnimal.AnimalesPorAdoptarBusquedaAvanzada(id_tipo_animal, ani_edad, id_animal_genero, ani_tamano);
    }
}