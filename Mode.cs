using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JP_Painter
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void loadSettings()
        {
            if (Properties.Settings.Default.IsFreestyle)
            {
                freesyle.Select();
            }
            else
            {
                dataPaint.Select();
            }
            
            width.Value = Properties.Settings.Default.CanvasWidth;
            height.Value = Properties.Settings.Default.CanvasHeight;

            if (File.Exists(Properties.Settings.Default.DataFile))
                dataFile.Text = Properties.Settings.Default.DataFile;
            else
                dataFile.Text = "";

            if (File.Exists(Properties.Settings.Default.PointsMapperFile))
                pointsMapperFile.Text = Properties.Settings.Default.PointsMapperFile;
            else
                pointsMapperFile.Text = "";

            if (File.Exists(Properties.Settings.Default.BgImageFile))
                bgImageFile.Text = Properties.Settings.Default.BgImageFile;
            else
                bgImageFile.Text = "";

            if (File.Exists(Properties.Settings.Default.ColorsFile))
                colorsFile.Text = Properties.Settings.Default.ColorsFile;
            else
                colorsFile.Text = "";
        }

        private void dataPaint_CheckedChanged(object sender, EventArgs e)
        {
            dataImport.Enabled = true;
        }

        private void freesyle_CheckedChanged(object sender, EventArgs e)
        {
            dataImport.Enabled = false;
        }

        private void paint_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (dataPaint.Checked)
            {
                if (dataFile.Text.Length == 0)
                {
                    MessageBox.Show(this, "Please choose a data file", "Data File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                }
                else if (pointsMapperFile.Text.Length == 0)
                {
                    MessageBox.Show(this, "Please choose a points mapper file", "Points Mapper Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                }
                else if (colorsFile.Text.Length == 0)
                {
                    MessageBox.Show(this, "Please choose a colors file", "Colors File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                }
            }

            if (!valid)
                return;


            Properties.Settings.Default.IsFreestyle = freesyle.Checked;
            Properties.Settings.Default.CanvasWidth =  (uint) width.Value;
            Properties.Settings.Default.CanvasHeight = (uint) height.Value;

            Properties.Settings.Default.DataFile = dataFile.Text;
            Properties.Settings.Default.PointsMapperFile = pointsMapperFile.Text;
            Properties.Settings.Default.BgImageFile = bgImageFile.Text;
            Properties.Settings.Default.ColorsFile = colorsFile.Text;

            Properties.Settings.Default.Save();


            Painter painter = null;
            Size painterSize = new System.Drawing.Size((int)width.Value, (int)height.Value);
            Image bgImage = null;

            if (bgImageFile.Text.Length > 0)
            {
                bgImage = Image.FromFile(bgImageFile.Text);
            }

            if (dataPaint.Checked)
            {
                painter = new Painter(painterSize, bgImage, colorsFile.Text, dataFile.Text, pointsMapperFile.Text);
            }
            else
            {
                painter = new Painter(painterSize, bgImage, colorsFile.Text);
            }


            this.Hide();
            painter.ShowDialog();
            this.Show();
        }

        private void dataFileBrowse_Click(object sender, EventArgs e)
        {
            if (openCSVFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataFile.Text = openCSVFileDialog.FileName;
            }
            else
            {
                dataFile.Text = "";
            }
        }

        private void pointsMapperBrowse_Click(object sender, EventArgs e)
        {
            if (openCSVFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pointsMapperFile.Text = openCSVFileDialog.FileName;
            }
            else
            {
                pointsMapperFile.Text = "";
            }
        }

        private void bgImageBrowse_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bgImageFile.Text = openImageDialog.FileName;
                Image img = Image.FromFile(bgImageFile.Text);

                width.Value = img.Width;
                height.Value = img.Height;
            }
            else
            {
                bgImageFile.Text = "";
            }
        }

        private void Mode_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            loadSettings();
        }

        private void colorsBrowse_Click(object sender, EventArgs e)
        {
            if (openCSVFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colorsFile.Text = openCSVFileDialog.FileName;
            }
            else
            {
                colorsFile.Text = "";
            }
        }
    }
}
