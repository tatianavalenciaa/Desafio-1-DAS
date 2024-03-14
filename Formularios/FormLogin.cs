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
    public partial class FormLogin : Form {

        UsuarioService usuarioService = new UsuarioService();

        public Usuario Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public FormPrincipal FormPrincipal { get; set; }

        public FormLogin() {
            InitializeComponent();
            Usuarios = usuarioService.ObtenerUsuarios();
        }

        private void FormLogin_Load(object sender, EventArgs e) {
            Hide();
            FormBienvenida formBienvenida = new FormBienvenida();
            formBienvenida.ShowDialog();
            Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e) {
            this.Hide();


            for (int i = 0; i < Usuarios.Count; i++) {
                if (Usuarios[i].User == txtUsuario.Text && Usuarios[i].Pass == txtPassword.Text) { 

                    // si llegue hasta aqui significa que encontre al usuario en la lista de usuarios
                    // por lo tanto, debo crear al usuario encontrado

                    Usuario = new Usuario();
                    Usuario.User = Usuarios[i].User;
                    Usuario.Pass = Usuarios[i].Pass;
                    Usuario.PrefiereProgramas = Usuarios[i].PrefiereProgramas;
                    Usuario.PrefiereLibros = Usuarios[i].PrefiereLibros;
                    Usuario.PrefiereLenguajes = Usuarios[i].PrefiereLenguajes;
                    
                    // mostramos el formulario principal y le mandamos el formulario login (this)
                    // el formulario login llevara a este usuario creado

                    FormPrincipal formPrincipal = new FormPrincipal(this);
                    formPrincipal.ShowDialog();
                    limpiarFormulario();
                    break;
                } else {
                    Show();
                    lblMensaje.Text = "Usuario o contraseña inválida";
                }
            }
        }


        private void linkCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FormCrearUsuario formCrearUsuario = new FormCrearUsuario(this);
            formCrearUsuario.ShowDialog();
        }

        private void limpiarFormulario() {
            txtUsuario.Clear();
            txtPassword.Clear();
            lblMensaje.Text = "";
        }
        
        
    }
}