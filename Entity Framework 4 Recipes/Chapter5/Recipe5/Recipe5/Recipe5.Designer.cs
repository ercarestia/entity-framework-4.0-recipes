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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Department_Company", "Company", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe5.Company), "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe5.Department), true)]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Employee_Department", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe5.Department), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe5.Employee), true)]
#endregion

namespace Recipe5
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
        public ObjectSet<Company> Companies
        {
            get
            {
                if ((_Companies == null))
                {
                    _Companies = base.CreateObjectSet<Company>("Companies");
                }
                return _Companies;
            }
        }
        private ObjectSet<Company> _Companies;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Department> Departments
        {
            get
            {
                if ((_Departments == null))
                {
                    _Departments = base.CreateObjectSet<Department>("Departments");
                }
                return _Departments;
            }
        }
        private ObjectSet<Department> _Departments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Companies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCompanies(Company company)
        {
            base.AddObject("Companies", company);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartments(Department department)
        {
            base.AddObject("Departments", department);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Company")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Company : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Company object.
        /// </summary>
        /// <param name="companyId">Initial value of the CompanyId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Company CreateCompany(global::System.Int32 companyId, global::System.String name)
        {
            Company company = new Company();
            company.CompanyId = companyId;
            
            company.Name = name;
            
            return company;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CompanyId
        {
            get
            {
                return _CompanyId;
            }
            set
            {
                if (_CompanyId != value)
                {
                    OnCompanyIdChanging(value);
                    ReportPropertyChanging("CompanyId");
                    _CompanyId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CompanyId");
                    OnCompanyIdChanged();
                }
            }
                
        }
        private global::System.Int32 _CompanyId;
        partial void OnCompanyIdChanging(global::System.Int32 value);
        partial void OnCompanyIdChanged();
        
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
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Department_Company", "Department")] 
        public EntityCollection<Department> Departments
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Department>("EFRecipesModel.FK_Department_Company", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Department>("EFRecipesModel.FK_Department_Company", "Department", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="departmentId">Initial value of the DepartmentId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="companyId">Initial value of the CompanyId property.</param>
        public static Department CreateDepartment(global::System.Int32 departmentId, global::System.String name, global::System.Int32 companyId)
        {
            Department department = new Department();
            department.DepartmentId = departmentId;
            
            department.Name = name;
            
            department.CompanyId = companyId;
            
            return department;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DepartmentId
        {
            get
            {
                return _DepartmentId;
            }
            set
            {
                if (_DepartmentId != value)
                {
                    OnDepartmentIdChanging(value);
                    ReportPropertyChanging("DepartmentId");
                    _DepartmentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DepartmentId");
                    OnDepartmentIdChanged();
                }
            }
                
        }
        private global::System.Int32 _DepartmentId;
        partial void OnDepartmentIdChanging(global::System.Int32 value);
        partial void OnDepartmentIdChanged();
        
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
        public global::System.Int32 CompanyId
        {
            get
            {
                return _CompanyId;
            }
            set
            {
                OnCompanyIdChanging(value);
                ReportPropertyChanging("CompanyId");
                _CompanyId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CompanyId");
                OnCompanyIdChanged();
            }
                
        }
        private global::System.Int32 _CompanyId;
        partial void OnCompanyIdChanging(global::System.Int32 value);
        partial void OnCompanyIdChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Department_Company", "Company")] 
        public Company Company
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("EFRecipesModel.FK_Department_Company", "Company").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("EFRecipesModel.FK_Department_Company", "Company").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Company> CompanyReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("EFRecipesModel.FK_Department_Company", "Company");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Company>("EFRecipesModel.FK_Department_Company", "Company", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Employee_Department", "Employee")] 
        public EntityCollection<Employee> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("EFRecipesModel.FK_Employee_Department", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("EFRecipesModel.FK_Employee_Department", "Employee", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employeeId">Initial value of the EmployeeId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="departmentId">Initial value of the DepartmentId property.</param>
        public static Employee CreateEmployee(global::System.Int32 employeeId, global::System.String name, global::System.Int32 departmentId)
        {
            Employee employee = new Employee();
            employee.EmployeeId = employeeId;
            
            employee.Name = name;
            
            employee.DepartmentId = departmentId;
            
            return employee;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeId
        {
            get
            {
                return _EmployeeId;
            }
            set
            {
                if (_EmployeeId != value)
                {
                    OnEmployeeIdChanging(value);
                    ReportPropertyChanging("EmployeeId");
                    _EmployeeId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeId");
                    OnEmployeeIdChanged();
                }
            }
                
        }
        private global::System.Int32 _EmployeeId;
        partial void OnEmployeeIdChanging(global::System.Int32 value);
        partial void OnEmployeeIdChanged();
        
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
        public global::System.Int32 DepartmentId
        {
            get
            {
                return _DepartmentId;
            }
            set
            {
                OnDepartmentIdChanging(value);
                ReportPropertyChanging("DepartmentId");
                _DepartmentId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DepartmentId");
                OnDepartmentIdChanged();
            }
                
        }
        private global::System.Int32 _DepartmentId;
        partial void OnDepartmentIdChanging(global::System.Int32 value);
        partial void OnDepartmentIdChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Employee_Department", "Department")] 
        public Department Department
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("EFRecipesModel.FK_Employee_Department", "Department").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("EFRecipesModel.FK_Employee_Department", "Department").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("EFRecipesModel.FK_Employee_Department", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("EFRecipesModel.FK_Employee_Department", "Department", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}
