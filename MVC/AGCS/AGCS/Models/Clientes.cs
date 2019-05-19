using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGCS.Models
{
    public class Clientes
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _email;
        private int _telefono;
        private int _telefono2;
        private string _localidad;
        private string _direccion;
        private string _provincia;
        private string _letra;
        private int _numero;
        private int _piso;

        public Clientes(int id, string nombre, string apellido, int dni, string email, int telefono, int telefono2, string localidad, string direccion, string provincia, string letra, int numero, int piso)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _email = email;
            _telefono = telefono;
            _telefono2 = telefono2;
            _localidad = localidad;
            _direccion = direccion;
            _provincia = provincia;
            _letra = letra;
            _numero = numero;
            _piso = piso;
        }

        public int Id { get => _id; }
        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; }
        public int Dni { get => _dni; }
        public string Email { get => _email;}
        public int Telefono { get => _telefono;}
        public int Telefono2 { get => _telefono2;}
        public string Localidad { get => _localidad;}
        public string Direccion { get => _direccion;}
        public string Provincia { get => _provincia;}
        public string Letra { get => _letra; }
        public int Numero { get => _numero;}
        public int Piso { get => _piso;}
    }
}
