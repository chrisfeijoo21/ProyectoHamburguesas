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
	public partial class Orden
	{
		private int id_orden;
		public virtual int Id_orden
		{
			get
			{
				return this.id_orden;
			}
			set
			{
				this.id_orden = value;
			}
		}
		
		private string estado;
		public virtual string Estado
		{
			get
			{
				return this.estado;
			}
			set
			{
				this.estado = value;
			}
		}
		
		private int? id_usuario;
		public virtual int? Id_usuario
		{
			get
			{
				return this.id_usuario;
			}
			set
			{
				this.id_usuario = value;
			}
		}
		
		private int? detalle_orden;
		public virtual int? Detalle_orden
		{
			get
			{
				return this.detalle_orden;
			}
			set
			{
				this.detalle_orden = value;
			}
		}
		
		private DateTime? fecha;
		public virtual DateTime? Fecha
		{
			get
			{
				return this.fecha;
			}
			set
			{
				this.fecha = value;
			}
		}
		
		private DetalleOrden detalleOrden;
		public virtual DetalleOrden DetalleOrden
		{
			get
			{
				return this.detalleOrden;
			}
			set
			{
				this.detalleOrden = value;
			}
		}
		
		private Usuario usuario;
		public virtual Usuario Usuario
		{
			get
			{
				return this.usuario;
			}
			set
			{
				this.usuario = value;
			}
		}
		
	}
}
#pragma warning restore 1591
