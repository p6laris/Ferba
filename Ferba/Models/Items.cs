using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Ferba.Models
{
    public class Items
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public UnmanagedMemoryStream? Sound { get; set; }
        public BitmapImage? Image { get; set; }

    }
}
