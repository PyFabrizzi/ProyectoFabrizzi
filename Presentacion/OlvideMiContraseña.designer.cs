
namespace Presentacion
{
    partial class OlvideMiContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlvideMiContraseña));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconclose = new System.Windows.Forms.PictureBox();
            this.Btn_GuardarNuevaPass = new System.Windows.Forms.Button();
            this.lbl_RepetirPass = new System.Windows.Forms.Label();
            this.lbl_NuevaPass = new System.Windows.Forms.Label();
            this.tBox_RepetirPass = new System.Windows.Forms.TextBox();
            this.tBox_NuevaPass = new System.Windows.Forms.TextBox();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.tBox_Legajo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 134);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // iconclose
            // 
            this.iconclose.Image = ((System.Drawing.Image)(resources.GetObject("iconclose.Image")));
            this.iconclose.Location = new System.Drawing.Point(357, 12);
            this.iconclose.Name = "iconclose";
            this.iconclose.Size = new System.Drawing.Size(29, 24);
            this.iconclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconclose.TabIndex = 78;
            this.iconclose.TabStop = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click);
            // 
            // Btn_GuardarNuevaPass
            // 
            this.Btn_GuardarNuevaPass.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_GuardarNuevaPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarNuevaPass.ForeColor = System.Drawing.Color.White;
            this.Btn_GuardarNuevaPass.Location = new System.Drawing.Point(141, 281);
            this.Btn_GuardarNuevaPass.Name = "Btn_GuardarNuevaPass";
            this.Btn_GuardarNuevaPass.Size = new System.Drawing.Size(129, 49);
            this.Btn_GuardarNuevaPass.TabIndex = 76;
            this.Btn_GuardarNuevaPass.Text = "Guardar";
            this.Btn_GuardarNuevaPass.UseVisualStyleBackColor = false;
            this.Btn_GuardarNuevaPass.Click += new System.EventHandler(this.Btn_GuardarNuevaPass_Click);
            // 
            // lbl_RepetirPass
            // 
            this.lbl_RepetirPass.AutoSize = true;
            this.lbl_RepetirPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RepetirPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RepetirPass.ForeColor = System.Drawing.Color.White;
            this.lbl_RepetirPass.Location = new System.Drawing.Point(37, 229);
            this.lbl_RepetirPass.Name = "lbl_RepetirPass";
            this.lbl_RepetirPass.Size = new System.Drawing.Size(133, 17);
            this.lbl_RepetirPass.TabIndex = 75;
            this.lbl_RepetirPass.Text = "Repetir Contraseña";
            // 
            // lbl_NuevaPass
            // 
            this.lbl_NuevaPass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_NuevaPass.AutoSize = true;
            this.lbl_NuevaPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NuevaPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevaPass.ForeColor = System.Drawing.Color.White;
            this.lbl_NuevaPass.Location = new System.Drawing.Point(37, 194);
            this.lbl_NuevaPass.Name = "lbl_NuevaPass";
            this.lbl_NuevaPass.Size = new System.Drawing.Size(131, 17);
            this.lbl_NuevaPass.TabIndex = 74;
            this.lbl_NuevaPass.Text = "Nueva Contraseña";
            // 
            // tBox_RepetirPass
            // 
            this.tBox_RepetirPass.Location = new System.Drawing.Point(198, 229);
            this.tBox_RepetirPass.Name = "tBox_RepetirPass";
            this.tBox_RepetirPass.PasswordChar = '*';
            this.tBox_RepetirPass.Size = new System.Drawing.Size(129, 20);
            this.tBox_RepetirPass.TabIndex = 73;
            // 
            // tBox_NuevaPass
            // 
            this.tBox_NuevaPass.Location = new System.Drawing.Point(198, 194);
            this.tBox_NuevaPass.Name = "tBox_NuevaPass";
            this.tBox_NuevaPass.PasswordChar = '*';
            this.tBox_NuevaPass.Size = new System.Drawing.Size(129, 20);
            this.tBox_NuevaPass.TabIndex = 72;
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Legajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Legajo.ForeColor = System.Drawing.Color.White;
            this.lbl_Legajo.Location = new System.Drawing.Point(39, 156);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(52, 17);
            this.lbl_Legajo.TabIndex = 81;
            this.lbl_Legajo.Text = "Legajo";
            // 
            // tBox_Legajo
            // 
            this.tBox_Legajo.Location = new System.Drawing.Point(198, 156);
            this.tBox_Legajo.Name = "tBox_Legajo";
            this.tBox_Legajo.Size = new System.Drawing.Size(129, 20);
            this.tBox_Legajo.TabIndex = 80;
            // 
            // OlvideMiContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(398, 367);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.tBox_Legajo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconclose);
            this.Controls.Add(this.Btn_GuardarNuevaPass);
            this.Controls.Add(this.lbl_RepetirPass);
            this.Controls.Add(this.lbl_NuevaPass);
            this.Controls.Add(this.tBox_RepetirPass);
            this.Controls.Add(this.tBox_NuevaPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OlvideMiContraseña";
            this.Text = "OlvideMiContraseña";
            this.Load += new System.EventHandler(this.OlvideMiContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconclose;
        private System.Windows.Forms.Button Btn_GuardarNuevaPass;
        private System.Windows.Forms.Label lbl_RepetirPass;
        private System.Windows.Forms.Label lbl_NuevaPass;
        private System.Windows.Forms.TextBox tBox_RepetirPass;
        private System.Windows.Forms.TextBox tBox_NuevaPass;
        private System.Windows.Forms.Label lbl_Legajo;
        private System.Windows.Forms.TextBox tBox_Legajo;
    }
}