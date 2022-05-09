using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClinica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            Medico medico1 = new Medico("Braulio","hombre",345555,3455555,1,3400);
            Medico medico2 = new Medico("Lara", "Mujer", 3451, 35785, 2, 2500);
            Medico medico3 = new Medico("Gianlucca", "hombre", 3451115, 3455785, 2,4000);
            Medico medico4 = new Medico("Pedro", "hombre", 3458815, 3458885, 3, 4500);
            Medico medico5 = new Medico("Mariela", "Mujer", 34215, 34285, 1, 4090);

            Paciente paciente1 = new Paciente("eusebio", "H", 23456978,145555, 2, "by pass");
            Paciente paciente2 = new Paciente("horacio", "H", 23458678, 245555, 2, "DIABETES");
            Paciente paciente3 = new Paciente("jose", "H", 23456778, 345355, 3, "tiroides");
            Paciente paciente4 = new Paciente("killian", "H", 23456768, 445555, 4, "dolor de cabeza");
            Paciente paciente5 = new Paciente("leonel", "H", 23456758, 345555, 4, "Operacion de cadera");
            Paciente paciente6 = new Paciente("lucas", "H", 23456718, 345655, 2, "esguince");
            Paciente paciente7 = new Paciente("pedro", "H", 23456278, 345755, 3, "ceguera");
            Paciente paciente8 = new Paciente("ian", "H", 23456748, 345558, 2, "cagadera");
            Paciente paciente9 = new Paciente("eustaquio", "H", 23345678, 945555, 1, "Operacion de cadera");
            Paciente paciente10 = new Paciente("bruno", "H", 233, 9455, 1, "Ligamento cruzado roto");
            Clinica clinica = new Clinica(5,10);

            clinica.AgregarMedicos(medico1);
            clinica.AgregarMedicos(medico2);
            clinica.AgregarMedicos(medico3);
            clinica.AgregarMedicos(medico4);
            clinica.AgregarMedicos(medico5);

            clinica.AgregarPacientes(paciente1);
            clinica.AgregarPacientes(paciente2);
            clinica.AgregarPacientes(paciente3);
            clinica.AgregarPacientes(paciente4);
            clinica.AgregarPacientes(paciente5);
            clinica.AgregarPacientes(paciente6);
            clinica.AgregarPacientes(paciente7);
            clinica.AgregarPacientes(paciente8);
            clinica.AgregarPacientes(paciente9);
            clinica.AgregarPacientes(paciente10);


            Console.WriteLine(clinica.ToString());
            Console.WriteLine("la cantidad de pacientes es: "+clinica.ContadorPacientes());
            Console.WriteLine("la cantidad de medicos son: " + clinica.ContadorMedicos());
            Console.WriteLine("el promedio del costo de la consulta medica es: $" + clinica.CostoPromedioConsultas());
            Console.WriteLine("El porcentaje de pacientes que tienen OSDE son: " + clinica.PorcentajeObraSocial()+"%");








            Console.ReadLine();
        }

    }
}
