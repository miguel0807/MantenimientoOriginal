using System;
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

        public string SecuenciaPruebas()
        {
            string comando = "";
            if (VsI == false && VsO == false)
            {
                VsI = true;
                comando = StringVsO;
            }
            else if (VsI == true && VsO == false)
            {
                VsO = true;
                
            }
            return comando;

        }

        public string CambiarVsI()
        {
            if (StringVsI == "vs i 1")
            {
                
                StringVsI = "vs i 0";
            }
            else
            {
              
                StringVsI = "vs i 1";
            }
            return StringVsI;
        }

        public string CambiarVsO()
        {
            if (StringVsO == "vs o 1")
            {
                StringVsO = "vs o 0";
            }
            else
            {
                StringVsO = "vs o 1";
            }
            return StringVsO;
        }


        public bool CambiarCorto()
        {
            if (Corto == false)
            {
                Corto = true;
            }
            else
            {
                Corto = false;
            }
            return Corto;
        }

        
    }
}
