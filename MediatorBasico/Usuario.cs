namespace MediatorBasico
{
    public abstract class Usuario
    {
        protected IMediador mediador;
        public string Nombre { get; }

        public Usuario(IMediador mediador, string nombre)
        {
            this.mediador = mediador;
            this.Nombre = nombre;
        }

        public abstract void Recibir(string mensaje, string nombreEmisor);
    }
}
