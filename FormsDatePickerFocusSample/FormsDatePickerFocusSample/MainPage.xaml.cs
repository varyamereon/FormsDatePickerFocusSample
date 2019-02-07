using System;
using Xamarin.Forms;

namespace FormsDatePickerFocusSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnMyButtonClicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (MyDatePicker.IsFocused)
                    MyDatePicker.Unfocus();

                MyDatePicker.Focus();
            });
        }
    }
}
