using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Accione
{
    public int IdAccion { get; set; }

    public int Cantidad { get; set; }

    public int? IdReserva { get; set; }

    public int? IdVajilla { get; set; }

    public virtual Reserva? IdReservaNavigation { get; set; }

    public virtual Vajilla? IdVajillaNavigation { get; set; }

	public Accione(int cantidad, int? idReserva, int? idVajilla)
	{
		Cantidad = cantidad;
		IdReserva = idReserva;
		IdVajilla = idVajilla;
	}
}
