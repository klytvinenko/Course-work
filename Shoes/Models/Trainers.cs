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
    class Trainers : FootWear
    {
        public Trainers(Gender sex, Color color, int size, Material material) : base(sex, color, size, material)
        {

        }
        public override string ToString()
        {
            return $"Sneakers: {gender.ToString()}, {color.ToString()}, {size}, {material}";
        }
    }
}
