using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Json
{
    public class Alumno:Principal
    {
        public string Carne { get; set; }
        public List<int> Notas { get; set; }

    }
}