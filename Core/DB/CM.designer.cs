﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.DB
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="smruser")]
	public partial class CMDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public CMDataContext() : 
				base(global::Core.Properties.Settings.Default.smruserConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Pages")]
		public int sp_Pages([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iud, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PageID", DbType="Int")] ref System.Nullable<int> pageID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ParentID", DbType="Int")] System.Nullable<int> parentID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TitleEN", DbType="NVarChar(200)")] string titleEN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TitleKA", DbType="NVarChar(200)")] string titleKA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TitleRU", DbType="NVarChar(200)")] string titleRU, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionEN", DbType="NVarChar(MAX)")] string descriptionEN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionKA", DbType="NVarChar(MAX)")] string descriptionKA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionRU", DbType="NVarChar(200)")] string descriptionRU, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TemplateID", DbType="Int")] System.Nullable<int> templateID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="URL", DbType="NVarChar(250)")] string uRL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Note", DbType="NVarChar(500)")] string note, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GalleryID", DbType="Int")] System.Nullable<int> galleryID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisible", DbType="Bit")] System.Nullable<bool> isVisible)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iud, pageID, parentID, titleEN, titleKA, titleRU, descriptionEN, descriptionKA, descriptionRU, templateID, uRL, note, galleryID, isVisible);
			pageID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_News")]
		public int sp_News(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iud, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NewsID", DbType="Int")] ref System.Nullable<int> newsID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NewsDate", DbType="DateTime")] System.Nullable<System.DateTime> newsDate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TitleEN", DbType="NVarChar(MAX)")] string titleEN, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TitleKA", DbType="NVarChar(MAX)")] string titleKA, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TitleRU", DbType="NVarChar(MAX)")] string titleRU, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionEN", DbType="NVarChar(MAX)")] string descriptionEN, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionKA", DbType="NVarChar(MAX)")] string descriptionKA, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionRU", DbType="NVarChar(MAX)")] string descriptionRU, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullTextEN", DbType="NVarChar(MAX)")] string fullTextEN, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullTextKA", DbType="NVarChar(MAX)")] string fullTextKA, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullTextRU", DbType="NVarChar(MAX)")] string fullTextRU, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CategoryID", DbType="Int")] System.Nullable<int> categoryID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SortVal", DbType="Int")] System.Nullable<int> sortVal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisible", DbType="Bit")] System.Nullable<bool> isVisible, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisibleSliderEN", DbType="Bit")] System.Nullable<bool> isVisibleSliderEN, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisibleSliderKA", DbType="Bit")] System.Nullable<bool> isVisibleSliderKA, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisibleSliderRU", DbType="Bit")] System.Nullable<bool> isVisibleSliderRU, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="VideoURL", DbType="NVarChar(300)")] string videoURL, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="GalleryID", DbType="Int")] System.Nullable<int> galleryID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iud, newsID, newsDate, titleEN, titleKA, titleRU, descriptionEN, descriptionKA, descriptionRU, fullTextEN, fullTextKA, fullTextRU, categoryID, sortVal, isVisible, isVisibleSliderEN, isVisibleSliderKA, isVisibleSliderRU, videoURL, galleryID);
			newsID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_Pages", IsComposable=true)]
		public IQueryable<fn_List_PagesResult> fn_List_Pages([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PageID", DbType="Int")] System.Nullable<int> pageID)
		{
			return this.CreateMethodCallQuery<fn_List_PagesResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pageID);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_News", IsComposable=true)]
		public IQueryable<fn_List_NewsResult> fn_List_News([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NewsID", DbType="Int")] System.Nullable<int> newsID)
		{
			return this.CreateMethodCallQuery<fn_List_NewsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), newsID);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_NewsForSlider", IsComposable=true)]
		public IQueryable<fn_List_NewsForSliderResult> fn_List_NewsForSlider([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisibleSlider", DbType="NVarChar(10)")] string isVisibleSlider)
		{
			return this.CreateMethodCallQuery<fn_List_NewsForSliderResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), isVisibleSlider);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_NewsByDate", IsComposable=true)]
		public IQueryable<fn_List_NewsByDateResult> fn_List_NewsByDate([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FromDate", DbType="Date")] System.Nullable<System.DateTime> fromDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ToDate", DbType="Date")] System.Nullable<System.DateTime> toDate)
		{
			return this.CreateMethodCallQuery<fn_List_NewsByDateResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fromDate, toDate);
		}
	}
	
	public partial class fn_List_PagesResult
	{
		
		private int _PageID;
		
		private System.Nullable<int> _ParentID;
		
		private string _TitleEN;
		
		private string _TitleKA;
		
		private string _TitleRU;
		
		private string _DescriptionEN;
		
		private string _DescriptionKA;
		
		private string _DescriptionRU;
		
		private System.Nullable<int> _TemplateID;
		
		private string _URL;
		
		private string _Note;
		
		private System.Nullable<int> _GalleryID;
		
		private bool _IsVisible;
		
		private string _FileUrl;
		
		public fn_List_PagesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageID", DbType="Int NOT NULL")]
		public int PageID
		{
			get
			{
				return this._PageID;
			}
			set
			{
				if ((this._PageID != value))
				{
					this._PageID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentID", DbType="Int")]
		public System.Nullable<int> ParentID
		{
			get
			{
				return this._ParentID;
			}
			set
			{
				if ((this._ParentID != value))
				{
					this._ParentID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleEN", DbType="NVarChar(200)")]
		public string TitleEN
		{
			get
			{
				return this._TitleEN;
			}
			set
			{
				if ((this._TitleEN != value))
				{
					this._TitleEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleKA", DbType="NVarChar(200)")]
		public string TitleKA
		{
			get
			{
				return this._TitleKA;
			}
			set
			{
				if ((this._TitleKA != value))
				{
					this._TitleKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleRU", DbType="NVarChar(200)")]
		public string TitleRU
		{
			get
			{
				return this._TitleRU;
			}
			set
			{
				if ((this._TitleRU != value))
				{
					this._TitleRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionEN", DbType="NVarChar(MAX)")]
		public string DescriptionEN
		{
			get
			{
				return this._DescriptionEN;
			}
			set
			{
				if ((this._DescriptionEN != value))
				{
					this._DescriptionEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionKA", DbType="NVarChar(MAX)")]
		public string DescriptionKA
		{
			get
			{
				return this._DescriptionKA;
			}
			set
			{
				if ((this._DescriptionKA != value))
				{
					this._DescriptionKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionRU", DbType="NVarChar(MAX)")]
		public string DescriptionRU
		{
			get
			{
				return this._DescriptionRU;
			}
			set
			{
				if ((this._DescriptionRU != value))
				{
					this._DescriptionRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TemplateID", DbType="Int")]
		public System.Nullable<int> TemplateID
		{
			get
			{
				return this._TemplateID;
			}
			set
			{
				if ((this._TemplateID != value))
				{
					this._TemplateID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(250)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this._URL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="NVarChar(500)")]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this._Note = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GalleryID", DbType="Int")]
		public System.Nullable<int> GalleryID
		{
			get
			{
				return this._GalleryID;
			}
			set
			{
				if ((this._GalleryID != value))
				{
					this._GalleryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisible", DbType="Bit NOT NULL")]
		public bool IsVisible
		{
			get
			{
				return this._IsVisible;
			}
			set
			{
				if ((this._IsVisible != value))
				{
					this._IsVisible = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileUrl", DbType="NVarChar(250)")]
		public string FileUrl
		{
			get
			{
				return this._FileUrl;
			}
			set
			{
				if ((this._FileUrl != value))
				{
					this._FileUrl = value;
				}
			}
		}
	}
	
	public partial class fn_List_NewsResult
	{
		
		private int _NewsID;
		
		private System.Nullable<System.DateTime> _NewsDate;
		
		private string _TitleEN;
		
		private string _TitleKA;
		
		private string _TitleRU;
		
		private string _DescriptionEN;
		
		private string _DescriptionKA;
		
		private string _DescriptionRU;
		
		private string _FullTextEN;
		
		private string _FullTextKA;
		
		private string _FullTextRU;
		
		private System.Nullable<int> _CategoryID;
		
		private System.Nullable<int> _SortVal;
		
		private bool _IsVisible;
		
		private bool _IsVisibleSliderEN;
		
		private bool _IsVisibleSliderKA;
		
		private bool _IsVisibleSliderRU;
		
		private string _VideoURL;
		
		private System.Nullable<int> _GalleryID;
		
		private string _URL;
		
		private string _URLKa;
		
		private string _URLRu;
		
		public fn_List_NewsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsID", DbType="Int NOT NULL")]
		public int NewsID
		{
			get
			{
				return this._NewsID;
			}
			set
			{
				if ((this._NewsID != value))
				{
					this._NewsID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsDate", DbType="Date")]
		public System.Nullable<System.DateTime> NewsDate
		{
			get
			{
				return this._NewsDate;
			}
			set
			{
				if ((this._NewsDate != value))
				{
					this._NewsDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleEN", DbType="NVarChar(MAX)")]
		public string TitleEN
		{
			get
			{
				return this._TitleEN;
			}
			set
			{
				if ((this._TitleEN != value))
				{
					this._TitleEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleKA", DbType="NVarChar(MAX)")]
		public string TitleKA
		{
			get
			{
				return this._TitleKA;
			}
			set
			{
				if ((this._TitleKA != value))
				{
					this._TitleKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleRU", DbType="NVarChar(MAX)")]
		public string TitleRU
		{
			get
			{
				return this._TitleRU;
			}
			set
			{
				if ((this._TitleRU != value))
				{
					this._TitleRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionEN", DbType="NVarChar(MAX)")]
		public string DescriptionEN
		{
			get
			{
				return this._DescriptionEN;
			}
			set
			{
				if ((this._DescriptionEN != value))
				{
					this._DescriptionEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionKA", DbType="NVarChar(MAX)")]
		public string DescriptionKA
		{
			get
			{
				return this._DescriptionKA;
			}
			set
			{
				if ((this._DescriptionKA != value))
				{
					this._DescriptionKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionRU", DbType="NVarChar(MAX)")]
		public string DescriptionRU
		{
			get
			{
				return this._DescriptionRU;
			}
			set
			{
				if ((this._DescriptionRU != value))
				{
					this._DescriptionRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextEN", DbType="NVarChar(MAX)")]
		public string FullTextEN
		{
			get
			{
				return this._FullTextEN;
			}
			set
			{
				if ((this._FullTextEN != value))
				{
					this._FullTextEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextKA", DbType="NVarChar(MAX)")]
		public string FullTextKA
		{
			get
			{
				return this._FullTextKA;
			}
			set
			{
				if ((this._FullTextKA != value))
				{
					this._FullTextKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextRU", DbType="NVarChar(MAX)")]
		public string FullTextRU
		{
			get
			{
				return this._FullTextRU;
			}
			set
			{
				if ((this._FullTextRU != value))
				{
					this._FullTextRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this._CategoryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SortVal", DbType="Int")]
		public System.Nullable<int> SortVal
		{
			get
			{
				return this._SortVal;
			}
			set
			{
				if ((this._SortVal != value))
				{
					this._SortVal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisible", DbType="Bit NOT NULL")]
		public bool IsVisible
		{
			get
			{
				return this._IsVisible;
			}
			set
			{
				if ((this._IsVisible != value))
				{
					this._IsVisible = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderEN", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderEN
		{
			get
			{
				return this._IsVisibleSliderEN;
			}
			set
			{
				if ((this._IsVisibleSliderEN != value))
				{
					this._IsVisibleSliderEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderKA", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderKA
		{
			get
			{
				return this._IsVisibleSliderKA;
			}
			set
			{
				if ((this._IsVisibleSliderKA != value))
				{
					this._IsVisibleSliderKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderRU", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderRU
		{
			get
			{
				return this._IsVisibleSliderRU;
			}
			set
			{
				if ((this._IsVisibleSliderRU != value))
				{
					this._IsVisibleSliderRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VideoURL", DbType="NVarChar(300)")]
		public string VideoURL
		{
			get
			{
				return this._VideoURL;
			}
			set
			{
				if ((this._VideoURL != value))
				{
					this._VideoURL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GalleryID", DbType="Int")]
		public System.Nullable<int> GalleryID
		{
			get
			{
				return this._GalleryID;
			}
			set
			{
				if ((this._GalleryID != value))
				{
					this._GalleryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(250)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this._URL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URLKa", DbType="NVarChar(250)")]
		public string URLKa
		{
			get
			{
				return this._URLKa;
			}
			set
			{
				if ((this._URLKa != value))
				{
					this._URLKa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URLRu", DbType="NVarChar(250)")]
		public string URLRu
		{
			get
			{
				return this._URLRu;
			}
			set
			{
				if ((this._URLRu != value))
				{
					this._URLRu = value;
				}
			}
		}
	}
	
	public partial class fn_List_NewsForSliderResult
	{
		
		private int _NewsID;
		
		private System.Nullable<System.DateTime> _NewsDate;
		
		private string _TitleEN;
		
		private string _TitleKA;
		
		private string _TitleRU;
		
		private string _DescriptionEN;
		
		private string _DescriptionKA;
		
		private string _DescriptionRU;
		
		private string _FullTextEN;
		
		private string _FullTextKA;
		
		private string _FullTextRU;
		
		private System.Nullable<int> _CategoryID;
		
		private System.Nullable<int> _SortVal;
		
		private bool _IsVisible;
		
		private bool _IsVisibleSliderEN;
		
		private bool _IsVisibleSliderKA;
		
		private bool _IsVisibleSliderRU;
		
		private string _VideoURL;
		
		private System.Nullable<int> _GalleryID;
		
		private string _URL;
		
		private string _URLKa;
		
		private string _URLRu;
		
		public fn_List_NewsForSliderResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsID", DbType="Int NOT NULL")]
		public int NewsID
		{
			get
			{
				return this._NewsID;
			}
			set
			{
				if ((this._NewsID != value))
				{
					this._NewsID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsDate", DbType="Date")]
		public System.Nullable<System.DateTime> NewsDate
		{
			get
			{
				return this._NewsDate;
			}
			set
			{
				if ((this._NewsDate != value))
				{
					this._NewsDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleEN", DbType="NVarChar(MAX)")]
		public string TitleEN
		{
			get
			{
				return this._TitleEN;
			}
			set
			{
				if ((this._TitleEN != value))
				{
					this._TitleEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleKA", DbType="NVarChar(MAX)")]
		public string TitleKA
		{
			get
			{
				return this._TitleKA;
			}
			set
			{
				if ((this._TitleKA != value))
				{
					this._TitleKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleRU", DbType="NVarChar(MAX)")]
		public string TitleRU
		{
			get
			{
				return this._TitleRU;
			}
			set
			{
				if ((this._TitleRU != value))
				{
					this._TitleRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionEN", DbType="NVarChar(MAX)")]
		public string DescriptionEN
		{
			get
			{
				return this._DescriptionEN;
			}
			set
			{
				if ((this._DescriptionEN != value))
				{
					this._DescriptionEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionKA", DbType="NVarChar(MAX)")]
		public string DescriptionKA
		{
			get
			{
				return this._DescriptionKA;
			}
			set
			{
				if ((this._DescriptionKA != value))
				{
					this._DescriptionKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionRU", DbType="NVarChar(MAX)")]
		public string DescriptionRU
		{
			get
			{
				return this._DescriptionRU;
			}
			set
			{
				if ((this._DescriptionRU != value))
				{
					this._DescriptionRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextEN", DbType="NVarChar(MAX)")]
		public string FullTextEN
		{
			get
			{
				return this._FullTextEN;
			}
			set
			{
				if ((this._FullTextEN != value))
				{
					this._FullTextEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextKA", DbType="NVarChar(MAX)")]
		public string FullTextKA
		{
			get
			{
				return this._FullTextKA;
			}
			set
			{
				if ((this._FullTextKA != value))
				{
					this._FullTextKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextRU", DbType="NVarChar(MAX)")]
		public string FullTextRU
		{
			get
			{
				return this._FullTextRU;
			}
			set
			{
				if ((this._FullTextRU != value))
				{
					this._FullTextRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this._CategoryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SortVal", DbType="Int")]
		public System.Nullable<int> SortVal
		{
			get
			{
				return this._SortVal;
			}
			set
			{
				if ((this._SortVal != value))
				{
					this._SortVal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisible", DbType="Bit NOT NULL")]
		public bool IsVisible
		{
			get
			{
				return this._IsVisible;
			}
			set
			{
				if ((this._IsVisible != value))
				{
					this._IsVisible = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderEN", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderEN
		{
			get
			{
				return this._IsVisibleSliderEN;
			}
			set
			{
				if ((this._IsVisibleSliderEN != value))
				{
					this._IsVisibleSliderEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderKA", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderKA
		{
			get
			{
				return this._IsVisibleSliderKA;
			}
			set
			{
				if ((this._IsVisibleSliderKA != value))
				{
					this._IsVisibleSliderKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderRU", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderRU
		{
			get
			{
				return this._IsVisibleSliderRU;
			}
			set
			{
				if ((this._IsVisibleSliderRU != value))
				{
					this._IsVisibleSliderRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VideoURL", DbType="NVarChar(300)")]
		public string VideoURL
		{
			get
			{
				return this._VideoURL;
			}
			set
			{
				if ((this._VideoURL != value))
				{
					this._VideoURL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GalleryID", DbType="Int")]
		public System.Nullable<int> GalleryID
		{
			get
			{
				return this._GalleryID;
			}
			set
			{
				if ((this._GalleryID != value))
				{
					this._GalleryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(250)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this._URL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URLKa", DbType="NVarChar(250)")]
		public string URLKa
		{
			get
			{
				return this._URLKa;
			}
			set
			{
				if ((this._URLKa != value))
				{
					this._URLKa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URLRu", DbType="NVarChar(250)")]
		public string URLRu
		{
			get
			{
				return this._URLRu;
			}
			set
			{
				if ((this._URLRu != value))
				{
					this._URLRu = value;
				}
			}
		}
	}
	
	public partial class fn_List_NewsByDateResult
	{
		
		private int _NewsID;
		
		private System.Nullable<System.DateTime> _NewsDate;
		
		private string _TitleEN;
		
		private string _TitleKA;
		
		private string _TitleRU;
		
		private string _DescriptionEN;
		
		private string _DescriptionKA;
		
		private string _DescriptionRU;
		
		private string _FullTextEN;
		
		private string _FullTextKA;
		
		private string _FullTextRU;
		
		private System.Nullable<int> _CategoryID;
		
		private System.Nullable<int> _SortVal;
		
		private bool _IsVisible;
		
		private bool _IsVisibleSliderEN;
		
		private bool _IsVisibleSliderKA;
		
		private bool _IsVisibleSliderRU;
		
		private string _VideoURL;
		
		private System.Nullable<int> _GalleryID;
		
		private string _URL;
		
		public fn_List_NewsByDateResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsID", DbType="Int NOT NULL")]
		public int NewsID
		{
			get
			{
				return this._NewsID;
			}
			set
			{
				if ((this._NewsID != value))
				{
					this._NewsID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsDate", DbType="Date")]
		public System.Nullable<System.DateTime> NewsDate
		{
			get
			{
				return this._NewsDate;
			}
			set
			{
				if ((this._NewsDate != value))
				{
					this._NewsDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleEN", DbType="NVarChar(MAX)")]
		public string TitleEN
		{
			get
			{
				return this._TitleEN;
			}
			set
			{
				if ((this._TitleEN != value))
				{
					this._TitleEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleKA", DbType="NVarChar(MAX)")]
		public string TitleKA
		{
			get
			{
				return this._TitleKA;
			}
			set
			{
				if ((this._TitleKA != value))
				{
					this._TitleKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleRU", DbType="NVarChar(MAX)")]
		public string TitleRU
		{
			get
			{
				return this._TitleRU;
			}
			set
			{
				if ((this._TitleRU != value))
				{
					this._TitleRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionEN", DbType="NVarChar(MAX)")]
		public string DescriptionEN
		{
			get
			{
				return this._DescriptionEN;
			}
			set
			{
				if ((this._DescriptionEN != value))
				{
					this._DescriptionEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionKA", DbType="NVarChar(MAX)")]
		public string DescriptionKA
		{
			get
			{
				return this._DescriptionKA;
			}
			set
			{
				if ((this._DescriptionKA != value))
				{
					this._DescriptionKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionRU", DbType="NVarChar(MAX)")]
		public string DescriptionRU
		{
			get
			{
				return this._DescriptionRU;
			}
			set
			{
				if ((this._DescriptionRU != value))
				{
					this._DescriptionRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextEN", DbType="NVarChar(MAX)")]
		public string FullTextEN
		{
			get
			{
				return this._FullTextEN;
			}
			set
			{
				if ((this._FullTextEN != value))
				{
					this._FullTextEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextKA", DbType="NVarChar(MAX)")]
		public string FullTextKA
		{
			get
			{
				return this._FullTextKA;
			}
			set
			{
				if ((this._FullTextKA != value))
				{
					this._FullTextKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTextRU", DbType="NVarChar(MAX)")]
		public string FullTextRU
		{
			get
			{
				return this._FullTextRU;
			}
			set
			{
				if ((this._FullTextRU != value))
				{
					this._FullTextRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this._CategoryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SortVal", DbType="Int")]
		public System.Nullable<int> SortVal
		{
			get
			{
				return this._SortVal;
			}
			set
			{
				if ((this._SortVal != value))
				{
					this._SortVal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisible", DbType="Bit NOT NULL")]
		public bool IsVisible
		{
			get
			{
				return this._IsVisible;
			}
			set
			{
				if ((this._IsVisible != value))
				{
					this._IsVisible = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderEN", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderEN
		{
			get
			{
				return this._IsVisibleSliderEN;
			}
			set
			{
				if ((this._IsVisibleSliderEN != value))
				{
					this._IsVisibleSliderEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderKA", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderKA
		{
			get
			{
				return this._IsVisibleSliderKA;
			}
			set
			{
				if ((this._IsVisibleSliderKA != value))
				{
					this._IsVisibleSliderKA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsVisibleSliderRU", DbType="Bit NOT NULL")]
		public bool IsVisibleSliderRU
		{
			get
			{
				return this._IsVisibleSliderRU;
			}
			set
			{
				if ((this._IsVisibleSliderRU != value))
				{
					this._IsVisibleSliderRU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VideoURL", DbType="NVarChar(300)")]
		public string VideoURL
		{
			get
			{
				return this._VideoURL;
			}
			set
			{
				if ((this._VideoURL != value))
				{
					this._VideoURL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GalleryID", DbType="Int")]
		public System.Nullable<int> GalleryID
		{
			get
			{
				return this._GalleryID;
			}
			set
			{
				if ((this._GalleryID != value))
				{
					this._GalleryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(250)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this._URL = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
