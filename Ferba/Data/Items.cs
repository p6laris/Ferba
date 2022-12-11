using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace Ferba.Data
{
    public class Items
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        //UI related
        public UnmanagedMemoryStream? Sound { get; set; }
        public BitmapImage? Image { get; set; }

    }
}
