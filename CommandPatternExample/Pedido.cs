namespace CommandPatternExample
{
    //ConcreteCommand
    public class Pedido : Command
    {
        private Chef Chef { get; set; }
        private string Acao { get; set; }

        public Pedido(Chef chef, string acao)
        {
            Chef = chef;
            Acao = acao;
        }

        public override void Execute()
        {
            if (Acao.Equals("Prato"))
            {
                Chef.PreparandoPrato();
            }
            else
            {
                Chef.PreparandoSobremesa();
            }
        }
    }
}
