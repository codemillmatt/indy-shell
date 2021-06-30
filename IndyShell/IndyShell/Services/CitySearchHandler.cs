using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IndyShell
{
    public class CitySearchHandler : SearchHandler
    {
        public List<string> Cities { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
                ItemsSource = null;
            else
            {
                ItemsSource = Cities.Where(c => c.ToLower().Contains(newValue.ToLower()));
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            await Task.Delay(500);

            await Shell.Current.GoToAsync($"smokey?cityName={item}");
        }
    }
}
