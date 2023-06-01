using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;

namespace Gerente_de_estudantes
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Coloca a imagem user.png na picture box da janela.
            pictureBox1.Image = Image.FromFile("../../imagens/user.png");
            pictureBox2.Image = Image.FromFile("../../imagens/senha.png");
            pictureBox3.Image = Image.FromFile("../../imagens/usuario.png");

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(0, 0, 0), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lbg = new LinearGradientBrush(area, Color.FromArgb(236, 196, 64), Color.FromArgb(221, 172, 23), LinearGradientMode.Vertical);
            mgraphics.FillRectangle( lbg, area);
            mgraphics.DrawRectangle(pen, area);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            MEU_BD bancoDeDados = new MEU_BD();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand ("SELECT * FROM `usuarios` WHERE `nome` = @usn AND `senha` = @psw", bancoDeDados.getConexao) 
        }
    }
}
