using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core;

/// <summary>
/// Summary description for NotifForm1
/// </summary>
public class NotifForm1 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRRichText txtName;
    private XRRichText txtOrgName;
    private XRRichText txtAddress;
    private XRRichText txtTel;
    private XRRichText txtEMail;
    private XRRichText txtFax;
    private XRLabel label1;
    private XRLabel label3;
    private XRLabel label6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRRichText txtWebPage;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRRichText txtMission;
    private XRLabel label13;
    private XRRichText txtContactInfo;
    private XRRichText xrRichText1;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRRichText txtHumNumber;
    private XRRichText txtDesc1;
    private XRRichText txtDesc2;
    private XRLabel xrLabel7;
    private XRRichText txtDonors;
    private XRLabel xrLabel8;
    private XRRichText txtHumTerms;
    private XRLabel xrLabel9;
    private XRRichText txtProportions;
    private XRLabel xrLabel10;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    //public NotifForm1()
    //{
    //    InitializeComponent();
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifForm1));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.txtProportions = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtHumTerms = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDonors = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDesc2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDesc1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtHumNumber = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label13 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtContactInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.txtMission = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtWebPage = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtOrgName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtAddress = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTel = new DevExpress.XtraReports.UI.XRRichText();
            this.txtEMail = new DevExpress.XtraReports.UI.XRRichText();
            this.txtFax = new DevExpress.XtraReports.UI.XRRichText();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtName = new DevExpress.XtraReports.UI.XRRichText();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.txtProportions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHumTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHumNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtProportions,
            this.xrLabel10,
            this.txtHumTerms,
            this.xrLabel9,
            this.txtDonors,
            this.xrLabel8,
            this.txtDesc2,
            this.xrLabel7,
            this.txtDesc1,
            this.xrLabel4,
            this.txtHumNumber,
            this.xrLabel3,
            this.label13,
            this.txtContactInfo,
            this.txtMission,
            this.xrLabel2,
            this.txtWebPage,
            this.xrLabel1,
            this.txtOrgName,
            this.txtAddress,
            this.txtTel,
            this.txtEMail,
            this.txtFax,
            this.label1,
            this.label3,
            this.label6,
            this.xrLabel5,
            this.xrLabel6,
            this.xrRichText1});
            this.Detail.HeightF = 632.2917F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtProportions
            // 
            this.txtProportions.LocationFloat = new DevExpress.Utils.PointFloat(291.2917F, 557.5833F);
            this.txtProportions.Name = "txtProportions";
            this.txtProportions.SerializableRtfString = resources.GetString("txtProportions.SerializableRtfString");
            this.txtProportions.SizeF = new System.Drawing.SizeF(348.7083F, 53.20834F);
            // 
            // xrLabel10
            // 
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(12.25001F, 557.5833F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(244.7917F, 53.20828F);
            this.xrLabel10.Text = "გადაუდებელი ჰუმანიტარული დახმარების შეტანის მიმართულება და პროპორციები";
            // 
            // txtHumTerms
            // 
            this.txtHumTerms.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 499.375F);
            this.txtHumTerms.Name = "txtHumTerms";
            this.txtHumTerms.SerializableRtfString = resources.GetString("txtHumTerms.SerializableRtfString");
            this.txtHumTerms.SizeF = new System.Drawing.SizeF(348.7083F, 53.20834F);
            // 
            // xrLabel9
            // 
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 499.375F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(244.7917F, 53.20828F);
            this.xrLabel9.Text = "გადაუდებელი ჰუმანიტარული დახმარების გაცემის ვადა (ერთჯერადი, მრავალჯერადი)";
            // 
            // txtDonors
            // 
            this.txtDonors.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 468.2501F);
            this.txtDonors.Name = "txtDonors";
            this.txtDonors.SerializableRtfString = resources.GetString("txtDonors.SerializableRtfString");
            this.txtDonors.SizeF = new System.Drawing.SizeF(348.7083F, 26.12491F);
            // 
            // xrLabel8
            // 
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(13.12497F, 468.25F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(244.7917F, 26.12494F);
            this.xrLabel8.Text = "დონორები";
            // 
            // txtDesc2
            // 
            this.txtDesc2.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 408.7501F);
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.SerializableRtfString = resources.GetString("txtDesc2.SerializableRtfString");
            this.txtDesc2.SizeF = new System.Drawing.SizeF(348.7083F, 26.12491F);
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(13.12496F, 437.7917F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(244.7917F, 26.12494F);
            this.xrLabel7.Text = "ჰუმანიტარული დახმარების რაოდენობა ";
            // 
            // txtDesc1
            // 
            this.txtDesc1.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 322.8333F);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.SerializableRtfString = resources.GetString("txtDesc1.SerializableRtfString");
            this.txtDesc1.SizeF = new System.Drawing.SizeF(348.7083F, 82.375F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(13.12494F, 408.7501F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(244.7917F, 26.12494F);
            this.xrLabel4.Text = " ჰუმანიტარული დახმარების აღწერა";
            // 
            // txtHumNumber
            // 
            this.txtHumNumber.LocationFloat = new DevExpress.Utils.PointFloat(291.2917F, 437.7917F);
            this.txtHumNumber.Name = "txtHumNumber";
            this.txtHumNumber.SerializableRtfString = resources.GetString("txtHumNumber.SerializableRtfString");
            this.txtHumNumber.SizeF = new System.Drawing.SizeF(348.7083F, 26.12491F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(13.12496F, 322.8333F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(244.7917F, 82.37497F);
            this.xrLabel3.Text = "ჰუმანიტარული მდგომარეობის აღწერა (რით არის გამოწვეული, რომელ გეოგრაფიულ არეალს მო" +
    "იცავს ჰუმანიტარული მდგომარეობის მიერ გამოწვეული შედეგები) ";
            // 
            // label13
            // 
            this.label13.LocationFloat = new DevExpress.Utils.PointFloat(13.12494F, 241.75F);
            this.label13.Name = "label13";
            this.label13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label13.SizeF = new System.Drawing.SizeF(244.7917F, 22.99997F);
            this.label13.Text = "საკონტაქტო პირი (სახელი, გვარი, ტელეფონი)";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 241.75F);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.SerializableRtfString = resources.GetString("txtContactInfo.SerializableRtfString");
            this.txtContactInfo.SizeF = new System.Drawing.SizeF(348.7083F, 22.99997F);
            // 
            // txtMission
            // 
            this.txtMission.LocationFloat = new DevExpress.Utils.PointFloat(290.2501F, 150F);
            this.txtMission.Name = "txtMission";
            this.txtMission.SerializableRtfString = resources.GetString("txtMission.SerializableRtfString");
            this.txtMission.SizeF = new System.Drawing.SizeF(349.7499F, 88.75002F);
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.12497F, 150F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(227.125F, 19F);
            this.xrLabel2.Text = "ორგანიზაციის მისიის აღწერა:";
            // 
            // txtWebPage
            // 
            this.txtWebPage.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 129F);
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.SerializableRtfString = resources.GetString("txtWebPage.SerializableRtfString");
            this.txtWebPage.SizeF = new System.Drawing.SizeF(349.7498F, 18.00002F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.12497F, 128F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.xrLabel1.Text = "ვებ გვერდი:";
            // 
            // txtOrgName
            // 
            this.txtOrgName.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 10.00001F);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.SerializableRtfString = resources.GetString("txtOrgName.SerializableRtfString");
            this.txtOrgName.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            // 
            // txtAddress
            // 
            this.txtAddress.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 33.99982F);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.SerializableRtfString = resources.GetString("txtAddress.SerializableRtfString");
            this.txtAddress.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            // 
            // txtTel
            // 
            this.txtTel.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 58.00009F);
            this.txtTel.Name = "txtTel";
            this.txtTel.SerializableRtfString = resources.GetString("txtTel.SerializableRtfString");
            this.txtTel.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            // 
            // txtEMail
            // 
            this.txtEMail.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 107F);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.SerializableRtfString = resources.GetString("txtEMail.SerializableRtfString");
            this.txtEMail.SizeF = new System.Drawing.SizeF(349.7498F, 20.00002F);
            // 
            // txtFax
            // 
            this.txtFax.LocationFloat = new DevExpress.Utils.PointFloat(290.2502F, 82F);
            this.txtFax.Name = "txtFax";
            this.txtFax.SerializableRtfString = resources.GetString("txtFax.SerializableRtfString");
            this.txtFax.SizeF = new System.Drawing.SizeF(349.7498F, 23F);
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(160.5833F, 23F);
            this.label1.Text = "ორგანიზაციის სახელი:";
            // 
            // label3
            // 
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 35.00001F);
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(144.9583F, 23.00003F);
            this.label3.Text = "მისამართი";
            // 
            // label6
            // 
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 59.00005F);
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label6.SizeF = new System.Drawing.SizeF(145.8333F, 23.00002F);
            this.label6.Text = "ტელეფონი:";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(12.25001F, 107F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(142.7083F, 19F);
            this.xrLabel5.Text = "ელ-ფოსტა:";
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(10.12497F, 85.99997F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.xrLabel6.Text = "ფაქსი:";
            // 
            // xrRichText1
            // 
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(64.66668F, 295.8333F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(563.2918F, 23F);
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
            this.txtName.LocationFloat = new DevExpress.Utils.PointFloat(175.2501F, 51.04167F);
            this.txtName.Name = "txtName";
            this.txtName.SerializableRtfString = resources.GetString("txtName.SerializableRtfString");
            this.txtName.SizeF = new System.Drawing.SizeF(283.0832F, 23F);
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 66.66666F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // NotifForm1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 67);
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.txtProportions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHumTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHumNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    public NotifForm1(Notifications nf1)
    {
        InitializeComponent();

        txtOrgName.Text = nf1.OrgName;
        txtAddress.Text = nf1.Address;
        txtTel.Text = nf1.Mobile;
        txtFax.Text = nf1.Fax;
        txtEMail.Text = nf1.Email;
        txtWebPage.Text = nf1.WebPage;
        txtMission.Text = nf1.MissionDesc;
        txtContactInfo.Text = nf1.Contact;
        txtDesc1.Text = nf1.Desc1;
        txtDesc2.Text = nf1.Desc2;
        txtHumNumber.Text = nf1.Number;
        txtDonors.Text = nf1.Donors;
        txtHumTerms.Text = nf1.Term;
        txtProportions.Text = nf1.Proportions;
    }
}
