using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MunozPortilloAlejandro_Examen_Recup_ED.Interfaces;

namespace MunozPortilloAlejandro_Examen_Recup_ED.Modelos
{
    public abstract class Animal : IPesable
    {
        protected String _Nombre;
        protected String _FechaNacimiento;
        protected double _Peso;
        protected String _Comentarios;


        public Animal(String nombre, String fechanacimiento, double peso)
        {
            _Nombre = nombre;
            _FechaNacimiento = fechanacimiento;
            _Peso = peso;
            //Comentarios Vacio
            _Comentarios = "";

        }
        //Heredado de Ipesable
        public void Pesar(double peso)
        {
            _Peso = peso;
        }

        //Getters  y Setters
        public string GetSetNombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    throw new Exception("Campo Nombre Vacio");
                }

                else { _Nombre = value; }
            }
        }

        public string GetSetFechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("CampoFecha vacia");
                }
                else { _FechaNacimiento = value; }
            }
        }
        public double GetSetPeso
        {
            get
            {
                return _Peso;
            }
            set
            {

                if (value < 1 || value >= 190)

                {
                    throw new System.SystemException("Fuera de Rango");

                }

                else { _Peso = value; }
            }
        }

        public string GetSetComentarios
        {
            get
            {
                return _Comentarios;
            }
            set
            {
                _Comentarios = value;
            }
        }
        //Constructor Animal
        public override string ToString()
        {
            return ("Animal [nombre=" + GetSetNombre + "\n fechaNac=" + GetSetFechaNacimiento + "\n peso=" + GetSetPeso + "\n comentarios=" + GetSetComentarios
                + "]");
        }


    }
}