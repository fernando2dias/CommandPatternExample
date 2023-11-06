namespace CommandPatternExample
{
    //Receiver
    public class Chef
    {
        public void PreparandoPrato() 
        {
            Console.WriteLine("Chefe está preparando o prato: Frango Marinado com especiarias...\n");
        }

        public void PreparandoSobremesa() 
        {
            Console.WriteLine("Chefe está preparando a sobremesa: Petit Gateau...\n");
        }
    }
}
