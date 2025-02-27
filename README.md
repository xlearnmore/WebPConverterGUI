# 🖼️ Convert Image to WebP

A Windows Forms application that allows users to convert images (**JPG, PNG, BMP, GIF**) to **WebP** format using the **FreeImageAPI**.

## ✨ Features
- ✅ **Select Images**: Choose multiple images manually via file dialog.
- 📂 **Select Folder**: Choose an entire folder to process all images inside.
- 🎛️ **Adjustable Quality**: Set WebP compression quality using a slider or numeric input.
- 📁 **Output Folder Selection**: Choose where to save the converted WebP images.
- ⚡ **Batch Processing**: Convert multiple images at once with progress tracking.
- 🔄 **Live Status Update**: Displays the number of images processed and remaining.
- 🚨 **Error Handling**: Notifies users if an image fails to convert.

## 🔧 Prerequisites
- 🖥️ Windows OS (Windows 10/11 or Windows Server 2019+ recommended)
- 🏗️ .NET Framework 4.7.2 or higher
- 🖼️ FreeImageAPI.dll (included in the project)
- 🔧 Freeimage.dll

## 📥 Installation
1. **Clone the repository**:
   ```sh
   git clone https://github.com/yourusername/Convert-Image-to-WebP.git
   cd Convert-Image-to-WebP
   ```
2. **Open the project** in Visual Studio.
3. **Restore NuGet Packages** (if required).
4. **Build & Run the project**.

## 🚀 How to Use
1. **Launch the application**.
2. Click **"📷 Select Images"** to choose specific images or **"📂 Select Folder"** to load all images from a directory.
3. Adjust the **🎚️ quality slider** (default: 80) if needed.
4. Choose the **💾 output folder** (default: same as input folder).
5. Click **"🔄 Convert to WebP"** and wait for the process to complete.
6. Converted images will be saved in the selected output folder.

## 📦 Dependencies
- [🖼️ FreeImageAPI](http://freeimage.sourceforge.net/)

## ⚠️ Known Issues
- ❌ Some images may fail to load due to unsupported formats.
- 🕒 Large batches may take time depending on system performance.

## 📜 License
This project is licensed under the **MIT License**.

## 👤 Author
[Xlearnmore](https://github.com/xlearnmore)

