using System.Runtime.Serialization;

namespace Shoes
{
    [DataContract]
    enum Gender
    {
        [EnumMember]
        Male,
        [EnumMember]
        Female,
        [EnumMember]
        Unisex,
    }
    [DataContract]
    enum Material
    {
        [EnumMember]
        Leather,
        [EnumMember]
        ImitationLeather,
        [EnumMember]
        Fabric,
    }
    [DataContract]
    enum Color
    {
        [EnumMember]
        Black,
        [EnumMember]
        White,
        [EnumMember]
        Gray,
    }
}
