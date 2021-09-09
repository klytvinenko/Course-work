using System.Runtime.Serialization;

namespace Shoes.Models
{
    [DataContract]
    abstract class FootWear : IExtensibleDataObject
    {
        [DataMember]
        public Gender gender;
        [DataMember]
        public Color color;
        [DataMember]
        public int size;
        [DataMember]
        public Material material;
        protected ExtensionDataObject theData;

        protected FootWear(Gender sex, Color color, int size, Material material)
        {
            this.gender = sex;
            this.color = color;
            this.size = size;
            this.material = material;
        }

        public ExtensionDataObject ExtensionData { get => theData; set => theData = value; }
    }
}
