using p7_triggersANAV.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace p7_triggersANAV.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    descripcion = "Cena",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/B4ywP9Z/cenaprueba.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Hotel",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/NV4DRrZ/hotel.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Fiesta",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/8rrbk4x/fiesta.png",
                    backgroundColor = "#EAEDF6",
                    textColor= "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Flores",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/GHStkhx/flores.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
            };
        }
    }
}
