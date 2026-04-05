using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace RoleplayingLibrary
{
    public sealed class ImageCollection : IDisposable
    {
        private readonly List<string> _images = new List<string>();
        private readonly Random _random = new Random();

        public int CurrentIndex { get; private set; } = -1;

        public int Count => _images.Count;

        public bool HasImages => _images.Count > 0;

        public ImageCollection() : this(@"Images")
        {
        }

        public ImageCollection(string folder)
        {
            LoadFromFolder(folder);
        }

        public Image CurrentImage
        {
            get
            {
                if (!HasImages)
                {
                    throw new InvalidOperationException("No images are loaded.");
                }

                return LoadImage(_images[CurrentIndex]);
            }
        }

        private void ClearImages()
        {
        }

        public Image MovePrevious()
        {
            EnsureImagesLoaded();

            CurrentIndex--;

            if (CurrentIndex < 0)
            {
                CurrentIndex = _images.Count - 1;
            }

            return LoadImage(_images[CurrentIndex]);
        }

        public Image GetCurrentImage()
        {
            EnsureImagesLoaded();
            return LoadImage(_images[CurrentIndex]);
        }

        public void SetIndex(int index)
        {
            EnsureImagesLoaded();

            if (index < 0 || index >= _images.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            CurrentIndex = index;
        }

        private void EnsureImagesLoaded()
        {
            if (!HasImages)
            {
                throw new InvalidOperationException("No images are loaded.");
            }
        }

        public void Dispose()
        {
            ClearImages();
        }

        private void LoadFromFolder(string folderPath)
        {
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                throw new ArgumentException("Folder path is required.", nameof(folderPath));
            }

            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException($"Folder not found: {folderPath}");
            }

            ClearImages();

            var supportedExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".bmp",
                ".gif",
                ".jpeg",
                ".jpg",
                ".png",
                ".webp"
            };

            var files = Directory
                .GetFiles(folderPath)
                .Where(path => supportedExtensions.Contains(Path.GetExtension(path)))
                .OrderBy(path => path)
                .ToList();

            foreach (var file in files)
            {
                _images.Add(file);
            }

            if (_images.Count == 0)
            {
                CurrentIndex = -1;
                return;
            }

            CurrentIndex = _random.Next(0, _images.Count);
        }

        public Image MoveNext()
        {
            EnsureImagesLoaded();

            CurrentIndex++;

            if (CurrentIndex > _images.Count - 1)
            {
                CurrentIndex = 0;
            }

            return LoadImage(_images[CurrentIndex]);
        }

        private Image LoadImage(string file)
        {
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var tempImage = Image.FromStream(stream))
                {
                    return new Bitmap(tempImage);
                }
            }
        }
    }
}
