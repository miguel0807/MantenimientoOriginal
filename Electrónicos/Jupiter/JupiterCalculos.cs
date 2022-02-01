﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrónicos.Jupiter
{
    


    class JupiterCalculos
    {
     

        public bool VsI { get ; set ; }
        public bool VsO { get; set; }
        public bool Corto { get; set; }
        public bool btnEstado { get; set; }
        public bool Direcciones { get; set; }


        public string StringVsI { get; set ;}
        public string StringVsO { get; set; }
        

        public JupiterCalculos()
        {
            VsI = false;
            VsO = false;
            Corto = false;
            StringVsI = "vs i 0";
            StringVsO = "vs o 0";
                        
        }

        //Secuencia de activación para alternar las mediciones de voltaje.
        public string SecuenciaComandos()       
        {
            string comando = "";
            if (VsI == false)
            {
                comando = CambiarVsI();
            }
            else

            {
                if (VsO == false)
                {
                    comando = CambiarVsO();
                }
               
            }

            return comando;
        }

        //Secuencia de activación para el boton Aceptar.
        public string SecuenciaPruebas()        
        {        
            string comando = "";

            if (VsI == false && VsO == false && Corto == false && Direcciones == false)
            {
                VsI = true;
                comando = StringVsO;
            }
            else if (VsI == true && VsO == false && Corto == false && Direcciones == false)
            {
                VsO = true;
                comando = "Favor realice el corto.";
            }

            else if (VsI == true && VsO == true && Corto == false && Direcciones == false)
            {
                Corto = true;
                
            }

            if (VsI == true && VsO == true && Corto == true && Direcciones == false)
            {
                Direcciones = true;

            }
            return comando;

        }

        //Cambia de estado el VSI
        public string CambiarVsI()
        {
            if (StringVsI == "vs i 1")
            {
                
                StringVsI = "vs i 0";
                btnEstado = false;
            }
            else
            {
              
                StringVsI = "vs i 1";
                btnEstado = true;
            }
            return StringVsI;
        }

        //Cambia de estado el VSO
        public string CambiarVsO()
        {
            if (StringVsO == "vs o 1")
            {
                StringVsO = "vs o 0";
                btnEstado = false;
            }
            else
            {
                StringVsO = "vs o 1";
                btnEstado = true;
            }
            return StringVsO;
        }


       

        
    }
}
