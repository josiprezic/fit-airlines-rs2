using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    class ImageUploadHelper
    {
        //
        // MARK: - Public methods
        //

        public static byte[] Resize2Max50Kbytes(byte[] byteImageIn)
        {
            byte[] currentByteImageArray = byteImageIn;
            double scale = 1f;

            // TODO: JR
            /*if (!IsValidImage(byteImageIn))
            {
                return null;
            }*/

            MemoryStream inputMemoryStream = new MemoryStream(byteImageIn);
            Image fullsizeImage = Image.FromStream(inputMemoryStream);

            while (currentByteImageArray.Length > 50000)
            {
                Bitmap fullSizeBitmap = new Bitmap(fullsizeImage, new Size((int)(fullsizeImage.Width * scale), (int)(fullsizeImage.Height * scale)));
                MemoryStream resultStream = new MemoryStream();

                fullSizeBitmap.Save(resultStream, fullsizeImage.RawFormat);

                currentByteImageArray = resultStream.ToArray();
                resultStream.Dispose();
                resultStream.Close();

                scale -= 0.05f;
            }

            return currentByteImageArray;
        }

        public static string ShowDialogAndGetImageLocation() 
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = GetFilteringOptions();

                if (dialog.ShowDialog() == DialogResult.OK) 
                {
                    return dialog.FileName;
                }
                return "";
            }
            catch (Exception) {
                return "";
            }
        }

        //
        // MARK: - Private methods
        // 

        private static string GetFilteringOptions() 
        {
            return " JPG files(*.jpg)|*.jpg| PNG files(*.png) |*.png";
        }
    }
}
