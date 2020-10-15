using System;
using System.Collections.Generic;
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
