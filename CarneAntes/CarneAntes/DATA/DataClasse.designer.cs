﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarneAntes.DATA
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Parcial2_Progra5")]
	public partial class DataClasseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertalumno(alumno instance);
    partial void Updatealumno(alumno instance);
    partial void Deletealumno(alumno instance);
    #endregion
		
		public DataClasseDataContext() : 
				base(global::CarneAntes.Properties.Settings.Default.Parcial2_Progra5ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<alumno> alumnos
		{
			get
			{
				return this.GetTable<alumno>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.alumno")]
	public partial class alumno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Carne;
		
		private string _apellido1_alumno;
		
		private string _apellido2_alumno;
		
		private string _nombre1_alumno;
		
		private string _nombre2_alumno;
		
		private System.Nullable<System.DateTime> _Fechanac;
		
		private string _Sexo_Alumno;
		
		private System.Nullable<int> _estado_alumno;
		
		private string _direccion_alumno;
		
		private string _celular_alumno;
		
		private System.Nullable<System.DateTime> _fechaingreso;
		
		private System.Nullable<int> _id_muni;
		
		private System.Nullable<int> _numero_actualizacion;
		
		private System.Nullable<int> _id_encargado;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCarneChanging(string value);
    partial void OnCarneChanged();
    partial void Onapellido1_alumnoChanging(string value);
    partial void Onapellido1_alumnoChanged();
    partial void Onapellido2_alumnoChanging(string value);
    partial void Onapellido2_alumnoChanged();
    partial void Onnombre1_alumnoChanging(string value);
    partial void Onnombre1_alumnoChanged();
    partial void Onnombre2_alumnoChanging(string value);
    partial void Onnombre2_alumnoChanged();
    partial void OnFechanacChanging(System.Nullable<System.DateTime> value);
    partial void OnFechanacChanged();
    partial void OnSexo_AlumnoChanging(string value);
    partial void OnSexo_AlumnoChanged();
    partial void Onestado_alumnoChanging(System.Nullable<int> value);
    partial void Onestado_alumnoChanged();
    partial void Ondireccion_alumnoChanging(string value);
    partial void Ondireccion_alumnoChanged();
    partial void Oncelular_alumnoChanging(string value);
    partial void Oncelular_alumnoChanged();
    partial void OnfechaingresoChanging(System.Nullable<System.DateTime> value);
    partial void OnfechaingresoChanged();
    partial void Onid_muniChanging(System.Nullable<int> value);
    partial void Onid_muniChanged();
    partial void Onnumero_actualizacionChanging(System.Nullable<int> value);
    partial void Onnumero_actualizacionChanged();
    partial void Onid_encargadoChanging(System.Nullable<int> value);
    partial void Onid_encargadoChanged();
    #endregion
		
		public alumno()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Carne", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Carne
		{
			get
			{
				return this._Carne;
			}
			set
			{
				if ((this._Carne != value))
				{
					this.OnCarneChanging(value);
					this.SendPropertyChanging();
					this._Carne = value;
					this.SendPropertyChanged("Carne");
					this.OnCarneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido1_alumno", DbType="NVarChar(20)")]
		public string apellido1_alumno
		{
			get
			{
				return this._apellido1_alumno;
			}
			set
			{
				if ((this._apellido1_alumno != value))
				{
					this.Onapellido1_alumnoChanging(value);
					this.SendPropertyChanging();
					this._apellido1_alumno = value;
					this.SendPropertyChanged("apellido1_alumno");
					this.Onapellido1_alumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido2_alumno", DbType="NVarChar(20)")]
		public string apellido2_alumno
		{
			get
			{
				return this._apellido2_alumno;
			}
			set
			{
				if ((this._apellido2_alumno != value))
				{
					this.Onapellido2_alumnoChanging(value);
					this.SendPropertyChanging();
					this._apellido2_alumno = value;
					this.SendPropertyChanged("apellido2_alumno");
					this.Onapellido2_alumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre1_alumno", DbType="NVarChar(20)")]
		public string nombre1_alumno
		{
			get
			{
				return this._nombre1_alumno;
			}
			set
			{
				if ((this._nombre1_alumno != value))
				{
					this.Onnombre1_alumnoChanging(value);
					this.SendPropertyChanging();
					this._nombre1_alumno = value;
					this.SendPropertyChanged("nombre1_alumno");
					this.Onnombre1_alumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre2_alumno", DbType="NVarChar(20)")]
		public string nombre2_alumno
		{
			get
			{
				return this._nombre2_alumno;
			}
			set
			{
				if ((this._nombre2_alumno != value))
				{
					this.Onnombre2_alumnoChanging(value);
					this.SendPropertyChanging();
					this._nombre2_alumno = value;
					this.SendPropertyChanged("nombre2_alumno");
					this.Onnombre2_alumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fechanac", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Fechanac
		{
			get
			{
				return this._Fechanac;
			}
			set
			{
				if ((this._Fechanac != value))
				{
					this.OnFechanacChanging(value);
					this.SendPropertyChanging();
					this._Fechanac = value;
					this.SendPropertyChanged("Fechanac");
					this.OnFechanacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo_Alumno", DbType="NVarChar(20)")]
		public string Sexo_Alumno
		{
			get
			{
				return this._Sexo_Alumno;
			}
			set
			{
				if ((this._Sexo_Alumno != value))
				{
					this.OnSexo_AlumnoChanging(value);
					this.SendPropertyChanging();
					this._Sexo_Alumno = value;
					this.SendPropertyChanged("Sexo_Alumno");
					this.OnSexo_AlumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado_alumno", DbType="Int")]
		public System.Nullable<int> estado_alumno
		{
			get
			{
				return this._estado_alumno;
			}
			set
			{
				if ((this._estado_alumno != value))
				{
					this.Onestado_alumnoChanging(value);
					this.SendPropertyChanging();
					this._estado_alumno = value;
					this.SendPropertyChanged("estado_alumno");
					this.Onestado_alumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion_alumno", DbType="NVarChar(100)")]
		public string direccion_alumno
		{
			get
			{
				return this._direccion_alumno;
			}
			set
			{
				if ((this._direccion_alumno != value))
				{
					this.Ondireccion_alumnoChanging(value);
					this.SendPropertyChanging();
					this._direccion_alumno = value;
					this.SendPropertyChanged("direccion_alumno");
					this.Ondireccion_alumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_celular_alumno", DbType="NVarChar(20)")]
		public string celular_alumno
		{
			get
			{
				return this._celular_alumno;
			}
			set
			{
				if ((this._celular_alumno != value))
				{
					this.Oncelular_alumnoChanging(value);
					this.SendPropertyChanging();
					this._celular_alumno = value;
					this.SendPropertyChanged("celular_alumno");
					this.Oncelular_alumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaingreso", DbType="DateTime")]
		public System.Nullable<System.DateTime> fechaingreso
		{
			get
			{
				return this._fechaingreso;
			}
			set
			{
				if ((this._fechaingreso != value))
				{
					this.OnfechaingresoChanging(value);
					this.SendPropertyChanging();
					this._fechaingreso = value;
					this.SendPropertyChanged("fechaingreso");
					this.OnfechaingresoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_muni", DbType="Int")]
		public System.Nullable<int> id_muni
		{
			get
			{
				return this._id_muni;
			}
			set
			{
				if ((this._id_muni != value))
				{
					this.Onid_muniChanging(value);
					this.SendPropertyChanging();
					this._id_muni = value;
					this.SendPropertyChanged("id_muni");
					this.Onid_muniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero_actualizacion", DbType="Int")]
		public System.Nullable<int> numero_actualizacion
		{
			get
			{
				return this._numero_actualizacion;
			}
			set
			{
				if ((this._numero_actualizacion != value))
				{
					this.Onnumero_actualizacionChanging(value);
					this.SendPropertyChanging();
					this._numero_actualizacion = value;
					this.SendPropertyChanged("numero_actualizacion");
					this.Onnumero_actualizacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_encargado", DbType="Int")]
		public System.Nullable<int> id_encargado
		{
			get
			{
				return this._id_encargado;
			}
			set
			{
				if ((this._id_encargado != value))
				{
					this.Onid_encargadoChanging(value);
					this.SendPropertyChanging();
					this._id_encargado = value;
					this.SendPropertyChanged("id_encargado");
					this.Onid_encargadoChanged();
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
