using Desafio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Servicios {
    public class UsuarioService {

        

        public List<Usuario> ObtenerUsuarios() {

            // como no tenemos base de datos, crearemos una lista de 5 usuarios quemados.

            List<Usuario> usuarios = new List<Usuario>();

            // Creando usuario 1

            Usuario usuario1 = new Usuario();
            usuario1.User = "usuario1";
            usuario1.Pass = "usuario1";
            usuario1.PrefiereProgramas = true;
            usuario1.PrefiereLibros = true;
            usuario1.PrefiereLenguajes = true;

            // Creando usuario 2

            Usuario usuario2 = new Usuario();
            usuario2.User = "usuario2";
            usuario2.Pass = "usuario2";
            usuario2.PrefiereProgramas = true;
            usuario2.PrefiereLibros = true;
            usuario2.PrefiereLenguajes = false;

            // Creando usuario 3

            Usuario usuario3 = new Usuario();
            usuario3.User = "usuario3";
            usuario3.Pass = "usuario3";
            usuario3.PrefiereProgramas = true;
            usuario3.PrefiereLibros = false;
            usuario3.PrefiereLenguajes = false;

            // Creando usuario 4

            Usuario usuario4 = new Usuario();
            usuario4.User = "usuario4";
            usuario4.Pass = "usuario4";
            usuario4.PrefiereProgramas = false;
            usuario4.PrefiereLibros = false;
            usuario4.PrefiereLenguajes = false;

            // Creando usuario 5

            Usuario usuario5 = new Usuario();
            usuario5.User = "usuario5";
            usuario5.Pass = "usuario5";
            usuario5.PrefiereProgramas = true;
            usuario5.PrefiereLibros = true;
            usuario5.PrefiereLenguajes = true;

            // agregando los usuarios a la lista

            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
            usuarios.Add(usuario3);
            usuarios.Add(usuario4);
            usuarios.Add(usuario5);

            return usuarios;
        }

        public Usuario CrearUsuario(string user, string pass, bool prefiereProgramas, bool prefiereLibros, bool prefiereLenguajes) { 
            Usuario usuario = new Usuario();
            usuario.User = user;
            usuario.Pass = pass;
            usuario.PrefiereProgramas = prefiereProgramas;
            usuario.PrefiereLibros = prefiereLibros;
            usuario.PrefiereLenguajes = prefiereLenguajes;
            return usuario;
        }
    }
}
