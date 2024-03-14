using Desafio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Servicios {
    public class LibroService {

        public List<Libro> ObtenerLibros() {

            // como no tenemos base de datos, crearemos una lista de 3 programas quemados.

            List<Libro> libros = new List<Libro>();

            // creando libro 1

            Libro libro1 = new Libro();
            libro1.NombreImagen = "harry-potter";
            libro1.TituloEnIngles = "HARRYPOTTER";
            libro1.Autor = "J. K. Rowling";
            libro1.Genero = "Novela";
            libro1.SubGenero = "Literatura fantástica, literaturajuvenil, novela dedesarrolloy literatura infantil yjuvenil";
            libro1.NumeroPagina = "3407 (ENG)3665 (ESP)";
            libro1.Protagonista = "Harry PotterRon weasleyHermione GrangerGinny WeasleyNeville LongbottomAlbus Dumbledore";
            libro1.Antagonista = "Lord VoldemortMortífagos";
            libro1.Argumento = "La historia comienza con lacelebración del mundo mágico.Durante muchos años, había sidoaterrorizado por elmalvado mago Lord Voldemort.La noche del 31 de octubre,mató a Lilyy James Potter. Sinembargo, cuando intenta matar asu hijo de 1 año, Harry, lamaldición asesina AvadaKedavra se vuelve sobre símismo. El cuerpo de Voldemortresulta destruido, pero élsobrevive: no está muerto nivivo. Por su parte, a Harry solole queda una cicatriz con formade rayo en la frente que es elúnico remanente físico de lamaldición de Voldemort. Harryes el único sobreviviente de lamaldición asesina, y a raíz de lamisteriosa derrota de Voldemort,el mundo mágico empieza allamarlo como «el niño quesobrevivió».";
            libro1.Porcentaje = "44";

            // creando libro 2

            Libro libro2 = new Libro();
            libro2.NombreImagen = "goosebumps";
            libro2.TituloEnIngles = "GOOSEBUMPS";
            libro2.Autor = "Robert Lawrence Stine";
            libro2.Genero = "Ciencia ficción, literaturainfantil y suspenso";
            libro2.SubGenero = "Suspenso, terror, juvenil";
            libro2.NumeroPagina = "---";
            libro2.Protagonista = "El protagonista principal de unahistoria de Pesadillas /Escalofríos, es a menudo situadoen una ubicación remota o dealguna manera aislada enalgunas situaciones.";
            libro2.Antagonista = "----";
            libro2.Argumento = "La serie consta de un total de 60libros para España, el último delos cuales (Sangre de monstruoIV) se publicó en 1999, mientrasque en Hispanoamérica constade 45 historias.El nombre se tradujo en Españacomo Pesadillas y enHispanoaméricacomo Escalofríos.";
            libro2.Porcentaje = "30";

            // creando libro 3

            Libro libro3 = new Libro();
            libro3.NombreImagen = "perry-mason";
            libro3.TituloEnIngles = "PERRYMASON";
            libro3.Autor = "Erle Stanley Gardner";
            libro3.Genero = "Novela policiaca";
            libro3.SubGenero = "xx";
            libro3.NumeroPagina = "xx";
            libro3.Protagonista = "Perry Mason";
            libro3.Antagonista = "xx";
            libro3.Argumento = "El personaje era un abogado quellegó a aparecer en 80 novelas ehistorias cortas, la mayoría delas cuales versaban sobre ladefensa de un cliente que habíasido acusado de asesinato. Engeneral, Perry Mason era capazde demostrar la inocencia de sucliente mediante la averiguaciónde la culpabilidad del verdaderoasesino, otro personaje de lahistoria.";
            libro3.Porcentaje = "26";
            // agregando los libros a la lista

            libros.Add(libro1);
            libros.Add(libro2);
            libros.Add(libro3);

            return libros;
        }
    }
}
