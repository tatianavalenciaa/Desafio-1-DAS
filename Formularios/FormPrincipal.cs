using Desafio1.Entidades;
using Desafio1.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1.Formularios {
    public partial class FormPrincipal : Form {

        public FormLogin FormLogin { get; set; }

        ProgramaService programaService = new ProgramaService();
        LibroService libroService = new LibroService();
        LenguajeService lenguajeService = new LenguajeService();

        List<Programa> programas = new List<Programa>();
        List<Libro> libros = new List<Libro>();
        List<Lenguaje> lenguajes = new List<Lenguaje>();

        public FormPrincipal() {}

        public FormPrincipal(FormLogin formLogin) {
            InitializeComponent();
            FormLogin = formLogin;
            cargarPreferenciasDeUsuario();

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            FormLogin.Show();
        }

        private void tsbCerrarSesion_Click(object sender, EventArgs e) {
            FormLogin.Show();
            Close();
        }

        private void btnProgramas1_Click(object sender, EventArgs e) {
            pintarPrograma(programas, 1);
        }

        private void btnProgramas2_Click(object sender, EventArgs e) {
            pintarPrograma(programas, 2);
        }

        private void btnProgramas3_Click(object sender, EventArgs e) {
            pintarPrograma(programas, 3);
        }

        private void btnLibros1_Click(object sender, EventArgs e) {
            pintarLibro(libros, 1);
        }

        private void btnLibros2_Click(object sender, EventArgs e) {
            pintarLibro(libros, 2);
        }

        private void btnLibros3_Click(object sender, EventArgs e) {
            pintarLibro(libros,3);
        }

        private void btnLenguajes1_Click(object sender, EventArgs e) {
            pintarLenguaje(lenguajes,1);
        }

        private void btnLenguajes2_Click(object sender, EventArgs e) {
            pintarLenguaje(lenguajes, 2);
        }

        private void btnLenguajes3_Click(object sender, EventArgs e) {
            pintarLenguaje(lenguajes, 3);
        }

        private void pintarPrograma(List<Programa> programas, int posicion) {
            pbProgramas.Image = (Image)Properties.Resources.ResourceManager.GetObject(programas[posicion-1].NombreImagen);
            lblTituloInglesProgramas.Text = programas[posicion-1].TituloEnIngles;
            lblTituloEspañolProgramas.Text = programas[posicion-1].TituloEnEspanol;
            lblCreadoProgramas.Text = programas[posicion-1].CreadoPor;
            lblProtagonistasProgramas.Text = programas[posicion-1].Protagonista;
            lblPaisProgramas.Text = programas[posicion-1].PaisDeOrigen;
            lblTemporadasProgramas.Text = programas[posicion-1].Temporadas;
            lblEpisodiosProgramas.Text = programas[posicion-1].Episodios;
            lblSinopsisProgramas.Text = programas[posicion-1].Sipnosis;
        }

        private void pintarLibro(List<Libro> libros, int posicion) {
            pbLibros.Image = (Image)Properties.Resources.ResourceManager.GetObject(libros[posicion-1].NombreImagen);
            lblTituloInglesLibros.Text = libros[posicion-1].TituloEnIngles;
            lblAutorLibros.Text = libros[posicion-1].Autor;
            lblGeneroLibros.Text = libros[posicion-1].Genero;
            lblSubgeneroLibros.Text = libros[posicion-1].SubGenero;
            lblNumeroPaginaLibros.Text = libros[posicion-1].NumeroPagina;
            lblProtagonistasLibros.Text = libros[posicion-1].Protagonista;
            lblAntagonistasLibros.Text = libros[posicion-1].Antagonista;
            lblArgumentoLibros.Text = libros[posicion-1].Argumento;
        }

        private void pintarLenguaje(List<Lenguaje> lenguajes, int posicion) {
            pbLenguajes.Image = (Image)Properties.Resources.ResourceManager.GetObject(lenguajes[posicion-1].NombreImagen);
            lblTituloInglesLenguajes.Text = lenguajes[posicion-1].TituloEnIngles;
            lblDesarrolladoresLenguajes.Text = lenguajes[posicion-1].Desarrolladores;
            lblExtensionesLenguajes.Text = lenguajes[posicion-1].Extenciones;
            lblAparecioLenguaje.Text = lenguajes[posicion-1].AparecioEn;
            lblSistemaOperativoLenguaje.Text = lenguajes[posicion-1].SistemaOperativo;
            lblParadigmaLenguajes.Text = lenguajes[posicion-1].Paradigma;
            lblUltimaVersionLenguajes.Text = lenguajes[posicion-1].UltimaVersion;
            lblLicenciaLenguajes.Text = lenguajes[posicion-1].Licencia;
        }

        private void cargarPreferenciasDeUsuario() {
            
            // siempre quiero mostrar el usuario logeado en el toolstrip

            tslUsuario.Text= FormLogin.Usuario.User;

            // cosas que tengo que mostrar segun la preferencias del usuario

            if (FormLogin.Usuario.PrefiereProgramas) {
                programas = programaService.ObtenerProgramas();
                pintarPrograma(programas, 1);
            } else {
                tabPrincipal.TabPages.Remove(tabProgramasTV);
                pbEstadisticasProgramas.Visible = false;
            }
            if (FormLogin.Usuario.PrefiereLibros) {
                libros = libroService.ObtenerLibros();
                pintarLibro(libros, 1);
            } else {
                tabPrincipal.TabPages.Remove(tabLibros);
                pbEstadisticaLibros.Visible = false;
            }
            if (FormLogin.Usuario.PrefiereLenguajes) {
                lenguajes = lenguajeService.ObtenerLenguajes();
                pintarLenguaje(lenguajes, 1);
            } else {
                tabPrincipal.TabPages.Remove(tabLenguajesDeProgramacion);
                pbEstadisticaLenguajes.Visible = false;
            } 
            if (!FormLogin.Usuario.PrefiereProgramas && !FormLogin.Usuario.PrefiereLibros && !FormLogin.Usuario.PrefiereLenguajes) {
                tabPrincipal.TabPages.Remove(tabEstadisticas);
            }
        }
    }
}



