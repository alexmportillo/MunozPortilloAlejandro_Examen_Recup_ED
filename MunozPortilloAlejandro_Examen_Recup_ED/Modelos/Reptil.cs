using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunozPortilloAlejandro_Examen_Recup_ED.Modelos
{
    class Reptil : Animal
    {
        private String _Especie;

        private bool _Venenoso;


        public Reptil(String nombre, String fechaNacimiento, double peso, String especie, bool venenoso)
            //Hereda de Animal(nombre,fechaNacimiento,
            //peso, "super() en JAVA)"
            : base(nombre, fechaNacimiento, peso)
        {

            _Especie = especie;
            _Venenoso = venenoso;

        }

        //Getters y Setters
        public string GetSetVenenoso
        {
            get
            {
                if (_Venenoso)
                    return "Muy Peligrosa, Cuidado!";
                else
                    return "No venenosa";
            }
        }

        public string GetSetEspecie
        {
            get
            {
                return _Especie;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Campo Microchip vacio");
                }
                else { _Especie = value; }
            }
        }

        //Constructor Reptil
        public override string ToString()
        {
            return string.Format("Ficha Reptil\n" + " Nombre: {0}\n Fecha de Nacimiento {1}\n Peso: {2} kg\n Especie: {3}\n Venenoso: {4}\n Comentarios {5}\n", GetSetNombre, GetSetFechaNacimiento, GetSetPeso, GetSetEspecie, GetSetVenenoso, GetSetComentarios);
        }

    }
}
