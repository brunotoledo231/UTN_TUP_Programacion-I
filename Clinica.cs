using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClinica
{
    internal class Clinica
    {
        private string nombreClinica;
        private Medico[] medicos;
        private Paciente[] pacientes;

        public Clinica(int cantidadMed, int cantidadPac)
        {
            nombreClinica = "";
            medicos = new Medico[cantidadMed];
            pacientes = new Paciente[cantidadPac];
        }

        public string pNombreClinica
        { get { return nombreClinica; }set { nombreClinica = value; } }

        public void AgregarMedicos(Medico oMedico)
        {
            
            for (int i = 0; i < medicos.Length; i++)
            {
                if (medicos[i] == null)
                {
                    medicos[i] = oMedico;
                   
                    break;
                }
            }

        }

        public int ContadorMedicos()
        {
            int contadorMedicos = 0;
            for(int i=0;i<medicos.Length;i++)
            if (medicos[i] != null)
               contadorMedicos++;
            return contadorMedicos;
        }


        public void AgregarPacientes(Paciente oPaciente)
        {
            int contadorPacientes = 0;
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] == null)
                {
                    pacientes[i] = oPaciente;
                    contadorPacientes++;
                    break;
                }
            }
        }

        public int ContadorPacientes()
        {
            int contadorPacientes = 0;
            for (int i = 0; i < pacientes.Length; i++)
                if (pacientes[i] != null)
                    contadorPacientes++;
            return contadorPacientes;
        }

        public double CostoPromedioConsultas()
        {
            double acumulador = 0;
            double promedioConsultas = 0;
            for (int i = 0; i < medicos.Length; i++)
                acumulador = acumulador + medicos[i].pCostoConsulta ;
                promedioConsultas=acumulador/ContadorMedicos();
            return promedioConsultas;
        }

        public double PorcentajeObraSocial()
        {
            double contadorOsde = 0;
            for(int i=0;i<pacientes.Length;i++)
            if (pacientes[i].pObraSocial == 1)
                contadorOsde++;
             double porcentajeOsde = contadorOsde * 100 / ContadorPacientes();
            return porcentajeOsde;
        }

        public override string ToString()
        {
            string aux1 = "";

            for (int i = 0; i < medicos.Length; i++)
            {
                if (medicos[i] != null) //esto es fundamental para procesar el vector de objetos!!!
                {
                    aux1 += medicos[i].ToString() + "\n";
                }
            }
            string aux2 = "";

            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] != null) //esto es fundamental para procesar el vector de objetos!!!
                {
                    aux2 += pacientes[i].ToString() + "\n";
                }
            }

            return aux1+"\n"+aux2;
        }


    }
}
