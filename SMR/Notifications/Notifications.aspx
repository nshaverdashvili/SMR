<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="Notifications.aspx.cs" Inherits="SMR.Notifications.Notifications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row">
            <div class="form-group">
                <h3>ნოტიფიკაცია ოკუპირებულ ტერიტორიებზე შესვლის თაობაზე</h3>
                <p>
                    საქართველოში მომუშავე და ოკუპირებული რეგიონების მონახულების მსურველმა პირებმა საჭიროა შეავსონ ქვემდებარე ფორმა. სანოტიფიკაციო ფორმა არ აკისრებს სახელმწიფო მინისტრის აპარატს რაიმე პასუხისმგებლობას და არ წარმოადგენს ოკუპირებული რეგიონების მონახულების ნებართვას. სანოტიფიკაციო ფორმა არის მხოლოდ ინფორმაციული ხასიათის. საერთაშორისო ჟურნალისტების მიერ მედიააკრედიტაციის მიღების მიზნით გთხოვთ დაუკავშირდეთ საქართველოს საგარეო საქმეთა სამინისტროს ან გადახვიდეთ ამ ბმულზე http://www.mfa.gov.ge
                </p>
            </div>
        </div>

        <div class="row form">
            <h4><%=Core.Properties.Resources.PersonalInformation%></h4>
            <div class="form-group">
                <label for="fuURL"><%=Core.Properties.Resources.UploadPhoto%></label>
                <asp:FileUpload runat="server" ID="fuURL" ClientIDMode="Static" />
                <p class="help-block" style="font-size: 10px;"><%=Core.Properties.Resources.fileextensions %></p>
                <p class="text-danger">
                    <asp:Literal ID="litUrl" runat="server" />
                </p>
                <asp:HiddenField runat="server" ID="hfURL" ClientIDMode="Static" />
                <asp:RequiredFieldValidator runat="server" ID="valfuURL" ControlToValidate="fuURL" Display="Dynamic"
                    CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>

            </div>

            <div class="form-group">
                <label for="txtFName"><%=Core.Properties.Resources.FirstName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFName" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqFname" ControlToValidate="txtFName" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtLName"><%=Core.Properties.Resources.LastName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtLName" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqLname" ControlToValidate="txtLName" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtAddress"><%=Core.Properties.Resources.Address%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqAddress" ControlToValidate="txtAddress" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtMobile"><%=Core.Properties.Resources.Telephone%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqMobile" ControlToValidate="txtMobile" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtFax"><%=Core.Properties.Resources.Fax%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFax" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqFax" ControlToValidate="txtFax" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtEmail"><%=Core.Properties.Resources.Email%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqEmail" ControlToValidate="txtEmail" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtPassportN"><%=Core.Properties.Resources.PassportNumber%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtPassportN" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqPassportN" ControlToValidate="txtPassportN" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtNationality"><%=Core.Properties.Resources.Nationality%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNationality" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqNationality" ControlToValidate="txtNationality" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtBDate"><%=Core.Properties.Resources.Dateofbirth%></label>
                <asp:TextBox runat="server" CssClass="form-control ical" ID="txtBDate" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqBDate" ControlToValidate="txtBDate" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="ddGender"><%=Core.Properties.Resources.Gender%></label>
                <asp:DropDownList runat="server" ID="ddGender" DataSourceID="dsGender" DataTextField="Caption" DataValueField="DictionaryID" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ID="reqGender" ControlToValidate="ddGender" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
            <h5><%=Core.Properties.Resources.Timeline%></h5>
            <div class="col-xs-6">
                <div class="form-group">
                    <label for="txtFDates"><%=Core.Properties.Resources.From%></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtFDates" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqFDate" ControlToValidate="txtFDates" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-xs-6">
                <div class="form-group">
                    <label for="txtLDate"><%=Core.Properties.Resources.To%></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtLDate" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqLDate" ControlToValidate="txtLDate" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="ddOrganisator"><%=Core.Properties.Resources.VisitOrganizedby%></label>
                <asp:DropDownList runat="server" ID="ddOrganisator" DataSourceID="dsVisitOrganisedBy" DataTextField="Caption" DataValueField="DictionaryID" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="ddTransportType"><%=Core.Properties.Resources.Vehicletype%></label>
                <asp:DropDownList runat="server" ID="ddTransportType" DataSourceID="dsVehicletype" DataTextField="Caption" DataValueField="DictionaryID" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="txtDestination"><%=Core.Properties.Resources.Destinationplace%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtDestination" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqDestination" ControlToValidate="txtDestination" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtHostName"><%=Core.Properties.Resources.HostsName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtHostName" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqHostName" ControlToValidate="txtHostName" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtHostContact"><%=Core.Properties.Resources.HostContact%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtHostContact" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqHostContact" ControlToValidate="txtHostContact" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <h4><%=Core.Properties.Resources.Emergency_Contacts%></h4>
            <div class="form-group">
                <label for="txtFName1"><%=Core.Properties.Resources.FirstName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFName1" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqFName1" ControlToValidate="txtFName1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtLName1"><%=Core.Properties.Resources.LastName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtLName1" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqLName1" ControlToValidate="txtLName1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtAddress1"><%=Core.Properties.Resources.Address%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress1" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqAddress1" ControlToValidate="txtAddress1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtMobile1"><%=Core.Properties.Resources.Telephone%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile1" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqMobile1" ControlToValidate="txtMobile1" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <h4><%=Core.Properties.Resources.ProjectImplemented%></h4>

            <div class="form-group">
                <label for="txtProject"><%=Core.Properties.Resources.ProjectImplemented%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProject" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqProject" ControlToValidate="txtProject" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtProjectStatus"><%=Core.Properties.Resources.Statusofthevisitor%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectStatus" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqProjectStatus" ControlToValidate="txtProjectStatus" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtProjectName"><%=Core.Properties.Resources.ProjectName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectName" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqProjectName" ControlToValidate="txtProjectName" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtProjectGoal"><%=Core.Properties.Resources.PurposeofVisit%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectGoal" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqProjectGoal" ControlToValidate="txtProjectGoal" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtProjectFDate"><%=Core.Properties.Resources.FDate%></label>
                <asp:TextBox runat="server" CssClass="form-control ical" ID="txtProjectFDate" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqProjectFDate" ControlToValidate="txtProjectFDate" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtProjectLDate"><%=Core.Properties.Resources.LDate%></label>
                <asp:TextBox runat="server" CssClass="form-control ical" ID="txtProjectLDate" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqProjectLDate" ControlToValidate="txtProjectLdate" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtLocalPartner"><%=Core.Properties.Resources.LocalPartner%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtLocalPartner" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqLocalPartner" ControlToValidate="txtLocalPartner" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="ddIsSent"><%=Core.Properties.Resources.IsSentProject%></label>
                <asp:DropDownList runat="server" ID="ddIsSent" DataSourceID="dsIsSent" DataTextField="Caption" DataValueField="DictionaryID" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ID="reqIsSent" ControlToValidate="ddIsSent" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtNote"><%=Core.Properties.Resources.Provideadditionalinformation%></label>
                <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtNote" ClientIDMode="Static"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqNote" ControlToValidate="txtNote" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

        </div>
        <div class="row">
            <div class="col-xs-12" style="margin: 20px 0;">
                
                <asp:Button runat="server" CssClass="btn btn-success btn-block" ID="btnSend" OnClick="btnSend_Click" />
            </div>
        </div>
    </div>
    <asp:ObjectDataSource ID="dsGender" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
            <asp:Parameter DefaultValue="5" Name="Code" Type="Int32" />
            <asp:Parameter Name="IsVisible" Type="Boolean" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="dsVisitOrganisedBy" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
            <asp:Parameter DefaultValue="6" Name="Code" Type="Int32" />
            <asp:Parameter Name="IsVisible" Type="Boolean" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="dsVehicletype" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
            <asp:Parameter DefaultValue="7" Name="Code" Type="Int32" />
            <asp:Parameter Name="IsVisible" Type="Boolean" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="dsIsSent" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
            <asp:Parameter DefaultValue="8" Name="Code" Type="Int32" />
            <asp:Parameter Name="IsVisible" Type="Boolean" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <h5><%=Core.Properties.Resources.FNote%></h5>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
