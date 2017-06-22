using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunozPortilloAlejandro_Examen_Recup_ED.Modelos
{
    class Pajaro : Animal
    {
        private bool _Cantor;
        private String _Especie;



        public Pajaro(String nombre, String fechaNacimiento, double peso, String especie, bool cantor)
            //Hereda de Animal(nombre,fechaNacimiento,
            //peso,super() en JAVA)
            : base(nombre, fechaNacimiento, peso)
        {
            _Especie = especie;
            _Cantor = cantor;

        }
        //Getters y Setters

        public string GetSetCantor
        {
            get
            {
                if (_Cantor)
                    return "Canta Mucho,No me deja dormir";
                else
                    return "Duermo Placidamente";
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
                    throw new Exception("Campo Microchip Vacio");
                }
                else { _Especie = value; }
            }
        }

        //Constructor Pajaro
        public override string ToString()
        {
            return string.Format("Ficha Pajaro\n" + " Nombre: {0}\n Fecha Nacimiento: {1}\n Peso: {2} kg\n Especie: {3}\n Canta: {4}\n Comentarios: {5}\n ", GetSetNombre, GetSetFechaNacimiento, GetSetPeso, GetSetEspecie, GetSetCantor, GetSetComentarios);
        }
    }
}

