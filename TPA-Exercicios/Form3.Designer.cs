
namespace TPA_Exercicios
{
    partial class frmEx12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEx12));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.txtSomandoFah = new System.Windows.Forms.TextBox();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.txtCelc = new System.Windows.Forms.TextBox();
            this.lblSomandoFah = new System.Windows.Forms.Label();
            this.lblFah = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(145, 395);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 41);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(29, 395);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 41);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(25, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Calcular utilizando:";
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(29, 280);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(99, 41);
            this.btnDo.TabIndex = 30;
            this.btnDo.Text = "DO";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(29, 233);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(99, 41);
            this.btnFor.TabIndex = 29;
            this.btnFor.Text = "FOR";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(29, 186);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(99, 41);
            this.btnWhile.TabIndex = 28;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // txtSomandoFah
            // 
            this.txtSomandoFah.Location = new System.Drawing.Point(229, 117);
            this.txtSomandoFah.Multiline = true;
            this.txtSomandoFah.Name = "txtSomandoFah";
            this.txtSomandoFah.ReadOnly = true;
            this.txtSomandoFah.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSomandoFah.Size = new System.Drawing.Size(277, 217);
            this.txtSomandoFah.TabIndex = 27;
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(229, 76);
            this.txtFah.Name = "txtFah";
            this.txtFah.ReadOnly = true;
            this.txtFah.Size = new System.Drawing.Size(277, 22);
            this.txtFah.TabIndex = 26;
            // 
            // txtCelc
            // 
            this.txtCelc.Location = new System.Drawing.Point(229, 48);
            this.txtCelc.Name = "txtCelc";
            this.txtCelc.Size = new System.Drawing.Size(277, 22);
            this.txtCelc.TabIndex = 25;
            // 
            // lblSomandoFah
            // 
            this.lblSomandoFah.AutoSize = true;
            this.lblSomandoFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblSomandoFah.Location = new System.Drawing.Point(25, 117);
            this.lblSomandoFah.Name = "lblSomandoFah";
            this.lblSomandoFah.Size = new System.Drawing.Size(128, 20);
            this.lblSomandoFah.TabIndex = 24;
            this.lblSomandoFah.Text = "F° de 10 em 10:";
            // 
            // lblFah
            // 
            this.lblFah.AutoSize = true;
            this.lblFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblFah.Location = new System.Drawing.Point(25, 76);
            this.lblFah.Name = "lblFah";
            this.lblFah.Size = new System.Drawing.Size(168, 20);
            this.lblFah.TabIndex = 23;
            this.lblFah.Text = "Convertendo para F°:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblCel.Location = new System.Drawing.Point(25, 48);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(165, 20);
            this.lblCel.TabIndex = 22;
            this.lblCel.Text = "Digite o valor em C°:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmEx12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.txtSomandoFah);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.txtCelc);
            this.Controls.Add(this.lblSomandoFah);
            this.Controls.Add(this.lblFah);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEx12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de celcius para fahreinheit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.TextBox txtSomandoFah;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.TextBox txtCelc;
        private System.Windows.Forms.Label lblSomandoFah;
        private System.Windows.Forms.Label lblFah;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}