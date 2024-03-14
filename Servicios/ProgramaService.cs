using Desafio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Servicios {
    public class ProgramaService {

        public List<Programa> ObtenerProgramas() {

            // como no tenemos base de datos, crearemos una lista de 3 programas quemados.

            List<Programa> programas = new List<Programa>();

            // creando programa 1

            Programa programa1 = new Programa();
            programa1.NombreImagen = "juego-de-tronos";
            programa1.TituloEnIngles = "GAME OF THRONES";
            programa1.TituloEnEspanol = "Juego de tronos";
            programa1.CreadoPor = "David BenioffD. B. Weiss";
            programa1.Protagonista = "Sean BeanNikolaj Coster-WaldauPeter DinklageEmilia ClarkeLena HeadeyIain GlenKit HaringtonSophie TurnerMaisie WilliamsIsaac Hempstead-WrightNatalie Dormer";
            programa1.PaisDeOrigen = "Estados Unidos";
            programa1.Temporadas = "8";
            programa1.Episodios = "73";
            programa1.Sipnosis = "La trama de Game ofThrones está basada en la seriede novelas Canción de hielo yfuego, y relata las vivencias deun grupo de personajes dedistintas casas nobiliarias en elcontinente ficticio Poniente paratener el control del Trono deHierro y gobernar los sietereinos que conforman elterritorio";
            programa1.Porcentaje = "40";

            // creando programa 2

            Programa programa2 = new Programa();
            programa2.NombreImagen = "chernobyl";
            programa2.TituloEnIngles = "CHERNOBYL";
            programa2.TituloEnEspanol = "Chernóbil";
            programa2.CreadoPor = "Craig Mazin";
            programa2.Protagonista = "Jared HarrisStellan SkarsgårdEmily Watson";
            programa2.PaisDeOrigen = "Estados UnidosReino Unido";
            programa2.Temporadas = "1";
            programa2.Episodios = "5";
            programa2.Sipnosis = "La serie gira en torno al desastrenuclear de Chernóbil de abril de1986 y los esfuerzos de limpiezasin precedentes que siguieron.Cuenta con un repartoencabezado por Jared Harris,Stellan Skarsgård y EmilyWatson.";
            programa2.Porcentaje = "34";

            // creando programa 3

            Programa programa3 = new Programa();
            programa3.NombreImagen = "the-marvelous-maisel";
            programa3.TituloEnIngles = "THEMARVELOUSMRS.MAISEL";
            programa3.TituloEnEspanol = "La maravillosa Señora Maisel";
            programa3.CreadoPor = "Amy Sherman-Palladino";
            programa3.Protagonista = "Rachel BrosnahanMichael ZegenAlex BorsteinTony ShalhoubMarin Hinkle";
            programa3.PaisDeOrigen = "Estados Unidos";
            programa3.Temporadas = "3";
            programa3.Episodios = "26";
            programa3.Sipnosis = "La serie cuenta la historia de unama de casa en Nueva York quedescubre que tiene una habilidadespecial para la comedia en vivo.El primer episodio se estrenócomo parte de la temporada depilotos de primavera de AmazonStudios el 17 de marzo de 2017,recibiendo la aclamación de lacrítica.";
            programa3.Porcentaje = "26";

            // agregando los programas a la lista

            programas.Add(programa1);
            programas.Add(programa2);
            programas.Add(programa3);

            return programas;
        } 
    }
}
