namespace MediatorBasico
{
    public class MediadorChat : IMediador
    {
        private UsuarioChat usuario1;
        private UsuarioChat usuario2;

        public void RegistrarUsuario1(UsuarioChat u) => usuario1 = u;
        public void RegistrarUsuario2(UsuarioChat u) => usuario2 = u;

        public void Enviar(string mensaje, Usuario emisor)
        {
            if (emisor == usuario1)
                usuario2.Recibir(mensaje, emisor.Nombre);
            else
                usuario1.Recibir(mensaje, emisor.Nombre);
        }
    }
}
