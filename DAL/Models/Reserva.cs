using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public DateTime? FchReserva { get; set; }

	//Contructores
	public Reserva()
	{
	}

	public Reserva(DateTime fchReserva)
	{
		this.FchReserva = fchReserva;
	}

	public Reserva(int idReserva, DateTime fchReserva)
	{
		this.IdReserva = idReserva;
		this.FchReserva = fchReserva;
	}

	//Geters y Serters
	public int getIdReserva()
	{
		return IdReserva;
	}



	public void setIdReserva(int idReserva)
	{
		this.IdReserva = idReserva;
	}


	public void setFchReserva(DateTime fchReserva)
	{
		this.FchReserva = fchReserva;
	}

	public DateTime getFecha()
	{
		return (DateTime)this.FchReserva;
	}

}
