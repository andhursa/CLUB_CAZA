namespace SLN.CLUB_CAZA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelSubMenu.Visible = false;
            panelReportes.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelReportes.Visible == true)
            {
                panelReportes.Visible = false;
            }
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(childForm);
            panelFormHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Autenticacion
        private void btnAutenticacion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new IngresoCliente());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarCliente());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        #region reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
