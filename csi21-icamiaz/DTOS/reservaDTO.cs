using DAL.Models;

namespace csi21_icamiaz.DTOS
{
	public class reservaDTO
	{

		public int idReserva;

		public DateTime fchReserva;



		public reservaDTO(int idReserva, DateTime fchReserva)
		{
			this.idReserva = idReserva;
			this.fchReserva = fchReserva;

		}

		public reservaDTO( DateTime fchReserva)
		{
			this.fchReserva = fchReserva;
		}
	}
}
