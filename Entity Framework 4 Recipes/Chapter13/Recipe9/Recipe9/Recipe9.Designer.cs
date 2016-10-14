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

[assembly: EdmRelationshipAttribute("EFRecipesModel", "ResumeResumeDetail", "Resume", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe9.Resume), "ResumeDetail", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe9.ResumeDetail), true)]

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
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(string connectionString) : base(connectionString, "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(EntityConnection connection) : base(connection, "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
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
        public ObjectSet<Resume> Resumes
        {
            get
            {
                if ((_Resumes == null))
                {
                    _Resumes = base.CreateObjectSet<Resume>("Resumes");
                }
                return _Resumes;
            }
        }
        private ObjectSet<Resume> _Resumes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ResumeDetail> ResumeDetails
        {
            get
            {
                if ((_ResumeDetails == null))
                {
                    _ResumeDetails = base.CreateObjectSet<ResumeDetail>("ResumeDetails");
                }
                return _ResumeDetails;
            }
        }
        private ObjectSet<ResumeDetail> _ResumeDetails;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Resumes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToResumes(Resume resume)
        {
            base.AddObject("Resumes", resume);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ResumeDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToResumeDetails(ResumeDetail resumeDetail)
        {
            base.AddObject("ResumeDetails", resumeDetail);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Resume")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Resume : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Resume object.
        /// </summary>
        /// <param name="resumeId">Initial value of the ResumeId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Resume CreateResume(global::System.Int32 resumeId, global::System.String title, global::System.String name)
        {
            Resume resume = new Resume();
            resume.ResumeId = resumeId;
            resume.Title = title;
            resume.Name = name;
            return resume;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ResumeId
        {
            get
            {
                return _ResumeId;
            }
            set
            {
                if (_ResumeId != value)
                {
                    OnResumeIdChanging(value);
                    ReportPropertyChanging("ResumeId");
                    _ResumeId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ResumeId");
                    OnResumeIdChanged();
                }
            }
        }
        private global::System.Int32 _ResumeId;
        partial void OnResumeIdChanging(global::System.Int32 value);
        partial void OnResumeIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
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
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "ResumeResumeDetail", "ResumeDetail")]
        public ResumeDetail ResumeDetail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ResumeDetail>("EFRecipesModel.ResumeResumeDetail", "ResumeDetail").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ResumeDetail>("EFRecipesModel.ResumeResumeDetail", "ResumeDetail").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ResumeDetail> ResumeDetailReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ResumeDetail>("EFRecipesModel.ResumeResumeDetail", "ResumeDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ResumeDetail>("EFRecipesModel.ResumeResumeDetail", "ResumeDetail", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="ResumeDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ResumeDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ResumeDetail object.
        /// </summary>
        /// <param name="body">Initial value of the Body property.</param>
        /// <param name="resumeId">Initial value of the ResumeId property.</param>
        public static ResumeDetail CreateResumeDetail(global::System.String body, global::System.Int32 resumeId)
        {
            ResumeDetail resumeDetail = new ResumeDetail();
            resumeDetail.Body = body;
            resumeDetail.ResumeId = resumeId;
            return resumeDetail;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Body
        {
            get
            {
                return _Body;
            }
            set
            {
                OnBodyChanging(value);
                ReportPropertyChanging("Body");
                _Body = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Body");
                OnBodyChanged();
            }
        }
        private global::System.String _Body;
        partial void OnBodyChanging(global::System.String value);
        partial void OnBodyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ResumeId
        {
            get
            {
                return _ResumeId;
            }
            set
            {
                if (_ResumeId != value)
                {
                    OnResumeIdChanging(value);
                    ReportPropertyChanging("ResumeId");
                    _ResumeId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ResumeId");
                    OnResumeIdChanged();
                }
            }
        }
        private global::System.Int32 _ResumeId;
        partial void OnResumeIdChanging(global::System.Int32 value);
        partial void OnResumeIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "ResumeResumeDetail", "Resume")]
        public Resume Resume
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Resume>("EFRecipesModel.ResumeResumeDetail", "Resume").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Resume>("EFRecipesModel.ResumeResumeDetail", "Resume").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Resume> ResumeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Resume>("EFRecipesModel.ResumeResumeDetail", "Resume");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Resume>("EFRecipesModel.ResumeResumeDetail", "Resume", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}