using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunozPortilloAlejandro_Examen_Recup_ED.Modelos
{
    public class ClinicaVeterinaria
    {
        //Nombre Clinica Veterinaria
        private String _Nombre;
        public List<Animal> ListaDeAnimales;

        public ClinicaVeterinaria(String nombre)
        {
            _Nombre = nombre;
            ListaDeAnimales = new List<Animal>();
        }


        //Metodos de Validacion
        //LEER Numero para Validar las Opciones de los Menus
        public static int ValidarNumero()
        {
            string entrada = "";
            int entero = 0;
            bool error = false;

            do
            {
                Console.WriteLine("Introduzca numero:");

                entrada = Console.ReadLine();
                error = Int32.TryParse(entrada, out entero);
                if (!error)
                    Console.WriteLine("Error no has introducido un numero");

            } while (!error);
            return entero;
        }

        //Leer Double para Validar los Valores que sean Double(por ejemplo,Peso)

        public static double ValidarDouble()
        {

            string entrada = "";
            double num = 0;
            bool error = false;

            do
            {
                Console.WriteLine("Introduzca numero:");

                entrada = Console.ReadLine();
                error = double.TryParse(entrada, out num);
                if (!error)
                    Console.WriteLine("Error no has introducido un numero");

            } while (!error);
            return num;
        }


        //Menus
        //Menu Principal
        public void MenuPrincipal()
        {

            int OpcionesMenuPrincipal;
            do
            {
                Console.WriteLine("Bienvenido a la Clinica [" + _Nombre + "]");

                Console.WriteLine();
                Console.WriteLine("*******MENU PRINCIPAL*************");
                Console.WriteLine("*******1.Add animal***************");
                Console.WriteLine("*******2.Modificar comentarios****");
                Console.WriteLine("*******3.Pesar Animal*************");
                Console.WriteLine("*******4.Ver ficha****************");
                Console.WriteLine("*******5.Salir********************");
                Console.WriteLine("*******MENU PRINCIPAL*************");
                OpcionesMenuPrincipal = ValidarNumero();
                Console.Clear();
                switch (OpcionesMenuPrincipal)
                {

                    case 1:
                        aniadirAnimal();
                        break;

                    case 2:
                        InsertComentarios();
                        
                        break;

                    case 3:
                        //Pesar Animal
                        ModifiPeso();
                        break;

                    case 4:
                        buscarAnimal();
                        break;
                    case 5:
                        Console.WriteLine(" Gracias por su visita\n" 
                        + " Esperos que vuelva a su " + _Nombre + "\n Estamos para lo que usted quiera");
                        break;

                    default:
                        Console.WriteLine("[ERROR] Nada que decir");
                        break;
                }
            } while (OpcionesMenuPrincipal != 5);
        }
        //Menu 2(Menu Animales)
        private int MenuElegirAnimal()
        {

            int OpcionesAnimal;
            do
            {
                Console.WriteLine();
                Console.WriteLine("*******SELECCION ANIMAL*******");
                Console.WriteLine("*******1.Perro****************");
                Console.WriteLine("*******2.Gato*****************");
                Console.WriteLine("*******3.Pajaro***************");
                Console.WriteLine("*******4.Reptil***************");
                Console.WriteLine("*******TIPO ANIMAL************");

                OpcionesAnimal = ValidarNumero();
            } while (OpcionesAnimal < 1 || OpcionesAnimal > 5);
            return OpcionesAnimal;
        }


        //Metodo que pide los datos del animal seleccionado en el switch y los insertará en la Lista.
        private void aniadirAnimal()
        {
            String nombre;
            String fechaNacimiento = "";
            double peso;
            int day;
            int month;
            int year;
            int temporal;

            int opcion = MenuElegirAnimal();

            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Dia nacimiento:");
            day = ValidarNumero();
            Console.WriteLine("Mes nacimiento:");
            month = ValidarNumero();
            Console.WriteLine("Anio nacimiento:");
            year = ValidarNumero();
            Console.WriteLine("Peso:");
            peso = ValidarDouble();
            //Guardamos en un string la fecha completa (Temporal Fecha)
            string temporalFecha = day.ToString();
            //Lo añadimos todo en la variable fecha
            fechaNacimiento += (day.ToString() + "/" + month.ToString() + "/" + year.ToString());

            switch (opcion)
            {
                case 1:
                    String razaPE;
                    String microchipPE;
                    Console.WriteLine("Raza:");
                    razaPE = Console.ReadLine();
                    Console.WriteLine("Numero microchip:");
                    temporalFecha = Console.ReadLine();
                    microchipPE = temporalFecha.ToString();
                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    Perro PE = new Perro(nombre, fechaNacimiento, peso, razaPE, microchipPE);
                    //Añadimos Animal Perro a la lista "Lista de Animales"
                    ListaDeAnimales.Add(PE);
                    break;
                case 2:
                    String razaGA;
                    String microchipGA;
                    Console.WriteLine("Raza:");
                    razaGA = Console.ReadLine();
                    Console.WriteLine("Numero microchip:");
                    temporalFecha = Console.ReadLine();
                    microchipGA = temporalFecha.ToString();
                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    Gato GA = new Gato(nombre, fechaNacimiento, peso, razaGA, microchipGA);
                    ListaDeAnimales.Add(GA);
                    break;
                case 3:
                    String especiePa;
                    bool cantor = false;
                    Console.WriteLine("Raza:");
                    especiePa = Console.ReadLine();
                    Console.WriteLine("Canta: (1. si / 2. no)");
                    do
                    {
                        temporal = ValidarNumero();
                    } while (temporal < 1 || temporal > 2);
                    if (temporal == 1)
                    {
                        cantor = true;
                    }
                    else if (temporal == 2)
                    {
                        cantor = false;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] Nada que decir ");
                    }
                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    Pajaro PA = new Pajaro(nombre, fechaNacimiento, peso, especiePa, cantor);
                    //Añadimos Animal Pajaro a la lista "Lista de Animales"
                    ListaDeAnimales.Add(PA);
                    break;
                case 4:

                    String especieRE;
                    bool venenoso = false;
                    Console.WriteLine("Especie:");
                    especieRE = Console.ReadLine();
                    Console.WriteLine("Es venenoso: (1. si / 2. no)");
                    do
                    {
                        temporal = ValidarNumero();
                    } while (temporal < 1 || temporal > 2);
                    if (temporal == 1)
                    {
                        venenoso = true;
                    }
                    else if (temporal == 2)
                    {
                        venenoso = false;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] Nada que decir ");
                    }
                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    Reptil RE = new Reptil(nombre, fechaNacimiento, peso, especieRE, venenoso);
                    //Añadimos Animal Reptil a la lista "Lista de Animales"
                    ListaDeAnimales.Add(RE);
                    break;
            }
        }

        //Buscar Animal

        private void buscarAnimal()
        {


            Console.WriteLine("Nombre de la mascota: ");
            String temporal = Console.ReadLine();
            Animal Buscar = null;

            foreach (Animal Anim in ListaDeAnimales)
            {
                if (Anim.GetSetNombre.ToUpper().Equals(temporal.ToUpper()))
                {
                    Buscar = Anim;
                }
            }
            // Si se encuentra, lo muestra.
            if (Buscar != null && ListaDeAnimales.Contains(Buscar))
            {

                Console.WriteLine(Buscar.ToString());

            }
            else
            {
                Console.WriteLine("La mascota: " + temporal + " no aparece en la base de datos");
            }
        }
        //Podemos añadir o modificar comentarios
        private void InsertComentarios()
        {
            if (ListaDeAnimales.Count == 0)
            {
                Console.WriteLine("No hay animales ingresados.");
            }
            else
            {

                Console.WriteLine("Nombre de la mascota: ");
                String temporal = Console.ReadLine();
                Animal Buscar = null;
                foreach (Animal ANIM in ListaDeAnimales)
                {
                    if (ANIM.GetSetNombre.ToUpper().Equals(temporal.ToUpper()))
                    {
                        Buscar = ANIM;
                    }
                }
                // Si se encuentra,permite modificar el nuevo comentario
                if (Buscar != null && ListaDeAnimales.Contains(Buscar))
                {

                    String comentarios;
                    Console.WriteLine("Introduzca o modifique el nuevo comentario:");
                    comentarios = Console.ReadLine();
                    Buscar.GetSetComentarios = comentarios;
                    

                }
                else
                {
                    Console.WriteLine("La mascota: " + temporal + " no aparece en la base de datos");
                }

            }

        }
        //Modificar Peso

            //Lo realiza cuando te vuelve a pedir el nombre
            //Pero me suma un valor no me lo modifica
            //Depende la opcion me salta una cosa diferente
            //Pero todo Funciona Perfectamente
        private void ModifiPeso()
        {
            {
                if (ListaDeAnimales.Count == 0)
                {
                    Console.WriteLine("No hay animales ingresados.");
                }
                else
                {

                    Console.WriteLine("Nombre de la mascota: ");
                    String temporal = Console.ReadLine();
                    Animal Buscar = null;
                    foreach (Animal ANIM in ListaDeAnimales)
                    {
                        if (ANIM.GetSetNombre.ToUpper().Equals(temporal.ToUpper()))

                        {
                            Buscar = ANIM;
                        }
                    }
                    // Si se encuentra,permite modificar el nuevo Peso
                    if (Buscar != null && ListaDeAnimales.Contains(Buscar))
                    {

                        double Pesa;
                        Console.WriteLine("Introduzca nuevo Peso:");
                        Pesa= Console.Read();
                        Buscar.GetSetPeso = Pesa;

                    }
                    else
                    {
                        Console.WriteLine("La mascota: " + temporal + " no aparece en la base de datos");
                    }

                }

            }
        }

    }
}

