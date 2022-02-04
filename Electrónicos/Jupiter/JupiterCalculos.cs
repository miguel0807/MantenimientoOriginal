using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrónicos.Jupiter
{
    


    class JupiterCalculos
    {

        public bool Resistencia38 { get; set; }
        public bool Voltaje33{ get; set; }
        public bool Voltaje66 { get; set; }
        public bool Voltaje10 { get; set; }
        public bool Voltaje60 { get; set; }
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

            if (Resistencia38 == false && Voltaje33 == false && Voltaje66== false && Voltaje10== false && Voltaje60 == false && VsI == false && VsO == false && Corto == false && Direcciones == false) 
            {
                Resistencia38 = true;
                comando = "Voltaje 3.3";

            }

            else if (Resistencia38 == true && Voltaje33 == false && Voltaje66 == false && Voltaje10 == false && Voltaje60 == false && VsI == false && VsO == false && Corto == false && Direcciones == false)
            {
                Voltaje33 = true;
                comando = "Voltaje 66";

            }

            else if (Resistencia38 == true && Voltaje33 == true && Voltaje66 == false && Voltaje10 == false && Voltaje60 == false && VsI == false && VsO == false && Corto == false && Direcciones == false)
            {
                Voltaje66 = true;
                comando = "Voltaje -10";
            }

            else if (Resistencia38 == true && Voltaje33 == true && Voltaje66 == true && Voltaje10 == false && Voltaje60 == false && VsI == false && VsO == false && Corto == false && Direcciones == false)
            {
                Voltaje10 = true;
                comando = "Voltaje 60";
            }

            else if (Resistencia38 == true && Voltaje33 == true && Voltaje66 == true && Voltaje10 == true && Voltaje60 == false && VsI == false && VsO == false && Corto == false && Direcciones == false)
            {
                Voltaje60 = true;
                comando = "Vs i 0";
            }

            else if (Resistencia38 == true && Voltaje33 == true && Voltaje66 == true && Voltaje10 == true && Voltaje60 == true && VsI == false && VsO == false && Corto == false && Direcciones == false)
            {
                VsI = true;
                comando = StringVsO;
            }
           
            else if (Resistencia38 == true && Voltaje33 == true && Voltaje66 == true && Voltaje10 == true && Voltaje60 == true && VsI == true && VsO == false && Corto == false && Direcciones == false)
            {
                VsO = true;
                comando = "Favor realice el corto.";
            }

            else if (Resistencia38 == true && Voltaje33 == true && Voltaje66 == true && Voltaje10 == true && Voltaje60 == true && VsI == true && VsO == true && Corto == false && Direcciones == false)
            {
                Corto = true;
                
            }

            if (Resistencia38 == true && Voltaje33 == true && Voltaje66 == true && Voltaje10 == true && Voltaje60 == true && VsI == true && VsO == true && Corto == true && Direcciones == false)
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
