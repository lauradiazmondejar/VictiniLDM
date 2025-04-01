using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoUWPenBlanco
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void cambiarVida(object sender, RangeBaseValueChangedEventArgs e)
        {
            //Obtener valor actual del slider y poner ese valor en la propiedad Vida del Control de Usuario
        }

        private void cambiarEnergía(object sender, RangeBaseValueChangedEventArgs e)
        {
            //Obtener valor actual del slider y poner ese valor en la propiedad Energía del Control de Usuario
        }

        private void EjecutarAtaqueFuerte(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionAtaqueFuerte();
        }

        private void EjecutarAtaqueFlojo(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionAtaqueFlojo();
        }

        private void EjecutarDefensa(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionDefensa();
        }

        private void EjecutarDescansar(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionDescasar();
        }

        private void activarIddle(object sender, RoutedEventArgs e)
        {
            ucVictini.activarAniIdle(true);
        }

        private void desactivarIddle(object sender, RoutedEventArgs e)
        {
            ucVictini.activarAniIdle(false);
        }

        private void desactivarCansado(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionNoCansado();
        }

        private void activarCansado(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionCansado();
        }

        private void activarHerido(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionHerido();

        }

        private void desactivarHerido(object sender, RoutedEventArgs e)
        {
            ucVictini.animacionNoHerido();
        }

        private void desactivarEscudo(object sender, RoutedEventArgs e)
        {
            ucVictini.verEscudo(false);
        }

        private void activarEscudo(object sender, RoutedEventArgs e)
        {
            ucVictini.verEscudo(true);
        }

        private void verFondo(object sender, RoutedEventArgs e)
        {
            ucVictini.verFondo(true);
        }

        private void noVerFondo(object sender, RoutedEventArgs e)
        {
            ucVictini.verFondo(false);
        }

        private void noVerFilaVida(object sender, RoutedEventArgs e)
        {
            ucVictini.verFilaVida(false);
        }

        private void verFilaVida(object sender, RoutedEventArgs e)
        {
            ucVictini.verFilaVida(true);
        }

        private void verFilaEnergia(object sender, RoutedEventArgs e)
        {
            ucVictini.verFilaEnergia(true);
        }

        private void noVerFilaEnergía(object sender, RoutedEventArgs e)
        {
            ucVictini.verFilaEnergia(false);
        }

        private void verPocimaVida(object sender, RoutedEventArgs e)
        {
            ucVictini.verPocionVida(true);
        }

        private void noVerPocimaVida(object sender, RoutedEventArgs e)
        {
            ucVictini.verPocionVida(false);
        }

        private void noVerPocimaEnergia(object sender, RoutedEventArgs e)
        {
            ucVictini.verPocionEnergia(false);
        }

        private void verPocimaEnergia(object sender, RoutedEventArgs e)
        {
            ucVictini.verPocionEnergia(true);
        }

        private void verNombrePokemon(object sender, RoutedEventArgs e)
        {
            ucVictini.verNombre(true);
        }

        private void noVerNombrePokemon(object sender, RoutedEventArgs e)
        {
            ucVictini.verNombre(false);
        }
    }
}
