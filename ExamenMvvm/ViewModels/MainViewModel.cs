using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenMvvm.Models;



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
           
            if (Producto1 < 0 || Producto2 < 0 || Producto3 < 0)
            {
                await Application.Current!.MainPage!.DisplayAlert("Error", "No pueden haber precios negativos", "OK");
                return; 
            }

           
            Subtotal = Producto1 + Producto2 + Producto3;
            Descuento = 0;

            if (Subtotal >= 1000 && Subtotal <= 4999.99)
            {
                Descuento = Subtotal * 0.10;
            }
            else if (Subtotal >= 5000 && Subtotal <= 9999.99)
            {
                Descuento = Subtotal * 0.20;
            }
            else if (Subtotal >= 10000 && Subtotal <= 19999.99)
            {
                Descuento = Subtotal * 0.30;
            }
            else if (Subtotal >= 20000)
            {
                Descuento = 0; 
            }

            PrecioFinal = Subtotal - Descuento;
        }

        [RelayCommand]
        private void Clean()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;
            PrecioFinal = 0;
        }
    }
}