using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;


// This class creates an instance that represents the information in a "row" in the datagridview

namespace JourneyMan
{
    [Serializable()] // Enables saving the object
    class RowObject
    {
        public Bitmap picture { get; set; }
        public string pictureFileName { get; set; }
        public string underPicText { get; set; }
        public string noteText { get; set; }
        
        // Designated Initializer
        public RowObject( Bitmap image, string filename )
        {
            if (image.Size.Width > 1600 || image.Size.Height > 1600 )
            {
                double scaleFactor = image.Size.Width >= image.Size.Height ? image.Size.Width / 1600 : image.Size.Height / 1600;
                picture = new Bitmap(image, new Size(Convert.ToInt32(Math.Round(image.Width / scaleFactor)), 
                    Convert.ToInt32(Math.Round(image.Height / scaleFactor))));
            }
            else
            {
                picture = new Bitmap(image);
            }
            pictureFileName = filename;
            underPicText = "";
            noteText = "";
        }

        public Bitmap returnResizedImage(double width)
        {
            double scaleFactor = picture.Size.Width >= picture.Size.Height ? picture.Size.Width / width : 
                picture.Size.Height / width;
            Bitmap sizedpicture = new Bitmap(picture, new Size(Convert.ToInt32(Math.Round(picture.Width / scaleFactor)), 
                Convert.ToInt32(Math.Round(picture.Height / scaleFactor))));
            return sizedpicture;
        }
    }
}
