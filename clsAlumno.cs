using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class clsAlumno
    {
        //atributos
        public string nombre;
        public int edad;
        public double nota;
        public string grado;

        //constructor
        public clsAlumno(
            string vNombre,
            int vEdad,
            double vNota,
            string vGrado
        ){
            nombre = vNombre;
            edad = vEdad;
            nota = vNota;
            grado = vGrado;
        }
    }
}
