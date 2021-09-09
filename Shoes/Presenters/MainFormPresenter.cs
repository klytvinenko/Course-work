using Shoes.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Linq;
namespace Shoes.Presenters
{
    class MainFormPresenter : IPresenter
    {
        private MainForm _view;
        private ObservableCollection<FootWear> _footWears;

        public ObservableCollection<FootWear> FootWears
        {
            get
            {
                return _footWears;
            }
            set
            {
                _footWears = value;
            }
        }


        public MainFormPresenter(MainForm view)
        {

            _view = view;
            _footWears = new ObservableCollection<FootWear>();
            _view.addFootWearButton.Click += new System.EventHandler(createOrderButton_Click);
            _view.Load += new System.EventHandler(MainForm_Load);
            _view.removeOrderButton.Click += new System.EventHandler(removeOrderButton_Click);
            _view.saveFileButton.Click += new System.EventHandler(saveFileButton_Click);
            _view.openFileButton.Click += new System.EventHandler(openFileButton_Click);
            _view.filterButton.Click += new System.EventHandler(filterFootWear_Click);
            _footWears.CollectionChanged += _orders_CollectionChanged;
        }

        private void _orders_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            _view.FootWears.Items.Clear();
            foreach (var item in _footWears)
            {
                _view.FootWears.Items.Add(item);
            }
            CheckOrders();
        }
        #region Form events
        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "(*.ocf)|*.ocf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var repository = new Models.OrdersRepository();
                        FootWears = repository.LoadFrom(openFileDialog.FileName);
                        _view.FootWears.Items.Clear();
                        foreach (var item in _footWears)
                        {
                            _view.FootWears.Items.Add(item);
                        }
                        _footWears.CollectionChanged += _orders_CollectionChanged;
                        CheckOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Corrupted data");
                    }

                }
            }
        }
        private void filterFootWear_Click(object sender, EventArgs e)
        {
            _view.FootWears.Items.Clear();
            var filteredFootWears = new FootWear[_footWears.Count];
            _footWears.CopyTo(filteredFootWears, 0);
            if ((_view.colorComboBox.SelectedIndex != -1) && _view.colorComboBox.SelectedIndex != 0)
            {
                filteredFootWears = filteredFootWears.Where(f => f.color == (Color)(_view.colorComboBox.SelectedIndex - 1)).ToArray();
            }
            if ((_view.materialComboBox.SelectedIndex != -1) && _view.materialComboBox.SelectedIndex != 0)
            {
                filteredFootWears = filteredFootWears.Where(f => f.material == (Material)(_view.materialComboBox.SelectedIndex - 1)).ToArray();
            }
            if ((_view.genderComboBox.SelectedIndex != -1) && _view.genderComboBox.SelectedIndex != 0)
            {
                filteredFootWears = filteredFootWears.Where(f => f.gender == (Gender)(_view.genderComboBox.SelectedIndex - 1)).ToArray();
            }
            foreach (var item in filteredFootWears)
            {
                _view.FootWears.Items.Add(item);
            }
            CheckOrders();
        }
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.AddExtension = true;
                openFileDialog.DefaultExt = ".ocf";
                openFileDialog.Filter = "(*.ocf)|*.ocf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var repository = new Models.OrdersRepository();
                    repository.SaveTo(_footWears, openFileDialog.FileName);
                }
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            var presenter = new AddFootWearPresenter(new View.AddFootWearForm(), this);
            presenter.Run();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckOrders();
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            if (_view.FootWears.SelectedItem != null)
            {
                FootWears.RemoveAt(_view.FootWears.SelectedIndex);
            }
        }
        #endregion
        private void CheckOrders()
        {
            if (_view.FootWears.Items.Count == 0)
                _view.removeOrderButton.Enabled = false;
            else
                _view.removeOrderButton.Enabled = true;
        }
        public void Run()
        {
            Application.Run(_view);
        }
    }
}
