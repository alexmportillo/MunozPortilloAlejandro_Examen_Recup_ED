using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MunozPortilloAlejandro_Examen_Recup_ED.Modelos;

namespace MunozPortilloAlejandro_Examen_Recup_ED
{
    class Program
    {
        private static ClinicaVeterinaria CL;

        static void Main(string[] args)
        {
            CL = new ClinicaVeterinaria("Clinica Don Mascota");
            CL.MenuPrincipal();
        }
    }
}
