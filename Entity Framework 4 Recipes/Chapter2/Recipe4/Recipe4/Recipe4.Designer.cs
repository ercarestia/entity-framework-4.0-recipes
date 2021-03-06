﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

#region EDM Relationship Metadata
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_OrderItem_Item", "Item", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe4.Item), "OrderItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe4.OrderItem), true)]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_OrderItem_Order", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe4.Order), "OrderItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe4.OrderItem), true)]
#endregion

namespace Recipe4
{
    #region Contexts
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EFRecipesEntities : ObjectContext
    {
        #region Constructors
        /// <summary>
        /// Initializes a new EFRecipesEntities object using the connection string found in the 'EFRecipesEntities' section of the application configuration file.
        /// </summary>
        public EFRecipesEntities() : base("name=EFRecipesEntities", "EFRecipesEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(string connectionString) : base(connectionString, "EFRecipesEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(EntityConnection connection) : base(connection, "EFRecipesEntities")
        {
            OnContextCreated();
        }
        #endregion
        
        #region Partial Methods
        partial void OnContextCreated();
        #endregion
        
        #region ObjectSet Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Item> Items
        {
            get
            {
                if ((_Items == null))
                {
                    _Items = base.CreateObjectSet<Item>("Items");
                }
                return _Items;
            }
        }
        private ObjectSet<Item> _Items;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderItem> OrderItems
        {
            get
            {
                if ((_OrderItems == null))
                {
                    _OrderItems = base.CreateObjectSet<OrderItem>("OrderItems");
                }
                return _OrderItems;
            }
        }
        private ObjectSet<OrderItem> _OrderItems;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Items EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToItems(Item item)
        {
            base.AddObject("Items", item);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderItems(OrderItem orderItem)
        {
            base.AddObject("OrderItems", orderItem);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Item")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Item : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Item object.
        /// </summary>
        /// <param name="sKU">Initial value of the SKU property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        public static Item CreateItem(global::System.Int32 sKU, global::System.String description, global::System.Decimal price)
        {
            Item item = new Item();
            item.SKU = sKU;
            
            item.Description = description;
            
            item.Price = price;
            
            return item;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SKU
        {
            get
            {
                return _SKU;
            }
            set
            {
                if (_SKU != value)
                {
                    OnSKUChanging(value);
                    ReportPropertyChanging("SKU");
                    _SKU = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SKU");
                    OnSKUChanged();
                }
            }
                
        }
        private global::System.Int32 _SKU;
        partial void OnSKUChanging(global::System.Int32 value);
        partial void OnSKUChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
                
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
                
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_OrderItem_Item", "OrderItem")] 
        public EntityCollection<OrderItem> OrderItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderItem>("EFRecipesModel.FK_OrderItem_Item", "OrderItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderItem>("EFRecipesModel.FK_OrderItem_Item", "OrderItem", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderId">Initial value of the OrderId property.</param>
        /// <param name="orderDate">Initial value of the OrderDate property.</param>
        public static Order CreateOrder(global::System.Int32 orderId, global::System.DateTime orderDate)
        {
            Order order = new Order();
            order.OrderId = orderId;
            
            order.OrderDate = orderDate;
            
            return order;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if (_OrderId != value)
                {
                    OnOrderIdChanging(value);
                    ReportPropertyChanging("OrderId");
                    _OrderId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderId");
                    OnOrderIdChanged();
                }
            }
                
        }
        private global::System.Int32 _OrderId;
        partial void OnOrderIdChanging(global::System.Int32 value);
        partial void OnOrderIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                OnOrderDateChanging(value);
                ReportPropertyChanging("OrderDate");
                _OrderDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderDate");
                OnOrderDateChanged();
            }
                
        }
        private global::System.DateTime _OrderDate;
        partial void OnOrderDateChanging(global::System.DateTime value);
        partial void OnOrderDateChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_OrderItem_Order", "OrderItem")] 
        public EntityCollection<OrderItem> OrderItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderItem>("EFRecipesModel.FK_OrderItem_Order", "OrderItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderItem>("EFRecipesModel.FK_OrderItem_Order", "OrderItem", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="OrderItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderItem : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new OrderItem object.
        /// </summary>
        /// <param name="orderId">Initial value of the OrderId property.</param>
        /// <param name="sKU">Initial value of the SKU property.</param>
        /// <param name="count">Initial value of the Count property.</param>
        public static OrderItem CreateOrderItem(global::System.Int32 orderId, global::System.Int32 sKU, global::System.Int32 count)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderId = orderId;
            
            orderItem.SKU = sKU;
            
            orderItem.Count = count;
            
            return orderItem;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if (_OrderId != value)
                {
                    OnOrderIdChanging(value);
                    ReportPropertyChanging("OrderId");
                    _OrderId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderId");
                    OnOrderIdChanged();
                }
            }
                
        }
        private global::System.Int32 _OrderId;
        partial void OnOrderIdChanging(global::System.Int32 value);
        partial void OnOrderIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SKU
        {
            get
            {
                return _SKU;
            }
            set
            {
                if (_SKU != value)
                {
                    OnSKUChanging(value);
                    ReportPropertyChanging("SKU");
                    _SKU = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SKU");
                    OnSKUChanged();
                }
            }
                
        }
        private global::System.Int32 _SKU;
        partial void OnSKUChanging(global::System.Int32 value);
        partial void OnSKUChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Count
        {
            get
            {
                return _Count;
            }
            set
            {
                OnCountChanging(value);
                ReportPropertyChanging("Count");
                _Count = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Count");
                OnCountChanged();
            }
                
        }
        private global::System.Int32 _Count;
        partial void OnCountChanging(global::System.Int32 value);
        partial void OnCountChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_OrderItem_Item", "Item")] 
        public Item Item
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("EFRecipesModel.FK_OrderItem_Item", "Item").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("EFRecipesModel.FK_OrderItem_Item", "Item").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Item> ItemReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("EFRecipesModel.FK_OrderItem_Item", "Item");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Item>("EFRecipesModel.FK_OrderItem_Item", "Item", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_OrderItem_Order", "Order")] 
        public Order Order
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Order> OrderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}
