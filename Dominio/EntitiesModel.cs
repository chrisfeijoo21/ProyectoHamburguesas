﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
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
	public partial class entidadDominio : OpenAccessContext, IentidadDominioUnitOfWork
	{
		private static string connectionStringName = @"TpfinalwebConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntitiesModel.rlinq");
		
		public entidadDominio()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public entidadDominio(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public entidadDominio(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public entidadDominio(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public entidadDominio(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Usuario> Usuarios 
		{
			get
			{
				return this.GetAll<Usuario>();
			}
		}
		
		public IQueryable<Subrubro> Subrubros 
		{
			get
			{
				return this.GetAll<Subrubro>();
			}
		}
		
		public IQueryable<Rubro> Rubros 
		{
			get
			{
				return this.GetAll<Rubro>();
			}
		}
		
		public IQueryable<Orden> Ordens 
		{
			get
			{
				return this.GetAll<Orden>();
			}
		}
		
		public IQueryable<LineaOrden> LineaOrdens 
		{
			get
			{
				return this.GetAll<LineaOrden>();
			}
		}
		
		public IQueryable<DetalleOrden> DetalleOrdens 
		{
			get
			{
				return this.GetAll<DetalleOrden>();
			}
		}
		
		public IQueryable<Articulo> Articulos 
		{
			get
			{
				return this.GetAll<Articulo>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
		
			CustomizeBackendConfiguration(ref backend);
		
			return backend;
		}
		
		/// <summary>
		/// Allows you to customize the BackendConfiguration of entidadDominio.
		/// </summary>
		/// <param name="config">The BackendConfiguration of entidadDominio.</param>
		static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
		
	}
	
	public interface IentidadDominioUnitOfWork : IUnitOfWork
	{
		IQueryable<Usuario> Usuarios
		{
			get;
		}
		IQueryable<Subrubro> Subrubros
		{
			get;
		}
		IQueryable<Rubro> Rubros
		{
			get;
		}
		IQueryable<Orden> Ordens
		{
			get;
		}
		IQueryable<LineaOrden> LineaOrdens
		{
			get;
		}
		IQueryable<DetalleOrden> DetalleOrdens
		{
			get;
		}
		IQueryable<Articulo> Articulos
		{
			get;
		}
	}
}
#pragma warning restore 1591
