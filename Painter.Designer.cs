namespace JP_Painter
{
    partial class Painter
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
            this.components = new System.ComponentModel.Container();
            this.clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPicker = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeW = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.sizeH = new System.Windows.Forms.NumericUpDown();
            this.position = new System.Windows.Forms.Label();
            this.randBt = new System.Windows.Forms.Button();
            this.freestyle = new System.Windows.Forms.GroupBox();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).BeginInit();
            this.freestyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(575, 402);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 33);
            this.clear.TabIndex = 0;
            this.clear.Text = "Reset";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(19, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 360);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.updatePosition);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Maroon;
            this.colorPicker.Location = new System.Drawing.Point(49, 22);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(33, 13);
            this.colorPicker.TabIndex = 3;
            this.colorPicker.Visible = false;
            this.colorPicker.Click += new System.EventHandler(this.changeColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transparency:";
            this.label2.Visible = false;
            // 
            // transp
            // 
            this.transp.Location = new System.Drawing.Point(185, 20);
            this.transp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.transp.Name = "transp";
            this.transp.Size = new System.Drawing.Size(44, 20);
            this.transp.TabIndex = 6;
            this.transp.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.transp.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size:";
            this.label3.Visible = false;
            // 
            // sizeW
            // 
            this.sizeW.DecimalPlaces = 2;
            this.sizeW.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sizeW.Location = new System.Drawing.Point(285, 20);
            this.sizeW.Name = "sizeW";
            this.sizeW.Size = new System.Drawing.Size(49, 20);
            this.sizeW.TabIndex = 8;
            this.sizeW.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sizeW.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "x";
            this.label4.Visible = false;
            // 
            // sizeH
            // 
            this.sizeH.DecimalPlaces = 2;
            this.sizeH.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sizeH.Location = new System.Drawing.Point(358, 20);
            this.sizeH.Name = "sizeH";
            this.sizeH.Size = new System.Drawing.Size(50, 20);
            this.sizeH.TabIndex = 10;
            this.sizeH.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sizeH.Visible = false;
            // 
            // position
            // 
            this.position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.position.Location = new System.Drawing.Point(559, 374);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(100, 13);
            this.position.TabIndex = 11;
            this.position.Text = "0,0";
            this.position.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // randBt
            // 
            this.randBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randBt.Location = new System.Drawing.Point(457, 17);
            this.randBt.Name = "randBt";
            this.randBt.Size = new System.Drawing.Size(50, 23);
            this.randBt.TabIndex = 16;
            this.randBt.Text = "Rand";
            this.randBt.UseVisualStyleBackColor = true;
            this.randBt.Click += new System.EventHandler(this.randBt_Click);
            // 
            // freestyle
            // 
            this.freestyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.freestyle.Controls.Add(this.randBt);
            this.freestyle.Controls.Add(this.colorPicker);
            this.freestyle.Controls.Add(this.label1);
            this.freestyle.Controls.Add(this.sizeH);
            this.freestyle.Controls.Add(this.label2);
            this.freestyle.Controls.Add(this.label4);
            this.freestyle.Controls.Add(this.transp);
            this.freestyle.Controls.Add(this.sizeW);
            this.freestyle.Controls.Add(this.label3);
            this.freestyle.Location = new System.Drawing.Point(19, 390);
            this.freestyle.Name = "freestyle";
            this.freestyle.Size = new System.Drawing.Size(513, 50);
            this.freestyle.TabIndex = 17;
            this.freestyle.TabStop = false;
            this.freestyle.Text = "Freestyle";
            // 
            // drawTimer
            // 
            this.drawTimer.Interval = 500;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 447);
            this.Controls.Add(this.freestyle);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.position);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Painter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Painter_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.transp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).EndInit();
            this.freestyle.ResumeLayout(false);
            this.freestyle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel colorPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown transp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sizeW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sizeH;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Button randBt;
        private System.Windows.Forms.GroupBox freestyle;
        private System.Windows.Forms.Timer drawTimer;
    }
}

