using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            new Usuarios().Menu();
        }
        
    }
    public class Usuarios
    {
        Business.Logic.UsuarioLogic UsuarioNegocio { get; set; }
        public Usuarios ()
        {
            this.UsuarioNegocio = new UsuarioLogic();
        }
        public void Menu()
        {
            Console.WriteLine("1– Listado General\n2– Consulta\n3– Agregar\n4 - Modificar\n5 - Eliminar\n6 - Salir");
        }
       public void ListadoGeneral() 
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }
        public void Consultar()
        {

        }
        public void Agregar()
        {

        }
        public void Mopdificar()
        {

        }
        public void Eliminar()
        {

        }
        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}",usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();
        }

    }
}
