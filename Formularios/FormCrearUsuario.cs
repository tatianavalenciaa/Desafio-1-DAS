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
    public partial class FormCrearUsuario : Form {

        public UsuarioService usuarioService = new UsuarioService();

        public FormLogin FormLogin {  get; set; }
        public FormCrearUsuario(FormLogin formLogin) {
            InitializeComponent();
            FormLogin = formLogin;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e) {
            string usuario = txtUsuario.Text;
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;
            bool prefiereProgramas = chkProgramas.Checked;
            bool prefiereLibros = chkLibros.Checked;
            bool prefiereLenguajes = chkLenguajes.Checked;

            if(usuario == "" || password1 == "" || password2 == "") {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Debe llenar todos los campos.";
            } else if(password1 != password2){
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Passwords no coinciden";
            } else {
                Usuario usuarioNuevo = usuarioService.CrearUsuario(usuario, password1, prefiereProgramas, prefiereLibros, prefiereLenguajes);
                FormLogin.Usuarios.Add(usuarioNuevo);
                lblMensaje.ForeColor = Color.Blue;
                lblMensaje.Text = "Usuario creado exitosamente";
                limpiarFormulario();
            }
        }

        private void limpiarFormulario() {
            txtUsuario.Clear();
            txtPassword1.Clear();
            txtPassword2.Clear();
            chkProgramas.Checked = false;
            chkLibros.Checked = false;
            chkLenguajes .Checked = false;
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e) {

        }
    }
}
