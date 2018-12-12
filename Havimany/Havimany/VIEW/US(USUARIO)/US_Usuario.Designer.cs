namespace Havimany.VIEW.US_USUARIO_
{
    partial class US_Usuario
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ButtonInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(367, 217);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            this.labelUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(367, 248);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(416, 214);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(416, 245);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassWord.TabIndex = 3;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(532, 213);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.OnClickLogin);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(532, 242);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonInserir
            // 
            this.ButtonInserir.Location = new System.Drawing.Point(416, 275);
            this.ButtonInserir.Name = "ButtonInserir";
            this.ButtonInserir.Size = new System.Drawing.Size(75, 23);
            this.ButtonInserir.TabIndex = 6;
            this.ButtonInserir.Text = "Inserir";
            this.ButtonInserir.UseVisualStyleBackColor = true;
            this.ButtonInserir.Click += new System.EventHandler(this.InserirUsuario);
            // 
            // US_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 310);
            this.Controls.Add(this.ButtonInserir);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Name = "US_Usuario";
            this.Text = "US_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button ButtonInserir;
    }
}