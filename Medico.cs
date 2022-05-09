using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClinica
{
    internal class Medico:Persona
    {
        private int especialidad;
        private double costoConsulta;

        public Medico(string nombre, string sexo, int dni, int telefono, int especialidad,double costoConsulta)
                        :base(nombre,sexo,dni,telefono)
        {
            this.especialidad = especialidad;   
            this.costoConsulta = costoConsulta;
        }

        public Medico():base()
        {
            especialidad=0;
            costoConsulta=0;
        }

        public int pEspecialidad
        { get { return especialidad; } set { especialidad = value; } }

        public double pCostoConsulta
        { get { return costoConsulta; } set { } }

        public string Especialidad()
        {
            string auxesp = "";
            if (especialidad == 1)
                auxesp = "Traumatologia";
            else if (especialidad == 2)
                auxesp = "Pediatria";
            else if (especialidad == 3)
                auxesp = "Cardiologia";
            else auxesp = "Sin especialidad";

            return auxesp;
        }

     

        
            
            

        

        public override string ToString()
        {
            return "\nMEDICO---------------------\n"+base.ToString() + "\nEspecialidad: " +Especialidad() +"\nCosto de consulta: $" + pCostoConsulta;
        }

    }
}
