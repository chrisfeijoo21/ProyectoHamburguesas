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
	public partial class ComidaXIngrediente
	{
		private int idComidaXIngrediente;
		public virtual int IdComidaXIngrediente
		{
			get
			{
				return this.idComidaXIngrediente;
			}
			set
			{
				this.idComidaXIngrediente = value;
			}
		}
		
		private int? idComida;
		public virtual int? IdComida
		{
			get
			{
				return this.idComida;
			}
			set
			{
				this.idComida = value;
			}
		}
		
		private int? idIngrediente;
		public virtual int? IdIngrediente
		{
			get
			{
				return this.idIngrediente;
			}
			set
			{
				this.idIngrediente = value;
			}
		}
		
		private Ingrediente ingrediente;
		public virtual Ingrediente Ingrediente
		{
			get
			{
				return this.ingrediente;
			}
			set
			{
				this.ingrediente = value;
			}
		}
		
		private Comida comida;
		public virtual Comida Comida
		{
			get
			{
				return this.comida;
			}
			set
			{
				this.comida = value;
			}
		}
		
	}
}
#pragma warning restore 1591
