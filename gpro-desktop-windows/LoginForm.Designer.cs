namespace gpro_desktop_windows
{
  partial class LoginForm
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
      this.textBoxUser = new MetroFramework.Controls.MetroTextBox();
      this.textBoxPass = new MetroFramework.Controls.MetroTextBox();
      this.btnIniciar = new MetroFramework.Controls.MetroButton();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxUser
      // 
      // 
      // 
      // 
      this.textBoxUser.CustomButton.Image = null;
      this.textBoxUser.CustomButton.Location = new System.Drawing.Point(285, 1);
      this.textBoxUser.CustomButton.Name = "";
      this.textBoxUser.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxUser.CustomButton.TabIndex = 1;
      this.textBoxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxUser.CustomButton.UseSelectable = true;
      this.textBoxUser.CustomButton.Visible = false;
      this.textBoxUser.Lines = new string[0];
      this.textBoxUser.Location = new System.Drawing.Point(280, 130);
      this.textBoxUser.MaxLength = 32767;
      this.textBoxUser.Name = "textBoxUser";
      this.textBoxUser.PasswordChar = '\0';
      this.textBoxUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxUser.SelectedText = "";
      this.textBoxUser.SelectionLength = 0;
      this.textBoxUser.SelectionStart = 0;
      this.textBoxUser.ShortcutsEnabled = true;
      this.textBoxUser.Size = new System.Drawing.Size(307, 23);
      this.textBoxUser.TabIndex = 0;
      this.textBoxUser.UseSelectable = true;
      this.textBoxUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxPass
      // 
      // 
      // 
      // 
      this.textBoxPass.CustomButton.Image = null;
      this.textBoxPass.CustomButton.Location = new System.Drawing.Point(285, 1);
      this.textBoxPass.CustomButton.Name = "";
      this.textBoxPass.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxPass.CustomButton.TabIndex = 1;
      this.textBoxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxPass.CustomButton.UseSelectable = true;
      this.textBoxPass.CustomButton.Visible = false;
      this.textBoxPass.Lines = new string[0];
      this.textBoxPass.Location = new System.Drawing.Point(280, 190);
      this.textBoxPass.MaxLength = 32767;
      this.textBoxPass.Name = "textBoxPass";
      this.textBoxPass.PasswordChar = '●';
      this.textBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxPass.SelectedText = "";
      this.textBoxPass.SelectionLength = 0;
      this.textBoxPass.SelectionStart = 0;
      this.textBoxPass.ShortcutsEnabled = true;
      this.textBoxPass.Size = new System.Drawing.Size(307, 23);
      this.textBoxPass.TabIndex = 1;
      this.textBoxPass.UseSelectable = true;
      this.textBoxPass.UseSystemPasswordChar = true;
      this.textBoxPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // btnIniciar
      // 
      this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnIniciar.DisplayFocus = true;
      this.btnIniciar.Location = new System.Drawing.Point(553, 258);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(130, 33);
      this.btnIniciar.TabIndex = 2;
      this.btnIniciar.Text = "Iniciar Sesión";
      this.btnIniciar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnIniciar.UseSelectable = true;
      this.btnIniciar.UseStyleColors = true;
      this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(280, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(53, 19);
      this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
      this.metroLabel1.TabIndex = 5;
      this.metroLabel1.Text = "Usuario";
      this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(280, 168);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(75, 19);
      this.metroLabel2.TabIndex = 5;
      this.metroLabel2.Text = "Contraseña";
      this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Consolas", 6F);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(18, 256);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(197, 9);
      this.label1.TabIndex = 6;
      this.label1.Text = "GPRO. Lisandro Caceres, Mariano Durand Mansilla,";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Location = new System.Drawing.Point(0, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(244, 309);
      this.panel1.TabIndex = 7;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Consolas", 6F);
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new System.Drawing.Point(18, 280);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(129, 9);
      this.label6.TabIndex = 7;
      this.label6.Text = "Licensed under the MIT license.";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Consolas", 6F);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(18, 268);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(149, 9);
      this.label5.TabIndex = 7;
      this.label5.Text = "Dardo Nosti, Juan Manuel Villarraza.";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 22F);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
      this.label2.Location = new System.Drawing.Point(272, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(286, 41);
      this.label2.TabIndex = 8;
      this.label2.Text = "Bienvenid@ a GPRO";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Consolas", 6.5F);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
      this.label3.Location = new System.Drawing.Point(278, 270);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 10);
      this.label3.TabIndex = 7;
      this.label3.Text = "Version 0.1";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Consolas", 6.5F);
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
      this.label4.Location = new System.Drawing.Point(278, 281);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 10);
      this.label4.TabIndex = 9;
      this.label4.Text = "Febrero 2020";
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(720, 309);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnIniciar);
      this.Controls.Add(this.textBoxPass);
      this.Controls.Add(this.textBoxUser);
      this.DisplayHeader = false;
      this.MaximizeBox = false;
      this.Movable = false;
      this.Name = "LoginForm";
      this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
      this.Resizable = false;
      this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
      this.Text = "Bienvenid@ a GPRO";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroTextBox textBoxUser;
    private MetroFramework.Controls.MetroTextBox textBoxPass;
    private MetroFramework.Controls.MetroButton btnIniciar;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
  }
}