using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public  class controllerValidarLogin
    {
        public void validarLogin(string user, string senha, Form form, Form form1)
        {
            ValidarLogin validarLogin = new ValidarLogin();

            validarLogin.validarLogin(user,senha,form,form1);
        }

        public void validarLoginCliente(string user, string senha, Form form, Form form1)
        {
            ValidarLogin validarLogin = new ValidarLogin();

            validarLogin.validarLoginCliente(user, senha, form, form1);
        }
    }
}
