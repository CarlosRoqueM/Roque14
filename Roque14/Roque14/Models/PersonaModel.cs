using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Roque14.Models
{
    public class PersonaModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy = false;

        public bool IsBusy
        {
            get { return isBusy = false; }
            set { isBusy = value; OnPropertyChanged(); }
        }


        private string id;

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; OnPropertyChanged(); OnPropertyChanged(nameof(NombreCompleto)); }
        }

        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; OnPropertyChanged(); OnPropertyChanged(nameof(NombreCompleto)); }
        }

        private string selectedDate;

        public string SelectedDate
        {
            get { return selectedDate; }
            set { selectedDate = value; OnPropertyChanged(); }
        }

        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return $"{Nombre} {Curso}"; }
            set { nombreCompleto = value; OnPropertyChanged(); OnPropertyChanged(nameof(Mensaje)); }
        }

        private string mensaje;

        public string Mensaje
        {
            get { return $"Tu nombre es {NombreCompleto}"; }
        }


    }
}
