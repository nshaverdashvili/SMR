using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core;

/// <summary>
/// Summary description for NotifForm2
/// </summary>
public class rptNotifForm2 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRRichText txtName;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel label6;
    private XRLabel label3;
    private XRLabel label1;
    private XRRichText txtFax;
    private XRRichText txtTel;
    private XRRichText txtAddress;
    private XRLabel xrLabel1;
    private XRRichText txtWebPage;
    private XRLabel xrLabel2;
    private XRRichText txtMission;
    private XRLabel label13;
    private XRRichText txtContactInfo;
    private XRLabel xrLabel3;
    private XRRichText txtProjectStatus;
    private XRLabel xrLabel7;
    private XRRichText txtProjectName;
    private XRLabel xrLabel4;
    private XRLabel xrLabel9;
    private XRRichText txtProjectGoal;
    private XRRichText txtDonorsInfo;
    private XRLabel xrLabel8;
    private XRRichText txtProjectResult;
    private XRLabel xrLabel10;
    private XRRichText txtLDate;
    private XRLabel xrLabel13;
    private XRRichText txtFDate;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRRichText txtEMail;
    private XRRichText txtOrgName;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rptNotifForm2()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    public rptNotifForm2(Notifications nf2)
    {
        InitializeComponent();

        txtOrgName.Text = nf2.OrgName;
        txtAddress.Text = nf2.Address;
        txtTel.Text = nf2.Mobile;
        txtFax.Text = nf2.Fax;
        txtEMail.Text = nf2.Email;
        txtWebPage.Text = nf2.WebPage;
        txtMission.Text = nf2.MissionDesc;
        txtContactInfo.Text = nf2.Contact;
        txtProjectName.Text = nf2.ProjectTitle;
        txtProjectStatus.Text = nf2.ProjectStatus;
        txtDonorsInfo.Text = nf2.Donors;
        txtProjectGoal.Text = nf2.IsActualProjects.ToString();
        txtProjectStatus.Text = nf2.Results;
        txtFDate.Text = nf2.ProjectFDate.ToString();
        txtLDate.Text = nf2.ProjectLDate.ToString();
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptNotifForm2));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtLDate = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtFDate = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectResult = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectGoal = new DevExpress.XtraReports.UI.XRRichText();
            this.txtDonorsInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectStatus = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label13 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtContactInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtFax = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTel = new DevExpress.XtraReports.UI.XRRichText();
            this.txtAddress = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtWebPage = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtMission = new DevExpress.XtraReports.UI.XRRichText();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtName = new DevExpress.XtraReports.UI.XRRichText();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.txtOrgName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtEMail = new DevExpress.XtraReports.UI.XRRichText();
            ((System.ComponentModel.ISupportInitialize)(this.txtLDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonorsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.txtLDate,
            this.xrLabel13,
            this.txtFDate,
            this.xrLabel12,
            this.txtProjectResult,
            this.xrLabel10,
            this.xrLabel9,
            this.txtProjectGoal,
            this.txtDonorsInfo,
            this.xrLabel8,
            this.txtProjectStatus,
            this.xrLabel7,
            this.txtProjectName,
            this.xrLabel4,
            this.xrLabel3,
            this.label13,
            this.txtContactInfo,
            this.xrLabel6,
            this.xrLabel5,
            this.label6,
            this.label3,
            this.label1,
            this.txtFax,
            this.txtEMail,
            this.txtTel,
            this.txtAddress,
            this.txtOrgName,
            this.xrLabel1,
            this.txtWebPage,
            this.xrLabel2,
            this.txtMission});
            this.Detail.HeightF = 780.2083F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(232.9167F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(147.9166F, 22.99997F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "ზოგადი ინფორმაცია";
            // 
            // txtLDate
            // 
            this.txtLDate.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtLDate.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 729.9792F);
            this.txtLDate.Name = "txtLDate";
            this.txtLDate.SerializableRtfString = resources.GetString("txtLDate.SerializableRtfString");
            this.txtLDate.SizeF = new System.Drawing.SizeF(348.7083F, 28.60425F);
            this.txtLDate.StylePriority.UseFont = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(12.24998F, 731.4168F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(244.7917F, 27.16663F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "დასრულების თარიღი";
            // 
            // txtFDate
            // 
            this.txtFDate.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtFDate.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 691.0208F);
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.SerializableRtfString = resources.GetString("txtFDate.SerializableRtfString");
            this.txtFDate.SizeF = new System.Drawing.SizeF(348.7083F, 28.60425F);
            this.txtFDate.StylePriority.UseFont = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(12.24998F, 692.4583F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(244.7917F, 27.16663F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "დაწყების თარიღი";
            // 
            // txtProjectResult
            // 
            this.txtProjectResult.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtProjectResult.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 610.8958F);
            this.txtProjectResult.Name = "txtProjectResult";
            this.txtProjectResult.SerializableRtfString = resources.GetString("txtProjectResult.SerializableRtfString");
            this.txtProjectResult.SizeF = new System.Drawing.SizeF(348.7083F, 76.12497F);
            this.txtProjectResult.StylePriority.UseFont = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(12.25001F, 610.8958F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "პროექტის მოსალოდნელი შედეგები";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 532.7708F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "პროექტის სტატუსი (მიმდინარე, იდეა, დაფინანსებული, გაგრძელებული) ";
            // 
            // txtProjectGoal
            // 
            this.txtProjectGoal.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtProjectGoal.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 532.7708F);
            this.txtProjectGoal.Name = "txtProjectGoal";
            this.txtProjectGoal.SerializableRtfString = resources.GetString("txtProjectGoal.SerializableRtfString");
            this.txtProjectGoal.SizeF = new System.Drawing.SizeF(348.7083F, 76.12497F);
            this.txtProjectGoal.StylePriority.UseFont = false;
            // 
            // txtDonorsInfo
            // 
            this.txtDonorsInfo.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtDonorsInfo.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 453.6458F);
            this.txtDonorsInfo.Name = "txtDonorsInfo";
            this.txtDonorsInfo.SerializableRtfString = resources.GetString("txtDonorsInfo.SerializableRtfString");
            this.txtDonorsInfo.SizeF = new System.Drawing.SizeF(348.7083F, 76.12497F);
            this.txtDonorsInfo.StylePriority.UseFont = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 453.6458F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "დონორები (დასახელება და საკონტაქტო ინფორმაცია)";
            // 
            // txtProjectStatus
            // 
            this.txtProjectStatus.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtProjectStatus.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 375.5208F);
            this.txtProjectStatus.Name = "txtProjectStatus";
            this.txtProjectStatus.SerializableRtfString = resources.GetString("txtProjectStatus.SerializableRtfString");
            this.txtProjectStatus.SizeF = new System.Drawing.SizeF(348.7083F, 76.12497F);
            this.txtProjectStatus.StylePriority.UseFont = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 375.5208F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "პროექტის სტატუსი (მიმდინარე, იდეა, დაფინანსებული, გაგრძელებული) ";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtProjectName.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 348.5208F);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.SerializableRtfString = resources.GetString("txtProjectName.SerializableRtfString");
            this.txtProjectName.SizeF = new System.Drawing.SizeF(348.7083F, 22.99997F);
            this.txtProjectName.StylePriority.UseFont = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 348.5208F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(244.7917F, 22.99997F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "პროექტის დასახელება";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(161.0417F, 307.4792F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(338.5416F, 22.99997F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "ინფორმაცია განსახორციელებელი პროექტის შესახებ";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.label13.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 263.2709F);
            this.label13.Name = "label13";
            this.label13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label13.SizeF = new System.Drawing.SizeF(244.7917F, 22.99997F);
            this.label13.StylePriority.UseFont = false;
            this.label13.Text = "საკონტაქტო პირი (სახელი, გვარი, ტელეფონი)";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtContactInfo.LocationFloat = new DevExpress.Utils.PointFloat(287.1252F, 263.2709F);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.SerializableRtfString = resources.GetString("txtContactInfo.SerializableRtfString");
            this.txtContactInfo.SizeF = new System.Drawing.SizeF(348.7083F, 22.99997F);
            this.txtContactInfo.StylePriority.UseFont = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(10.12497F, 107F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "ფაქსი:";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(12.25001F, 128F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(142.7083F, 19F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "ელ-ფოსტა:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 80.00002F);
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label6.SizeF = new System.Drawing.SizeF(145.8333F, 23.00002F);
            this.label6.StylePriority.UseFont = false;
            this.label6.Text = "ტელეფონი:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 56.00001F);
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(144.9583F, 23.00003F);
            this.label3.StylePriority.UseFont = false;
            this.label3.Text = "მისამართი";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 31.00001F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(160.5833F, 23F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "ორგანიზაციის სახელი:";
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtFax.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 103F);
            this.txtFax.Name = "txtFax";
            this.txtFax.SerializableRtfString = resources.GetString("txtFax.SerializableRtfString");
            this.txtFax.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            this.txtFax.StylePriority.UseFont = false;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtTel.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 79.00009F);
            this.txtTel.Name = "txtTel";
            this.txtTel.SerializableRtfString = resources.GetString("txtTel.SerializableRtfString");
            this.txtTel.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            this.txtTel.StylePriority.UseFont = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtAddress.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 54.99979F);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.SerializableRtfString = resources.GetString("txtAddress.SerializableRtfString");
            this.txtAddress.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            this.txtAddress.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.12497F, 149F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "ვებ გვერდი:";
            // 
            // txtWebPage
            // 
            this.txtWebPage.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtWebPage.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 150F);
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.SerializableRtfString = resources.GetString("txtWebPage.SerializableRtfString");
            this.txtWebPage.SizeF = new System.Drawing.SizeF(349.7498F, 18.00002F);
            this.txtWebPage.StylePriority.UseFont = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.12497F, 171F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(227.125F, 19F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "ორგანიზაციის მისიის აღწერა:";
            // 
            // txtMission
            // 
            this.txtMission.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtMission.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 171F);
            this.txtMission.Name = "txtMission";
            this.txtMission.SerializableRtfString = resources.GetString("txtMission.SerializableRtfString");
            this.txtMission.SizeF = new System.Drawing.SizeF(349.7499F, 88.75002F);
            this.txtMission.StylePriority.UseFont = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtName});
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtName.LocationFloat = new DevExpress.Utils.PointFloat(33.33333F, 10.00001F);
            this.txtName.Name = "txtName";
            this.txtName.SerializableRtfString = resources.GetString("txtName.SerializableRtfString");
            this.txtName.SizeF = new System.Drawing.SizeF(582.0416F, 61.24999F);
            this.txtName.StylePriority.UseFont = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtOrgName
            // 
            this.txtOrgName.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtOrgName.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 31.00001F);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.SerializableRtfString = resources.GetString("txtOrgName.SerializableRtfString");
            this.txtOrgName.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            this.txtOrgName.StylePriority.UseFont = false;
            // 
            // txtEMail
            // 
            this.txtEMail.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.txtEMail.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 128F);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.SerializableRtfString = resources.GetString("txtEMail.SerializableRtfString");
            this.txtEMail.SizeF = new System.Drawing.SizeF(349.7498F, 20.00002F);
            this.txtEMail.StylePriority.UseFont = false;
            // 
            // rptNotifForm2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.txtLDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonorsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
