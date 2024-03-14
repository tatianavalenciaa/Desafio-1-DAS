using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Entidades {
    public class Usuario {

        public string User {  get; set; }
        public string Pass {  get; set; }
        public bool PrefiereProgramas { get; set; }
        public bool PrefiereLibros { get; set; }
        public bool PrefiereLenguajes {  get; set; }

        public Usuario() {}
    }
}
