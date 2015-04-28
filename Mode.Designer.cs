namespace JP_Painter
{
    partial class Mode
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
            this.dataPaint = new System.Windows.Forms.RadioButton();
            this.freesyle = new System.Windows.Forms.RadioButton();
            this.paint = new System.Windows.Forms.Button();
            this.dataImport = new System.Windows.Forms.GroupBox();
            this.pointsMapperBrowse = new System.Windows.Forms.Button();
            this.pointsMapperFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataFileBrowse = new System.Windows.Forms.Button();
            this.dataFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorsBrowse = new System.Windows.Forms.Button();
            this.bgImageBrowse = new System.Windows.Forms.Button();
            this.bgImageFile = new System.Windows.Forms.TextBox();
            this.colorsFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.reset = new System.Windows.Forms.Button();
            this.dataImport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPaint
            // 
            this.dataPaint.AutoSize = true;
            this.dataPaint.Checked = true;
            this.dataPaint.Location = new System.Drawing.Point(11, 19);
            this.dataPaint.Name = "dataPaint";
            this.dataPaint.Size = new System.Drawing.Size(75, 17);
            this.dataPaint.TabIndex = 0;
            this.dataPaint.TabStop = true;
            this.dataPaint.Text = "Data Paint";
            this.dataPaint.UseVisualStyleBackColor = true;
            this.dataPaint.CheckedChanged += new System.EventHandler(this.dataPaint_CheckedChanged);
            // 
            // freesyle
            // 
            this.freesyle.AutoSize = true;
            this.freesyle.Location = new System.Drawing.Point(92, 19);
            this.freesyle.Name = "freesyle";
            this.freesyle.Size = new System.Drawing.Size(67, 17);
            this.freesyle.TabIndex = 1;
            this.freesyle.Text = "Freestyle";
            this.freesyle.UseVisualStyleBackColor = true;
            this.freesyle.CheckedChanged += new System.EventHandler(this.freesyle_CheckedChanged);
            // 
            // paint
            // 
            this.paint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paint.Location = new System.Drawing.Point(375, 326);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(86, 30);
            this.paint.TabIndex = 2;
            this.paint.Text = "Paint";
            this.paint.UseVisualStyleBackColor = true;
            this.paint.Click += new System.EventHandler(this.paint_Click);
            // 
            // dataImport
            // 
            this.dataImport.Controls.Add(this.pointsMapperBrowse);
            this.dataImport.Controls.Add(this.pointsMapperFile);
            this.dataImport.Controls.Add(this.label2);
            this.dataImport.Controls.Add(this.dataFileBrowse);
            this.dataImport.Controls.Add(this.dataFile);
            this.dataImport.Controls.Add(this.label1);
            this.dataImport.Location = new System.Drawing.Point(12, 70);
            this.dataImport.Name = "dataImport";
            this.dataImport.Size = new System.Drawing.Size(453, 87);
            this.dataImport.TabIndex = 3;
            this.dataImport.TabStop = false;
            this.dataImport.Text = "Data Import";
            // 
            // pointsMapperBrowse
            // 
            this.pointsMapperBrowse.Location = new System.Drawing.Point(372, 44);
            this.pointsMapperBrowse.Name = "pointsMapperBrowse";
            this.pointsMapperBrowse.Size = new System.Drawing.Size(75, 23);
            this.pointsMapperBrowse.TabIndex = 5;
            this.pointsMapperBrowse.Text = "Browse";
            this.pointsMapperBrowse.UseVisualStyleBackColor = true;
            this.pointsMapperBrowse.Click += new System.EventHandler(this.pointsMapperBrowse_Click);
            // 
            // pointsMapperFile
            // 
            this.pointsMapperFile.Location = new System.Drawing.Point(92, 46);
            this.pointsMapperFile.Name = "pointsMapperFile";
            this.pointsMapperFile.ReadOnly = true;
            this.pointsMapperFile.Size = new System.Drawing.Size(274, 20);
            this.pointsMapperFile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points Mapper:";
            // 
            // dataFileBrowse
            // 
            this.dataFileBrowse.Location = new System.Drawing.Point(372, 18);
            this.dataFileBrowse.Name = "dataFileBrowse";
            this.dataFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.dataFileBrowse.TabIndex = 2;
            this.dataFileBrowse.Text = "Browse";
            this.dataFileBrowse.UseVisualStyleBackColor = true;
            this.dataFileBrowse.Click += new System.EventHandler(this.dataFileBrowse_Click);
            // 
            // dataFile
            // 
            this.dataFile.Location = new System.Drawing.Point(92, 20);
            this.dataFile.Name = "dataFile";
            this.dataFile.ReadOnly = true;
            this.dataFile.Size = new System.Drawing.Size(274, 20);
            this.dataFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data File:";
            // 
            // openCSVFileDialog
            // 
            this.openCSVFileDialog.Filter = "Excel File|*.xlsx|Excel File|*.xls";
            this.openCSVFileDialog.InitialDirectory = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorsBrowse);
            this.groupBox1.Controls.Add(this.bgImageBrowse);
            this.groupBox1.Controls.Add(this.bgImageFile);
            this.groupBox1.Controls.Add(this.colorsFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canvas";
            // 
            // colorsBrowse
            // 
            this.colorsBrowse.Location = new System.Drawing.Point(370, 47);
            this.colorsBrowse.Name = "colorsBrowse";
            this.colorsBrowse.Size = new System.Drawing.Size(75, 23);
            this.colorsBrowse.TabIndex = 12;
            this.colorsBrowse.Text = "Browse";
            this.colorsBrowse.UseVisualStyleBackColor = true;
            this.colorsBrowse.Click += new System.EventHandler(this.colorsBrowse_Click);
            // 
            // bgImageBrowse
            // 
            this.bgImageBrowse.Location = new System.Drawing.Point(370, 20);
            this.bgImageBrowse.Name = "bgImageBrowse";
            this.bgImageBrowse.Size = new System.Drawing.Size(75, 23);
            this.bgImageBrowse.TabIndex = 8;
            this.bgImageBrowse.Text = "Browse";
            this.bgImageBrowse.UseVisualStyleBackColor = true;
            this.bgImageBrowse.Click += new System.EventHandler(this.bgImageBrowse_Click);
            // 
            // bgImageFile
            // 
            this.bgImageFile.Location = new System.Drawing.Point(109, 22);
            this.bgImageFile.Name = "bgImageFile";
            this.bgImageFile.ReadOnly = true;
            this.bgImageFile.Size = new System.Drawing.Size(255, 20);
            this.bgImageFile.TabIndex = 7;
            // 
            // colorsFile
            // 
            this.colorsFile.Location = new System.Drawing.Point(109, 49);
            this.colorsFile.Name = "colorsFile";
            this.colorsFile.ReadOnly = true;
            this.colorsFile.Size = new System.Drawing.Size(255, 20);
            this.colorsFile.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Background Image:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Colors:";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(203, 76);
            this.height.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(53, 20);
            this.height.TabIndex = 3;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Height (px):";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(70, 76);
            this.width.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(53, 20);
            this.width.TabIndex = 1;
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.width.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width (px):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataPaint);
            this.groupBox2.Controls.Add(this.freesyle);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "PNG files|*.png|JPEG files|*.jpg";
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Location = new System.Drawing.Point(297, 326);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(72, 30);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataImport);
            this.Controls.Add(this.paint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mode";
            this.Text = "Painter Mode";
            this.Load += new System.EventHandler(this.Mode_Load);
            this.dataImport.ResumeLayout(false);
            this.dataImport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton dataPaint;
        private System.Windows.Forms.RadioButton freesyle;
        private System.Windows.Forms.Button paint;
        private System.Windows.Forms.GroupBox dataImport;
        private System.Windows.Forms.Button pointsMapperBrowse;
        private System.Windows.Forms.TextBox pointsMapperFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dataFileBrowse;
        private System.Windows.Forms.TextBox dataFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openCSVFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bgImageBrowse;
        private System.Windows.Forms.TextBox bgImageFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button colorsBrowse;
        private System.Windows.Forms.TextBox colorsFile;
        private System.Windows.Forms.Label label7;
    }
}