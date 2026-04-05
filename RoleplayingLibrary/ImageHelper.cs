using System.Drawing;
using System.Windows.Forms;

namespace RoleplayingLibrary
{
    public static class ImageHelper
    {
        public static Bitmap ResizeImage(Image newImage, int width, int height)
        {
            var bmp = new Bitmap(width, height);

            using (var g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(newImage, 0, 0, width, height);
            }

            return bmp;
        }

        public static void LoadPortrait(PictureBox picture)
        {
            var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = fileDialog.FileName;
                picture.BackgroundImageLayout = ImageLayout.Zoom;
                picture.BackgroundImage = Image.FromFile(file);
            }
        }
    }
}
