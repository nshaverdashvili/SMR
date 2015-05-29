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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SMR")]
	public partial class GeneralDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public GeneralDataContext() : 
				base(global::Core.Properties.Settings.Default.SMRConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GeneralDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GeneralDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GeneralDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GeneralDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Dictionaries")]
		public int sp_Dictionaries([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iud, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DictionaryID", DbType="Int")] ref System.Nullable<int> dictionaryID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Caption", DbType="NVarChar(200)")] string caption, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Caption1", DbType="NVarChar(200)")] string caption1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CodeVal", DbType="Int")] System.Nullable<int> codeVal, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ParentID", DbType="Int")] System.Nullable<int> parentID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Level", DbType="SmallInt")] System.Nullable<short> level, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hierarchy", DbType="VarChar(200)")] string hierarchy, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StringCode", DbType="NVarChar(100)")] string stringCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DictionaryCode", DbType="Int")] System.Nullable<int> dictionaryCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DefVal", DbType="Bit")] System.Nullable<bool> defVal, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Visible", DbType="Bit")] System.Nullable<bool> visible, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SortVal", DbType="Int")] System.Nullable<int> sortVal)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iud, dictionaryID, caption, caption1, codeVal, parentID, level, hierarchy, stringCode, dictionaryCode, defVal, visible, sortVal);
			dictionaryID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Files")]
		public int sp_Files([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iud, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FileID", DbType="Int")] ref System.Nullable<int> fileID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FileName", DbType="NVarChar(300)")] string fileName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(300)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="URL", DbType="NVarChar(250)")] string uRL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TypeID", DbType="Int")] System.Nullable<int> typeID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iud, fileID, fileName, description, uRL, typeID);
			fileID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Gallery")]
		public int sp_Gallery([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iud, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RecordID", DbType="Int")] ref System.Nullable<int> recordID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="VarChar(200)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(MAX)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LangID", DbType="Int")] System.Nullable<int> langID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iud, recordID, title, description, langID);
			recordID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_News")]
		public int sp_News([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iud, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NewsID", DbType="Int")] ref System.Nullable<int> newsID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NewsDate", DbType="DateTime")] System.Nullable<System.DateTime> newsDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(200)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(MAX)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullText", DbType="NVarChar(MAX)")] string fullText, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LangID", DbType="Int")] System.Nullable<int> langID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CategoryID", DbType="Int")] System.Nullable<int> categoryID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SortVal", DbType="Int")] System.Nullable<int> sortVal, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisible", DbType="Bit")] System.Nullable<bool> isVisible, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VideoURL", DbType="NVarChar(300)")] string videoURL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GalleryID", DbType="Int")] System.Nullable<int> galleryID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iud, newsID, newsDate, title, description, fullText, langID, categoryID, sortVal, isVisible, videoURL, galleryID);
			newsID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Pages")]
		public int sp_Pages([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> iud, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PageID", DbType="Int")] ref System.Nullable<int> pageID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ParentID", DbType="Int")] System.Nullable<int> parentID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(250)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(MAX)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TemplateID", DbType="Int")] System.Nullable<int> templateID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="URL", DbType="NVarChar(250)")] string uRL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Note", DbType="NVarChar(500)")] string note, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GalleryID", DbType="Int")] System.Nullable<int> galleryID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LangID", DbType="Int")] System.Nullable<int> langID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVisible", DbType="Int")] System.Nullable<int> isVisible)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iud, pageID, parentID, title, description, templateID, uRL, note, galleryID, langID, isVisible);
			pageID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_Dictionaries", IsComposable=true)]
		public IQueryable<fn_List_DictionariesResult> fn_List_Dictionaries([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Level", DbType="Int")] System.Nullable<int> level, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DictionaryCode", DbType="Int")] System.Nullable<int> dictionaryCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ShowInvisibleItems", DbType="Bit")] System.Nullable<bool> showInvisibleItems)
		{
			return this.CreateMethodCallQuery<fn_List_DictionariesResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), level, dictionaryCode, showInvisibleItems);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_Files", IsComposable=true)]
		public IQueryable<fn_List_FilesResult> fn_List_Files([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FileID", DbType="Int")] System.Nullable<int> fileID)
		{
			return this.CreateMethodCallQuery<fn_List_FilesResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fileID);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_Gallery", IsComposable=true)]
		public IQueryable<fn_List_GalleryResult> fn_List_Gallery([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RecordID", DbType="Int")] System.Nullable<int> recordID)
		{
			return this.CreateMethodCallQuery<fn_List_GalleryResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), recordID);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_News", IsComposable=true)]
		public IQueryable<fn_List_NewsResult> fn_List_News([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NewsID", DbType="Int")] System.Nullable<int> newsID)
		{
			return this.CreateMethodCallQuery<fn_List_NewsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), newsID);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_List_Pages", IsComposable=true)]
		public IQueryable<fn_List_PagesResult> fn_List_Pages([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PageID", DbType="Int")] System.Nullable<int> pageID)
		{
			return this.CreateMethodCallQuery<fn_List_PagesResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pageID);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetDictionaryCaption", IsComposable=true)]
		public string GetDictionaryCaption([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DictionaryID", DbType="Int")] System.Nullable<int> dictionaryID)
		{
			return ((string)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dictionaryID).ReturnValue));
		}
	}
	
	public partial class fn_List_DictionariesResult
	{
		
		private System.Nullable<long> _RowNum;
		
		private int _DictionaryID;
		
		private string _Caption;
		
		private string _Caption1;
		
		private System.Nullable<int> _CodeVal;
		
		private System.Nullable<int> _ParentID;
		
		private string _StringCode;
		
		private short _DictionaryCode;
		
		private System.Nullable<bool> _DefVal;
		
		private bool _Visible;
		
		private System.Nullable<int> _SortVal;
		
		private System.DateTime _CRTime;
		
		public fn_List_DictionariesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RowNum", DbType="BigInt")]
		public System.Nullable<long> RowNum
		{
			get
			{
				return this._RowNum;
			}
			set
			{
				if ((this._RowNum != value))
				{
					this._RowNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictionaryID", DbType="Int NOT NULL")]
		public int DictionaryID
		{
			get
			{
				return this._DictionaryID;
			}
			set
			{
				if ((this._DictionaryID != value))
				{
					this._DictionaryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Caption", DbType="NVarChar(200)")]
		public string Caption
		{
			get
			{
				return this._Caption;
			}
			set
			{
				if ((this._Caption != value))
				{
					this._Caption = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Caption1", DbType="NVarChar(200)")]
		public string Caption1
		{
			get
			{
				return this._Caption1;
			}
			set
			{
				if ((this._Caption1 != value))
				{
					this._Caption1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeVal", DbType="Int")]
		public System.Nullable<int> CodeVal
		{
			get
			{
				return this._CodeVal;
			}
			set
			{
				if ((this._CodeVal != value))
				{
					this._CodeVal = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StringCode", DbType="NVarChar(100)")]
		public string StringCode
		{
			get
			{
				return this._StringCode;
			}
			set
			{
				if ((this._StringCode != value))
				{
					this._StringCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictionaryCode", DbType="SmallInt NOT NULL")]
		public short DictionaryCode
		{
			get
			{
				return this._DictionaryCode;
			}
			set
			{
				if ((this._DictionaryCode != value))
				{
					this._DictionaryCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DefVal", DbType="Bit")]
		public System.Nullable<bool> DefVal
		{
			get
			{
				return this._DefVal;
			}
			set
			{
				if ((this._DefVal != value))
				{
					this._DefVal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Visible", DbType="Bit NOT NULL")]
		public bool Visible
		{
			get
			{
				return this._Visible;
			}
			set
			{
				if ((this._Visible != value))
				{
					this._Visible = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRTime", DbType="DateTime NOT NULL")]
		public System.DateTime CRTime
		{
			get
			{
				return this._CRTime;
			}
			set
			{
				if ((this._CRTime != value))
				{
					this._CRTime = value;
				}
			}
		}
	}
	
	public partial class fn_List_FilesResult
	{
		
		private string _FileName;
		
		private string _Description;
		
		private string _URL;
		
		private int _TypeID;
		
		public fn_List_FilesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this._FileName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(300)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeID", DbType="Int NOT NULL")]
		public int TypeID
		{
			get
			{
				return this._TypeID;
			}
			set
			{
				if ((this._TypeID != value))
				{
					this._TypeID = value;
				}
			}
		}
	}
	
	public partial class fn_List_GalleryResult
	{
		
		private string _Title;
		
		private string _Description;
		
		private int _LangID;
		
		public fn_List_GalleryResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(200)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LangID", DbType="Int NOT NULL")]
		public int LangID
		{
			get
			{
				return this._LangID;
			}
			set
			{
				if ((this._LangID != value))
				{
					this._LangID = value;
				}
			}
		}
	}
	
	public partial class fn_List_NewsResult
	{
		
		private System.Nullable<System.DateTime> _NewsDate;
		
		private string _Title;
		
		private string _Description;
		
		private string _FullText;
		
		private System.Nullable<int> _LangID;
		
		private System.Nullable<int> _CategoryID;
		
		private System.Nullable<int> _SortVal;
		
		private bool _IsVisible;
		
		private string _VideoURL;
		
		private System.Nullable<int> _GalleryID;
		
		public fn_List_NewsResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullText", DbType="NVarChar(MAX)")]
		public string FullText
		{
			get
			{
				return this._FullText;
			}
			set
			{
				if ((this._FullText != value))
				{
					this._FullText = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LangID", DbType="Int")]
		public System.Nullable<int> LangID
		{
			get
			{
				return this._LangID;
			}
			set
			{
				if ((this._LangID != value))
				{
					this._LangID = value;
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
	}
	
	public partial class fn_List_PagesResult
	{
		
		private int _ParentID;
		
		private string _Title;
		
		private string _Description;
		
		private System.Nullable<int> _TemplateID;
		
		private string _URL;
		
		private string _Note;
		
		private System.Nullable<int> _GalleryID;
		
		private int _LangID;
		
		private bool _IsVisible;
		
		public fn_List_PagesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentID", DbType="Int NOT NULL")]
		public int ParentID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LangID", DbType="Int NOT NULL")]
		public int LangID
		{
			get
			{
				return this._LangID;
			}
			set
			{
				if ((this._LangID != value))
				{
					this._LangID = value;
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
	}
}
#pragma warning restore 1591
