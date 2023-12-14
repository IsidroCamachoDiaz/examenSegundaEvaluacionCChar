using csi21_icamiaz.DTOS;
using csi21_icamiaz.Servicios;
using DAL.Models;
using Microsoft.Extensions.Options;

namespace csi21_icamiaz.Controllers
{
	internal class Main
	{
		/// <autor>Isidro Camacho Diaz</autor>
		internal static void Principal(ExaDosContext ges)
		{
			int opcion=0;
			//Creo las listas
			List <Vajilla> vasD= new List<Vajilla> ();
			List <vajillaDTO> vas=new List<vajillaDTO> ();
			List <Reserva> resD= new List<Reserva> ();
			List <reservaDTO> res =new List<reservaDTO> ();
			interfazIteracion it= new implementacionIteraccion();
			vasD = ges.Vajillas.ToList();
			
			do
			{
				try
				{
                    //Menu
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("1-Dar de alta");
					Console.WriteLine("2-Mostrar Stock");
					Console.WriteLine("3-Crear Reserva");
					Console.WriteLine("0-Salir");
					Console.WriteLine("--------------------------------------------------");
					opcion = Util.CapturaEntero(0, 3, "Introduzca Una opcion: ");
					switch (opcion)
					{
						case 1:
							it.meterVajilla(vas,vasD,ges);
                            Console.WriteLine("Se inserto la vajilla");
                            break;
						case 2:
							it.MostrarStock(vas,vasD,ges);
                            break;
						case 3:
							it.CrearReserva(vas,vasD,resD,res,ges);
                            Console.WriteLine("Se creo la reserva");
                            break;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("Hubo un error en el main" + e.Message);
					opcion = 8;
				}

			} while (opcion != 0);

		}
	}
}
