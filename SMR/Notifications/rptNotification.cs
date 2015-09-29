using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core;
/// <summary>
/// Summary description for Notification
/// </summary>
public class rptNotification : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRRichText richText1;
    private XRLabel label12;
    private XRLabel label11;
    private XRLabel label10;
    private XRLabel label9;
    private XRLabel label8;
    private XRLabel label7;
    private XRLabel label6;
    private XRLabel label5;
    private XRLabel label4;
    private XRLabel label3;
    private XRLabel label2;
    private XRLabel label1;
    private XRLabel label13;
    private XRRichText txtDestination;
    private XRRichText txtHostInfo;
    private XRRichText txtGender;
    private XRRichText txtDates;
    private XRRichText txtBDate;
    private XRRichText txtPassportN;
    private XRRichText txtFax;
    private XRRichText txtEMail;
    private XRRichText txtNationality;
    private XRRichText txtTel;
    private XRRichText txtAddress;
    private XRRichText txtLName;
    private XRRichText txtFName;
    private XRRichText txtTransportType;
    private XRLabel label14;
    private XRRichText txtName;
    private XRLabel label16;
    private XRLabel label15;
    private XRLabel label18;
    private XRLabel label17;
    private XRRichText txtLName2;
    private XRRichText txtTel2;
    private XRRichText txtAddress2;
    private XRLabel label19;
    private XRRichText xrRichText5;
    private XRRichText xrRichText1;
    private XRRichText xrRichText2;
    private XRRichText xrRichText3;
    private XRRichText xrRichText4;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRRichText txtVisitorStatus;
    private XRRichText txtProjectName;
    private XRRichText txtVisitGoal;
    private XRRichText txtIsSent;
    private XRRichText txtLDate;
    private XRRichText txtFDate;
    private XRRichText txtPartner;
    private XRRichText txtAddInfo;
    private XRLabel xrLabel5;
    private XRRichText txtHostName;
    private XRLabel xrLabel6;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public Notifications NotificationData { get; set; }

    public rptNotification()
    {
        InitializeComponent();
        //txtFName.Text = NotificationData.FName;
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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptNotification));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtHostName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtVisitorStatus = new DevExpress.XtraReports.UI.XRRichText();
            this.txtProjectName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtVisitGoal = new DevExpress.XtraReports.UI.XRRichText();
            this.txtIsSent = new DevExpress.XtraReports.UI.XRRichText();
            this.txtLDate = new DevExpress.XtraReports.UI.XRRichText();
            this.txtFDate = new DevExpress.XtraReports.UI.XRRichText();
            this.txtPartner = new DevExpress.XtraReports.UI.XRRichText();
            this.txtAddInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label16 = new DevExpress.XtraReports.UI.XRLabel();
            this.label15 = new DevExpress.XtraReports.UI.XRLabel();
            this.label18 = new DevExpress.XtraReports.UI.XRLabel();
            this.label17 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtLName2 = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTel2 = new DevExpress.XtraReports.UI.XRRichText();
            this.txtAddress2 = new DevExpress.XtraReports.UI.XRRichText();
            this.label19 = new DevExpress.XtraReports.UI.XRLabel();
            this.richText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.label12 = new DevExpress.XtraReports.UI.XRLabel();
            this.label11 = new DevExpress.XtraReports.UI.XRLabel();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.label13 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDestination = new DevExpress.XtraReports.UI.XRRichText();
            this.txtHostInfo = new DevExpress.XtraReports.UI.XRRichText();
            this.txtGender = new DevExpress.XtraReports.UI.XRRichText();
            this.txtDates = new DevExpress.XtraReports.UI.XRRichText();
            this.txtBDate = new DevExpress.XtraReports.UI.XRRichText();
            this.txtPassportN = new DevExpress.XtraReports.UI.XRRichText();
            this.txtFax = new DevExpress.XtraReports.UI.XRRichText();
            this.txtEMail = new DevExpress.XtraReports.UI.XRRichText();
            this.txtNationality = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTel = new DevExpress.XtraReports.UI.XRRichText();
            this.txtAddress = new DevExpress.XtraReports.UI.XRRichText();
            this.txtLName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtFName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTransportType = new DevExpress.XtraReports.UI.XRRichText();
            this.label14 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtName = new DevExpress.XtraReports.UI.XRRichText();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsSent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassportN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.txtHostName,
            this.xrLabel5,
            this.txtVisitorStatus,
            this.txtProjectName,
            this.txtVisitGoal,
            this.txtIsSent,
            this.txtLDate,
            this.txtFDate,
            this.txtPartner,
            this.txtAddInfo,
            this.xrRichText5,
            this.xrRichText1,
            this.xrRichText2,
            this.xrRichText3,
            this.xrRichText4,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.label16,
            this.label15,
            this.label18,
            this.label17,
            this.txtLName2,
            this.txtTel2,
            this.txtAddress2,
            this.label19,
            this.richText1,
            this.label12,
            this.label11,
            this.label10,
            this.label9,
            this.label8,
            this.label7,
            this.label6,
            this.label5,
            this.label4,
            this.label3,
            this.label2,
            this.label1,
            this.label13,
            this.txtDestination,
            this.txtHostInfo,
            this.txtGender,
            this.txtDates,
            this.txtBDate,
            this.txtPassportN,
            this.txtFax,
            this.txtEMail,
            this.txtNationality,
            this.txtTel,
            this.txtAddress,
            this.txtLName,
            this.txtFName,
            this.txtTransportType,
            this.label14});
            this.Detail.HeightF = 838.5417F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(6.875006F, 148.1667F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.xrLabel6.Text = "ფაქსი:";
            // 
            // txtHostName
            // 
            this.txtHostName.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 348.5417F);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.SerializableRtfString = resources.GetString("txtHostName.SerializableRtfString");
            this.txtHostName.SizeF = new System.Drawing.SizeF(348.7083F, 19F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(9.000047F, 169.1667F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.xrLabel5.Text = "ელ-ფოსტა:";
            // 
            // txtVisitorStatus
            // 
            this.txtVisitorStatus.LocationFloat = new DevExpress.Utils.PointFloat(294.375F, 555.2291F);
            this.txtVisitorStatus.Name = "txtVisitorStatus";
            this.txtVisitorStatus.SerializableRtfString = resources.GetString("txtVisitorStatus.SerializableRtfString");
            this.txtVisitorStatus.SizeF = new System.Drawing.SizeF(287.5F, 23.00001F);
            // 
            // txtProjectName
            // 
            this.txtProjectName.LocationFloat = new DevExpress.Utils.PointFloat(294.375F, 580.229F);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.SerializableRtfString = resources.GetString("txtProjectName.SerializableRtfString");
            this.txtProjectName.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtVisitGoal
            // 
            this.txtVisitGoal.LocationFloat = new DevExpress.Utils.PointFloat(294.375F, 605.2291F);
            this.txtVisitGoal.Name = "txtVisitGoal";
            this.txtVisitGoal.SerializableRtfString = resources.GetString("txtVisitGoal.SerializableRtfString");
            this.txtVisitGoal.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtIsSent
            // 
            this.txtIsSent.LocationFloat = new DevExpress.Utils.PointFloat(294.375F, 704.2291F);
            this.txtIsSent.Name = "txtIsSent";
            this.txtIsSent.SerializableRtfString = resources.GetString("txtIsSent.SerializableRtfString");
            this.txtIsSent.SizeF = new System.Drawing.SizeF(320.8333F, 23F);
            // 
            // txtLDate
            // 
            this.txtLDate.LocationFloat = new DevExpress.Utils.PointFloat(294.375F, 654.2291F);
            this.txtLDate.Name = "txtLDate";
            this.txtLDate.SerializableRtfString = resources.GetString("txtLDate.SerializableRtfString");
            this.txtLDate.SizeF = new System.Drawing.SizeF(287.5F, 23.00002F);
            // 
            // txtFDate
            // 
            this.txtFDate.LocationFloat = new DevExpress.Utils.PointFloat(294.375F, 629.2291F);
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.SerializableRtfString = resources.GetString("txtFDate.SerializableRtfString");
            this.txtFDate.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtPartner
            // 
            this.txtPartner.LocationFloat = new DevExpress.Utils.PointFloat(294.3751F, 679.2291F);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.SerializableRtfString = resources.GetString("txtPartner.SerializableRtfString");
            this.txtPartner.SizeF = new System.Drawing.SizeF(344.7916F, 22.99997F);
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.LocationFloat = new DevExpress.Utils.PointFloat(294.3751F, 780.8542F);
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.SerializableRtfString = resources.GetString("txtAddInfo.SerializableRtfString");
            this.txtAddInfo.SizeF = new System.Drawing.SizeF(320.8333F, 23F);
            // 
            // xrRichText5
            // 
            this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(6.750043F, 780.8542F);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // xrRichText1
            // 
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(6.750107F, 676.6041F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // xrRichText2
            // 
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(6.750043F, 700.6042F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(287.625F, 79.25F);
            // 
            // xrRichText3
            // 
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(6.75017F, 628.4791F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // xrRichText4
            // 
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(6.750107F, 652.6042F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(287.5F, 23.00001F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 464.7709F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(144.9583F, 23.00003F);
            this.xrLabel1.Text = "მისამართი";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 488.7709F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(145.8333F, 23.00002F);
            this.xrLabel2.Text = "ტელეფონი:";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(287.1251F, 416.6458F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(145.8333F, 23F);
            this.xrLabel3.Text = "სახელი:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 440.7708F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(145.8333F, 23F);
            this.xrLabel4.Text = "გვარი:";
            // 
            // label16
            // 
            this.label16.LocationFloat = new DevExpress.Utils.PointFloat(6.750107F, 440.7709F);
            this.label16.Name = "label16";
            this.label16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label16.SizeF = new System.Drawing.SizeF(145.8333F, 23F);
            this.label16.Text = "გვარი:";
            // 
            // label15
            // 
            this.label15.LocationFloat = new DevExpress.Utils.PointFloat(6.875006F, 416.6458F);
            this.label15.Name = "label15";
            this.label15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label15.SizeF = new System.Drawing.SizeF(145.8333F, 23F);
            this.label15.Text = "სახელი:";
            // 
            // label18
            // 
            this.label18.LocationFloat = new DevExpress.Utils.PointFloat(6.750107F, 488.7709F);
            this.label18.Name = "label18";
            this.label18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label18.SizeF = new System.Drawing.SizeF(145.8333F, 23.00002F);
            this.label18.Text = "ტელეფონი:";
            // 
            // label17
            // 
            this.label17.LocationFloat = new DevExpress.Utils.PointFloat(6.750107F, 464.7709F);
            this.label17.Name = "label17";
            this.label17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label17.SizeF = new System.Drawing.SizeF(144.9583F, 23.00003F);
            this.label17.Text = "მისამართი";
            // 
            // txtLName2
            // 
            this.txtLName2.LocationFloat = new DevExpress.Utils.PointFloat(6.874943F, 556.3541F);
            this.txtLName2.Name = "txtLName2";
            this.txtLName2.SerializableRtfString = resources.GetString("txtLName2.SerializableRtfString");
            this.txtLName2.SizeF = new System.Drawing.SizeF(287.5F, 23.00001F);
            // 
            // txtTel2
            // 
            this.txtTel2.LocationFloat = new DevExpress.Utils.PointFloat(6.874911F, 604.3542F);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.SerializableRtfString = resources.GetString("txtTel2.SerializableRtfString");
            this.txtTel2.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtAddress2
            // 
            this.txtAddress2.LocationFloat = new DevExpress.Utils.PointFloat(6.874943F, 580.3541F);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.SerializableRtfString = resources.GetString("txtAddress2.SerializableRtfString");
            this.txtAddress2.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // label19
            // 
            this.label19.LocationFloat = new DevExpress.Utils.PointFloat(147.5417F, 520.7709F);
            this.label19.Name = "label19";
            this.label19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label19.SizeF = new System.Drawing.SizeF(251.4583F, 23F);
            this.label19.Text = "განსახორციელებელი პროექტი";
            // 
            // richText1
            // 
            this.richText1.LocationFloat = new DevExpress.Utils.PointFloat(6.750043F, 0F);
            this.richText1.Name = "richText1";
            this.richText1.SerializableRtfString = resources.GetString("richText1.SerializableRtfString");
            this.richText1.SizeF = new System.Drawing.SizeF(98.95833F, 25.08333F);
            // 
            // label12
            // 
            this.label12.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 348.5417F);
            this.label12.Name = "label12";
            this.label12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label12.SizeF = new System.Drawing.SizeF(223.9583F, 21F);
            this.label12.Text = "მასპინძლის სახელი, გვარი:";
            // 
            // label11
            // 
            this.label11.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 325.5416F);
            this.label11.Name = "label11";
            this.label11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label11.SizeF = new System.Drawing.SizeF(223.9583F, 20F);
            this.label11.Text = "დანიშნულების ადგილი:";
            // 
            // label10
            // 
            this.label10.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 233.1667F);
            this.label10.Name = "label10";
            this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label10.SizeF = new System.Drawing.SizeF(148.9583F, 21F);
            this.label10.Text = "დაბადების თარიღი:";
            // 
            // label9
            // 
            this.label9.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 256.5417F);
            this.label9.Name = "label9";
            this.label9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label9.SizeF = new System.Drawing.SizeF(148.9583F, 18.99997F);
            this.label9.Text = "სქესი:";
            // 
            // label8
            // 
            this.label8.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 279.5417F);
            this.label8.Name = "label8";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label8.SizeF = new System.Drawing.SizeF(148.9583F, 21F);
            this.label8.Text = "დროის შუალედი:";
            // 
            // label7
            // 
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 304.5417F);
            this.label7.Name = "label7";
            this.label7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label7.SizeF = new System.Drawing.SizeF(148.9583F, 20F);
            this.label7.Text = "ტრანსპორტის სახე:";
            // 
            // label6
            // 
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(6.750043F, 121.1667F);
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label6.SizeF = new System.Drawing.SizeF(145.8333F, 23.00002F);
            this.label6.Text = "ტელეფონი:";
            // 
            // label5
            // 
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 189.1667F);
            this.label5.Name = "label5";
            this.label5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label5.SizeF = new System.Drawing.SizeF(145.8333F, 19F);
            this.label5.Text = "პასპორტის ნომერი:";
            // 
            // label4
            // 
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 209.1667F);
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label4.SizeF = new System.Drawing.SizeF(145.8333F, 21F);
            this.label4.Text = "მოქალაქეობა:";
            // 
            // label3
            // 
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(6.750043F, 97.16673F);
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(144.9583F, 23.00003F);
            this.label3.Text = "მისამართი";
            // 
            // label2
            // 
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(6.750043F, 72.1666F);
            this.label2.Name = "label2";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label2.SizeF = new System.Drawing.SizeF(145.8333F, 23F);
            this.label2.Text = "გვარი:";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6.750043F, 47.16673F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(145.8333F, 23F);
            this.label1.Text = "სახელი:";
            // 
            // label13
            // 
            this.label13.LocationFloat = new DevExpress.Utils.PointFloat(9.875043F, 369.5417F);
            this.label13.Name = "label13";
            this.label13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label13.SizeF = new System.Drawing.SizeF(244.7917F, 22.99997F);
            this.label13.Text = "მასპინძლის საკონტაქტო ინფორმაცია:";
            // 
            // txtDestination
            // 
            this.txtDestination.LocationFloat = new DevExpress.Utils.PointFloat(287.1251F, 325.5416F);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.SerializableRtfString = resources.GetString("txtDestination.SerializableRtfString");
            this.txtDestination.SizeF = new System.Drawing.SizeF(348.7083F, 21F);
            // 
            // txtHostInfo
            // 
            this.txtHostInfo.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 369.5417F);
            this.txtHostInfo.Name = "txtHostInfo";
            this.txtHostInfo.SerializableRtfString = resources.GetString("txtHostInfo.SerializableRtfString");
            this.txtHostInfo.SizeF = new System.Drawing.SizeF(348.7083F, 18F);
            // 
            // txtGender
            // 
            this.txtGender.LocationFloat = new DevExpress.Utils.PointFloat(287.1251F, 256.5417F);
            this.txtGender.Name = "txtGender";
            this.txtGender.SerializableRtfString = resources.GetString("txtGender.SerializableRtfString");
            this.txtGender.SizeF = new System.Drawing.SizeF(320.8333F, 21F);
            // 
            // txtDates
            // 
            this.txtDates.LocationFloat = new DevExpress.Utils.PointFloat(287.1251F, 279.5417F);
            this.txtDates.Name = "txtDates";
            this.txtDates.SerializableRtfString = resources.GetString("txtDates.SerializableRtfString");
            this.txtDates.SizeF = new System.Drawing.SizeF(335.1666F, 22F);
            // 
            // txtBDate
            // 
            this.txtBDate.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 233.1667F);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.SerializableRtfString = resources.GetString("txtBDate.SerializableRtfString");
            this.txtBDate.SizeF = new System.Drawing.SizeF(344.7916F, 21F);
            // 
            // txtPassportN
            // 
            this.txtPassportN.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 189.1667F);
            this.txtPassportN.Name = "txtPassportN";
            this.txtPassportN.SerializableRtfString = resources.GetString("txtPassportN.SerializableRtfString");
            this.txtPassportN.SizeF = new System.Drawing.SizeF(344.7916F, 18.99997F);
            // 
            // txtFax
            // 
            this.txtFax.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 144.1667F);
            this.txtFax.Name = "txtFax";
            this.txtFax.SerializableRtfString = resources.GetString("txtFax.SerializableRtfString");
            this.txtFax.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtEMail
            // 
            this.txtEMail.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 167.1667F);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.SerializableRtfString = resources.GetString("txtEMail.SerializableRtfString");
            this.txtEMail.SizeF = new System.Drawing.SizeF(287.5F, 21.00002F);
            // 
            // txtNationality
            // 
            this.txtNationality.LocationFloat = new DevExpress.Utils.PointFloat(287.1251F, 210.1667F);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.SerializableRtfString = resources.GetString("txtNationality.SerializableRtfString");
            this.txtNationality.SizeF = new System.Drawing.SizeF(320.8333F, 21F);
            // 
            // txtTel
            // 
            this.txtTel.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 120.1668F);
            this.txtTel.Name = "txtTel";
            this.txtTel.SerializableRtfString = resources.GetString("txtTel.SerializableRtfString");
            this.txtTel.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtAddress
            // 
            this.txtAddress.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 95.1666F);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.SerializableRtfString = resources.GetString("txtAddress.SerializableRtfString");
            this.txtAddress.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtLName
            // 
            this.txtLName.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 70.16673F);
            this.txtLName.Name = "txtLName";
            this.txtLName.SerializableRtfString = resources.GetString("txtLName.SerializableRtfString");
            this.txtLName.SizeF = new System.Drawing.SizeF(287.5F, 23.00001F);
            // 
            // txtFName
            // 
            this.txtFName.LocationFloat = new DevExpress.Utils.PointFloat(287.0002F, 47.16673F);
            this.txtFName.Name = "txtFName";
            this.txtFName.SerializableRtfString = resources.GetString("txtFName.SerializableRtfString");
            this.txtFName.SizeF = new System.Drawing.SizeF(287.5F, 23F);
            // 
            // txtTransportType
            // 
            this.txtTransportType.LocationFloat = new DevExpress.Utils.PointFloat(287.1251F, 304.5417F);
            this.txtTransportType.Name = "txtTransportType";
            this.txtTransportType.SerializableRtfString = resources.GetString("txtTransportType.SerializableRtfString");
            this.txtTransportType.SizeF = new System.Drawing.SizeF(348.7083F, 20F);
            // 
            // label14
            // 
            this.label14.LocationFloat = new DevExpress.Utils.PointFloat(147.5417F, 393.0834F);
            this.label14.Name = "label14";
            this.label14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label14.SizeF = new System.Drawing.SizeF(322.0417F, 22.99994F);
            this.label14.Text = "გადაუდებელ შემთხვევაში საკონტაქტო პირი";
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
            this.txtName.LocationFloat = new DevExpress.Utils.PointFloat(72.54172F, 38.54167F);
            this.txtName.Name = "txtName";
            this.txtName.SerializableRtfString = resources.GetString("txtName.SerializableRtfString");
            this.txtName.SizeF = new System.Drawing.SizeF(474.7499F, 23F);
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // rptNotification
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.txtHostName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsSent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassportN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
