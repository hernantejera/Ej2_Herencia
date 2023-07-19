using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_Herencia
{
    //Cerveza tiene grado de alcohol y amargor
    public class Cerveza : Bebida
    {
        public double GradoAlcohol { get; set; }
        public double Amargor { get; set; }

    }
}
