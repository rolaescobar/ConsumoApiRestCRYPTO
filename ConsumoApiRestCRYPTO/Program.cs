
using ConsumoApiRestCRYPTO;

var servicio = new CryptoServicio();

//consultar servicio Kraken

await servicio.ObtenerPrecioKraken("ETHUSDC");