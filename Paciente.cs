using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClinica
{
    internal class Paciente:Persona
    {
        private int obraSocial;
        private string historiaClinica;

        public Paciente(string nombre, string sexo, int dni, int telefono,int obraSocial,string historiaClinica)
                        :base(nombre,sexo,dni,telefono)
        {
            this.obraSocial = obraSocial;
            this.historiaClinica= historiaClinica;
        }

        public int pObraSocial
        { get { return this.obraSocial; } set { this.obraSocial = value; } }

        public string pHistoriaClinica
        { get { return historiaClinica; }set { historiaClinica = value; } }

        public string ObraSocial()
        {
            string auxesp = "";
            if (obraSocial == 1)
                auxesp = "Apross";
            else if (obraSocial == 2)
                auxesp = "Met";
            else if (obraSocial == 3)
                auxesp = "Osde";
            else if (obraSocial == 4)
                auxesp = "otras";
            else auxesp = "Sin obra social";

            return auxesp;
        }

        public override string ToString()
        {
            return "\nPACIENTE---------------------\n" + base.ToString() + "\nObra Social: " + ObraSocial() + "\nHistoria Clinica: " + pHistoriaClinica;
        }
    }
}
