using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administrador_alumnos.BLL
{
    class alumnosBLL
    {
        public int ID { get; set; }
        public string Escuela { get; set; }
        public string Año { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materia { get; set; }
        public string Nota { get; set; }
        public byte[] Foto { get; set; }
    }
}
