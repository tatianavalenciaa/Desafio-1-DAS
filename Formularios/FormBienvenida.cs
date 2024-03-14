using Desafio1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1 {
    public partial class FormBienvenida : Form {
        public FormBienvenida() {
            InitializeComponent();
            
        }

        private void FormBienvenida_Load(object sender, EventArgs e) {
            Timer timer = new Timer();
            timer.Interval = 15000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Close();
        }
    }
}
