using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunozPortilloAlejandro_Examen_Recup_ED.Modelos
{
    
    class Gato : Animal
    {
        private String _Raza;
        private String _Microchip;


        public Gato(String nombre, String fechaNacimiento, double peso, String microchip, String raza)
            //Hereda de Animal(nombre,fechaNacimiento,
            //peso,super() en JAVA)
            : base(nombre, fechaNacimiento, peso)
        {
            _Raza = raza;
            _Microchip = microchip;


        }

        //Getters y Setters
        public string GetSetRaza
        {
            get
            {
                return _Raza;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Raza vacia");
                }
                else { _Raza = value; }
            }
        }

        public string GetSetMicrochip
        {
            get
            {
                return _Microchip;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Campo Microchip vacio");
                }
                else { _Microchip = value; }
            }
        }
        //Constructor Gato
        public override string ToString()
        {
            return string.Format("Ficha Gato\n" + " Nombre: {0}\n Raza: {1}\n Fecha Nacimiento: {2}\n Peso: {3} kg \n Numero Microchip: {4}\n Comentarios: {5}\n", GetSetNombre, GetSetRaza, GetSetFechaNacimiento, GetSetPeso, GetSetMicrochip, GetSetComentarios);
        }



    }
}
