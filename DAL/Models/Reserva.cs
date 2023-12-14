using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Reserva
{

	public int IdReserva { get; set; }

    public DateTime FchReserva { get; set; }

    public virtual ICollection<Accione> Acciones { get; set; } = new List<Accione>();

	public Reserva(int idReserva, DateTime fchReserva, ICollection<Accione> acciones)
	{
		IdReserva = idReserva;
		FchReserva = fchReserva;
		Acciones = acciones;
	}

	public Reserva(DateTime fchReserva)
	{
		FchReserva = fchReserva;
	}
}
