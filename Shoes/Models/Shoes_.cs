using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Models
{
    [DataContract]
    class Shoes_ : FootWear
    {
        public Shoes_(Gender gender, Color color, int size, Material material) : base(gender, color, size, material)
        {
        }
        public override string ToString()
        {
            return $"Shoes: {gender.ToString()}, {color.ToString()}, {size}, {material}";
        }
    }
}
