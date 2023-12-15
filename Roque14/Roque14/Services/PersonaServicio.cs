using Roque14.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Roque14.Services
{
    public class PersonaServicio
    {
        public ObservableCollection<PersonaModel> personas
        { get; set; }

        public PersonaServicio()
        {

            if (personas == null)
            {
                personas = new ObservableCollection<PersonaModel>();
            }
        }

        public ObservableCollection<PersonaModel> Consultar()
        {

            return personas;

        }

        public void Guardar(PersonaModel modelo)
        {

            personas.Add(modelo);

        }

    }
}
