using System.Collections.ObjectModel;

namespace Shoes.Models
{
    interface IRepository
    {
        public ObservableCollection<FootWear> LoadFrom(string filePath);
        public void SaveTo(ObservableCollection<FootWear> orders, string filePath);
        
    }
}
