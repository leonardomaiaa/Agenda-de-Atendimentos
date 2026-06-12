namespace AgendaAtendimentos
{
    /// <summary>
    /// Classe principal que inicia a aplicação.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal da aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita estilos visuais modernos e configurações de DPI
            ApplicationConfiguration.Initialize();
            // Inicia o formulário principal da agenda
            Application.Run(new Form1());
        }
    }
}