using MovieTicketSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieTicketSystem.AppData;
using MovieTicketSystem.Forms;

namespace MovieTicketSystem
{
    public partial class Login : Form
    {
        UserRepository userRepo;
        public Login()
        {
            InitializeComponent();

            userRepo = new UserRepository();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(log_Username.Text))
            {
                MessageBox.Show("No Username Input", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(log_Password.Text))
            {
                MessageBox.Show("No Password Input", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userLogged = userRepo.GetUserByUsername(log_Username.Text);

            if (userLogged != null)
            {
                if (userLogged.userPassword.Equals(log_Password.Text))
                {
                    // Assigned to a singleton
                    UserLogged.GetInstance().UserAccount = userLogged;

                    switch ((Role)userLogged.roleId)
                    {
                        case Role.Student:
                            // Load student Dashboard
                            new Frm_Student_Dashboard().Show();
                            this.Hide();
                            break;
                        case Role.Teacher:
                            // Load Teacher Dashboard
                            new Frm_Teacher_DashBoard().Show();
                            this.Hide();
                            break;
                        case Role.Admin:
                            // Load Admin Dashboard
                            new Frm_Admin_Dashboard().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }


        }
    }
}
