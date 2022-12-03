using Ferba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferba.Data
{
    internal static class Data
    {
        public static List<Items> GetData()
        {
            return new()
            {
                new Items(){Name= "باز", 
                    Description = "هەڵۆ یاخود باز باڵدارێکی گۆشتخۆرە، خاوەن چاوێکی تیژە", 
                    Sound = "./Asstes/Audio/Baz.wav", 
                    Image = new(new Uri("./Assets/Images/Objects/Baz.jpg",UriKind.Relative))}
            };
        }
    }
}


