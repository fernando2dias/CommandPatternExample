using CommandPatternExample;

Console.WriteLine("## Command Pattern ##");

//Cria uma instancia de Chef para poder preparar o pedido
//Receiver
Chef chef = new Chef();

//prato 
Pedido pedido = new Pedido(chef, "Prato");
Garcom garcom = new Garcom(pedido);
garcom.Executar();

//sobremesa
pedido = new Pedido(chef, "Sobremesa");
garcom = new Garcom(pedido);
garcom.Executar();

Console.ReadKey();
