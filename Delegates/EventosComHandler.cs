using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Delegates
{


    public class PedidoEventArgs : EventArgs
    {
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }


    public class EventosComHandler
    {
        void EventoPedidos()
        {
            var pedido = new PedidoHandler();
            pedido.OnCriarPedido += EmailHandler.Enviar;
            pedido.OnCriarPedido += SmsHandler.Enviar;

            pedido.CriarPedido();
            pedido.CriarPedido("alex@gmail.com", "1192933900");
        }
    }


    //Não precisa criar o delegate pois o eventHandler é fornecido pela plataforma dotnet
    //public delegate void PedidoEventoHandler();
    
    public class PedidoHandler
    {
        //Criar Evento usando o delegate criado
         public event EventHandler? OnCriarPedido;

        //Criar Evento usando o delegate criado
         public event EventHandler<PedidoEventArgs>? OnCriarPedidoParameter;

        public void CriarPedido()
        {
            Console.WriteLine("Pedido Criado!!");
            if (OnCriarPedido != null)
            {
                //passa o proprio objeto, sem nenhum dado do evento
                OnCriarPedido(this, EventArgs.Empty);
            }
        }


        public void CriarPedido(string email, string fone)
        {
            Console.WriteLine("Pedido Criado!!");


            //Modo com parametros
            if (OnCriarPedidoParameter != null)
            {
                OnCriarPedidoParameter(this,new PedidoEventArgs() {Email = email, Telefone = fone  });
            }
        }
    }


    public class EmailHandler
    {
        public static void Enviar(object? sender, EventArgs e)
        {
            Console.WriteLine("Enviando um Email");
        }
    }


    public class SmsHandler
    {
        public static void Enviar(object? sender, EventArgs e)
        {
            Console.WriteLine("Enviando um SMS");
        }
    }


    public class EmailHandlerT
    {
        public static void Enviar(object? sender, PedidoEventArgs e)
        {
            Console.WriteLine(e.Email);
        }
    }


    public class SmsHandlerT
    {
        public static void Enviar(object? sender, PedidoEventArgs e)
        {
            Console.WriteLine(e.Telefone);
        }
    }
}
