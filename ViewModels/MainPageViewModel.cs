using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13E51925597.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string sueldo;
        [ObservableProperty]
        private string aumento;

        [RelayCommand]
        private void CalcularAumento()
        {
            if(double.TryParse(Sueldo, out double sld))
            {
                if (sld > 1000)
                {
                    Aumento = "Su aumento del 12% es : $" + (sld + (sld * 0.12));
                }
                else
                {
                    Aumento = "Su aumento del 15% es : $" + (sld + (sld * 0.15));
                }
            }
            else
            {
                Aumento = "Ingrese datos numericos";
            }
        }
    }
}
