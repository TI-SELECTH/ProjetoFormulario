using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticCV
{
    public partial class Login : Form
    {
        //Fiz via code para ter menos chances de ser editado, se fosse JSON seria fácil editar. Provavelmente não é o melhor jeito...
        string[] users = {"x@selecth.com.br", "y@selecth.com.br" , "z@selecth.com.br" };
        string[] passwords = {"x", "y", "z"};

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarDados();
        }

        private void validarDados()
        {

            bool userValidado = false;
            bool passValidado = false;

            //Comparar o username
            for(int i = 0; i < users.Length; i++ )
            {
                if (string.Equals(users[i], txt_user.Text))
                    {
                    userValidado = true;
                    //Comparar Password
                    if (string.Equals(passwords[i], txt_password.Text))
                        passValidado = true;
                    }
            }         

            if (userValidado == true && passValidado == true)
            {

                var form = new MainWindow();
                this.Hide();
                form.ShowDialog();
                this.Close();

            }

        }
    }
}
