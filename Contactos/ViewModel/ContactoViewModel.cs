using Contactos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Contactos.ViewModel
{
    public class ContactoViewModel : BaseViewModel
    {
        #region Propiedades
        public ObservableCollection<Contacto> Contactos { get; set; }
        #endregion


        public ContactoViewModel()
        {
            Contactos = new ObservableCollection<Contacto>();
            Contactos.Add(new Contacto()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "Mario",
                ApellidoPaterno = "Carvantes",
                ApellidoMaterno = "Gutierrez",
                Organizacion = "UdC",
                Telefonos = new ObservableCollection<Telefono>() { new Telefono{Id = Guid.NewGuid().ToString(), Numero= "246810" },
                new Telefono{Id = Guid.NewGuid().ToString(), Numero="102030"},
                }
            });

            Contactos.Add(new Contacto()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "Axel",
                ApellidoPaterno = "Bell",
                ApellidoMaterno = "Woods",
                Organizacion = "UdC",
                Telefonos = new ObservableCollection<Telefono>() { new Telefono{Id = Guid.NewGuid().ToString(), Numero= "123456" },
                new Telefono{Id = Guid.NewGuid().ToString(), Numero="312312456"},
                }
            });
        }
    }
}
