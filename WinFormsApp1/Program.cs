namespace AgendaAtendimentos
{
    /// Classe principal da aplicacao
    internal static class Program
    {
        /// Ponto de entrada principal da aplicacao
        [STAThread]
        static void Main()
        {
         /// Habilita estilos visuais 
            ApplicationConfiguration.Initialize();
         /// Inicia o formulário principal da agenda
            Application.Run(new Form1());
        }
    }
}