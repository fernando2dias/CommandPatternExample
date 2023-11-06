using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    //Invoker
    public class Garcom
    {
        private Pedido _pedido;
        public Garcom(Pedido pedido) 
        {
            _pedido = pedido;
        }

        public void Executar() 
        {
            _pedido.Execute();
        }
    }
}
