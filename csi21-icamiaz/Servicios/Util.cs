using csi21_icamiaz.DTOS;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace csi21_icamiaz.Servicios
{
	public class Util
	{
		/// <summary>
		/// Devuelve u n entereo que este por los valores pedidos
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <param name="texto"></param>
		/// <returns></returns>
		public static int CapturaEntero(int min,int max,string texto)
		{
			int num=0;
			bool ok = false;
			do
			{
                Console.WriteLine("Introduzca Un numero de {0} al {1}",min,max);
				ok=Int32.TryParse(Console.ReadLine(), out num);

				if(!ok)
                    Console.WriteLine("No introdujo un numero");
				else if(num<min||num>max)
					Console.WriteLine("No introdujo un numero dentro de los parametros");

			} while (num < min || num > max);
			return num;
		}
		/// <summary>
		/// Pasa los Daos a Dtos de reserva
		/// </summary>
		/// <param name="res"></param>
		/// <returns></returns>
		public static List<reservaDTO> pasarDaoDtoReserva(List<Reserva> res)
		{
			DateTime m= DateTime.Now;
			List<reservaDTO> reservas = new List<reservaDTO>();
			for (int i = 0; i < res.Count; i++)
			{
				reservas.Add(new reservaDTO(res[i].getIdReserva(),res[i].getFecha()));
			}
			return reservas;
		}
		/// <summary>
		/// Pasa los daos a dtos de vajilla
		/// </summary>
		/// <param name="res"></param>
		/// <returns></returns>

		public static List<vajillaDTO> pasarDaoDtoVajilla(List<Vajilla> res)
		{
			List<vajillaDTO> vajillas = new List<vajillaDTO>();
			for (int i = 0; i < res.Count; i++)
			{
				vajillas.Add(new vajillaDTO(res[i].getIdElemento(),
						res[i].getCodigoElemento(),
						res[i].getNombreElemento(),
						 res[i].getDescripcionElemento(), res[i].getCantidad()));
			}
			return vajillas;
		}

		/// <summary>
		/// Pasa los dtos de daos de vajilla
		/// </summary>
		/// <param name="res"></param>
		/// <returns></returns>

		public static List<Vajilla> pasarDtoDaoVajilla(List<vajillaDTO> res)
		{
			List<Vajilla> vajillas = new List<Vajilla>();
			for (int i = 0; i < res.Count; i++)
			{
				vajillas.Add(new Vajilla( res[i].nombreElemento, res[i].descripcion, res[i].cantidad, res[i].getCodigoElemento()));
			}
			return vajillas;
		}
		/// <summary>
		/// Pasa los dtos a daos de reserva
		/// </summary>
		/// <param name="res"></param>
		/// <returns></returns>

		public static List<Reserva> pasarDtoDaoReserva(List<reservaDTO> res)
		{
			List<Reserva> reservas = new List<Reserva>();
			for (int i = 0; i < res.Count; i++)
			{
				reservas.Add(new Reserva(res[i].fchReserva));
			}
			return reservas;
		}

		/// <summary>
		/// Metodo que devuelve un booleano segun la respuesta que conteste
		/// </summary>
		/// <param name="texto"></param>
		/// <returns></returns>
		public static bool PreguntaSiNo(string texto)
		{
			string re="";
			do
			{
				Console.WriteLine("{0} s=Si n=No",texto);
				re = Console.ReadLine();

				if (re == "s" || re == "S")
					return true;
				else if(re=="n"||re=="N")
					return false;

            } while (true);
		}
	}
}
