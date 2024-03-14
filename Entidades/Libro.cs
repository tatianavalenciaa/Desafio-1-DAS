using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Entidades {
    public class Libro {

        public string NombreImagen { get; set; }
        public string TituloEnIngles { get; set; }
        public string Autor {  get; set; }
        public string Genero { get; set; }
        public string SubGenero { get; set; }
        public string NumeroPagina { get; set;}
        public string Protagonista { get; set;}
        public string Antagonista { get; set;}
        public string Argumento { get; set;}
        public string Porcentaje { get; set; }
        public Libro() { }
    }
}
