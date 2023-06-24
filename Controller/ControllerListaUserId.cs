using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class ControllerListaUserId
    {
        
        public static int acessarLista()
        {
            int id = 0;
            foreach (int i in EstaticoConectarIdUserCarrinho.lista)
            {
                if(i > 0)
                {
                    id = i;
                }

            }
            return id;

        }
    }
}
