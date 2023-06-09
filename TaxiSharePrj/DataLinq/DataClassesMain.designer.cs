﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxiSharePrj.DataLinq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TxShareDB")]
	public partial class DataClassesMainDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_Notification(TBL_Notification instance);
    partial void UpdateTBL_Notification(TBL_Notification instance);
    partial void DeleteTBL_Notification(TBL_Notification instance);
    partial void InsertTBL_RecPay(TBL_RecPay instance);
    partial void UpdateTBL_RecPay(TBL_RecPay instance);
    partial void DeleteTBL_RecPay(TBL_RecPay instance);
    partial void InsertTBL_ReqCustomer(TBL_ReqCustomer instance);
    partial void UpdateTBL_ReqCustomer(TBL_ReqCustomer instance);
    partial void DeleteTBL_ReqCustomer(TBL_ReqCustomer instance);
    partial void InsertTBL_ReqMachine(TBL_ReqMachine instance);
    partial void UpdateTBL_ReqMachine(TBL_ReqMachine instance);
    partial void DeleteTBL_ReqMachine(TBL_ReqMachine instance);
    #endregion
		
		public DataClassesMainDataContext() : 
				base(global::TaxiSharePrj.Properties.Settings.Default.TxShareDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesMainDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesMainDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesMainDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesMainDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_Notification> TBL_Notifications
		{
			get
			{
				return this.GetTable<TBL_Notification>();
			}
		}
		
		public System.Data.Linq.Table<TBL_User> TBL_Users
		{
			get
			{
				return this.GetTable<TBL_User>();
			}
		}
		
		public System.Data.Linq.Table<TBL_RecPay> TBL_RecPays
		{
			get
			{
				return this.GetTable<TBL_RecPay>();
			}
		}
		
		public System.Data.Linq.Table<TBL_ReqCustomer> TBL_ReqCustomers
		{
			get
			{
				return this.GetTable<TBL_ReqCustomer>();
			}
		}
		
		public System.Data.Linq.Table<TBL_SepCost> TBL_SepCosts
		{
			get
			{
				return this.GetTable<TBL_SepCost>();
			}
		}
		
		public System.Data.Linq.Table<TBL_ReqMachine> TBL_ReqMachines
		{
			get
			{
				return this.GetTable<TBL_ReqMachine>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_Notification")]
	public partial class TBL_Notification : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserCode;
		
		private int _NotifCode;
		
		private string _NotifDsc;
		
		private System.Nullable<short> _SepdRecType;
		
		private System.Nullable<bool> _Active;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserCodeChanging(int value);
    partial void OnUserCodeChanged();
    partial void OnNotifCodeChanging(int value);
    partial void OnNotifCodeChanged();
    partial void OnNotifDscChanging(string value);
    partial void OnNotifDscChanged();
    partial void OnSepdRecTypeChanging(System.Nullable<short> value);
    partial void OnSepdRecTypeChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    #endregion
		
		public TBL_Notification()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this.OnUserCodeChanging(value);
					this.SendPropertyChanging();
					this._UserCode = value;
					this.SendPropertyChanged("UserCode");
					this.OnUserCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotifCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NotifCode
		{
			get
			{
				return this._NotifCode;
			}
			set
			{
				if ((this._NotifCode != value))
				{
					this.OnNotifCodeChanging(value);
					this.SendPropertyChanging();
					this._NotifCode = value;
					this.SendPropertyChanged("NotifCode");
					this.OnNotifCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotifDsc", DbType="NVarChar(1000)")]
		public string NotifDsc
		{
			get
			{
				return this._NotifDsc;
			}
			set
			{
				if ((this._NotifDsc != value))
				{
					this.OnNotifDscChanging(value);
					this.SendPropertyChanging();
					this._NotifDsc = value;
					this.SendPropertyChanged("NotifDsc");
					this.OnNotifDscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SepdRecType", DbType="SmallInt")]
		public System.Nullable<short> SepdRecType
		{
			get
			{
				return this._SepdRecType;
			}
			set
			{
				if ((this._SepdRecType != value))
				{
					this.OnSepdRecTypeChanging(value);
					this.SendPropertyChanging();
					this._SepdRecType = value;
					this.SendPropertyChanged("SepdRecType");
					this.OnSepdRecTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_Users")]
	public partial class TBL_User
	{
		
		private int _UserCode;
		
		private string _AgencyName;
		
		private string _UserPass;
		
		private string _AgencyCode;
		
		private string _AgencyManager;
		
		private System.Nullable<System.DateTime> _GenerateDate;
		
		private System.Nullable<int> _PartMain;
		
		private System.Nullable<int> _Part1;
		
		private System.Nullable<int> _Part2;
		
		private System.Nullable<int> _Part3;
		
		private System.Nullable<int> _Part4;
		
		private System.Nullable<int> _Part5;
		
		private System.Nullable<int> _Part6;
		
		private System.Nullable<double> _AccountPrice;
		
		private System.Nullable<bool> _Active;
		
		public TBL_User()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this._UserCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgencyName", DbType="NVarChar(50)")]
		public string AgencyName
		{
			get
			{
				return this._AgencyName;
			}
			set
			{
				if ((this._AgencyName != value))
				{
					this._AgencyName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPass", DbType="NVarChar(10)")]
		public string UserPass
		{
			get
			{
				return this._UserPass;
			}
			set
			{
				if ((this._UserPass != value))
				{
					this._UserPass = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgencyCode", DbType="NVarChar(10)")]
		public string AgencyCode
		{
			get
			{
				return this._AgencyCode;
			}
			set
			{
				if ((this._AgencyCode != value))
				{
					this._AgencyCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgencyManager", DbType="NVarChar(50)")]
		public string AgencyManager
		{
			get
			{
				return this._AgencyManager;
			}
			set
			{
				if ((this._AgencyManager != value))
				{
					this._AgencyManager = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenerateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> GenerateDate
		{
			get
			{
				return this._GenerateDate;
			}
			set
			{
				if ((this._GenerateDate != value))
				{
					this._GenerateDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartMain", DbType="Int")]
		public System.Nullable<int> PartMain
		{
			get
			{
				return this._PartMain;
			}
			set
			{
				if ((this._PartMain != value))
				{
					this._PartMain = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part1", DbType="Int")]
		public System.Nullable<int> Part1
		{
			get
			{
				return this._Part1;
			}
			set
			{
				if ((this._Part1 != value))
				{
					this._Part1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part2", DbType="Int")]
		public System.Nullable<int> Part2
		{
			get
			{
				return this._Part2;
			}
			set
			{
				if ((this._Part2 != value))
				{
					this._Part2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part3", DbType="Int")]
		public System.Nullable<int> Part3
		{
			get
			{
				return this._Part3;
			}
			set
			{
				if ((this._Part3 != value))
				{
					this._Part3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part4", DbType="Int")]
		public System.Nullable<int> Part4
		{
			get
			{
				return this._Part4;
			}
			set
			{
				if ((this._Part4 != value))
				{
					this._Part4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part5", DbType="Int")]
		public System.Nullable<int> Part5
		{
			get
			{
				return this._Part5;
			}
			set
			{
				if ((this._Part5 != value))
				{
					this._Part5 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part6", DbType="Int")]
		public System.Nullable<int> Part6
		{
			get
			{
				return this._Part6;
			}
			set
			{
				if ((this._Part6 != value))
				{
					this._Part6 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountPrice", DbType="Float")]
		public System.Nullable<double> AccountPrice
		{
			get
			{
				return this._AccountPrice;
			}
			set
			{
				if ((this._AccountPrice != value))
				{
					this._AccountPrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_RecPay")]
	public partial class TBL_RecPay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserCode;
		
		private int _RecPayCode;
		
		private System.Nullable<int> _ReqCMCode;
		
		private short _ReqType;
		
		private System.Nullable<short> _RetCostType;
		
		private System.Nullable<short> _SepCostCode;
		
		private System.Nullable<double> _PriceRecPay;
		
		private System.Nullable<double> _ModAccount;
		
		private string _DscRecPay;
		
		private System.Nullable<System.DateTime> _RecPayDate;
		
		private System.Nullable<int> _RecPayTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserCodeChanging(int value);
    partial void OnUserCodeChanged();
    partial void OnRecPayCodeChanging(int value);
    partial void OnRecPayCodeChanged();
    partial void OnReqCMCodeChanging(System.Nullable<int> value);
    partial void OnReqCMCodeChanged();
    partial void OnReqTypeChanging(short value);
    partial void OnReqTypeChanged();
    partial void OnRetCostTypeChanging(System.Nullable<short> value);
    partial void OnRetCostTypeChanged();
    partial void OnSepCostCodeChanging(System.Nullable<short> value);
    partial void OnSepCostCodeChanged();
    partial void OnPriceRecPayChanging(System.Nullable<double> value);
    partial void OnPriceRecPayChanged();
    partial void OnModAccountChanging(System.Nullable<double> value);
    partial void OnModAccountChanged();
    partial void OnDscRecPayChanging(string value);
    partial void OnDscRecPayChanged();
    partial void OnRecPayDateChanging(System.Nullable<System.DateTime> value);
    partial void OnRecPayDateChanged();
    partial void OnRecPayTimeChanging(System.Nullable<int> value);
    partial void OnRecPayTimeChanged();
    #endregion
		
		public TBL_RecPay()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this.OnUserCodeChanging(value);
					this.SendPropertyChanging();
					this._UserCode = value;
					this.SendPropertyChanged("UserCode");
					this.OnUserCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecPayCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RecPayCode
		{
			get
			{
				return this._RecPayCode;
			}
			set
			{
				if ((this._RecPayCode != value))
				{
					this.OnRecPayCodeChanging(value);
					this.SendPropertyChanging();
					this._RecPayCode = value;
					this.SendPropertyChanged("RecPayCode");
					this.OnRecPayCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqCMCode", DbType="Int")]
		public System.Nullable<int> ReqCMCode
		{
			get
			{
				return this._ReqCMCode;
			}
			set
			{
				if ((this._ReqCMCode != value))
				{
					this.OnReqCMCodeChanging(value);
					this.SendPropertyChanging();
					this._ReqCMCode = value;
					this.SendPropertyChanged("ReqCMCode");
					this.OnReqCMCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqType", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short ReqType
		{
			get
			{
				return this._ReqType;
			}
			set
			{
				if ((this._ReqType != value))
				{
					this.OnReqTypeChanging(value);
					this.SendPropertyChanging();
					this._ReqType = value;
					this.SendPropertyChanged("ReqType");
					this.OnReqTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RetCostType", DbType="SmallInt")]
		public System.Nullable<short> RetCostType
		{
			get
			{
				return this._RetCostType;
			}
			set
			{
				if ((this._RetCostType != value))
				{
					this.OnRetCostTypeChanging(value);
					this.SendPropertyChanging();
					this._RetCostType = value;
					this.SendPropertyChanged("RetCostType");
					this.OnRetCostTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SepCostCode", DbType="SmallInt")]
		public System.Nullable<short> SepCostCode
		{
			get
			{
				return this._SepCostCode;
			}
			set
			{
				if ((this._SepCostCode != value))
				{
					this.OnSepCostCodeChanging(value);
					this.SendPropertyChanging();
					this._SepCostCode = value;
					this.SendPropertyChanged("SepCostCode");
					this.OnSepCostCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceRecPay", DbType="Float")]
		public System.Nullable<double> PriceRecPay
		{
			get
			{
				return this._PriceRecPay;
			}
			set
			{
				if ((this._PriceRecPay != value))
				{
					this.OnPriceRecPayChanging(value);
					this.SendPropertyChanging();
					this._PriceRecPay = value;
					this.SendPropertyChanged("PriceRecPay");
					this.OnPriceRecPayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModAccount", DbType="Float")]
		public System.Nullable<double> ModAccount
		{
			get
			{
				return this._ModAccount;
			}
			set
			{
				if ((this._ModAccount != value))
				{
					this.OnModAccountChanging(value);
					this.SendPropertyChanging();
					this._ModAccount = value;
					this.SendPropertyChanged("ModAccount");
					this.OnModAccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DscRecPay", DbType="NVarChar(400)")]
		public string DscRecPay
		{
			get
			{
				return this._DscRecPay;
			}
			set
			{
				if ((this._DscRecPay != value))
				{
					this.OnDscRecPayChanging(value);
					this.SendPropertyChanging();
					this._DscRecPay = value;
					this.SendPropertyChanged("DscRecPay");
					this.OnDscRecPayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecPayDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> RecPayDate
		{
			get
			{
				return this._RecPayDate;
			}
			set
			{
				if ((this._RecPayDate != value))
				{
					this.OnRecPayDateChanging(value);
					this.SendPropertyChanging();
					this._RecPayDate = value;
					this.SendPropertyChanged("RecPayDate");
					this.OnRecPayDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecPayTime", DbType="Int")]
		public System.Nullable<int> RecPayTime
		{
			get
			{
				return this._RecPayTime;
			}
			set
			{
				if ((this._RecPayTime != value))
				{
					this.OnRecPayTimeChanging(value);
					this.SendPropertyChanging();
					this._RecPayTime = value;
					this.SendPropertyChanged("RecPayTime");
					this.OnRecPayTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_ReqCustomer")]
	public partial class TBL_ReqCustomer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ReqCCode;
		
		private int _UserCode;
		
		private System.Nullable<int> _PartDest;
		
		private System.Nullable<System.DateTime> _ReqCDate;
		
		private System.Nullable<int> _ReqCTime;
		
		private System.Nullable<int> _ReciveTime;
		
		private System.Nullable<int> _DalayTime;
		
		private System.Nullable<int> _Priority;
		
		private System.Nullable<bool> _Active;
		
		private string _ReqCDsc;
		
		private string _CarName;
		
		private System.Nullable<int> _RetUserCode;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReqCCodeChanging(long value);
    partial void OnReqCCodeChanged();
    partial void OnUserCodeChanging(int value);
    partial void OnUserCodeChanged();
    partial void OnPartDestChanging(System.Nullable<int> value);
    partial void OnPartDestChanged();
    partial void OnReqCDateChanging(System.Nullable<System.DateTime> value);
    partial void OnReqCDateChanged();
    partial void OnReqCTimeChanging(System.Nullable<int> value);
    partial void OnReqCTimeChanged();
    partial void OnReciveTimeChanging(System.Nullable<int> value);
    partial void OnReciveTimeChanged();
    partial void OnDalayTimeChanging(System.Nullable<int> value);
    partial void OnDalayTimeChanged();
    partial void OnPriorityChanging(System.Nullable<int> value);
    partial void OnPriorityChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnReqCDscChanging(string value);
    partial void OnReqCDscChanged();
    partial void OnCarNameChanging(string value);
    partial void OnCarNameChanged();
    partial void OnRetUserCodeChanging(System.Nullable<int> value);
    partial void OnRetUserCodeChanged();
    #endregion
		
		public TBL_ReqCustomer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqCCode", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long ReqCCode
		{
			get
			{
				return this._ReqCCode;
			}
			set
			{
				if ((this._ReqCCode != value))
				{
					this.OnReqCCodeChanging(value);
					this.SendPropertyChanging();
					this._ReqCCode = value;
					this.SendPropertyChanged("ReqCCode");
					this.OnReqCCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this.OnUserCodeChanging(value);
					this.SendPropertyChanging();
					this._UserCode = value;
					this.SendPropertyChanged("UserCode");
					this.OnUserCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartDest", DbType="Int")]
		public System.Nullable<int> PartDest
		{
			get
			{
				return this._PartDest;
			}
			set
			{
				if ((this._PartDest != value))
				{
					this.OnPartDestChanging(value);
					this.SendPropertyChanging();
					this._PartDest = value;
					this.SendPropertyChanged("PartDest");
					this.OnPartDestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqCDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ReqCDate
		{
			get
			{
				return this._ReqCDate;
			}
			set
			{
				if ((this._ReqCDate != value))
				{
					this.OnReqCDateChanging(value);
					this.SendPropertyChanging();
					this._ReqCDate = value;
					this.SendPropertyChanged("ReqCDate");
					this.OnReqCDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqCTime", DbType="Int")]
		public System.Nullable<int> ReqCTime
		{
			get
			{
				return this._ReqCTime;
			}
			set
			{
				if ((this._ReqCTime != value))
				{
					this.OnReqCTimeChanging(value);
					this.SendPropertyChanging();
					this._ReqCTime = value;
					this.SendPropertyChanged("ReqCTime");
					this.OnReqCTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciveTime", DbType="Int")]
		public System.Nullable<int> ReciveTime
		{
			get
			{
				return this._ReciveTime;
			}
			set
			{
				if ((this._ReciveTime != value))
				{
					this.OnReciveTimeChanging(value);
					this.SendPropertyChanging();
					this._ReciveTime = value;
					this.SendPropertyChanged("ReciveTime");
					this.OnReciveTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DalayTime", DbType="Int")]
		public System.Nullable<int> DalayTime
		{
			get
			{
				return this._DalayTime;
			}
			set
			{
				if ((this._DalayTime != value))
				{
					this.OnDalayTimeChanging(value);
					this.SendPropertyChanging();
					this._DalayTime = value;
					this.SendPropertyChanged("DalayTime");
					this.OnDalayTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priority", DbType="Int")]
		public System.Nullable<int> Priority
		{
			get
			{
				return this._Priority;
			}
			set
			{
				if ((this._Priority != value))
				{
					this.OnPriorityChanging(value);
					this.SendPropertyChanging();
					this._Priority = value;
					this.SendPropertyChanged("Priority");
					this.OnPriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqCDsc", DbType="NVarChar(400)")]
		public string ReqCDsc
		{
			get
			{
				return this._ReqCDsc;
			}
			set
			{
				if ((this._ReqCDsc != value))
				{
					this.OnReqCDscChanging(value);
					this.SendPropertyChanging();
					this._ReqCDsc = value;
					this.SendPropertyChanged("ReqCDsc");
					this.OnReqCDscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarName", DbType="NVarChar(50)")]
		public string CarName
		{
			get
			{
				return this._CarName;
			}
			set
			{
				if ((this._CarName != value))
				{
					this.OnCarNameChanging(value);
					this.SendPropertyChanging();
					this._CarName = value;
					this.SendPropertyChanged("CarName");
					this.OnCarNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RetUserCode", DbType="Int")]
		public System.Nullable<int> RetUserCode
		{
			get
			{
				return this._RetUserCode;
			}
			set
			{
				if ((this._RetUserCode != value))
				{
					this.OnRetUserCodeChanging(value);
					this.SendPropertyChanging();
					this._RetUserCode = value;
					this.SendPropertyChanged("RetUserCode");
					this.OnRetUserCodeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_SepCost")]
	public partial class TBL_SepCost
	{
		
		private System.Nullable<int> _SepCostCode;
		
		private string _PathType;
		
		private System.Nullable<int> _PerReqer;
		
		private System.Nullable<int> _PerSolver;
		
		public TBL_SepCost()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SepCostCode", DbType="Int")]
		public System.Nullable<int> SepCostCode
		{
			get
			{
				return this._SepCostCode;
			}
			set
			{
				if ((this._SepCostCode != value))
				{
					this._SepCostCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PathType", DbType="NVarChar(50)")]
		public string PathType
		{
			get
			{
				return this._PathType;
			}
			set
			{
				if ((this._PathType != value))
				{
					this._PathType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PerReqer", DbType="Int")]
		public System.Nullable<int> PerReqer
		{
			get
			{
				return this._PerReqer;
			}
			set
			{
				if ((this._PerReqer != value))
				{
					this._PerReqer = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PerSolver", DbType="Int")]
		public System.Nullable<int> PerSolver
		{
			get
			{
				return this._PerSolver;
			}
			set
			{
				if ((this._PerSolver != value))
				{
					this._PerSolver = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_ReqMachine")]
	public partial class TBL_ReqMachine : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ReqMCode;
		
		private int _UserCode;
		
		private System.Nullable<System.DateTime> _ReqMDate;
		
		private System.Nullable<int> _ReqMTime;
		
		private System.Nullable<int> _PartBeggining;
		
		private System.Nullable<int> _PartDest;
		
		private string _TelCust;
		
		private string _MobileCust;
		
		private System.Nullable<double> _ServicePrice;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<int> _RetUserCode;
		
		private string _ReqMDsc;
		
		private string _CancelDsc;
		
		private string _CarName;
		
		private System.Nullable<int> _MaxTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReqMCodeChanging(long value);
    partial void OnReqMCodeChanged();
    partial void OnUserCodeChanging(int value);
    partial void OnUserCodeChanged();
    partial void OnReqMDateChanging(System.Nullable<System.DateTime> value);
    partial void OnReqMDateChanged();
    partial void OnReqMTimeChanging(System.Nullable<int> value);
    partial void OnReqMTimeChanged();
    partial void OnPartBegginingChanging(System.Nullable<int> value);
    partial void OnPartBegginingChanged();
    partial void OnPartDestChanging(System.Nullable<int> value);
    partial void OnPartDestChanged();
    partial void OnTelCustChanging(string value);
    partial void OnTelCustChanged();
    partial void OnMobileCustChanging(string value);
    partial void OnMobileCustChanged();
    partial void OnServicePriceChanging(System.Nullable<double> value);
    partial void OnServicePriceChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnRetUserCodeChanging(System.Nullable<int> value);
    partial void OnRetUserCodeChanged();
    partial void OnReqMDscChanging(string value);
    partial void OnReqMDscChanged();
    partial void OnCancelDscChanging(string value);
    partial void OnCancelDscChanged();
    partial void OnCarNameChanging(string value);
    partial void OnCarNameChanged();
    partial void OnMaxTimeChanging(System.Nullable<int> value);
    partial void OnMaxTimeChanged();
    #endregion
		
		public TBL_ReqMachine()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqMCode", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long ReqMCode
		{
			get
			{
				return this._ReqMCode;
			}
			set
			{
				if ((this._ReqMCode != value))
				{
					this.OnReqMCodeChanging(value);
					this.SendPropertyChanging();
					this._ReqMCode = value;
					this.SendPropertyChanged("ReqMCode");
					this.OnReqMCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this.OnUserCodeChanging(value);
					this.SendPropertyChanging();
					this._UserCode = value;
					this.SendPropertyChanged("UserCode");
					this.OnUserCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqMDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ReqMDate
		{
			get
			{
				return this._ReqMDate;
			}
			set
			{
				if ((this._ReqMDate != value))
				{
					this.OnReqMDateChanging(value);
					this.SendPropertyChanging();
					this._ReqMDate = value;
					this.SendPropertyChanged("ReqMDate");
					this.OnReqMDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqMTime", DbType="Int")]
		public System.Nullable<int> ReqMTime
		{
			get
			{
				return this._ReqMTime;
			}
			set
			{
				if ((this._ReqMTime != value))
				{
					this.OnReqMTimeChanging(value);
					this.SendPropertyChanging();
					this._ReqMTime = value;
					this.SendPropertyChanged("ReqMTime");
					this.OnReqMTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartBeggining", DbType="Int")]
		public System.Nullable<int> PartBeggining
		{
			get
			{
				return this._PartBeggining;
			}
			set
			{
				if ((this._PartBeggining != value))
				{
					this.OnPartBegginingChanging(value);
					this.SendPropertyChanging();
					this._PartBeggining = value;
					this.SendPropertyChanged("PartBeggining");
					this.OnPartBegginingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartDest", DbType="Int")]
		public System.Nullable<int> PartDest
		{
			get
			{
				return this._PartDest;
			}
			set
			{
				if ((this._PartDest != value))
				{
					this.OnPartDestChanging(value);
					this.SendPropertyChanging();
					this._PartDest = value;
					this.SendPropertyChanged("PartDest");
					this.OnPartDestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelCust", DbType="VarChar(20)")]
		public string TelCust
		{
			get
			{
				return this._TelCust;
			}
			set
			{
				if ((this._TelCust != value))
				{
					this.OnTelCustChanging(value);
					this.SendPropertyChanging();
					this._TelCust = value;
					this.SendPropertyChanged("TelCust");
					this.OnTelCustChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobileCust", DbType="VarChar(20)")]
		public string MobileCust
		{
			get
			{
				return this._MobileCust;
			}
			set
			{
				if ((this._MobileCust != value))
				{
					this.OnMobileCustChanging(value);
					this.SendPropertyChanging();
					this._MobileCust = value;
					this.SendPropertyChanged("MobileCust");
					this.OnMobileCustChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServicePrice", DbType="Float")]
		public System.Nullable<double> ServicePrice
		{
			get
			{
				return this._ServicePrice;
			}
			set
			{
				if ((this._ServicePrice != value))
				{
					this.OnServicePriceChanging(value);
					this.SendPropertyChanging();
					this._ServicePrice = value;
					this.SendPropertyChanged("ServicePrice");
					this.OnServicePriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RetUserCode", DbType="Int")]
		public System.Nullable<int> RetUserCode
		{
			get
			{
				return this._RetUserCode;
			}
			set
			{
				if ((this._RetUserCode != value))
				{
					this.OnRetUserCodeChanging(value);
					this.SendPropertyChanging();
					this._RetUserCode = value;
					this.SendPropertyChanged("RetUserCode");
					this.OnRetUserCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReqMDsc", DbType="NVarChar(400)")]
		public string ReqMDsc
		{
			get
			{
				return this._ReqMDsc;
			}
			set
			{
				if ((this._ReqMDsc != value))
				{
					this.OnReqMDscChanging(value);
					this.SendPropertyChanging();
					this._ReqMDsc = value;
					this.SendPropertyChanged("ReqMDsc");
					this.OnReqMDscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CancelDsc", DbType="NVarChar(400)")]
		public string CancelDsc
		{
			get
			{
				return this._CancelDsc;
			}
			set
			{
				if ((this._CancelDsc != value))
				{
					this.OnCancelDscChanging(value);
					this.SendPropertyChanging();
					this._CancelDsc = value;
					this.SendPropertyChanged("CancelDsc");
					this.OnCancelDscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarName", DbType="NVarChar(500)")]
		public string CarName
		{
			get
			{
				return this._CarName;
			}
			set
			{
				if ((this._CarName != value))
				{
					this.OnCarNameChanging(value);
					this.SendPropertyChanging();
					this._CarName = value;
					this.SendPropertyChanged("CarName");
					this.OnCarNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxTime", DbType="Int")]
		public System.Nullable<int> MaxTime
		{
			get
			{
				return this._MaxTime;
			}
			set
			{
				if ((this._MaxTime != value))
				{
					this.OnMaxTimeChanging(value);
					this.SendPropertyChanging();
					this._MaxTime = value;
					this.SendPropertyChanged("MaxTime");
					this.OnMaxTimeChanged();
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
