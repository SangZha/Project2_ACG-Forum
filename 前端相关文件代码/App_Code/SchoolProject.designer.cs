﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SchoolProject")]
public partial class SchoolProjectDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void InsertAdministrators(Administrators instance);
  partial void UpdateAdministrators(Administrators instance);
  partial void DeleteAdministrators(Administrators instance);
  partial void InsertArticles(Articles instance);
  partial void UpdateArticles(Articles instance);
  partial void DeleteArticles(Articles instance);
  partial void InsertComments(Comments instance);
  partial void UpdateComments(Comments instance);
  partial void DeleteComments(Comments instance);
  partial void InsertReplies(Replies instance);
  partial void UpdateReplies(Replies instance);
  partial void DeleteReplies(Replies instance);
  partial void InsertUsers(Users instance);
  partial void UpdateUsers(Users instance);
  partial void DeleteUsers(Users instance);
  #endregion
	
	public SchoolProjectDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SchoolProjectConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public SchoolProjectDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SchoolProjectDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SchoolProjectDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SchoolProjectDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Administrators> Administrators
	{
		get
		{
			return this.GetTable<Administrators>();
		}
	}
	
	public System.Data.Linq.Table<Articles> Articles
	{
		get
		{
			return this.GetTable<Articles>();
		}
	}
	
	public System.Data.Linq.Table<Comments> Comments
	{
		get
		{
			return this.GetTable<Comments>();
		}
	}
	
	public System.Data.Linq.Table<Replies> Replies
	{
		get
		{
			return this.GetTable<Replies>();
		}
	}
	
	public System.Data.Linq.Table<Users> Users
	{
		get
		{
			return this.GetTable<Users>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Administrators")]
public partial class Administrators : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _AdministratorId;
	
	private string _AdministratorName;
	
	private string _AdministratorAccount;
	
	private string _AdministratorPassword;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdministratorIdChanging(int value);
    partial void OnAdministratorIdChanged();
    partial void OnAdministratorNameChanging(string value);
    partial void OnAdministratorNameChanged();
    partial void OnAdministratorAccountChanging(string value);
    partial void OnAdministratorAccountChanged();
    partial void OnAdministratorPasswordChanging(string value);
    partial void OnAdministratorPasswordChanged();
    #endregion
	
	public Administrators()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdministratorId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int AdministratorId
	{
		get
		{
			return this._AdministratorId;
		}
		set
		{
			if ((this._AdministratorId != value))
			{
				this.OnAdministratorIdChanging(value);
				this.SendPropertyChanging();
				this._AdministratorId = value;
				this.SendPropertyChanged("AdministratorId");
				this.OnAdministratorIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdministratorName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string AdministratorName
	{
		get
		{
			return this._AdministratorName;
		}
		set
		{
			if ((this._AdministratorName != value))
			{
				this.OnAdministratorNameChanging(value);
				this.SendPropertyChanging();
				this._AdministratorName = value;
				this.SendPropertyChanged("AdministratorName");
				this.OnAdministratorNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdministratorAccount", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string AdministratorAccount
	{
		get
		{
			return this._AdministratorAccount;
		}
		set
		{
			if ((this._AdministratorAccount != value))
			{
				this.OnAdministratorAccountChanging(value);
				this.SendPropertyChanging();
				this._AdministratorAccount = value;
				this.SendPropertyChanged("AdministratorAccount");
				this.OnAdministratorAccountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdministratorPassword", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string AdministratorPassword
	{
		get
		{
			return this._AdministratorPassword;
		}
		set
		{
			if ((this._AdministratorPassword != value))
			{
				this.OnAdministratorPasswordChanging(value);
				this.SendPropertyChanging();
				this._AdministratorPassword = value;
				this.SendPropertyChanged("AdministratorPassword");
				this.OnAdministratorPasswordChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Articles")]
public partial class Articles : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ArticleId;
	
	private string _ArticleTitle;
	
	private string _ArticleContent;
	
	private string _ArticleWriter;
	
	private System.DateTime _ArticleTime;
	
	private EntitySet<Comments> _Comments;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnArticleIdChanging(int value);
    partial void OnArticleIdChanged();
    partial void OnArticleTitleChanging(string value);
    partial void OnArticleTitleChanged();
    partial void OnArticleContentChanging(string value);
    partial void OnArticleContentChanged();
    partial void OnArticleWriterChanging(string value);
    partial void OnArticleWriterChanged();
    partial void OnArticleTimeChanging(System.DateTime value);
    partial void OnArticleTimeChanged();
    #endregion
	
	public Articles()
	{
		this._Comments = new EntitySet<Comments>(new Action<Comments>(this.attach_Comments), new Action<Comments>(this.detach_Comments));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ArticleId
	{
		get
		{
			return this._ArticleId;
		}
		set
		{
			if ((this._ArticleId != value))
			{
				this.OnArticleIdChanging(value);
				this.SendPropertyChanging();
				this._ArticleId = value;
				this.SendPropertyChanged("ArticleId");
				this.OnArticleIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleTitle", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string ArticleTitle
	{
		get
		{
			return this._ArticleTitle;
		}
		set
		{
			if ((this._ArticleTitle != value))
			{
				this.OnArticleTitleChanging(value);
				this.SendPropertyChanging();
				this._ArticleTitle = value;
				this.SendPropertyChanged("ArticleTitle");
				this.OnArticleTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleContent", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
	public string ArticleContent
	{
		get
		{
			return this._ArticleContent;
		}
		set
		{
			if ((this._ArticleContent != value))
			{
				this.OnArticleContentChanging(value);
				this.SendPropertyChanging();
				this._ArticleContent = value;
				this.SendPropertyChanged("ArticleContent");
				this.OnArticleContentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleWriter", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string ArticleWriter
	{
		get
		{
			return this._ArticleWriter;
		}
		set
		{
			if ((this._ArticleWriter != value))
			{
				this.OnArticleWriterChanging(value);
				this.SendPropertyChanging();
				this._ArticleWriter = value;
				this.SendPropertyChanged("ArticleWriter");
				this.OnArticleWriterChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleTime", DbType="DateTime NOT NULL")]
	public System.DateTime ArticleTime
	{
		get
		{
			return this._ArticleTime;
		}
		set
		{
			if ((this._ArticleTime != value))
			{
				this.OnArticleTimeChanging(value);
				this.SendPropertyChanging();
				this._ArticleTime = value;
				this.SendPropertyChanged("ArticleTime");
				this.OnArticleTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Articles_Comments", Storage="_Comments", ThisKey="ArticleId", OtherKey="ArticleId")]
	public EntitySet<Comments> Comments
	{
		get
		{
			return this._Comments;
		}
		set
		{
			this._Comments.Assign(value);
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
	
	private void attach_Comments(Comments entity)
	{
		this.SendPropertyChanging();
		entity.Articles = this;
	}
	
	private void detach_Comments(Comments entity)
	{
		this.SendPropertyChanging();
		entity.Articles = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comments")]
public partial class Comments : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CommentId;
	
	private string _CommentContent;
	
	private System.DateTime _CommentTime;
	
	private int _ArticleId;
	
	private int _UserId;
	
	private EntitySet<Replies> _Replies;
	
	private EntityRef<Articles> _Articles;
	
	private EntityRef<Users> _Users;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCommentIdChanging(int value);
    partial void OnCommentIdChanged();
    partial void OnCommentContentChanging(string value);
    partial void OnCommentContentChanged();
    partial void OnCommentTimeChanging(System.DateTime value);
    partial void OnCommentTimeChanged();
    partial void OnArticleIdChanging(int value);
    partial void OnArticleIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    #endregion
	
	public Comments()
	{
		this._Replies = new EntitySet<Replies>(new Action<Replies>(this.attach_Replies), new Action<Replies>(this.detach_Replies));
		this._Articles = default(EntityRef<Articles>);
		this._Users = default(EntityRef<Users>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CommentId
	{
		get
		{
			return this._CommentId;
		}
		set
		{
			if ((this._CommentId != value))
			{
				this.OnCommentIdChanging(value);
				this.SendPropertyChanging();
				this._CommentId = value;
				this.SendPropertyChanged("CommentId");
				this.OnCommentIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentContent", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
	public string CommentContent
	{
		get
		{
			return this._CommentContent;
		}
		set
		{
			if ((this._CommentContent != value))
			{
				this.OnCommentContentChanging(value);
				this.SendPropertyChanging();
				this._CommentContent = value;
				this.SendPropertyChanged("CommentContent");
				this.OnCommentContentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentTime", DbType="DateTime NOT NULL")]
	public System.DateTime CommentTime
	{
		get
		{
			return this._CommentTime;
		}
		set
		{
			if ((this._CommentTime != value))
			{
				this.OnCommentTimeChanging(value);
				this.SendPropertyChanging();
				this._CommentTime = value;
				this.SendPropertyChanged("CommentTime");
				this.OnCommentTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleId", DbType="Int NOT NULL")]
	public int ArticleId
	{
		get
		{
			return this._ArticleId;
		}
		set
		{
			if ((this._ArticleId != value))
			{
				if (this._Articles.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnArticleIdChanging(value);
				this.SendPropertyChanging();
				this._ArticleId = value;
				this.SendPropertyChanged("ArticleId");
				this.OnArticleIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
	public int UserId
	{
		get
		{
			return this._UserId;
		}
		set
		{
			if ((this._UserId != value))
			{
				if (this._Users.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserIdChanging(value);
				this.SendPropertyChanging();
				this._UserId = value;
				this.SendPropertyChanged("UserId");
				this.OnUserIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Comments_Replies", Storage="_Replies", ThisKey="CommentId", OtherKey="ConmmentId")]
	public EntitySet<Replies> Replies
	{
		get
		{
			return this._Replies;
		}
		set
		{
			this._Replies.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Articles_Comments", Storage="_Articles", ThisKey="ArticleId", OtherKey="ArticleId", IsForeignKey=true)]
	public Articles Articles
	{
		get
		{
			return this._Articles.Entity;
		}
		set
		{
			Articles previousValue = this._Articles.Entity;
			if (((previousValue != value) 
						|| (this._Articles.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Articles.Entity = null;
					previousValue.Comments.Remove(this);
				}
				this._Articles.Entity = value;
				if ((value != null))
				{
					value.Comments.Add(this);
					this._ArticleId = value.ArticleId;
				}
				else
				{
					this._ArticleId = default(int);
				}
				this.SendPropertyChanged("Articles");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Comments", Storage="_Users", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
	public Users Users
	{
		get
		{
			return this._Users.Entity;
		}
		set
		{
			Users previousValue = this._Users.Entity;
			if (((previousValue != value) 
						|| (this._Users.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Users.Entity = null;
					previousValue.Comments.Remove(this);
				}
				this._Users.Entity = value;
				if ((value != null))
				{
					value.Comments.Add(this);
					this._UserId = value.UserId;
				}
				else
				{
					this._UserId = default(int);
				}
				this.SendPropertyChanged("Users");
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
	
	private void attach_Replies(Replies entity)
	{
		this.SendPropertyChanging();
		entity.Comments = this;
	}
	
	private void detach_Replies(Replies entity)
	{
		this.SendPropertyChanging();
		entity.Comments = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Replies")]
public partial class Replies : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ReplyId;
	
	private string _ReplyContent;
	
	private System.DateTime _ReplyTime;
	
	private int _ConmmentId;
	
	private EntityRef<Comments> _Comments;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReplyIdChanging(int value);
    partial void OnReplyIdChanged();
    partial void OnReplyContentChanging(string value);
    partial void OnReplyContentChanged();
    partial void OnReplyTimeChanging(System.DateTime value);
    partial void OnReplyTimeChanged();
    partial void OnConmmentIdChanging(int value);
    partial void OnConmmentIdChanged();
    #endregion
	
	public Replies()
	{
		this._Comments = default(EntityRef<Comments>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReplyId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ReplyId
	{
		get
		{
			return this._ReplyId;
		}
		set
		{
			if ((this._ReplyId != value))
			{
				this.OnReplyIdChanging(value);
				this.SendPropertyChanging();
				this._ReplyId = value;
				this.SendPropertyChanged("ReplyId");
				this.OnReplyIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReplyContent", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
	public string ReplyContent
	{
		get
		{
			return this._ReplyContent;
		}
		set
		{
			if ((this._ReplyContent != value))
			{
				this.OnReplyContentChanging(value);
				this.SendPropertyChanging();
				this._ReplyContent = value;
				this.SendPropertyChanged("ReplyContent");
				this.OnReplyContentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReplyTime", DbType="DateTime NOT NULL")]
	public System.DateTime ReplyTime
	{
		get
		{
			return this._ReplyTime;
		}
		set
		{
			if ((this._ReplyTime != value))
			{
				this.OnReplyTimeChanging(value);
				this.SendPropertyChanging();
				this._ReplyTime = value;
				this.SendPropertyChanged("ReplyTime");
				this.OnReplyTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConmmentId", DbType="Int NOT NULL")]
	public int ConmmentId
	{
		get
		{
			return this._ConmmentId;
		}
		set
		{
			if ((this._ConmmentId != value))
			{
				if (this._Comments.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnConmmentIdChanging(value);
				this.SendPropertyChanging();
				this._ConmmentId = value;
				this.SendPropertyChanged("ConmmentId");
				this.OnConmmentIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Comments_Replies", Storage="_Comments", ThisKey="ConmmentId", OtherKey="CommentId", IsForeignKey=true)]
	public Comments Comments
	{
		get
		{
			return this._Comments.Entity;
		}
		set
		{
			Comments previousValue = this._Comments.Entity;
			if (((previousValue != value) 
						|| (this._Comments.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Comments.Entity = null;
					previousValue.Replies.Remove(this);
				}
				this._Comments.Entity = value;
				if ((value != null))
				{
					value.Replies.Add(this);
					this._ConmmentId = value.CommentId;
				}
				else
				{
					this._ConmmentId = default(int);
				}
				this.SendPropertyChanged("Comments");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _UserId;
	
	private string _UserName;
	
	private string _UserAccount;
	
	private string _UserPassword;
	
	private string _UserSign;
	
	private string _UserSex;
	
	private System.Nullable<System.DateTime> _UserBirth;
	
	private string _UserProvince;
	
	private string _UserCity;
	
	private System.Nullable<int> _UserLove;
	
	private string _UserQQ;
	
	private string _UserWechat;
	
	private EntitySet<Comments> _Comments;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnUserAccountChanging(string value);
    partial void OnUserAccountChanged();
    partial void OnUserPasswordChanging(string value);
    partial void OnUserPasswordChanged();
    partial void OnUserSignChanging(string value);
    partial void OnUserSignChanged();
    partial void OnUserSexChanging(string value);
    partial void OnUserSexChanged();
    partial void OnUserBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnUserBirthChanged();
    partial void OnUserProvinceChanging(string value);
    partial void OnUserProvinceChanged();
    partial void OnUserCityChanging(string value);
    partial void OnUserCityChanged();
    partial void OnUserLoveChanging(System.Nullable<int> value);
    partial void OnUserLoveChanged();
    partial void OnUserQQChanging(string value);
    partial void OnUserQQChanged();
    partial void OnUserWechatChanging(string value);
    partial void OnUserWechatChanged();
    #endregion
	
	public Users()
	{
		this._Comments = new EntitySet<Comments>(new Action<Comments>(this.attach_Comments), new Action<Comments>(this.detach_Comments));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int UserId
	{
		get
		{
			return this._UserId;
		}
		set
		{
			if ((this._UserId != value))
			{
				this.OnUserIdChanging(value);
				this.SendPropertyChanging();
				this._UserId = value;
				this.SendPropertyChanged("UserId");
				this.OnUserIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAccount", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string UserAccount
	{
		get
		{
			return this._UserAccount;
		}
		set
		{
			if ((this._UserAccount != value))
			{
				this.OnUserAccountChanging(value);
				this.SendPropertyChanging();
				this._UserAccount = value;
				this.SendPropertyChanged("UserAccount");
				this.OnUserAccountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string UserPassword
	{
		get
		{
			return this._UserPassword;
		}
		set
		{
			if ((this._UserPassword != value))
			{
				this.OnUserPasswordChanging(value);
				this.SendPropertyChanging();
				this._UserPassword = value;
				this.SendPropertyChanged("UserPassword");
				this.OnUserPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserSign", DbType="VarChar(100)")]
	public string UserSign
	{
		get
		{
			return this._UserSign;
		}
		set
		{
			if ((this._UserSign != value))
			{
				this.OnUserSignChanging(value);
				this.SendPropertyChanging();
				this._UserSign = value;
				this.SendPropertyChanged("UserSign");
				this.OnUserSignChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserSex", DbType="VarChar(10)")]
	public string UserSex
	{
		get
		{
			return this._UserSex;
		}
		set
		{
			if ((this._UserSex != value))
			{
				this.OnUserSexChanging(value);
				this.SendPropertyChanging();
				this._UserSex = value;
				this.SendPropertyChanged("UserSex");
				this.OnUserSexChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserBirth", DbType="DateTime")]
	public System.Nullable<System.DateTime> UserBirth
	{
		get
		{
			return this._UserBirth;
		}
		set
		{
			if ((this._UserBirth != value))
			{
				this.OnUserBirthChanging(value);
				this.SendPropertyChanging();
				this._UserBirth = value;
				this.SendPropertyChanged("UserBirth");
				this.OnUserBirthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserProvince", DbType="VarChar(20)")]
	public string UserProvince
	{
		get
		{
			return this._UserProvince;
		}
		set
		{
			if ((this._UserProvince != value))
			{
				this.OnUserProvinceChanging(value);
				this.SendPropertyChanging();
				this._UserProvince = value;
				this.SendPropertyChanged("UserProvince");
				this.OnUserProvinceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCity", DbType="VarChar(20)")]
	public string UserCity
	{
		get
		{
			return this._UserCity;
		}
		set
		{
			if ((this._UserCity != value))
			{
				this.OnUserCityChanging(value);
				this.SendPropertyChanging();
				this._UserCity = value;
				this.SendPropertyChanged("UserCity");
				this.OnUserCityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLove", DbType="Int")]
	public System.Nullable<int> UserLove
	{
		get
		{
			return this._UserLove;
		}
		set
		{
			if ((this._UserLove != value))
			{
				this.OnUserLoveChanging(value);
				this.SendPropertyChanging();
				this._UserLove = value;
				this.SendPropertyChanged("UserLove");
				this.OnUserLoveChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserQQ", DbType="VarChar(30)")]
	public string UserQQ
	{
		get
		{
			return this._UserQQ;
		}
		set
		{
			if ((this._UserQQ != value))
			{
				this.OnUserQQChanging(value);
				this.SendPropertyChanging();
				this._UserQQ = value;
				this.SendPropertyChanged("UserQQ");
				this.OnUserQQChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserWechat", DbType="VarChar(30)")]
	public string UserWechat
	{
		get
		{
			return this._UserWechat;
		}
		set
		{
			if ((this._UserWechat != value))
			{
				this.OnUserWechatChanging(value);
				this.SendPropertyChanging();
				this._UserWechat = value;
				this.SendPropertyChanged("UserWechat");
				this.OnUserWechatChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Comments", Storage="_Comments", ThisKey="UserId", OtherKey="UserId")]
	public EntitySet<Comments> Comments
	{
		get
		{
			return this._Comments;
		}
		set
		{
			this._Comments.Assign(value);
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
	
	private void attach_Comments(Comments entity)
	{
		this.SendPropertyChanging();
		entity.Users = this;
	}
	
	private void detach_Comments(Comments entity)
	{
		this.SendPropertyChanging();
		entity.Users = null;
	}
}
#pragma warning restore 1591
