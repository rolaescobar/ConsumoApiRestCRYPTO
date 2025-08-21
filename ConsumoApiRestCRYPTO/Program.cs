
using ConsumoApiRestCRYPTO;

var servicio = new CryptoServicio();

//consultar servicio Kraken



Console.WriteLine("*************************************************");
Console.WriteLine("**** OPCIÓN 1: EXCHANGE KRAKEN *******************");
Console.WriteLine("**** OPCIÓN 2: EXCHANGE BINACE *******************");
var opcion = Console.ReadLine();

if (opcion == "1")
{
    await servicio.ObtenerPrecioKraken("XBTUSD");

}
else
{
    Console.WriteLine("tU ELEGISTE BINACE");

}