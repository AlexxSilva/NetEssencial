using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Delegates
{
  

    public class Eventos
    {
        void EventoPedidos()
        {
            var pedido = new Pedido();
            pedido.OnCriarPedido += Email.Enviar;
            pedido.OnCriarPedido += Sms.Enviar;

            pedido.CriarPedido();
        }
    }


    //criar o delegate para o evento
    public delegate void PedidoEventoHandler();
    
    public class Pedido
    {
        //Criar Evento usando o delegate criado
        public event PedidoEventoHandler? OnCriarPedido;

        public void CriarPedido()
        {
            Console.WriteLine("Pedido Criado!!");
            if (OnCriarPedido != null)
            {
                OnCriarPedido();
            }
        }
    }


    class Email
    {
        public static void Enviar()
        {
            Console.WriteLine("Enviando um Email");
        }
    }


    class Sms
    {
        public static void Enviar()
        {
            Console.WriteLine("Enviando um SMS");
        }
    }
}
