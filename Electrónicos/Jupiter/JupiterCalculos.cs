using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrónicos.Jupiter
{
    


    class JupiterCalculos
    {
        private bool vsI, vsO,corto;

        public bool _vsI { get => vsI; set => vsI = value; }
        public bool _vsO { get => vsO; set => vsO = value; }
        public bool _corto { get => corto; set => corto = value; }


        public JupiterCalculos()
        {
            vsI = false;
            vsO = false;
            corto = false;

        }

        public bool CambiarVsI()
        {
            if (vsI == false)
            {
                vsI = true;
            }
            else
            {
                vsI = false;
            }
            return vsI;
        }

        public bool CambiarVsO()
        {
            if (vsO == false)
            {
                vsO = true;
            }
            else
            {
                vsO = false;
            }
            return vsO;
        }


        public bool CambiarCorto()
        {
            if (corto == false)
            {
                corto = true;
            }
            else
            {
                corto = false;
            }
            return corto;
        }

        
    }
}
