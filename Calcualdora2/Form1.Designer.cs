
namespace Calcualdora2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btResultado = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.opSuma = new System.Windows.Forms.RadioButton();
            this.opResta = new System.Windows.Forms.RadioButton();
            this.opMultiplicacion = new System.Windows.Forms.RadioButton();
            this.opDivision = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btResultado
            // 
            resources.ApplyResources(this.btResultado, "btResultado");
            this.btResultado.BackColor = System.Drawing.SystemColors.Info;
            this.btResultado.Name = "btResultado";
            this.btResultado.UseVisualStyleBackColor = false;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // txt2
            // 
            resources.ApplyResources(this.txt2, "txt2");
            this.txt2.BackColor = System.Drawing.Color.White;
            this.txt2.Name = "txt2";
            // 
            // txt1
            // 
            resources.ApplyResources(this.txt1, "txt1");
            this.txt1.BackColor = System.Drawing.Color.White;
            this.txt1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt1.Name = "txt1";
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.BackColor = System.Drawing.Color.Red;
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Name = "lblResultado";
            // 
            // opSuma
            // 
            resources.ApplyResources(this.opSuma, "opSuma");
            this.opSuma.BackColor = System.Drawing.Color.White;
            this.opSuma.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.opSuma.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.opSuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.opSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opSuma.Name = "opSuma";
            this.opSuma.TabStop = true;
            this.opSuma.UseVisualStyleBackColor = false;
            this.opSuma.CheckedChanged += new System.EventHandler(this.opSuma_CheckedChanged);
            // 
            // opResta
            // 
            resources.ApplyResources(this.opResta, "opResta");
            this.opResta.BackColor = System.Drawing.Color.White;
            this.opResta.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.opResta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.opResta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.opResta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opResta.Name = "opResta";
            this.opResta.TabStop = true;
            this.opResta.UseVisualStyleBackColor = false;
            this.opResta.CheckedChanged += new System.EventHandler(this.opResta_CheckedChanged);
            // 
            // opMultiplicacion
            // 
            resources.ApplyResources(this.opMultiplicacion, "opMultiplicacion");
            this.opMultiplicacion.BackColor = System.Drawing.Color.White;
            this.opMultiplicacion.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.opMultiplicacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.opMultiplicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.opMultiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opMultiplicacion.Name = "opMultiplicacion";
            this.opMultiplicacion.TabStop = true;
            this.opMultiplicacion.UseVisualStyleBackColor = false;
            this.opMultiplicacion.CheckedChanged += new System.EventHandler(this.opMultiplicacion_CheckedChanged);
            // 
            // opDivision
            // 
            resources.ApplyResources(this.opDivision, "opDivision");
            this.opDivision.BackColor = System.Drawing.Color.White;
            this.opDivision.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.opDivision.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.opDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.opDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opDivision.Name = "opDivision";
            this.opDivision.TabStop = true;
            this.opDivision.UseVisualStyleBackColor = false;
            this.opDivision.CheckedChanged += new System.EventHandler(this.opDivision_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.opDivision);
            this.Controls.Add(this.opMultiplicacion);
            this.Controls.Add(this.opResta);
            this.Controls.Add(this.opSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btResultado);
            this.HelpButton = true;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton opSuma;
        private System.Windows.Forms.RadioButton opResta;
        private System.Windows.Forms.RadioButton opMultiplicacion;
        private System.Windows.Forms.RadioButton opDivision;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

