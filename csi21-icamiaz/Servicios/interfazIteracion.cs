using csi21_icamiaz.DTOS;
using DAL.Models;

namespace csi21_icamiaz.Servicios
{
	public interface interfazIteracion
	{
		/// <summary>
		/// Metodo para dar de alta una vajilla y se mete en la abse de datos
		/// </summary>
		/// <param name="vas"></param>
		/// <param name="vasD"></param>
		/// <param name="ges"></param>
		/// /// <autor>Isidro Camacho Diaz</autor>
		public void meterVajilla(List<vajillaDTO> vas, List<Vajilla> vasD, ExaDosContext ges);
		/// <summary>
		/// Metodo para mostrar el stock de vajillas
		/// </summary>
		/// <param name="vas"></param>
		/// <param name="vasD"></param>
		/// <param name="ges"></param>
		/// <autor>Isidro Camacho Diaz</autor>
		public void MostrarStock(List<vajillaDTO> vas, List<Vajilla> vasD, ExaDosContext ges);
		/// <summary>
		/// Metodo para crear una reservar y meterla en la base de datos
		/// </summary>
		/// <param name="vas"></param>
		/// <param name="vasD"></param>
		/// <param name="resd"></param>
		/// <param name="res"></param>
		/// <param name="ges"></param>
		/// <autor>Isidro Camacho Diaz</autor>
		public void CrearReserva(List<vajillaDTO> vas, List<Vajilla> vasD, List<Reserva> resd, List<reservaDTO> res, ExaDosContext ges);
	}
}
