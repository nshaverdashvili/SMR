using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core;

/// <summary>
/// Summary description for NotifForm3
/// </summary>
public class NotifForm3 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRRichText txtName;
    private XRRichText txtOrgName;
    private XRLabel label1;
    private XRLabel xrLabel11;
    private XRLabel xrLabel1;
    private XRRichText txtProjectDesc;
    private XRRichText txtWebPage;
    private XRLabel xrLabel2;
    private XRRichText txtAddress;
    private XRRichText txtTel;
    private XRRichText txtEMail;
    private XRLabel label3;
    private XRLabel label6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel3;
    private XRRichText txtMission;
    private XRLabel label13;
    private XRRichText txtContactInfo;
    private XRRichText txtProjectIsActive;
    private XRLabel xrLabel4;
    private XRLabel xrLabel6;
    private XRLabel xrLabel7;
    private XRRichText txtProjectName;
    private XRLabel xrLabel8;
    private XRRichText txtProjectStatus;
    private XRLabel xrLabel9;
    private XRRichText txtDonorsInfo;
    private XRLabel xrLabel12;
    private XRRichText txtProjectResult;
    private XRLabel xrLabel13;
    private XRRichText txtFDate;
    private XRLabel xrLabel14;
    private XRRichText txtLDate;
    private XRRichText txtLocalPartner;
    private XRLabel xrLabel16;
    private XRLabel xrLabel15;
    private XRRichText txtFinanceInfo;
    private XRRichText txtDepartPlan;
    private XRLabel xrLabel17;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public NotifForm3()
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
    public NotifForm3(Notifications nf3)
    {
        InitializeComponent();

        txtOrgName.Text = nf3.OrgName;
        txtProjectDesc.Text = nf3.Note;
        txtAddress.Text = nf3.Address;
        txtTel.Text = nf3.Mobile;
        txtEMail.Text = nf3.Email;
        txtWebPage.Text = nf3.WebPage;
        txtMission.Text = nf3.MissionDesc;
        txtProjectIsActive.Text = nf3.IsActualProjects.ToString();
        txtContactInfo.Text = nf3.Contact;
        txtProjectName.Text = nf3.ProjectTitle;
        txtDonorsInfo.Text = nf3.Donors;
        txtProjectResult.Text = nf3.ProjectResults;
        txtFDate.Text = nf3.ProjectFDate.ToString();
        txtLDate.Text = nf3.ProjectLDate.ToString();
        txtFinanceInfo.Text = nf3.FinanceInfo;
        txtLocalPartner.Text = nf3.PartnerInfo;
        txtDepartPlan.Text = nf3.DepartPlan;

    }
    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifForm3));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.txtDepartPlan = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtLocalPartner = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtFinanceInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectStatus = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDonorsInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectResult = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtFDate = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtLDate = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProjectIsActive = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtWebPage = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtAddress = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTel = new DevExpress.XtraReports.UI.XRRichText();
            this.txtEMail = new DevExpress.XtraReports.UI.XRRichText();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtMission = new DevExpress.XtraReports.UI.XRRichText();
            this.label13 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtContactInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.txtProjectDesc = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtOrgName = new DevExpress.XtraReports.UI.XRRichText();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtName = new DevExpress.XtraReports.UI.XRRichText();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinanceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonorsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtDepartPlan,
            this.xrLabel17,
            this.txtLocalPartner,
            this.xrLabel16,
            this.xrLabel15,
            this.txtFinanceInfo,
            this.xrLabel7,
            this.txtProjectName,
            this.xrLabel8,
            this.txtProjectStatus,
            this.xrLabel9,
            this.txtDonorsInfo,
            this.xrLabel12,
            this.txtProjectResult,
            this.xrLabel13,
            this.txtFDate,
            this.xrLabel14,
            this.txtLDate,
            this.xrLabel6,
            this.txtProjectIsActive,
            this.xrLabel4,
            this.txtWebPage,
            this.xrLabel2,
            this.txtAddress,
            this.txtTel,
            this.txtEMail,
            this.label3,
            this.label6,
            this.xrLabel5,
            this.xrLabel3,
            this.txtMission,
            this.label13,
            this.txtContactInfo,
            this.txtProjectDesc,
            this.xrLabel1,
            this.xrLabel11,
            this.txtOrgName,
            this.label1});
            this.Detail.HeightF = 1053.875F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtDepartPlan
            // 
            this.txtDepartPlan.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 952.8333F);
            this.txtDepartPlan.Name = "txtDepartPlan";
            this.txtDepartPlan.SerializableRtfString = resources.GetString("txtDepartPlan.SerializableRtfString");
            this.txtDepartPlan.SizeF = new System.Drawing.SizeF(345.5833F, 76.12494F);
            // 
            // xrLabel17
            // 
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(12.24999F, 952.8333F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(247.0417F, 43.83337F);
            this.xrLabel17.Text = "ოკუპირებულ ტერიტორიებზე გამგზავრების მოსალოდნელი განრიგი";
            // 
            // txtLocalPartner
            // 
            this.txtLocalPartner.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 872.6251F);
            this.txtLocalPartner.Name = "txtLocalPartner";
            this.txtLocalPartner.SerializableRtfString = resources.GetString("txtLocalPartner.SerializableRtfString");
            this.txtLocalPartner.SizeF = new System.Drawing.SizeF(345.5833F, 76.12494F);
            // 
            // xrLabel16
            // 
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(12.24995F, 872.6251F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(244.7917F, 57.37488F);
            this.xrLabel16.Text = "ინფორმაცია ადგილობრივი პარტნიორების შესახებ (დასახელება და საკონტაქტო ინფორმაცია)" +
    " ";
            // 
            // xrLabel15
            // 
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(12.24996F, 790.9587F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel15.Text = "ფინანსური ინფორმაცია (მოსალოდნელი ბიუჯეტი, რესურსები, საბანკო ინფორმაცია)";
            // 
            // txtFinanceInfo
            // 
            this.txtFinanceInfo.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 790.9587F);
            this.txtFinanceInfo.Name = "txtFinanceInfo";
            this.txtFinanceInfo.SerializableRtfString = resources.GetString("txtFinanceInfo.SerializableRtfString");
            this.txtFinanceInfo.SizeF = new System.Drawing.SizeF(345.5833F, 76.12494F);
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 460.8961F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(244.7917F, 22.99997F);
            this.xrLabel7.Text = "პროექტის დასახელება";
            // 
            // txtProjectName
            // 
            this.txtProjectName.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 460.8961F);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.SerializableRtfString = resources.GetString("txtProjectName.SerializableRtfString");
            this.txtProjectName.SizeF = new System.Drawing.SizeF(345.5833F, 22.99997F);
            // 
            // xrLabel8
            // 
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 487.8961F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel8.Text = "პროექტის სტატუსი (მიმდინარე, იდეა, დაფინანსებული, გაგრძელებული) ";
            // 
            // txtProjectStatus
            // 
            this.txtProjectStatus.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 487.8961F);
            this.txtProjectStatus.Name = "txtProjectStatus";
            this.txtProjectStatus.SerializableRtfString = resources.GetString("txtProjectStatus.SerializableRtfString");
            this.txtProjectStatus.SizeF = new System.Drawing.SizeF(345.5833F, 76.12497F);
            // 
            // xrLabel9
            // 
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 566.021F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel9.Text = "დონორები (დასახელება და საკონტაქტო ინფორმაცია)";
            // 
            // txtDonorsInfo
            // 
            this.txtDonorsInfo.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 566.021F);
            this.txtDonorsInfo.Name = "txtDonorsInfo";
            this.txtDonorsInfo.SerializableRtfString = resources.GetString("txtDonorsInfo.SerializableRtfString");
            this.txtDonorsInfo.SizeF = new System.Drawing.SizeF(345.5833F, 76.125F);
            // 
            // xrLabel12
            // 
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(12.24999F, 646.2709F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(244.7917F, 43.83331F);
            this.xrLabel12.Text = "პროექტის მოსალოდნელი შედეგები";
            // 
            // txtProjectResult
            // 
            this.txtProjectResult.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 646.2709F);
            this.txtProjectResult.Name = "txtProjectResult";
            this.txtProjectResult.SerializableRtfString = resources.GetString("txtProjectResult.SerializableRtfString");
            this.txtProjectResult.SizeF = new System.Drawing.SizeF(345.5833F, 76.12494F);
            // 
            // xrLabel13
            // 
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(12.24996F, 727.8335F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(244.7917F, 27.16663F);
            this.xrLabel13.Text = "დაწყების თარიღი";
            // 
            // txtFDate
            // 
            this.txtFDate.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 726.396F);
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.SerializableRtfString = resources.GetString("txtFDate.SerializableRtfString");
            this.txtFDate.SizeF = new System.Drawing.SizeF(345.5833F, 28.60425F);
            // 
            // xrLabel14
            // 
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(12.24996F, 760.7921F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(244.7917F, 27.16663F);
            this.xrLabel14.Text = "დასრულების თარიღი";
            // 
            // txtLDate
            // 
            this.txtLDate.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 759.3544F);
            this.txtLDate.Name = "txtLDate";
            this.txtLDate.SerializableRtfString = resources.GetString("txtLDate.SerializableRtfString");
            this.txtLDate.SizeF = new System.Drawing.SizeF(345.5833F, 28.60431F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(162.5F, 426.4378F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(341.6666F, 22.99997F);
            this.xrLabel6.Text = "ინფორმაცია განსახორციელებელი პროექტის შესახებ";
            // 
            // txtProjectIsActive
            // 
            this.txtProjectIsActive.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 343.8544F);
            this.txtProjectIsActive.Name = "txtProjectIsActive";
            this.txtProjectIsActive.SerializableRtfString = resources.GetString("txtProjectIsActive.SerializableRtfString");
            this.txtProjectIsActive.SizeF = new System.Drawing.SizeF(348.7083F, 22.99997F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 343.8544F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(262.5F, 22.99997F);
            this.xrLabel4.Text = "პროექტები (მიმდინარე/დასრულებული):";
            // 
            // txtWebPage
            // 
            this.txtWebPage.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 229.5835F);
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.SerializableRtfString = resources.GetString("txtWebPage.SerializableRtfString");
            this.txtWebPage.SizeF = new System.Drawing.SizeF(349.7498F, 18.00002F);
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 228.5835F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.xrLabel2.Text = "ვებ გვერდი:";
            // 
            // txtAddress
            // 
            this.txtAddress.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 158.1667F);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.SerializableRtfString = resources.GetString("txtAddress.SerializableRtfString");
            this.txtAddress.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            // 
            // txtTel
            // 
            this.txtTel.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 182.167F);
            this.txtTel.Name = "txtTel";
            this.txtTel.SerializableRtfString = resources.GetString("txtTel.SerializableRtfString");
            this.txtTel.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            // 
            // txtEMail
            // 
            this.txtEMail.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 206.5835F);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.SerializableRtfString = resources.GetString("txtEMail.SerializableRtfString");
            this.txtEMail.SizeF = new System.Drawing.SizeF(349.7498F, 20.00002F);
            // 
            // label3
            // 
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 159.1669F);
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(144.9583F, 23.00003F);
            this.label3.Text = "მისამართი";
            // 
            // label6
            // 
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 183.1669F);
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label6.SizeF = new System.Drawing.SizeF(145.8333F, 23.00002F);
            this.label6.Text = "ტელეფონი:";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 207.5835F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(142.7083F, 19F);
            this.xrLabel5.Text = "ელ-ფოსტა:";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 250.5835F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(227.125F, 19F);
            this.xrLabel3.Text = "ორგანიზაციის მისიის აღწერა:";
            // 
            // txtMission
            // 
            this.txtMission.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 250.5835F);
            this.txtMission.Name = "txtMission";
            this.txtMission.SerializableRtfString = resources.GetString("txtMission.SerializableRtfString");
            this.txtMission.SizeF = new System.Drawing.SizeF(349.7499F, 88.75002F);
            // 
            // label13
            // 
            this.label13.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 370.1045F);
            this.label13.Name = "label13";
            this.label13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label13.SizeF = new System.Drawing.SizeF(262.5F, 38.62497F);
            this.label13.Text = "საკონტაქტო პირი (სახელი, გვარი, ტელეფონი)";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 370.1045F);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.SerializableRtfString = resources.GetString("txtContactInfo.SerializableRtfString");
            this.txtContactInfo.SizeF = new System.Drawing.SizeF(348.7083F, 22.99997F);
            // 
            // txtProjectDesc
            // 
            this.txtProjectDesc.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 56.00001F);
            this.txtProjectDesc.Name = "txtProjectDesc";
            this.txtProjectDesc.SerializableRtfString = resources.GetString("txtProjectDesc.SerializableRtfString");
            this.txtProjectDesc.SizeF = new System.Drawing.SizeF(349.7498F, 100.1666F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 56.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(236.625F, 102.1666F);
            this.xrLabel1.Text = "პროექტი ერთობლივად არის წარდგენილი დონორისა და პროექტის წარმდგენელის მიერ (კი/არა" +
    "). დადებითი პასუხის შემთხვევაში: დონორ(ებ)ის დასახელება";
            // 
            // xrLabel11
            // 
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(226.0417F, 3F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(147.9166F, 22.99997F);
            this.xrLabel11.Text = "ზოგადი ინფორმაცია";
            // 
            // txtOrgName
            // 
            this.txtOrgName.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 30.00001F);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.SerializableRtfString = resources.GetString("txtOrgName.SerializableRtfString");
            this.txtOrgName.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 30.00001F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(160.5833F, 23F);
            this.label1.Text = "ორგანიზაციის სახელი:";
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
            this.txtName.LocationFloat = new DevExpress.Utils.PointFloat(54.16667F, 48.95833F);
            this.txtName.Name = "txtName";
            this.txtName.SerializableRtfString = resources.GetString("txtName.SerializableRtfString");
            this.txtName.SizeF = new System.Drawing.SizeF(565.3749F, 37.29166F);
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // NotifForm3
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinanceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonorsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
