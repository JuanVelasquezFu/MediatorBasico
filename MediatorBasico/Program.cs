using System;

namespace MediatorBasico
{
    class Program
    {
        static void Main()
        {
            var mediador = new MediadorChat();

            var ana = new UsuarioChat(mediador, "Ana");
            var luis = new UsuarioChat(mediador, "Luis");

            mediador.RegistrarUsuario1(ana);
            mediador.RegistrarUsuario2(luis);

            ana.Enviar("¡Hola Luis!");
            luis.Enviar("¡Hola Ana, todo bien?");

            Console.ReadLine();
        }
    }
}
