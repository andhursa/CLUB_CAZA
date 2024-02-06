namespace SLN.CLUB_CAZA
{
    partial class fmrLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrLogin));
            lblUser = new Label();
            lblPassword = new Label();
            tbUser = new TextBox();
            tbPass = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.ButtonFace;
            lblUser.Location = new Point(89, 70);
            lblUser.Margin = new Padding(5, 0, 5, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(118, 29);
            lblUser.TabIndex = 0;
            lblUser.Text = "USUARIO";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(89, 154);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(146, 29);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "PASSWORD";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(256, 61);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(208, 38);
            tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(256, 145);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(208, 38);
            tbPass.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(89, 217);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(113, 40);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(256, 217);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // fmrLogin
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(710, 291);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmrLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPassword;
        private TextBox tbUser;
        private TextBox tbPass;
        private Button btnAceptar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}