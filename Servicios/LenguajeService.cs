using Desafio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Servicios {
    public class LenguajeService {

        public List<Lenguaje> ObtenerLenguajes() {

            // como no tenemos base de datos, crearemos una lista de 3 programas quemados.

            List<Lenguaje> lenguajes = new List<Lenguaje>();

            // creando lenguaje 1

            Lenguaje lenguaje1 = new Lenguaje();
            lenguaje1.NombreImagen = "python";
            lenguaje1.TituloEnIngles = "PYTHON";
            lenguaje1.Desarrolladores = "Python Software Foundation";
            lenguaje1.Extenciones = ".py, .pyc, .pyd, .pyo, .pyw, .pyz";
            lenguaje1.AparecioEn = "1991";
            lenguaje1.SistemaOperativo = "Multiplataforma";
            lenguaje1.Paradigma = "Multiparadigma: orientado aobjetos, imperativo, funcional,reflexivo";
            lenguaje1.UltimaVersion = "3.8.3";
            lenguaje1.Licencia = "Python Software FoundationLicense";
            lenguaje1.Porcentaje = "47";

            // creando lenguaje 2

            Lenguaje lenguaje2 = new Lenguaje();
            lenguaje2.NombreImagen = "java";
            lenguaje2.TituloEnIngles = "JAVA";
            lenguaje2.Desarrolladores = "James Gosling y SunMicrosystems";
            lenguaje2.Extenciones = "java, class, jar, jad y jmod";
            lenguaje2.AparecioEn = "1996";
            lenguaje2.SistemaOperativo = "Multiplataforma";
            lenguaje2.Paradigma = "Orientado a objetos, imperativo";
            lenguaje2.UltimaVersion = "14.01";
            lenguaje2.Licencia = "GNU GPL / Java CommunityProcess";
            lenguaje2.Porcentaje = "38";

            // creando lenguaje 3

            Lenguaje lenguaje3 = new Lenguaje();
            lenguaje3.NombreImagen = "javascript";
            lenguaje3.TituloEnIngles = "JAVASCRIPT";
            lenguaje3.Desarrolladores = "xx";
            lenguaje3.Extenciones = ".js";
            lenguaje3.AparecioEn = "1995";
            lenguaje3.SistemaOperativo = "xx";
            lenguaje3.Paradigma = "Multiparadigma, programaciónfuncional,1 programación basadaenprototipos, imperativo, interpretado (scripting)";
            lenguaje3.UltimaVersion = "ECMAScript2016";
            lenguaje3.Licencia = "xx";
            lenguaje3.Porcentaje = "15";

            // agregando los lenguajes a la lista

            lenguajes.Add(lenguaje1);
            lenguajes.Add(lenguaje2);
            lenguajes.Add(lenguaje3);

            return lenguajes;
        }
    }
}
