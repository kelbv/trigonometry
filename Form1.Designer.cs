namespace blank2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAnglesDegrees = new System.Windows.Forms.RadioButton();
            this.rbAnglesRadians = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maxmodud = new System.Windows.Forms.NumericUpDown();
            this.cbDrawArcs = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxmodud)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDrawArcs);
            this.panel1.Controls.Add(this.maxmodud);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 571);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAnglesDegrees);
            this.groupBox1.Controls.Add(this.rbAnglesRadians);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbAnglesDegrees
            // 
            this.rbAnglesDegrees.AutoSize = true;
            this.rbAnglesDegrees.Checked = true;
            this.rbAnglesDegrees.Location = new System.Drawing.Point(6, 19);
            this.rbAnglesDegrees.Name = "rbAnglesDegrees";
            this.rbAnglesDegrees.Size = new System.Drawing.Size(63, 17);
            this.rbAnglesDegrees.TabIndex = 1;
            this.rbAnglesDegrees.TabStop = true;
            this.rbAnglesDegrees.Text = "degrees";
            this.rbAnglesDegrees.UseVisualStyleBackColor = true;
            this.rbAnglesDegrees.CheckedChanged += new System.EventHandler(this.rbAnglesDegrees_CheckedChanged);
            // 
            // rbAnglesRadians
            // 
            this.rbAnglesRadians.AutoSize = true;
            this.rbAnglesRadians.Location = new System.Drawing.Point(6, 42);
            this.rbAnglesRadians.Name = "rbAnglesRadians";
            this.rbAnglesRadians.Size = new System.Drawing.Size(59, 17);
            this.rbAnglesRadians.TabIndex = 2;
            this.rbAnglesRadians.Text = "radians";
            this.rbAnglesRadians.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 336);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 235);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(239, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 571);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // maxmodud
            // 
            this.maxmodud.Location = new System.Drawing.Point(18, 107);
            this.maxmodud.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.maxmodud.Name = "maxmodud";
            this.maxmodud.Size = new System.Drawing.Size(120, 20);
            this.maxmodud.TabIndex = 4;
            this.maxmodud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxmodud.ValueChanged += new System.EventHandler(this.maxmodud_ValueChanged);
            // 
            // cbDrawArcs
            // 
            this.cbDrawArcs.AutoSize = true;
            this.cbDrawArcs.Location = new System.Drawing.Point(18, 157);
            this.cbDrawArcs.Name = "cbDrawArcs";
            this.cbDrawArcs.Size = new System.Drawing.Size(72, 17);
            this.cbDrawArcs.TabIndex = 5;
            this.cbDrawArcs.Text = "draw arcs";
            this.cbDrawArcs.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sine Cosine and Tan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxmodud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAnglesDegrees;
        private System.Windows.Forms.RadioButton rbAnglesRadians;
        private System.Windows.Forms.NumericUpDown maxmodud;
        private System.Windows.Forms.CheckBox cbDrawArcs;
    }
}

