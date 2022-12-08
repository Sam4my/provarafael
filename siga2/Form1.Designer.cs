namespace siga2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.tbc_Aluno = new System.Windows.Forms.TabControl();
            this.tb_Aluno = new System.Windows.Forms.TabPage();
            this.btn_entAlun = new System.Windows.Forms.Button();
            this.cbx_UnitAlun = new System.Windows.Forms.ComboBox();
            this.txt_AlunPass = new System.Windows.Forms.TextBox();
            this.txt_Alunuser = new System.Windows.Forms.TextBox();
            this.tb_Prof = new System.Windows.Forms.TabPage();
            this.btn_entProf = new System.Windows.Forms.Button();
            this.cbx_unitProf = new System.Windows.Forms.ComboBox();
            this.txt_profUser = new System.Windows.Forms.TextBox();
            this.txt_profPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbc_Aluno.SuspendLayout();
            this.tb_Aluno.SuspendLayout();
            this.tb_Prof.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.MaximumSize = new System.Drawing.Size(98, 57);
            this.lbl_titulo.MinimumSize = new System.Drawing.Size(80, 40);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_titulo.Size = new System.Drawing.Size(92, 51);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "SIGA";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(21, 19);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(56, 15);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "USUÁRIO";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(21, 61);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(45, 15);
            this.lbl_Pass.TabIndex = 2;
            this.lbl_Pass.Text = "SENHA";
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.Location = new System.Drawing.Point(21, 107);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(57, 15);
            this.lbl_unit.TabIndex = 3;
            this.lbl_unit.Text = "UNIDADE";
            // 
            // tbc_Aluno
            // 
            this.tbc_Aluno.Controls.Add(this.tb_Aluno);
            this.tbc_Aluno.Controls.Add(this.tb_Prof);
            this.tbc_Aluno.Location = new System.Drawing.Point(120, 92);
            this.tbc_Aluno.Name = "tbc_Aluno";
            this.tbc_Aluno.SelectedIndex = 0;
            this.tbc_Aluno.Size = new System.Drawing.Size(395, 259);
            this.tbc_Aluno.TabIndex = 4;
            // 
            // tb_Aluno
            // 
            this.tb_Aluno.BackColor = System.Drawing.SystemColors.Info;
            this.tb_Aluno.Controls.Add(this.btn_entAlun);
            this.tb_Aluno.Controls.Add(this.cbx_UnitAlun);
            this.tb_Aluno.Controls.Add(this.txt_AlunPass);
            this.tb_Aluno.Controls.Add(this.txt_Alunuser);
            this.tb_Aluno.Controls.Add(this.lbl_User);
            this.tb_Aluno.Controls.Add(this.lbl_unit);
            this.tb_Aluno.Controls.Add(this.lbl_Pass);
            this.tb_Aluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Aluno.Location = new System.Drawing.Point(4, 24);
            this.tb_Aluno.Name = "tb_Aluno";
            this.tb_Aluno.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Aluno.Size = new System.Drawing.Size(387, 231);
            this.tb_Aluno.TabIndex = 0;
            this.tb_Aluno.Text = "ALUNO";
            // 
            // btn_entAlun
            // 
            this.btn_entAlun.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_entAlun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_entAlun.Location = new System.Drawing.Point(26, 172);
            this.btn_entAlun.Name = "btn_entAlun";
            this.btn_entAlun.Size = new System.Drawing.Size(75, 26);
            this.btn_entAlun.TabIndex = 7;
            this.btn_entAlun.Text = "ENTRAR";
            this.btn_entAlun.UseVisualStyleBackColor = false;
            // 
            // cbx_UnitAlun
            // 
            this.cbx_UnitAlun.FormattingEnabled = true;
            this.cbx_UnitAlun.Location = new System.Drawing.Point(26, 125);
            this.cbx_UnitAlun.Name = "cbx_UnitAlun";
            this.cbx_UnitAlun.Size = new System.Drawing.Size(226, 23);
            this.cbx_UnitAlun.TabIndex = 6;
            // 
            // txt_AlunPass
            // 
            this.txt_AlunPass.Location = new System.Drawing.Point(26, 79);
            this.txt_AlunPass.Name = "txt_AlunPass";
            this.txt_AlunPass.Size = new System.Drawing.Size(145, 23);
            this.txt_AlunPass.TabIndex = 5;
            // 
            // txt_Alunuser
            // 
            this.txt_Alunuser.Location = new System.Drawing.Point(26, 37);
            this.txt_Alunuser.Name = "txt_Alunuser";
            this.txt_Alunuser.Size = new System.Drawing.Size(145, 23);
            this.txt_Alunuser.TabIndex = 4;
            // 
            // tb_Prof
            // 
            this.tb_Prof.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_Prof.Controls.Add(this.btn_entProf);
            this.tb_Prof.Controls.Add(this.cbx_unitProf);
            this.tb_Prof.Controls.Add(this.txt_profUser);
            this.tb_Prof.Controls.Add(this.txt_profPass);
            this.tb_Prof.Controls.Add(this.label3);
            this.tb_Prof.Controls.Add(this.label2);
            this.tb_Prof.Controls.Add(this.label1);
            this.tb_Prof.Location = new System.Drawing.Point(4, 24);
            this.tb_Prof.Name = "tb_Prof";
            this.tb_Prof.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Prof.Size = new System.Drawing.Size(387, 231);
            this.tb_Prof.TabIndex = 1;
            this.tb_Prof.Text = "PROFESSOR";
            // 
            // btn_entProf
            // 
            this.btn_entProf.BackColor = System.Drawing.SystemColors.Info;
            this.btn_entProf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_entProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_entProf.Location = new System.Drawing.Point(24, 174);
            this.btn_entProf.Name = "btn_entProf";
            this.btn_entProf.Size = new System.Drawing.Size(75, 25);
            this.btn_entProf.TabIndex = 6;
            this.btn_entProf.Text = "ENTRAR";
            this.btn_entProf.UseVisualStyleBackColor = false;
            // 
            // cbx_unitProf
            // 
            this.cbx_unitProf.FormattingEnabled = true;
            this.cbx_unitProf.Location = new System.Drawing.Point(22, 130);
            this.cbx_unitProf.Name = "cbx_unitProf";
            this.cbx_unitProf.Size = new System.Drawing.Size(223, 23);
            this.cbx_unitProf.TabIndex = 5;
            // 
            // txt_profUser
            // 
            this.txt_profUser.Location = new System.Drawing.Point(22, 39);
            this.txt_profUser.Name = "txt_profUser";
            this.txt_profUser.Size = new System.Drawing.Size(161, 23);
            this.txt_profUser.TabIndex = 4;
            // 
            // txt_profPass
            // 
            this.txt_profPass.Location = new System.Drawing.Point(22, 84);
            this.txt_profPass.Name = "txt_profPass";
            this.txt_profPass.Size = new System.Drawing.Size(161, 23);
            this.txt_profPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "UNIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUÁRIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 428);
            this.Controls.Add(this.tbc_Aluno);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = "SIGA";
            this.tbc_Aluno.ResumeLayout(false);
            this.tb_Aluno.ResumeLayout(false);
            this.tb_Aluno.PerformLayout();
            this.tb_Prof.ResumeLayout(false);
            this.tb_Prof.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.TabControl tbc_Aluno;
        private System.Windows.Forms.TabPage tb_Aluno;
        private System.Windows.Forms.Button btn_entAlun;
        private System.Windows.Forms.ComboBox cbx_UnitAlun;
        private System.Windows.Forms.TextBox txt_AlunPass;
        private System.Windows.Forms.TextBox txt_Alunuser;
        private System.Windows.Forms.TabPage tb_Prof;
        private System.Windows.Forms.Button btn_entProf;
        private System.Windows.Forms.ComboBox cbx_unitProf;
        private System.Windows.Forms.TextBox txt_profUser;
        private System.Windows.Forms.TextBox txt_profPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
