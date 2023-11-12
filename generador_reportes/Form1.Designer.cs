namespace generador_reportes
{
    partial class frm_reports
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
            this.lbl_automation = new System.Windows.Forms.Label();
            this.bar_load = new System.Windows.Forms.ProgressBar();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.img_check = new System.Windows.Forms.PictureBox();
            this.img_load = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_automation
            // 
            this.lbl_automation.AutoSize = true;
            this.lbl_automation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_automation.ForeColor = System.Drawing.Color.White;
            this.lbl_automation.Location = new System.Drawing.Point(452, 48);
            this.lbl_automation.Name = "lbl_automation";
            this.lbl_automation.Size = new System.Drawing.Size(318, 32);
            this.lbl_automation.TabIndex = 0;
            this.lbl_automation.Text = "Automation Enclosures";
            // 
            // bar_load
            // 
            this.bar_load.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bar_load.Location = new System.Drawing.Point(-2, 434);
            this.bar_load.Name = "bar_load";
            this.bar_load.Size = new System.Drawing.Size(805, 31);
            this.bar_load.TabIndex = 2;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.White;
            this.btn_inicio.Location = new System.Drawing.Point(332, 327);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(164, 46);
            this.btn_inicio.TabIndex = 3;
            this.btn_inicio.Text = "Generar Reporte";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(12, 398);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(233, 24);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developer Marco Rico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // img_check
            // 
            this.img_check.Image = global::generador_reportes.Properties.Resources.lista_de_verificacion;
            this.img_check.Location = new System.Drawing.Point(347, 144);
            this.img_check.Name = "img_check";
            this.img_check.Size = new System.Drawing.Size(135, 137);
            this.img_check.TabIndex = 6;
            this.img_check.TabStop = false;
            this.img_check.Visible = false;
            // 
            // img_load
            // 
            this.img_load.Image = global::generador_reportes.Properties.Resources.cargando;
            this.img_load.Location = new System.Drawing.Point(347, 144);
            this.img_load.Name = "img_load";
            this.img_load.Size = new System.Drawing.Size(135, 137);
            this.img_load.TabIndex = 5;
            this.img_load.TabStop = false;
            this.img_load.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::generador_reportes.Properties.Resources.getsitelogo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 77);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img_check);
            this.Controls.Add(this.img_load);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.bar_load);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_automation);
            this.Name = "frm_reports";
            this.Text = "Hipot Ckeck";
            ((System.ComponentModel.ISupportInitialize)(this.img_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_automation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar bar_load;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox img_load;
        private System.Windows.Forms.PictureBox img_check;
    }
}

