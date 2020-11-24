namespace Sistema
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.adminis = new System.Windows.Forms.RadioButton();
            this.func = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versenha = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.naoversenha = new System.Windows.Forms.Button();
            senhaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.ForeColor = System.Drawing.Color.Black;
            senhaLabel.Location = new System.Drawing.Point(110, 139);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(54, 16);
            senhaLabel.TabIndex = 7;
            senhaLabel.Text = "senha:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.BackColor = System.Drawing.Color.Transparent;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.ForeColor = System.Drawing.Color.Black;
            usuarioLabel.Location = new System.Drawing.Point(101, 103);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(63, 16);
            usuarioLabel.TabIndex = 8;
            usuarioLabel.Text = "usuario:";
            usuarioLabel.Click += new System.EventHandler(this.usuarioLabel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(85, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 27);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(268, 211);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 27);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(175, 138);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(142, 20);
            this.senhaTextBox.TabIndex = 2;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(175, 102);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(142, 20);
            this.usuarioTextBox.TabIndex = 1;
            // 
            // adminis
            // 
            this.adminis.AutoSize = true;
            this.adminis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminis.ForeColor = System.Drawing.Color.Black;
            this.adminis.Location = new System.Drawing.Point(245, 175);
            this.adminis.Name = "adminis";
            this.adminis.Size = new System.Drawing.Size(88, 17);
            this.adminis.TabIndex = 10;
            this.adminis.Text = "Administrador";
            this.adminis.UseVisualStyleBackColor = true;
            // 
            // func
            // 
            this.func.AutoSize = true;
            this.func.Checked = true;
            this.func.Cursor = System.Windows.Forms.Cursors.Hand;
            this.func.ForeColor = System.Drawing.Color.Black;
            this.func.Location = new System.Drawing.Point(113, 175);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(77, 17);
            this.func.TabIndex = 11;
            this.func.TabStop = true;
            this.func.Text = "funcionario";
            this.func.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(85, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 5);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(268, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 5);
            this.panel2.TabIndex = 13;
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataSource = typeof(Sistema.DAL.tb_usuario);
            // 
            // versenha
            // 
            this.versenha.BackColor = System.Drawing.Color.DimGray;
            this.versenha.BackgroundImage = global::Sistema.Properties.Resources.icons8_mostrar_a_senha_24;
            this.versenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.versenha.FlatAppearance.BorderSize = 0;
            this.versenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.versenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versenha.Location = new System.Drawing.Point(323, 138);
            this.versenha.Name = "versenha";
            this.versenha.Size = new System.Drawing.Size(30, 22);
            this.versenha.TabIndex = 32;
            this.versenha.UseVisualStyleBackColor = false;
            this.versenha.Click += new System.EventHandler(this.versenha_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.Location = new System.Drawing.Point(323, 155);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 5);
            this.panel7.TabIndex = 33;
            // 
            // naoversenha
            // 
            this.naoversenha.BackColor = System.Drawing.Color.DimGray;
            this.naoversenha.BackgroundImage = global::Sistema.Properties.Resources.icons8_mostrar_a_senha_24;
            this.naoversenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.naoversenha.Enabled = false;
            this.naoversenha.FlatAppearance.BorderSize = 0;
            this.naoversenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.naoversenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naoversenha.Location = new System.Drawing.Point(323, 138);
            this.naoversenha.Name = "naoversenha";
            this.naoversenha.Size = new System.Drawing.Size(30, 22);
            this.naoversenha.TabIndex = 34;
            this.naoversenha.UseVisualStyleBackColor = false;
            this.naoversenha.Visible = false;
            this.naoversenha.Click += new System.EventHandler(this.naoversenha_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::Sistema.Properties.Resources.sapatos1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(431, 285);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.naoversenha);
            this.Controls.Add(this.versenha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.func);
            this.Controls.Add(this.adminis);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.RadioButton adminis;
        private System.Windows.Forms.RadioButton func;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button versenha;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button naoversenha;
    }
}