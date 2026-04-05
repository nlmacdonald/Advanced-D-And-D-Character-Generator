using System.Drawing;
using RoleplayingLibrary;

namespace ADandD1ECharacterGenerator.Helpers
{
    public static class ResourceHelper
    {
        private static ImageCollection _collection;

        public static void InitializeSettingImages()
        {
            _collection = new ImageCollection();
        }

        public static Image GetCurrentSettingImage()
        {
            return _collection.GetCurrentImage();
        }

        public static Image NextSettingImage()
        {
            return _collection.MoveNext();
        }

        public static Image PreviousSettingImage()
        {
            return _collection.MovePrevious();
        }

        public static void CloseImages()
        {
            _collection.Dispose();
        }
    }
}
