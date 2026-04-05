using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace RoleplayingLibrary
{
    public static class JsonImage
    {
        public static string ToBase64String(PictureBox pictureBox)
        {
            if (pictureBox.BackgroundImage == null) return null;

            using (var ms = new MemoryStream())
            {
                pictureBox.BackgroundImage.Save(ms, ImageFormat.Png);
                var base64 = Convert.ToBase64String(ms.ToArray());

                return base64;
            }
        }

        public static Image ToImage(string base64Value)
        {
            if (string.IsNullOrWhiteSpace(base64Value)) return null;

            var bytes = Convert.FromBase64String(base64Value);

            using (var ms = new MemoryStream(bytes))
            {
                using (var img = Image.FromStream(ms))
                {
                    return new Bitmap(img);
                }
            }
        }
    }
}
