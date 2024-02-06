using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace SLN.CLUB_CAZA
{
    
    public partial class fmrLogin : Form
    {
        SqlControl SqlControl= new SqlControl();
        public fmrLogin()
        {
            InitializeComponent();
        }

        //public void Logins()
        //{
        //    try
        //    {
        //        string ConexionBD = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
        //        using (SqlConnection conexion = new SqlConnection(ConexionBD))
        //        {
        //            conexion.Open();
        //            using (SqlCommand cmd = new SqlCommand("SELECT Usuario, Password FROM Usuarios WHERE Usuario='" + tbUser.Text + "'AND Password='" + tbPass.Text + "'", conexion))
        //            {
        //                SqlDataReader dr = cmd.ExecuteReader();

        //                if (dr.Read())
        //                {
        //                   // MessageBox.Show("Login Exitoso.");                            
        //                    this.Close();                            

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Datos Incorrectos");
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Logins();
            int result=SqlControl.Login(tbUser.Text,tbPass.Text);

            if(result==1)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();                
                frmPrincipal.ShowDialog();
                this.Hide();

            }
            else if(result==0)
            {
                MessageBox.Show("Usuario o password Incorrectos.");
                tbPass.Text=string.Empty;
                tbUser.Text = string.Empty;
            
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
