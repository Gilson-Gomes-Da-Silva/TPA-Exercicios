
namespace TPA_Exercicios
{
    partial class frmEx13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEx13));
            this.txtAreaTot = new System.Windows.Forms.TextBox();
            this.txtAreaCom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtLargCom = new System.Windows.Forms.TextBox();
            this.txtCompCom = new System.Windows.Forms.TextBox();
            this.txtNomeCom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAreaTot
            // 
            this.txtAreaTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtAreaTot.Location = new System.Drawing.Point(507, 211);
            this.txtAreaTot.Name = "txtAreaTot";
            this.txtAreaTot.ReadOnly = true;
            this.txtAreaTot.Size = new System.Drawing.Size(364, 27);
            this.txtAreaTot.TabIndex = 46;
            // 
            // txtAreaCom
            // 
            this.txtAreaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtAreaCom.Location = new System.Drawing.Point(31, 211);
            this.txtAreaCom.Name = "txtAreaCom";
            this.txtAreaCom.ReadOnly = true;
            this.txtAreaCom.Size = new System.Drawing.Size(419, 27);
            this.txtAreaCom.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(27, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Digite o largura do cômodo (m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Digite o comprimento do cômodo (m):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Digite o nome do cômodo:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(143, 271);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 41);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(30, 271);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 41);
            this.btnVoltar.TabIndex = 40;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 39;
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
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(759, 49);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 106);
            this.btnCalc.TabIndex = 38;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtLargCom
            // 
            this.txtLargCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtLargCom.Location = new System.Drawing.Point(507, 128);
            this.txtLargCom.Name = "txtLargCom";
            this.txtLargCom.Size = new System.Drawing.Size(233, 27);
            this.txtLargCom.TabIndex = 37;
            // 
            // txtCompCom
            // 
            this.txtCompCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtCompCom.Location = new System.Drawing.Point(507, 90);
            this.txtCompCom.Name = "txtCompCom";
            this.txtCompCom.Size = new System.Drawing.Size(233, 27);
            this.txtCompCom.TabIndex = 36;
            // 
            // txtNomeCom
            // 
            this.txtNomeCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtNomeCom.Location = new System.Drawing.Point(507, 49);
            this.txtNomeCom.Name = "txtNomeCom";
            this.txtNomeCom.Size = new System.Drawing.Size(233, 27);
            this.txtNomeCom.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(503, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "A área total do imóvel é:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(27, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "A área do cômodo é:";
            // 
            // frmEx13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 355);
            this.Controls.Add(this.txtAreaTot);
            this.Controls.Add(this.txtAreaCom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtLargCom);
            this.Controls.Add(this.txtCompCom);
            this.Controls.Add(this.txtNomeCom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEx13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de área de um imóvel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAreaTot;
        private System.Windows.Forms.TextBox txtAreaCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtLargCom;
        private System.Windows.Forms.TextBox txtCompCom;
        private System.Windows.Forms.TextBox txtNomeCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}