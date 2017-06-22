using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunozPortilloAlejandro_Examen_Recup_ED.Modelos
{
    class Perro : Animal
    {
        private string _Raza;
        private string _Microchip;



        public Perro(String nombre, String fechaNacimiento, double peso,String raza, String microchip)
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
                if (string.IsNullOrEmpty(value)) { throw new Exception("Raza vacia"); }
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
                if (string.IsNullOrEmpty(value)) { throw new Exception("Micro vacio"); }
                else { _Microchip = value; }
            }
        }

        //Constructor Perro
        public override string ToString()
        {
            //Nombre, raza,fechanacimiento,peso heredados de Animal
            return string.Format("Ficha Perro: \n" + " Nombre: {0}\n Raza: {1}\n Fecha Nacimiento: {2}\n Peso: {3} kg \n Numero Microchip: {4}\n Comentarios: {5}\n", GetSetNombre, GetSetRaza, GetSetFechaNacimiento, GetSetPeso, GetSetMicrochip, GetSetComentarios);
        }




    }
}
