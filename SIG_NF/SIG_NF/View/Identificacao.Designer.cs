namespace SIG_NF.View
{
    partial class Identificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identificacao));
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Entrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.Location = new System.Drawing.Point(451, 150);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(271, 79);
            this.btn_Entrar.TabIndex = 15;
            this.btn_Entrar.Text = "Listar Nota Fiscal";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(174, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 79);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cadastrar Nota Fiscal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Identificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Entrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Identificacao";
            this.Text = "Sistema Gerenciador de Notas Fiscais";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button button1;
    }
}