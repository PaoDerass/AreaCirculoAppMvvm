using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class CirculoViewModel : ObservableObject
    {
        public const double PI = 3.1415926535897931;

        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double res;

        [RelayCommand]
        public void CalcArea()
        {
            Res= PI * Radio * Radio;
        }

        [RelayCommand]
        public void Limpiar()
        {
            Radio = 0;
            Res = 0;
        }
    }
}
