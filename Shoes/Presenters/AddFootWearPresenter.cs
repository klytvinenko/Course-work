using Shoes.Models;
using Shoes.View;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Shoes.Presenters
{
    class AddFootWearPresenter : IPresenter
    {
        private bool saved;
        private bool wantToSave;

        private AddFootWearForm _view;
        private IPresenter _context;
        public FootWear footWear;

        public AddFootWearPresenter(AddFootWearForm view, IPresenter context)
        {
            _view = view;
            _context = context;

            _view.saveFootWear.Click += SaveOrderButton_Click;

        }

        private void Save()
        {
            switch (_view.shoesTypeComboBox.SelectedIndex)
            {
                case 0:
                    (_context as MainFormPresenter).FootWears.Add(new Shoes_((Gender)_view.genderComboBox.SelectedIndex, (Color)_view.colorComboBox.SelectedIndex, Convert.ToInt32(_view.sizeTextBox.Text), (Material)_view.materialComboBox.SelectedIndex));
                    return;
                case 1:
                    (_context as MainFormPresenter).FootWears.Add(new Trainers((Gender)_view.genderComboBox.SelectedIndex, (Color)_view.colorComboBox.SelectedIndex, Convert.ToInt32(_view.sizeTextBox.Text), (Material)_view.materialComboBox.SelectedIndex));
                    return;
                case 2:
                    (_context as MainFormPresenter).FootWears.Add(new Sneakers((Gender)_view.genderComboBox.SelectedIndex, (Color)_view.colorComboBox.SelectedIndex, Convert.ToInt32(_view.sizeTextBox.Text), (Material)_view.materialComboBox.SelectedIndex));
                    return;
            }
            
                saved = true;
            
        }
        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            if (_view.ValidateChildren())
            {
                Save();
                _view.Close();

            }
        }
        public void Run()
        {
            _view.ShowDialog();
        }

    }

}
