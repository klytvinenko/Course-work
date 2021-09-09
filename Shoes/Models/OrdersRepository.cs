using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;


namespace Shoes.Models
{
    class OrdersRepository : IRepository
    {
        public void SaveTo(ObservableCollection<FootWear> orders, string filePath)
        {
            Type[] knownTypes = new Type[] { typeof(Shoes_), typeof(Sneakers) , typeof(Trainers)};
            var serializer = new DataContractSerializer(typeof(ObservableCollection<FootWear>), knownTypes);
            using (var writer = XmlWriter.Create(filePath))
            {
                serializer.WriteObject(writer, orders);
            }
        }

        public ObservableCollection<FootWear> LoadFrom(string filePath)
        {
            if (File.Exists(filePath))
            {
                Type[] knownTypes = new Type[] { typeof(Shoes_), typeof(Sneakers), typeof(Trainers) };
                var serializer = new DataContractSerializer(typeof(ObservableCollection<FootWear>), knownTypes);
                using (var reader = XmlReader.Create(filePath))
                {
                    var orders = (ObservableCollection<FootWear>)serializer.ReadObject(reader);
                    return orders;
                }
            }
            else
            {
                throw new Exception("File does not exists");
            }
        }
    }
}
