
namespace TPA_Exercicios
{
    partial class frmEx11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEx11));
            this.label2 = new System.Windows.Forms.Label();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtTabu = new System.Windows.Forms.TextBox();
            this.lblTabu = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(346, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Calcular utilizando:";
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(350, 225);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(99, 41);
            this.btnDo.TabIndex = 20;
            this.btnDo.Text = "DO";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(350, 178);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(99, 41);
            this.btnFor.TabIndex = 19;
            this.btnFor.Text = "FOR";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(350, 131);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(99, 41);
            this.btnWhile.TabIndex = 18;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(150, 392);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 41);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(34, 392);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 41);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtTabu
            // 
            this.txtTabu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtTabu.Location = new System.Drawing.Point(34, 131);
            this.txtTabu.Multiline = true;
            this.txtTabu.Name = "txtTabu";
            this.txtTabu.ReadOnly = true;
            this.txtTabu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTabu.Size = new System.Drawing.Size(237, 235);
            this.txtTabu.TabIndex = 15;
            // 
            // lblTabu
            // 
            this.lblTabu.AutoSize = true;
            this.lblTabu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblTabu.Location = new System.Drawing.Point(30, 108);
            this.lblTabu.Name = "lblTabu";
            this.lblTabu.Size = new System.Drawing.Size(176, 20);
            this.lblTabu.TabIndex = 14;
            this.lblTabu.Text = "Resultado da tabuada:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtNum.Location = new System.Drawing.Point(338, 66);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(237, 27);
            this.txtNum.TabIndex = 13;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblNum.Location = new System.Drawing.Point(30, 69);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(219, 20);
            this.lblNum.TabIndex = 11;
            this.lblNum.Text = "Digite o número que deseja:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 28);
            this.menuStrip1.TabIndex = 12;
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
            // frmEx11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtTabu);
            this.Controls.Add(this.lblTabu);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEx11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada 10x";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtTabu;
        private System.Windows.Forms.Label lblTabu;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}