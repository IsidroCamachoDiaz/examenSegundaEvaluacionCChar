using DAL.Models;

namespace csi21_icamiaz.DTOS
{
    public class vajillaDTO
    {
		public int idElemento;

		public string codigoElemento;

		public string nombreElemento;

		public string descripcion;

		public int cantidad;


		public vajillaDTO(int idElemento, string codigoElemento, string nombreElemento, string des, int c)
		{
			this.idElemento = idElemento;
			this.codigoElemento = codigoElemento;
			this.nombreElemento = nombreElemento;
			this.descripcion = des;
			this.cantidad = c;
		}

		public vajillaDTO(string nombreElemento, string des, int c)
		{
			this.nombreElemento = nombreElemento;
			this.descripcion = des;
			this.cantidad = c;
		}

		public vajillaDTO()
		{
		}

		public int getIdElemento()
		{
			return idElemento;
		}

		public void setIdElemento(int idElemento)
		{
			this.idElemento = idElemento;
		}

		public String getCodigoElemento()
		{
			return codigoElemento;
		}

		public void setCodigoElemento(String codigoElemento)
		{
			this.codigoElemento = codigoElemento;
		}

		public String getNombreElemento()
		{
			return nombreElemento;
		}

		public void setNombreElemento(string nombreElemento)
		{
			this.nombreElemento = nombreElemento;
		}

	}
}
