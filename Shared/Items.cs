using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace Shared
{
    public partial class Items
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public UnmanagedMemoryStream? Sound { get; set; }
        public BitmapImage? Image { get; set; }

    }
}
