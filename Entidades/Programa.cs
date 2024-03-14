using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Entidades {
    public class Programa {

        public string NombreImagen { get; set; }
        public string TituloEnIngles {  get; set; }
        public string TituloEnEspanol { get; set; }
        public string CreadoPor { get; set; }
        public string Protagonista { get; set; }
        public string PaisDeOrigen { get; set; }
        public string Temporadas { get; set; }
        public string Episodios { get; set; }
        public string Sipnosis { get; set; }
        public string Porcentaje { get; set; }

        public Programa() { }

    }
}
