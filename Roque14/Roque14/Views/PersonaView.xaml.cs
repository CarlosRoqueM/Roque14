using Roque14.Models;
using Roque14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roque14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaView : ContentPage
    {
        PersonaViewModel contexto = new PersonaViewModel();

        public PersonaView()
        {

            InitializeComponent();
            BindingContext = contexto;
            LvPersonas.ItemSelected += LvPersonas_ItemSelected;

        }



        private void LvPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                PersonaModel modelo = (PersonaModel)e.SelectedItem;
                contexto.Nombre = modelo.Nombre;
                contexto.Curso = modelo.Curso;
                contexto.SelectedDate = modelo.SelectedDate;
                contexto.Id = modelo.Id;
            }
        }
    }
}