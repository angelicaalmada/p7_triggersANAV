using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace p7_triggersANAV.Triggers.Tcategoria
{
    public class Timagen : TriggerAction<Image>
    {
        public bool activacion {  get; set; }
        protected override async void Invoke(Image sender)
        {
            if (activacion == true)
            {
                sender.BackgroundColor = Color.Red;
                //Rotacion que tendra, tiempo que tendra en milisegundos,
                //tipo de animacion(efecto)
                await sender.RelRotateTo(360, 5000, Easing.BounceOut);
            }
            if (activacion == false)
            {
                //En esta parte restauramos los valores a un estado normal
                sender.BackgroundColor = new Image().BackgroundColor;
                sender.Rotation = new Image().Rotation;
            }
        }
    }
}
