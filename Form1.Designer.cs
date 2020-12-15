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
            this.btnTheta = new System.Windows.Forms.Button();
            this.thetaUd = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbArc = new System.Windows.Forms.CheckBox();
            this.arcUd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSnapToDegrees = new System.Windows.Forms.CheckBox();
            this.cbDrawArcs = new System.Windows.Forms.CheckBox();
            this.maxmodud = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAnglesDegrees = new System.Windows.Forms.RadioButton();
            this.rbAnglesRadians = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thetaUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxmodud)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTheta);
            this.panel1.Controls.Add(this.thetaUd);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.cbArc);
            this.panel1.Controls.Add(this.arcUd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSnapToDegrees);
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
            // btnTheta
            // 
            this.btnTheta.Location = new System.Drawing.Point(160, 109);
            this.btnTheta.Name = "btnTheta";
            this.btnTheta.Size = new System.Drawing.Size(62, 23);
            this.btnTheta.TabIndex = 12;
            this.btnTheta.Text = "go";
            this.btnTheta.UseVisualStyleBackColor = true;
            this.btnTheta.Click += new System.EventHandler(this.btnTheta_Click);
            // 
            // thetaUd
            // 
            this.thetaUd.DecimalPlaces = 2;
            this.thetaUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.thetaUd.Location = new System.Drawing.Point(68, 112);
            this.thetaUd.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.thetaUd.Name = "thetaUd";
            this.thetaUd.Size = new System.Drawing.Size(86, 20);
            this.thetaUd.TabIndex = 11;
            this.thetaUd.ValueChanged += new System.EventHandler(this.thetaUd_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(17, 177);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 104);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Click right mouse button to toggle arcs, click middle mousebutton to repeat sweep" +
    " of arc from circle to tangent. Hold both mouse buttons to change radius";
            // 
            // cbArc
            // 
            this.cbArc.AutoSize = true;
            this.cbArc.Location = new System.Drawing.Point(144, 310);
            this.cbArc.Name = "cbArc";
            this.cbArc.Size = new System.Drawing.Size(62, 17);
            this.cbArc.TabIndex = 9;
            this.cbArc.Text = "one arc";
            this.cbArc.UseVisualStyleBackColor = true;
            this.cbArc.Visible = false;
            this.cbArc.CheckedChanged += new System.EventHandler(this.cbArc_CheckedChanged);
            // 
            // arcUd
            // 
            this.arcUd.Location = new System.Drawing.Point(18, 310);
            this.arcUd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.arcUd.Name = "arcUd";
            this.arcUd.Size = new System.Drawing.Size(120, 20);
            this.arcUd.TabIndex = 8;
            this.arcUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arcUd.Visible = false;
            this.arcUd.ValueChanged += new System.EventHandler(this.arcUd_ValueChanged);
            this.arcUd.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.arcud_MouseWheel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "scale";
            // 
            // cbSnapToDegrees
            // 
            this.cbSnapToDegrees.AutoSize = true;
            this.cbSnapToDegrees.Location = new System.Drawing.Point(18, 87);
            this.cbSnapToDegrees.Name = "cbSnapToDegrees";
            this.cbSnapToDegrees.Size = new System.Drawing.Size(102, 17);
            this.cbSnapToDegrees.TabIndex = 6;
            this.cbSnapToDegrees.Text = "snap to degrees";
            this.cbSnapToDegrees.UseVisualStyleBackColor = true;
            this.cbSnapToDegrees.CheckedChanged += new System.EventHandler(this.cbSnapToDegrees_CheckedChanged);
            // 
            // cbDrawArcs
            // 
            this.cbDrawArcs.AutoSize = true;
            this.cbDrawArcs.Location = new System.Drawing.Point(18, 287);
            this.cbDrawArcs.Name = "cbDrawArcs";
            this.cbDrawArcs.Size = new System.Drawing.Size(72, 17);
            this.cbDrawArcs.TabIndex = 5;
            this.cbDrawArcs.Text = "draw arcs";
            this.cbDrawArcs.UseVisualStyleBackColor = true;
            this.cbDrawArcs.Visible = false;
            this.cbDrawArcs.CheckedChanged += new System.EventHandler(this.cbDrawArcs_CheckedChanged);
            // 
            // maxmodud
            // 
            this.maxmodud.DecimalPlaces = 1;
            this.maxmodud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.maxmodud.Location = new System.Drawing.Point(68, 145);
            this.maxmodud.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.maxmodud.Name = "maxmodud";
            this.maxmodud.Size = new System.Drawing.Size(86, 20);
            this.maxmodud.TabIndex = 4;
            this.maxmodud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxmodud.ValueChanged += new System.EventHandler(this.maxmodud_ValueChanged);
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
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "theta (θ)";
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thetaUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxmodud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSnapToDegrees;
        private System.Windows.Forms.CheckBox cbArc;
        private System.Windows.Forms.NumericUpDown arcUd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTheta;
        private System.Windows.Forms.NumericUpDown thetaUd;
        private System.Windows.Forms.Label label2;
    }
}

