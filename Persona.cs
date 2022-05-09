using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClinica
{
    internal class Persona
    {   
        protected string nombre;
        protected string sexo;
        protected int dni;
        protected int telefono;


        public Persona()
        {
            nombre = "";
            sexo = "";
            dni = 0;
            telefono = 0;
        }



        public Persona(string nombre, string sexo, int dni, int telefono)
        {
             this.nombre = nombre;
             this.sexo = sexo;
             this.dni = dni;
             this.telefono = telefono;
        } 
        
        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int pDni
        {
            get { return dni; }
            set { dni = value; }
        } 
        
        public int pTelefono
        {
            get { return telefono; }set { telefono =value;}
        } 

        
        public override string ToString()
        {
            return "Nombre: " + nombre + "\n" + "Edad: " + sexo + "\n" + "DNi:  "+dni+ "\n" + "Telefono: "
                + telefono;                
        }

   

    }
}
