#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Dominio;

namespace Dominio	
{
	public partial class Rubro
	{
		private int id_rubro;
		public virtual int Id_rubro
		{
			get
			{
				return this.id_rubro;
			}
			set
			{
				this.id_rubro = value;
			}
		}
		
		private string nombre;
		public virtual string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
		
		private IList<Articulo> articulo = new List<Articulo>();
		public virtual IList<Articulo> Articulo
		{
			get
			{
				return this.articulo;
			}
		}
		
		private IList<Subrubro> subrubro = new List<Subrubro>();
		public virtual IList<Subrubro> Subrubro
		{
			get
			{
				return this.subrubro;
			}
		}
		
	}
}
#pragma warning restore 1591
