using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Issue_13645.Views
{
    public partial class AboutPage : ContentPage
    {
        private List<string> _letters = new List<string>
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"
        };

        private int _selectedPosition = 0;
        private string _selectedLetter = "A";

        public AboutPage()
        {
            BindingContext = this;
            InitializeComponent();
        }

        public List<string> Letters
        {
            get
            {
                return _letters;
            }
            set
            {
                _letters = value;
                OnPropertyChanged();
            }
        }


        public int SelectedPosition
        {
            get
            {
                return _selectedPosition;
            }
            set
            {
                _selectedPosition = value;
                OnPropertyChanged();
            }
        }

        public string SelectedLetter => _selectedLetter;

        void CarouselView_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            _selectedLetter = e.CurrentItem.ToString();
            OnPropertyChanged(nameof(SelectedLetter));
        }
    }
}