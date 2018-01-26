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

namespace Centennial_Catering_System
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CateringDB")]
	public partial class SaleReportDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblOrderItem(tblOrderItem instance);
    partial void UpdatetblOrderItem(tblOrderItem instance);
    partial void DeletetblOrderItem(tblOrderItem instance);
    partial void InserttblOrder(tblOrder instance);
    partial void UpdatetblOrder(tblOrder instance);
    partial void DeletetblOrder(tblOrder instance);
    partial void InserttblItem(tblItem instance);
    partial void UpdatetblItem(tblItem instance);
    partial void DeletetblItem(tblItem instance);
    partial void InserttblCategory(tblCategory instance);
    partial void UpdatetblCategory(tblCategory instance);
    partial void DeletetblCategory(tblCategory instance);
    #endregion
		
		public SaleReportDataContext() : 
				base(global::Centennial_Catering_System.Properties.Settings.Default.CateringDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SaleReportDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaleReportDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaleReportDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaleReportDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblOrderItem> tblOrderItems
		{
			get
			{
				return this.GetTable<tblOrderItem>();
			}
		}
		
		public System.Data.Linq.Table<tblOrder> tblOrders
		{
			get
			{
				return this.GetTable<tblOrder>();
			}
		}
		
		public System.Data.Linq.Table<tblItem> tblItems
		{
			get
			{
				return this.GetTable<tblItem>();
			}
		}
		
		public System.Data.Linq.Table<tblCategory> tblCategories
		{
			get
			{
				return this.GetTable<tblCategory>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblOrderItems")]
	public partial class tblOrderItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OrderID;
		
		private string _OrderItemID;
		
		private string _ItemID;
		
		private int _Quantity;
		
		private decimal _Total;
		
		private EntityRef<tblOrder> _tblOrder;
		
		private EntityRef<tblItem> _tblItem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(string value);
    partial void OnOrderIDChanged();
    partial void OnOrderItemIDChanging(string value);
    partial void OnOrderItemIDChanged();
    partial void OnItemIDChanging(string value);
    partial void OnItemIDChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnTotalChanging(decimal value);
    partial void OnTotalChanged();
    #endregion
		
		public tblOrderItem()
		{
			this._tblOrder = default(EntityRef<tblOrder>);
			this._tblItem = default(EntityRef<tblItem>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					if (this._tblOrder.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderItemID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OrderItemID
		{
			get
			{
				return this._OrderItemID;
			}
			set
			{
				if ((this._OrderItemID != value))
				{
					this.OnOrderItemIDChanging(value);
					this.SendPropertyChanging();
					this._OrderItemID = value;
					this.SendPropertyChanged("OrderItemID");
					this.OnOrderItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					if (this._tblItem.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Decimal(6,2) NOT NULL")]
		public decimal Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblOrder_tblOrderItem", Storage="_tblOrder", ThisKey="OrderID", OtherKey="OrderID", IsForeignKey=true)]
		public tblOrder tblOrder
		{
			get
			{
				return this._tblOrder.Entity;
			}
			set
			{
				tblOrder previousValue = this._tblOrder.Entity;
				if (((previousValue != value) 
							|| (this._tblOrder.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblOrder.Entity = null;
						previousValue.tblOrderItems.Remove(this);
					}
					this._tblOrder.Entity = value;
					if ((value != null))
					{
						value.tblOrderItems.Add(this);
						this._OrderID = value.OrderID;
					}
					else
					{
						this._OrderID = default(string);
					}
					this.SendPropertyChanged("tblOrder");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblItem_tblOrderItem", Storage="_tblItem", ThisKey="ItemID", OtherKey="ItemID", IsForeignKey=true)]
		public tblItem tblItem
		{
			get
			{
				return this._tblItem.Entity;
			}
			set
			{
				tblItem previousValue = this._tblItem.Entity;
				if (((previousValue != value) 
							|| (this._tblItem.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblItem.Entity = null;
						previousValue.tblOrderItems.Remove(this);
					}
					this._tblItem.Entity = value;
					if ((value != null))
					{
						value.tblOrderItems.Add(this);
						this._ItemID = value.ItemID;
					}
					else
					{
						this._ItemID = default(string);
					}
					this.SendPropertyChanged("tblItem");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblOrders")]
	public partial class tblOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OrderID;
		
		private string _CustomerID;
		
		private string _OrderDate;
		
		private decimal _Amount;
		
		private EntitySet<tblOrderItem> _tblOrderItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(string value);
    partial void OnOrderIDChanged();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnOrderDateChanging(string value);
    partial void OnOrderDateChanged();
    partial void OnAmountChanging(decimal value);
    partial void OnAmountChanged();
    #endregion
		
		public tblOrder()
		{
			this._tblOrderItems = new EntitySet<tblOrderItem>(new Action<tblOrderItem>(this.attach_tblOrderItems), new Action<tblOrderItem>(this.detach_tblOrderItems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="VarChar(10)")]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(6,2) NOT NULL")]
		public decimal Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblOrder_tblOrderItem", Storage="_tblOrderItems", ThisKey="OrderID", OtherKey="OrderID")]
		public EntitySet<tblOrderItem> tblOrderItems
		{
			get
			{
				return this._tblOrderItems;
			}
			set
			{
				this._tblOrderItems.Assign(value);
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
		
		private void attach_tblOrderItems(tblOrderItem entity)
		{
			this.SendPropertyChanging();
			entity.tblOrder = this;
		}
		
		private void detach_tblOrderItems(tblOrderItem entity)
		{
			this.SendPropertyChanging();
			entity.tblOrder = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblItems")]
	public partial class tblItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ItemID;
		
		private string _CategoryID;
		
		private string _ProductName;
		
		private string _ProductImg;
		
		private decimal _Price;
		
		private EntitySet<tblOrderItem> _tblOrderItems;
		
		private EntityRef<tblCategory> _tblCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIDChanging(string value);
    partial void OnItemIDChanged();
    partial void OnCategoryIDChanging(string value);
    partial void OnCategoryIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnProductImgChanging(string value);
    partial void OnProductImgChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    #endregion
		
		public tblItem()
		{
			this._tblOrderItems = new EntitySet<tblOrderItem>(new Action<tblOrderItem>(this.attach_tblOrderItems), new Action<tblOrderItem>(this.detach_tblOrderItems));
			this._tblCategory = default(EntityRef<tblCategory>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					if (this._tblCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductImg", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProductImg
		{
			get
			{
				return this._ProductImg;
			}
			set
			{
				if ((this._ProductImg != value))
				{
					this.OnProductImgChanging(value);
					this.SendPropertyChanging();
					this._ProductImg = value;
					this.SendPropertyChanged("ProductImg");
					this.OnProductImgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(6,2) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblItem_tblOrderItem", Storage="_tblOrderItems", ThisKey="ItemID", OtherKey="ItemID")]
		public EntitySet<tblOrderItem> tblOrderItems
		{
			get
			{
				return this._tblOrderItems;
			}
			set
			{
				this._tblOrderItems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCategory_tblItem", Storage="_tblCategory", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
		public tblCategory tblCategory
		{
			get
			{
				return this._tblCategory.Entity;
			}
			set
			{
				tblCategory previousValue = this._tblCategory.Entity;
				if (((previousValue != value) 
							|| (this._tblCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblCategory.Entity = null;
						previousValue.tblItems.Remove(this);
					}
					this._tblCategory.Entity = value;
					if ((value != null))
					{
						value.tblItems.Add(this);
						this._CategoryID = value.CategoryID;
					}
					else
					{
						this._CategoryID = default(string);
					}
					this.SendPropertyChanged("tblCategory");
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
		
		private void attach_tblOrderItems(tblOrderItem entity)
		{
			this.SendPropertyChanging();
			entity.tblItem = this;
		}
		
		private void detach_tblOrderItems(tblOrderItem entity)
		{
			this.SendPropertyChanging();
			entity.tblItem = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCategories")]
	public partial class tblCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CategoryID;
		
		private string _CategoryDescription;
		
		private EntitySet<tblItem> _tblItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(string value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryDescriptionChanging(string value);
    partial void OnCategoryDescriptionChanged();
    #endregion
		
		public tblCategory()
		{
			this._tblItems = new EntitySet<tblItem>(new Action<tblItem>(this.attach_tblItems), new Action<tblItem>(this.detach_tblItems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryDescription", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CategoryDescription
		{
			get
			{
				return this._CategoryDescription;
			}
			set
			{
				if ((this._CategoryDescription != value))
				{
					this.OnCategoryDescriptionChanging(value);
					this.SendPropertyChanging();
					this._CategoryDescription = value;
					this.SendPropertyChanged("CategoryDescription");
					this.OnCategoryDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCategory_tblItem", Storage="_tblItems", ThisKey="CategoryID", OtherKey="CategoryID")]
		public EntitySet<tblItem> tblItems
		{
			get
			{
				return this._tblItems;
			}
			set
			{
				this._tblItems.Assign(value);
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
		
		private void attach_tblItems(tblItem entity)
		{
			this.SendPropertyChanging();
			entity.tblCategory = this;
		}
		
		private void detach_tblItems(tblItem entity)
		{
			this.SendPropertyChanging();
			entity.tblCategory = null;
		}
	}
}
#pragma warning restore 1591