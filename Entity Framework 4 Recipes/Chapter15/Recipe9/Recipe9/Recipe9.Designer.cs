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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "CustomerOrder", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe9.Customer), "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe9.Order), true)]
#endregion

namespace Recipe9
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
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;
    
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
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="fullName">Initial value of the FullName property.</param>
        public static Customer CreateCustomer(global::System.Int32 customerId, global::System.String firstName, global::System.String lastName, global::System.String fullName)
        {
            Customer customer = new Customer();
            customer.CustomerId = customerId;
            
            customer.FirstName = firstName;
            
            customer.LastName = lastName;
            
            customer.FullName = fullName;
            
            return customer;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                if (_CustomerId != value)
                {
                    OnCustomerIdChanging(value);
                    ReportPropertyChanging("CustomerId");
                    _CustomerId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerId");
                    OnCustomerIdChanged();
                }
            }
                
        }
        private global::System.Int32 _CustomerId;
        partial void OnCustomerIdChanging(global::System.Int32 value);
        partial void OnCustomerIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
                
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
                
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                OnFullNameChanging(value);
                ReportPropertyChanging("FullName");
                _FullName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FullName");
                OnFullNameChanged();
            }
                
        }
        private global::System.String _FullName;
        partial void OnFullNameChanging(global::System.String value);
        partial void OnFullNameChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> TotalOrders
        {
            get
            {
                return _TotalOrders;
            }
            set
            {
                OnTotalOrdersChanging(value);
                ReportPropertyChanging("TotalOrders");
                _TotalOrders = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalOrders");
                OnTotalOrdersChanged();
            }
                
        }
        private Nullable<global::System.Int32> _TotalOrders;
        partial void OnTotalOrdersChanging(Nullable<global::System.Int32> value);
        partial void OnTotalOrdersChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "CustomerOrder", "Order")] 
        public EntityCollection<Order> Orders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Order>("EFRecipesModel.CustomerOrder", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Order>("EFRecipesModel.CustomerOrder", "Order", value);
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
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        /// <param name="orderStatusTypeId">Initial value of the OrderStatusTypeId property.</param>
        /// <param name="shippingTypeId">Initial value of the ShippingTypeId property.</param>
        /// <param name="orderStatus">Initial value of the OrderStatus property.</param>
        /// <param name="shippingType">Initial value of the ShippingType property.</param>
        public static Order CreateOrder(global::System.Int32 orderId, global::System.DateTime orderDate, global::System.Int32 customerId, global::System.Int32 orderStatusTypeId, global::System.Int32 shippingTypeId, global::System.String orderStatus, global::System.String shippingType)
        {
            Order order = new Order();
            order.OrderId = orderId;
            
            order.OrderDate = orderDate;
            
            order.CustomerId = customerId;
            
            order.OrderStatusTypeId = orderStatusTypeId;
            
            order.ShippingTypeId = shippingTypeId;
            
            order.OrderStatus = orderStatus;
            
            order.ShippingType = shippingType;
            
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
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                OnCustomerIdChanging(value);
                ReportPropertyChanging("CustomerId");
                _CustomerId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CustomerId");
                OnCustomerIdChanged();
            }
                
        }
        private global::System.Int32 _CustomerId;
        partial void OnCustomerIdChanging(global::System.Int32 value);
        partial void OnCustomerIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderStatusTypeId
        {
            get
            {
                return _OrderStatusTypeId;
            }
            set
            {
                OnOrderStatusTypeIdChanging(value);
                ReportPropertyChanging("OrderStatusTypeId");
                _OrderStatusTypeId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderStatusTypeId");
                OnOrderStatusTypeIdChanged();
            }
                
        }
        private global::System.Int32 _OrderStatusTypeId;
        partial void OnOrderStatusTypeIdChanging(global::System.Int32 value);
        partial void OnOrderStatusTypeIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ShippingTypeId
        {
            get
            {
                return _ShippingTypeId;
            }
            set
            {
                OnShippingTypeIdChanging(value);
                ReportPropertyChanging("ShippingTypeId");
                _ShippingTypeId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShippingTypeId");
                OnShippingTypeIdChanged();
            }
                
        }
        private global::System.Int32 _ShippingTypeId;
        partial void OnShippingTypeIdChanging(global::System.Int32 value);
        partial void OnShippingTypeIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OrderStatus
        {
            get
            {
                return _OrderStatus;
            }
            set
            {
                OnOrderStatusChanging(value);
                ReportPropertyChanging("OrderStatus");
                _OrderStatus = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("OrderStatus");
                OnOrderStatusChanged();
            }
                
        }
        private global::System.String _OrderStatus;
        partial void OnOrderStatusChanging(global::System.String value);
        partial void OnOrderStatusChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ShippingType
        {
            get
            {
                return _ShippingType;
            }
            set
            {
                OnShippingTypeChanging(value);
                ReportPropertyChanging("ShippingType");
                _ShippingType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ShippingType");
                OnShippingTypeChanged();
            }
                
        }
        private global::System.String _ShippingType;
        partial void OnShippingTypeChanging(global::System.String value);
        partial void OnShippingTypeChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "CustomerOrder", "Customer")] 
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerOrder", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerOrder", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerOrder", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("EFRecipesModel.CustomerOrder", "Customer", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}