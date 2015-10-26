<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="NotifForm1.aspx.cs" Inherits="SMR.Notifications.NotifForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <script>
        $(function () {
            $(".nav-tabs a").click(function () {
                $("#hfNotifyType").val($(this).data("value"));
                $(".nav-tabs a").parent().removeClass("active");
                $(this).parent().addClass("active");

                var tabClass = $(this).parent().parent().data("tabclass");
                var id = $(this).attr("href");

                $(tabClass).addClass("hidden");
                $(id).removeClass("hidden");

                return false;
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="col-xs-12" style="margin-top: 30px;">
            <ul class="nav nav-tabs" data-tabclass=".notifgroup">
                <li role="presentation" class="active"><a href="#groupnotif1" data-value="2">სანოტიფიკაციო ფორმა 1</a></li>
                <li role="presentation"><a href="#groupnotif2" data-value="3">სანოტიფიკაციო ფორმა 2</a></li>
                <li role="presentation"><a href="#groupnotif3" data-value="4">სანოტიფიკაციო ფორმა 3</a></li>
            </ul>
            <asp:HiddenField runat="server" ID ="hfNotifyType" ClientIDMode="Static" value="2"/>
            <div id="groupnotif1" class="notifgroup">
                <h4><%=Core.Properties.Resources.preface1%></h4>
                <h5><%=Core.Properties.Resources.GeneralInformation %></h5>

                <div class="form-group ">
                    <label for="txtOrgName"><%=Core.Properties.Resources.OrganizationName%></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrgName" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqOrgName" ControlToValidate="txtOrgName" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group ">
                    <label for="txtAddress"><%=Core.Properties.Resources.Address%></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqAddress" ControlToValidate="txtAddress" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group ">
                    <label for="txtMobile"><%=Core.Properties.Resources.Telephone%></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqMobile" ControlToValidate="txtMobile" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group ">
                    <label for="txtEmail"><%=Core.Properties.Resources.Email%></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqEmail" ControlToValidate="txtEmail" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtWebPage"><%=Core.Properties.Resources.WebPage %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtWebPage" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqWebPage" ControlToValidate="txtWebPage" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="fuURL"><%=Core.Properties.Resources.ApplicableUpload %>)</label>
                    <asp:FileUpload runat="server" ID="fuURL" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;"><%=Core.Properties.Resources.fileextensions %></p>
                    <asp:RequiredFieldValidator runat="server" ID="reqAppUpload" ControlToValidate="fuURL" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <p class="text-danger">
                        <asp:Literal ID="litUrl" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="hfURL" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="reqfuURL" ControlToValidate="fuURL" Display="Dynamic" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtMissionDesc"><%=Core.Properties.Resources.MissionDesc %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtMissionDesc" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqMissionDesc" ControlToValidate="txtMissionDesc" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtContact"><%=Core.Properties.Resources.ContactForm1 %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtContact" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqContactForm1" ControlToValidate="txtContact" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <h4><%=Core.Properties.Resources.HumInfo %></h4>

                <div class="form-group">
                    <label for="txtDesc1"><%=Core.Properties.Resources.HumDesc %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDesc1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqHumDesc" ControlToValidate="txtDesc1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtDesc2"><%=Core.Properties.Resources.HumType %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDesc2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqHumType" ControlToValidate="txtDesc2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtNumber"><%=Core.Properties.Resources.HumQuantity %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtNumber" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqHumQuantity" ControlToValidate="txtNumber" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtDonors"><%=Core.Properties.Resources.Donor_s_ %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonors" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqDonors" ControlToValidate="txtDonors" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtTerms"><%=Core.Properties.Resources.EmerHum %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTerms" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqTerms" ControlToValidate="txtTerms" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>


                <div class="form-group">
                    <label for="txtProportions"><%=Core.Properties.Resources.HumDirection %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProportions" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqDireqtions" ControlToValidate="txtProportions" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="fuURLNote"><%=Core.Properties.Resources.AddInfo %></label>
                    <asp:FileUpload runat="server" ID="fuURLNote" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;"><%=Core.Properties.Resources.fileextensions %></p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal1" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField1" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="reqAddInfo" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
                </div>                
            </div>

            <div id="groupnotif2" class="notifgroup hidden">
                <h3><%=Core.Properties.Resources.NotifForm2Desc %></h3>
                <h4><%=Core.Properties.Resources.GeneralInformation %></h4>
                <div class="form-group">
                    <label for="txtOrgName1"><%=Core.Properties.Resources.OrganizationName %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrgName1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqOrgName1" ControlToValidate="txtOrgName1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtAddress1"><%=Core.Properties.Resources.Address %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqAddress1" ControlToValidate="txtAddress1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtMobile1"><%=Core.Properties.Resources.Telephone %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqMobile1" ControlToValidate="txtMobile1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtEmail1"><%=Core.Properties.Resources.Email %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqEmail2" ControlToValidate="txtEmail1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtWebPage1"><%=Core.Properties.Resources.WebPage %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtWebPage1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqWebPage2" ControlToValidate="txtWebPage1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtMissionDesc1"><%=Core.Properties.Resources.MissionDesc%></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtMissionDesc1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqMissionDesc2" ControlToValidate="txtMissionDesc1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtContact1"><%=Core.Properties.Resources.ContactForm1%></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtContact1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqContact2" ControlToValidate="txtContact1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <h4><%=Core.Properties.Resources.InformationProjects %></h4>

                <div class="form-group">
                    <label for="txtProjectTitle"><%=Core.Properties.Resources.ProjectName%></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectTitle" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectTitle" ControlToValidate="txtProjectTitle" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectStatus"><%=Core.Properties.Resources.StatusOfProject %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectStatus" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectStatus" ControlToValidate="txtProjectStatus" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtDonors1"><%=Core.Properties.Resources.DonorsForm2 %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonors1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqDonors2" ControlToValidate="txtDonors1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectGoal1"><%=Core.Properties.Resources.AimOfProject %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectGoal1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectGoal2" ControlToValidate="txtProjectGoal1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectResults1"><%=Core.Properties.Resources.ExpectedResults%></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectResults1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectResults2" ControlToValidate="txtProjectResults1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectFDate"><%=Core.Properties.Resources.FDate%></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtProjectFDate" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectFDate" ControlToValidate="txtProjectFDate" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectLDate"><%=Core.Properties.Resources.LDate%></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtProjectLDate" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectLDate" ControlToValidate="txtProjectLDate" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="fuURLNote1"><%=Core.Properties.Resources.AddInfo%></label>
                    <asp:FileUpload runat="server" ID="fuURLNote1" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;"><%=Core.Properties.Resources.fileextensions%></p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal2" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField2" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>

                </div>
            </div>
           
            <div id="groupnotif3" class="notifgroup hidden">
                <h4><%=Core.Properties.Resources.DescForm3 %></h4>
                <h5><%=Core.Properties.Resources.GeneralInformation %></h5>

                <div class="form-group">
                    <label for="txtOrgName2"><%=Core.Properties.Resources.OrganizationName %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrgName2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqOrgName2" ControlToValidate="txtOrgName2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="txtDonors3"><%=Core.Properties.Resources.DonorsForm3 %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtDonors3" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqDonors3" ControlToValidate="txtDonors3" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtAddress2"><%=Core.Properties.Resources.Address %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqAddress3" ControlToValidate="txtAddress2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtMobile2"><%=Core.Properties.Resources.Telephone %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqMobile3" ControlToValidate="txtMobile2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtEmail2"><%=Core.Properties.Resources.Email %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqEmail3" ControlToValidate="txtEmail2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtWebPage2"><%=Core.Properties.Resources.WebPage %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtWebPage2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqWebPage3" ControlToValidate="txtWebPage2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="fuURL2"><%=Core.Properties.Resources.ApplicableUpload %></label>
                    <asp:FileUpload runat="server" ID="fuURL2" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;"><%=Core.Properties.Resources.fileextensions %></p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal3" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField3" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtMission2"><%=Core.Properties.Resources.MissionDesc %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtMission2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqMissionDesc3" ControlToValidate="txtMission2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtIsActive2"><%=Core.Properties.Resources.StatusOfProject %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtIsActive2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqStatusOfProject3" ControlToValidate="txtIsActive2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtContactInfo2"><%=Core.Properties.Resources.ContactForm1 %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtContactInfo2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqContacts3" ControlToValidate="txtContactInfo2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <h4><%=Core.Properties.Resources.InformationProjects %></h4>

                <div class="form-group">
                    <label for="txtProjectTitle2"><%=Core.Properties.Resources.ProjectName %></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectTitle2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectTitle3" ControlToValidate="txtProjectTitle2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectStatus2"><%=Core.Properties.Resources.StatusOfProject %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectStatus2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqStatus3" ControlToValidate="txtProjectStatus2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtDonorContacts"><%=Core.Properties.Resources.DonorsForm2 %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonorContacts" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqDonorsContacts3" ControlToValidate="txtDonorContacts" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectGoal2"><%=Core.Properties.Resources.Projectpurpose %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectGoal2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectGoal3" ControlToValidate="txtProjectGoal2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectResults2"><%=Core.Properties.Resources.ExpectedResults %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectResults2" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqProjectResults3" ControlToValidate="txtProjectResults2" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectFDate1"><%=Core.Properties.Resources.FDate %></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtProjectFDate1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqFDate3" ControlToValidate="txtProjectFDate1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtProjectLDate1"><%=Core.Properties.Resources.LDate %></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtProjectLDate1" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqLDate3" ControlToValidate="txtProjectLDate1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtFinanceInfo"><%=Core.Properties.Resources.FinanceInfo %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtFinanceInfo" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqFinanceInfo" ControlToValidate="txtFinanceInfo" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtPartnerInfo"><%=Core.Properties.Resources.LocalPartner %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtPartnerInfo" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqPartnerInfo" ControlToValidate="txtPartnerInfo" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="txtDepart"><%=Core.Properties.Resources.Schedule %></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDepart" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqSchedule" ControlToValidate="txtDepart" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="fuURLNote2"><%=Core.Properties.Resources.AddInfo %></label>
                    <asp:FileUpload runat="server" ID="fuURLNote2" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;"><%=Core.Properties.Resources.fileextensions%></p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal4" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField4" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
                </div>
            </div>

             <div class="col-xs-12" style="margin: 20px 0;">
                 <asp:Button runat="server"  CssClass="btn btn-block btn-success" ID="btnAddnew" OnClick="btnSend_Click"   />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
     <asp:Literal runat="server" ID="litScripts"></asp:Literal>
</asp:Content>
