using Binding.Models;
using Microsoft.Maui;
using System.Collections.ObjectModel;

namespace Binding
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Persona> People = new ObservableCollection<Persona>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_ShowData_Clicked(object sender, EventArgs e)
        {
            Persona persona = new Persona(name.Text,lastname1.Text,lastname2.Text);
            People.Add(persona);
            collectionPeople.ItemsSource = People;

        }
        
    }
}