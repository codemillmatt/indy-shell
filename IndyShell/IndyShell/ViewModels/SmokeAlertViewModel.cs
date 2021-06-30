using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

using Xamarin.CommunityToolkit.ObjectModel;

namespace IndyShell
{
    public class SmokeAlertViewModel : ObservableObject
    {
        public SmokeAlertViewModel()
        {
            Cities = CityData.CityNames;

            ViewSmokeyDetails = CommandFactory.Create(async () => {
                if (!string.IsNullOrWhiteSpace(SelectedCity))
                {
                    await Task.CompletedTask;
                    //await Shell.Current.GoToAsync("smokey");
                    var city = SelectedCity;
                    await Shell.Current.GoToAsync($"smokey?cityName={city}");
                }

                SelectedCity = null;
            });

        }

        public List<string> Cities { get; }

        string selectedCity;
        public string SelectedCity {
            get => selectedCity;
            set => SetProperty(ref selectedCity, value);
        }

        public IAsyncCommand ViewSmokeyDetails { get; }

    }
}
