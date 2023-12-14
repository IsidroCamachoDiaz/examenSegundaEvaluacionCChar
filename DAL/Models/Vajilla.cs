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

    public virtual ICollection<Accione> Acciones { get; set; } = new List<Accione>();

	public Vajilla(int idElemento, int cantidadElemento, string? codigoElemento, string descripcionElemento, string nombreElemento, ICollection<Accione> acciones)
	{
		IdElemento = idElemento;
		CantidadElemento = cantidadElemento;
		CodigoElemento = codigoElemento;
		DescripcionElemento = descripcionElemento;
		NombreElemento = nombreElemento;
		Acciones = acciones;
	}

	public Vajilla(string? codigoElemento, string descripcionElemento, string nombreElemento, int cantidadElemento)
	{
		CantidadElemento = cantidadElemento;
		CodigoElemento = codigoElemento;
		DescripcionElemento = descripcionElemento;
		NombreElemento = nombreElemento;
	}

}
