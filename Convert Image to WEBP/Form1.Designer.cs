using ImageProcessor.Imaging.Helpers;
using System.IO;
using System.Windows.Forms;

namespace Convert_Image_to_WEBP
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
            this.listViewImages = new System.Windows.Forms.ListView();
            this.progressBar = new CS_ClassLibraryTester.CarbonFiberProgressBar();
            this.nsTheme1 = new NSTheme();
            this.nsGroupBox2 = new NSGroupBox();
            this.carbonFiberLabel1 = new CS_ClassLibraryTester.CarbonFiberLabel();
            this.numericQuality = new System.Windows.Forms.NumericUpDown();
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.nsGroupBox1 = new NSGroupBox();
            this.nsControlButton3 = new NSControlButton();
            this.nsControlButton2 = new NSControlButton();
            this.nsControlButton1 = new NSControlButton();
            this.lblStatus = new VitalityLabel();
            this.nsLabel2 = new NSLabel();
            this.nsLabel1 = new NSLabel();
            this.btnSelectFolder = new NSButton();
            this.btnSelectImages = new NSButton();
            this.btnOutputBrowse = new NSButton();
            this.txtOutputPath = new NSTextBox();
            this.txtImagePath = new NSTextBox();
            this.btnConvert = new NSButton();
            this.nsTheme1.SuspendLayout();
            this.nsGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.nsGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewImages
            // 
            this.listViewImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listViewImages.ForeColor = System.Drawing.SystemColors.Menu;
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(12, 47);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(344, 136);
            this.listViewImages.TabIndex = 3;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            this.listViewImages.View = System.Windows.Forms.View.List;
            this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.listViewImages_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Current = 0D;
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar.Location = new System.Drawing.Point(114, 123);
            this.progressBar.Maximum = 0D;
            this.progressBar.Name = "progressBar";
            this.progressBar.Progress = 0D;
            this.progressBar.ShowPercentage = true;
            this.progressBar.Size = new System.Drawing.Size(548, 23);
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.nsGroupBox2);
            this.nsTheme1.Controls.Add(this.nsGroupBox1);
            this.nsTheme1.Controls.Add(this.nsControlButton3);
            this.nsTheme1.Controls.Add(this.nsControlButton2);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Controls.Add(this.lblStatus);
            this.nsTheme1.Controls.Add(this.nsLabel2);
            this.nsTheme1.Controls.Add(this.nsLabel1);
            this.nsTheme1.Controls.Add(this.btnSelectFolder);
            this.nsTheme1.Controls.Add(this.btnSelectImages);
            this.nsTheme1.Controls.Add(this.btnOutputBrowse);
            this.nsTheme1.Controls.Add(this.txtOutputPath);
            this.nsTheme1.Controls.Add(this.txtImagePath);
            this.nsTheme1.Controls.Add(this.btnConvert);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = true;
            this.nsTheme1.Size = new System.Drawing.Size(772, 429);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nsTheme1.TabIndex = 13;
            this.nsTheme1.Text = "Xlearnmore WebP";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.Controls.Add(this.carbonFiberLabel1);
            this.nsGroupBox2.Controls.Add(this.numericQuality);
            this.nsGroupBox2.Controls.Add(this.trackBarQuality);
            this.nsGroupBox2.DrawSeperator = true;
            this.nsGroupBox2.Location = new System.Drawing.Point(393, 178);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(367, 121);
            this.nsGroupBox2.SubTitle = "Settings";
            this.nsGroupBox2.TabIndex = 20;
            this.nsGroupBox2.Text = "nsGroupBox2";
            this.nsGroupBox2.Title = "Conversion";
            // 
            // carbonFiberLabel1
            // 
            this.carbonFiberLabel1.BackColor = System.Drawing.Color.Transparent;
            this.carbonFiberLabel1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.carbonFiberLabel1.Customization = "";
            this.carbonFiberLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonFiberLabel1.Image = null;
            this.carbonFiberLabel1.Location = new System.Drawing.Point(16, 47);
            this.carbonFiberLabel1.Name = "carbonFiberLabel1";
            this.carbonFiberLabel1.NoRounding = false;
            this.carbonFiberLabel1.Size = new System.Drawing.Size(73, 14);
            this.carbonFiberLabel1.TabIndex = 3;
            this.carbonFiberLabel1.Text = "Quality (%)";
            this.carbonFiberLabel1.Transparent = true;
            // 
            // numericQuality
            // 
            this.numericQuality.Enabled = false;
            this.numericQuality.Location = new System.Drawing.Point(292, 67);
            this.numericQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuality.Name = "numericQuality";
            this.numericQuality.Size = new System.Drawing.Size(58, 20);
            this.numericQuality.TabIndex = 1;
            this.numericQuality.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericQuality.ValueChanged += new System.EventHandler(this.numericQuality_ValueChanged);
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Enabled = false;
            this.trackBarQuality.Location = new System.Drawing.Point(16, 67);
            this.trackBarQuality.Maximum = 100;
            this.trackBarQuality.Minimum = 1;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(270, 45);
            this.trackBarQuality.TabIndex = 0;
            this.trackBarQuality.TickFrequency = 10;
            this.trackBarQuality.Value = 80;
            this.trackBarQuality.Scroll += new System.EventHandler(this.trackBarQuality_Scroll);
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.listViewImages);
            this.nsGroupBox1.DrawSeperator = true;
            this.nsGroupBox1.Location = new System.Drawing.Point(15, 178);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(367, 199);
            this.nsGroupBox1.SubTitle = "List";
            this.nsGroupBox1.TabIndex = 19;
            this.nsGroupBox1.Text = "nsGroupBox1";
            this.nsGroupBox1.Title = "Image Converter";
            // 
            // nsControlButton3
            // 
            this.nsControlButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton3.ControlButton = NSControlButton.Button.Minimize;
            this.nsControlButton3.Location = new System.Drawing.Point(707, 3);
            this.nsControlButton3.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton3.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.Name = "nsControlButton3";
            this.nsControlButton3.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton3.TabIndex = 18;
            this.nsControlButton3.Text = "nsControlButton3";
            // 
            // nsControlButton2
            // 
            this.nsControlButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton2.ControlButton = NSControlButton.Button.MaximizeRestore;
            this.nsControlButton2.Location = new System.Drawing.Point(725, 3);
            this.nsControlButton2.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton2.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.Name = "nsControlButton2";
            this.nsControlButton2.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton2.TabIndex = 17;
            this.nsControlButton2.Text = "nsControlButton2";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(743, 3);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 16;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(347, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 15;
            // 
            // nsLabel2
            // 
            this.nsLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel2.Location = new System.Drawing.Point(20, 94);
            this.nsLabel2.Name = "nsLabel2";
            this.nsLabel2.Size = new System.Drawing.Size(90, 23);
            this.nsLabel2.TabIndex = 14;
            this.nsLabel2.Text = "nsLabel2";
            this.nsLabel2.Value1 = "OUTPUT";
            this.nsLabel2.Value2 = " IMAGE";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(25, 39);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(85, 23);
            this.nsLabel1.TabIndex = 13;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "SELECT";
            this.nsLabel1.Value2 = " IMAGE";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(669, 68);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(92, 23);
            this.btnSelectFolder.TabIndex = 12;
            this.btnSelectFolder.Text = "Select Folder...";
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Location = new System.Drawing.Point(668, 39);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(92, 23);
            this.btnSelectImages.TabIndex = 0;
            this.btnSelectImages.Text = "Select Files...";
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Location = new System.Drawing.Point(668, 97);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(92, 23);
            this.btnOutputBrowse.TabIndex = 6;
            this.btnOutputBrowse.Text = "Browse...";
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.AutoScroll = false;
            this.txtOutputPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputPath.Location = new System.Drawing.Point(114, 97);
            this.txtOutputPath.MaxLength = 32767;
            this.txtOutputPath.Multiline = false;
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.NumberBounds = new System.Drawing.Point(0, 0);
            this.txtOutputPath.NumbersOnly = false;
            this.txtOutputPath.ReadOnly = false;
            this.txtOutputPath.Size = new System.Drawing.Size(548, 20);
            this.txtOutputPath.TabIndex = 4;
            this.txtOutputPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOutputPath.UseSystemPasswordChar = false;
            // 
            // txtImagePath
            // 
            this.txtImagePath.AutoScroll = false;
            this.txtImagePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImagePath.Location = new System.Drawing.Point(114, 42);
            this.txtImagePath.MaxLength = 32767;
            this.txtImagePath.Multiline = false;
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.NumberBounds = new System.Drawing.Point(0, 0);
            this.txtImagePath.NumbersOnly = false;
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(548, 20);
            this.txtImagePath.TabIndex = 1;
            this.txtImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImagePath.UseSystemPasswordChar = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(15, 383);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(745, 34);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert Image";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 429);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Image to WebP Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.nsGroupBox2.ResumeLayout(false);
            this.nsGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.nsGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NSButton btnSelectImages;
        private NSTextBox txtImagePath;
        private NSTextBox txtOutputPath;
        private NSButton btnOutputBrowse;
        private NSButton btnConvert;
        private System.Windows.Forms.NumericUpDown numericQuality;
        private System.Windows.Forms.TrackBar trackBarQuality;
        private CS_ClassLibraryTester.CarbonFiberProgressBar progressBar;
        private NSButton btnSelectFolder;
        private ListView listViewImages;
        private NSTheme nsTheme1;
        private NSLabel nsLabel2;
        private NSLabel nsLabel1;
        private VitalityLabel lblStatus;
        private NSControlButton nsControlButton3;
        private NSControlButton nsControlButton2;
        private NSControlButton nsControlButton1;
        private NSGroupBox nsGroupBox1;
        private NSGroupBox nsGroupBox2;
        private CS_ClassLibraryTester.CarbonFiberLabel carbonFiberLabel1;
    }
}