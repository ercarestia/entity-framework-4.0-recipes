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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Invoice_Customer", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe2.Customer), "Invoice", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe2.Invoice), true)]
#endregion

namespace Recipe2
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
        public ObjectSet<Invoice> Invoices
        {
            get
            {
                if ((_Invoices == null))
                {
                    _Invoices = base.CreateObjectSet<Invoice>("Invoices");
                }
                return _Invoices;
            }
        }
        private ObjectSet<Invoice> _Invoices;
    
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
        /// Deprecated Method for adding a new object to the Invoices EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToInvoices(Invoice invoice)
        {
            base.AddObject("Invoices", invoice);
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
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="city">Initial value of the City property.</param>
        public static Customer CreateCustomer(global::System.Int32 customerId, global::System.String name, global::System.String city)
        {
            Customer customer = new Customer();
            customer.CustomerId = customerId;
            
            customer.Name = name;
            
            customer.City = city;
            
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
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
                
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
                
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Invoice_Customer", "Invoice")] 
        public EntityCollection<Invoice> Invoices
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Invoice>("EFRecipesModel.FK_Invoice_Customer", "Invoice");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Invoice>("EFRecipesModel.FK_Invoice_Customer", "Invoice", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Invoice")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Invoice : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Invoice object.
        /// </summary>
        /// <param name="invoiceId">Initial value of the InvoiceId property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        public static Invoice CreateInvoice(global::System.Int32 invoiceId, global::System.Decimal amount, global::System.String description, global::System.DateTime date, global::System.Int32 customerId)
        {
            Invoice invoice = new Invoice();
            invoice.InvoiceId = invoiceId;
            
            invoice.Amount = amount;
            
            invoice.Description = description;
            
            invoice.Date = date;
            
            invoice.CustomerId = customerId;
            
            return invoice;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 InvoiceId
        {
            get
            {
                return _InvoiceId;
            }
            set
            {
                if (_InvoiceId != value)
                {
                    OnInvoiceIdChanging(value);
                    ReportPropertyChanging("InvoiceId");
                    _InvoiceId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("InvoiceId");
                    OnInvoiceIdChanged();
                }
            }
                
        }
        private global::System.Int32 _InvoiceId;
        partial void OnInvoiceIdChanging(global::System.Int32 value);
        partial void OnInvoiceIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                OnAmountChanging(value);
                ReportPropertyChanging("Amount");
                _Amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Amount");
                OnAmountChanged();
            }
                
        }
        private global::System.Decimal _Amount;
        partial void OnAmountChanging(global::System.Decimal value);
        partial void OnAmountChanged();
        
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
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
                
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
        
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
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Invoice_Customer", "Customer")] 
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.FK_Invoice_Customer", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.FK_Invoice_Customer", "Customer").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.FK_Invoice_Customer", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("EFRecipesModel.FK_Invoice_Customer", "Customer", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}
