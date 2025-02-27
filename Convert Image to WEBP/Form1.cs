// MIT License
// 
// Copyright (c) 2025 Xlearnmore
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using FreeImageAPI;
using System.Collections.Generic;
using System.Linq;

namespace Convert_Image_to_WEBP
{
    public partial class Form1 : Form
    {
        private string selectedImagePath;
        private Image selectedImage;
        private List<string> selectedImagePaths = new List<string>();
        private string outputFolderPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Select Images";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedImagePaths.Clear();
                        selectedImagePaths.AddRange(openFileDialog.FileNames);
                        txtImagePath.Text = $"{selectedImagePaths.Count} files selected";

                        // Clear the ListView and add the new images
                        listViewImages.Items.Clear();
                        foreach (var imagePath in selectedImagePaths)
                        {
                            listViewImages.Items.Add(Path.GetFileName(imagePath));
                        }

                        btnConvert.Enabled = true;
                        trackBarQuality.Enabled = true;
                        numericQuality.Enabled = true;

                        // Set default output folder to the same as first image
                        string directory = Path.GetDirectoryName(selectedImagePaths[0]);
                        outputFolderPath = directory;
                        txtOutputPath.Text = outputFolderPath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading images: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder containing images to convert";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] imageExtensions = { "*.jpg", "*.jpeg", "*.png", "*.bmp", "*.gif" };
                        selectedImagePaths.Clear();

                        selectedImagePaths = Directory.EnumerateFiles(folderDialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
                              .Where(f => imageExtensions.Contains(Path.GetExtension(f).ToLower()))
                              .ToList();


                        txtImagePath.Text = $"{selectedImagePaths.Count} files found in folder";

                        // Clear the ListView and add the new images
                        listViewImages.Items.Clear();
                        foreach (var imagePath in selectedImagePaths)
                        {
                            listViewImages.Items.Add(Path.GetFileName(imagePath));
                        }

                        btnConvert.Enabled = true;
                        trackBarQuality.Enabled = true;
                        numericQuality.Enabled = true;

                        // Set default output folder to the same as input folder
                        outputFolderPath = folderDialog.SelectedPath;
                        txtOutputPath.Text = outputFolderPath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error accessing folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select output folder for WebP images";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFolderPath = folderDialog.SelectedPath;
                    txtOutputPath.Text = outputFolderPath;
                }
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (selectedImagePaths.Count == 0)
            {
                MessageBox.Show("Please select images first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(outputFolderPath))
            {
                MessageBox.Show("Please specify an output folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quality = (int)numericQuality.Value;

            EnableControls(false);
            progressBar.Progress = 0;
            progressBar.Maximum = selectedImagePaths.Count;
            progressBar.Visible = true;
            lblStatus.Text = "Converting...";
            lblStatus.Visible = true;

            if (!Directory.Exists(outputFolderPath))
            {
                MessageBox.Show("Output folder does not exist or could not be created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int successCount = 0;
            int failCount = 0;

            try
            {
                for (int i = 0; i < selectedImagePaths.Count; i++)
                {
                    string currentImagePath = selectedImagePaths[i];
                    string filename = Path.GetFileNameWithoutExtension(currentImagePath);
                    string outputFilePath = Path.Combine(outputFolderPath, filename + ".webp");

                    lblStatus.Text = $"Converting {i + 1} of {selectedImagePaths.Count}...";
                    Application.DoEvents();

                    try
                    {
                        await Task.Run(() =>
                        {
                            FIBITMAP dib = FreeImage.LoadEx(currentImagePath);
                            if (dib.IsNull)
                            {
                                throw new Exception($"Failed to load image: {currentImagePath}");
                            }

                            string outputFile = Path.Combine(outputFolderPath, filename + ".webp");

                            Console.WriteLine($"Converting: {currentImagePath}");
                            Console.WriteLine($"Saving to: {outputFile}");

                            FreeImage.Save(FREE_IMAGE_FORMAT.FIF_WEBP, dib, outputFile, FREE_IMAGE_SAVE_FLAGS.WEBP_DEFAULT);
                            FreeImage.UnloadEx(ref dib);

                            if (!File.Exists(outputFile))
                            {
                                throw new Exception($"Failed to save file: {outputFile}");
                            }
                        });

                        successCount++;

                        // Remove the converted image from the ListView
                        var itemToRemove = listViewImages.Items.Cast<ListViewItem>()
                                                              .FirstOrDefault(item => item.Text == Path.GetFileName(currentImagePath));
                        if (itemToRemove != null)
                        {
                            listViewImages.Items.Remove(itemToRemove);
                        }
                    }
                    catch (Exception ex)
                    {
                        failCount++;
                        Console.WriteLine($"Error converting {currentImagePath}: {ex.Message}");
                    }

                    Invoke(new Action(() =>
                    {
                        progressBar.Progress = i + 1;
                        lblStatus.Text = $"Converting {i + 1} of {selectedImagePaths.Count}...";
                    }));

                }

                lblStatus.Text = "Conversion completed!";
                MessageBox.Show($"Conversion completed!\n\nSuccessfully converted: {successCount} images\nFailed: {failCount} images",
                    "Conversion Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Conversion failed.";
            }
            finally
            {
                EnableControls(true);
            }
        }

        private void EnableControls(bool enable)
        {
            btnSelectImages.Enabled = enable;
            btnSelectFolder.Enabled = enable;
            btnOutputBrowse.Enabled = enable;
            btnConvert.Enabled = enable && selectedImagePaths.Count > 0;
            trackBarQuality.Enabled = enable && selectedImagePaths.Count > 0;
            numericQuality.Enabled = enable && selectedImagePaths.Count > 0;
        }

        private void trackBarQuality_Scroll(object sender, EventArgs e)
        {
            numericQuality.Value = trackBarQuality.Value;
        }

        private void numericQuality_ValueChanged(object sender, EventArgs e)
        {
            trackBarQuality.Value = (int)numericQuality.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectedImage != null)
            {
                selectedImage.Dispose();
            }
        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {

        }

        private void carbonFiberProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}