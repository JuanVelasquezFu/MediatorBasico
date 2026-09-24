using System;

namespace MediatorBasico
{
    public class UsuarioChat : Usuario
    {
        public UsuarioChat(IMediador mediador, string nombre) : base(mediador, nombre) { }

        public void Enviar(string mensaje)
        {
            Console.WriteLine($"{Nombre} envía: {mensaje}");
            mediador.Enviar(mensaje, this);
        }

        public override void Recibir(string mensaje, string nombreEmisor)
        {
            Console.WriteLine($"{Nombre} recibe de {nombreEmisor}: {mensaje}");
        }
    }
}
