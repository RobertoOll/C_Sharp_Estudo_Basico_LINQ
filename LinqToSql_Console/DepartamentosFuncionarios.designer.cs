﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSql_Console
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Empresa")]
	public partial class DepartamentosFuncionariosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartamentos(Departamentos instance);
    partial void UpdateDepartamentos(Departamentos instance);
    partial void DeleteDepartamentos(Departamentos instance);
    partial void InsertFuncionarios(Funcionarios instance);
    partial void UpdateFuncionarios(Funcionarios instance);
    partial void DeleteFuncionarios(Funcionarios instance);
    #endregion
		
		public DepartamentosFuncionariosDataContext() : 
				base(global::LinqToSql_Console.Properties.Settings.Default.EmpresaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DepartamentosFuncionariosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DepartamentosFuncionariosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DepartamentosFuncionariosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DepartamentosFuncionariosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Departamentos> Departamentos
		{
			get
			{
				return this.GetTable<Departamentos>();
			}
		}
		
		public System.Data.Linq.Table<Funcionarios> Funcionarios
		{
			get
			{
				return this.GetTable<Funcionarios>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departamentos")]
	public partial class Departamentos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Sigla;
		
		private string _Departamento1;
		
		private EntitySet<Funcionarios> _Funcionarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSiglaChanging(string value);
    partial void OnSiglaChanged();
    partial void OnDepartamento1Changing(string value);
    partial void OnDepartamento1Changed();
    #endregion
		
		public Departamentos()
		{
			this._Funcionarios = new EntitySet<Funcionarios>(new Action<Funcionarios>(this.attach_Funcionarios), new Action<Funcionarios>(this.detach_Funcionarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sigla", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Sigla
		{
			get
			{
				return this._Sigla;
			}
			set
			{
				if ((this._Sigla != value))
				{
					this.OnSiglaChanging(value);
					this.SendPropertyChanging();
					this._Sigla = value;
					this.SendPropertyChanged("Sigla");
					this.OnSiglaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Departamento", Storage="_Departamento1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Departamento1
		{
			get
			{
				return this._Departamento1;
			}
			set
			{
				if ((this._Departamento1 != value))
				{
					this.OnDepartamento1Changing(value);
					this.SendPropertyChanging();
					this._Departamento1 = value;
					this.SendPropertyChanged("Departamento1");
					this.OnDepartamento1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Funcionario", Storage="_Funcionarios", ThisKey="Sigla", OtherKey="Departamento")]
		public EntitySet<Funcionarios> Funcionarios
		{
			get
			{
				return this._Funcionarios;
			}
			set
			{
				this._Funcionarios.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Funcionarios(Funcionarios entity)
		{
			this.SendPropertyChanging();
			entity.Departamentos = this;
		}
		
		private void detach_Funcionarios(Funcionarios entity)
		{
			this.SendPropertyChanging();
			entity.Departamentos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Funcionarios")]
	public partial class Funcionarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nome;
		
		private string _Departamento;
		
		private EntityRef<Departamentos> _Departamentos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnDepartamentoChanging(string value);
    partial void OnDepartamentoChanged();
    #endregion
		
		public Funcionarios()
		{
			this._Departamentos = default(EntityRef<Departamentos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Departamento", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Departamento
		{
			get
			{
				return this._Departamento;
			}
			set
			{
				if ((this._Departamento != value))
				{
					if (this._Departamentos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartamentoChanging(value);
					this.SendPropertyChanging();
					this._Departamento = value;
					this.SendPropertyChanged("Departamento");
					this.OnDepartamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Funcionario", Storage="_Departamentos", ThisKey="Departamento", OtherKey="Sigla", IsForeignKey=true)]
		public Departamentos Departamentos
		{
			get
			{
				return this._Departamentos.Entity;
			}
			set
			{
				Departamentos previousValue = this._Departamentos.Entity;
				if (((previousValue != value) 
							|| (this._Departamentos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departamentos.Entity = null;
						previousValue.Funcionarios.Remove(this);
					}
					this._Departamentos.Entity = value;
					if ((value != null))
					{
						value.Funcionarios.Add(this);
						this._Departamento = value.Sigla;
					}
					else
					{
						this._Departamento = default(string);
					}
					this.SendPropertyChanged("Departamentos");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591