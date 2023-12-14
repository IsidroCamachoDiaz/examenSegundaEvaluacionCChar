using csi21_icamiaz.DTOS;
using DAL.Models;
using System.Security.Cryptography;

namespace csi21_icamiaz.Servicios
{
	public class implementacionIteraccion : interfazIteracion
	{
		public void CrearReserva(List<vajillaDTO> vas, List<Vajilla> vasD, List<Reserva> resd, List<reservaDTO> res, ExaDosContext ges)
		{
			try
			{
				DateTime dia;
				bool ok;
				do
				{
					Console.WriteLine("Introduja la Fecha de la Rerserva");
					ok = DateTime.TryParse(Console.ReadLine(), out dia);
					
					if (!ok)
					{
						Console.WriteLine("No introdujo bien la fecha");
					}
				}while (!ok);

				
				vasD= ges.Vajillas.ToList();
				vas=Util.pasarDaoDtoVajilla(vasD);
				reservaDTO re = new reservaDTO(dia);
				res.Add(re);
				resd = Util.pasarDtoDaoReserva(res);
				ges.Reservas.Add(resd[resd.Count - 1]);
				ges.SaveChanges();
				if (ges.Vajillas.ToList().Count == 0)
				{
					Console.WriteLine("No hay vajilla par añadir");
				}
				else {
					if (Util.PreguntaSiNo("Quiero añadir vajilla?")) {
						for (int i = 0; i < vasD.Count; i++)
						{
							Console.WriteLine("Vajilla: {0} Nombre: {1} Descripcion: {2} Cantidad: {3}", i, vas[i].nombreElemento, vas[i].descripcion, vas[i].cantidad);
						}
						int iVajilla = Util.CapturaEntero(0, vas.Count - 1, "Indique el id de la vajilla");
						int cantidad = Util.CapturaEntero(0, vas[iVajilla].cantidad, "Que cantidad quiere");
						List<vajillaDTO> vajillaMeter = new List<vajillaDTO>();
						vajillaMeter.Add(vas[iVajilla]);
						List <Reserva> resEs = ges.Reservas.ToList();
						for(int i=0;i<resEs.Count;i++)
						{
							if (resEs[i].FchReserva==dia) {
								Accione acio = new Accione(cantidad, resEs[i].IdReserva, vas[iVajilla].idElemento);
								ges.Acciones.Add(acio);
								ges.SaveChanges();
							}
						}
						

					}
				}
				
				

			}
			catch(Exception ex)
			{
                Console.WriteLine("Error en  Crear Reserva: "+ex.Message);
            }
        }

		public void meterVajilla(List<vajillaDTO> vas, List<Vajilla> vasD, ExaDosContext ges)
		{
			try
			{
				Console.WriteLine("Dar de alta");
				Console.WriteLine("Introduzca un Nombre de la vajilla:");
				string nombre = Console.ReadLine();
				Console.WriteLine("Introduzca una Descripcion de la vajilla:");
				string des = Console.ReadLine();

				int cantidad = Util.CapturaEntero(1, 9999, "Introduzca una cantidad de la vajilla:");


				if (des.Length < 3)
					des = des + "aaaaaaaaa";
				if (cantidad != 999)
				{
					vajillaDTO u1 = new vajillaDTO(nombre, des, cantidad);
					u1.setCodigoElemento(des.Substring(0, 3) + "-" + nombre);
					vas.Add(u1);
					vasD = Util.pasarDtoDaoVajilla(vas);
					ges.Vajillas.Add(vasD[0]);
					ges.SaveChanges();
					Console.WriteLine("Se hizo correctamente");
				}
				else
					Console.WriteLine("No se creo");
			}catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		public void MostrarStock(List<vajillaDTO> vas, List<Vajilla> vasD, ExaDosContext ges)
		{
			vasD = ges.Vajillas.ToList();
			vas = Util.pasarDaoDtoVajilla(vasD);
			if (vas.Count > 0)
			{
				for (int i = 0; i < vas.Count; i++)
				{
					string texto = vas[i].nombreElemento + " " + vas[i].descripcion + " " + vas[i].cantidad;
					Console.WriteLine(texto);
				}
			}
			else
			{
                Console.WriteLine("No hay vajillas Registradas");
            }
		}
	}
}
