using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Vajilla
{
    public int IdElemento { get; set; }

    public int CantidadElemento { get; set; }

    public string? CodigoElemento { get; set; }

    public string DescripcionElemento { get; set; } = null!;

    public string NombreElemento { get; set; } = null!;

	public Vajilla(string nombreElemento, string des, int c)
	{
		this.NombreElemento = nombreElemento;
		this.DescripcionElemento = des;
		this.CantidadElemento = c;
	}

	public Vajilla()
	{
	}


	public Vajilla(int idElemento, string nombreElemento, string descripcionElemento,
			int cantidad, string codigoElemento)
	{
		this.IdElemento = idElemento;
		this.CodigoElemento = codigoElemento;
		this.NombreElemento = nombreElemento;
		this.DescripcionElemento = descripcionElemento;
		this.CantidadElemento = cantidad;
	}

	public Vajilla(string nombreElemento, string descripcionElemento, int cantidad, string codigo)
	{
		this.NombreElemento = nombreElemento;
		this.DescripcionElemento = descripcionElemento;
		this.CantidadElemento = cantidad;
		this.CodigoElemento = codigo;
	}

	public Vajilla(int idElemento, string codigoElemento, string nombreElemento, string des, int c)
	{
		this.IdElemento = idElemento;
		this.CodigoElemento = codigoElemento;
		this.NombreElemento = nombreElemento;
		this.DescripcionElemento = des;
		this.CantidadElemento = c;
	}

	//Geters y seters
	public int getIdElemento()
	{
		return IdElemento;
	}

	public void setIdElemento(int idElemento)
	{
		this.IdElemento = idElemento;
	}

	public string getCodigoElemento()
	{
		return CodigoElemento;
	}

	public void setCodigoElemento(string codigoElemento)
	{
		this.CodigoElemento = codigoElemento;
	}

	public string getNombreElemento()
	{
		return NombreElemento;
	}

	public void setNombreElemento(string nombreElemento)
	{
		this.NombreElemento = nombreElemento;
	}


	public string getDescripcionElemento()
	{
		return DescripcionElemento;
	}

	public void setDescripcionElemento(string descripcionElemento)
	{
		this.DescripcionElemento = descripcionElemento;
	}

	public int getCantidad()
	{
		return CantidadElemento;
	}

	public void setCantidad(int cantidad)
	{
		this.CantidadElemento = cantidad;
	}
}
