using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenMvvm.Models;
using SoundAnalysis;

namespace ExamenMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double producto1;
        [ObservableProperty]
        private double producto2;
        [ObservableProperty]
        private double producto3;


        [ObservableProperty]
        private double subtotal;
        [ObservableProperty]
        private double descuento;
        [ObservableProperty]
        private double precioFinal;
        [RelayCommand]
        private async Task CalcularDescuento()
        {

            subtotal = producto1 + producto2 + producto3;
            descuento = 0;

            if (subtotal >= 1000 && subtotal <= 4999.99)
            {
                descuento = subtotal * 0.10;
                precioFinal = subtotal - descuento;
            }
            else if (subtotal >= 5000 && subtotal <= 9999.99)
            {
                descuento = subtotal * 0.20;
                precioFinal = subtotal - descuento;
            }
            else if (subtotal >= 10000 && subtotal <= 19999.99)
            {
                descuento = subtotal * 0.30;
                precioFinal = subtotal - descuento;
            }
            else if (subtotal >= 20000)
            {
                descuento = 0; // No aplica descuento
                precioFinal = subtotal;
            }


            [RelayCommand]
            private void Clean()
            {
                Producto1 = 0;
                Producto2 = 0;
                Producto3 = 0;
            }

        }

    }
}
