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
                <p class="help-block" style="font-size: 10px;">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
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
            </div>

            <div class="form-group">
                <label for="txtAddress"><%=Core.Properties.Resources.Address%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtMobile"><%=Core.Properties.Resources.Telephone%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtFax"><%=Core.Properties.Resources.Fax%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFax" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtEmail"><%=Core.Properties.Resources.Email%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtPassportN"><%=Core.Properties.Resources.PassportNumber%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtPassportN" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtNationality"><%=Core.Properties.Resources.Nationality%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNationality" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtBDate"><%=Core.Properties.Resources.Dateofbirth%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtBDate" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="ddGender"><%=Core.Properties.Resources.Gender%></label>
                <asp:DropDownList runat="server" ID="ddGender" DataSourceID="dsGender" DataTextField="Caption" DataValueField="DictionaryID" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
            </div>
            <h5><%=Core.Properties.Resources.Timeline%></h5>
            <div class="col-xs-6">
                <div class="form-group">
                    <label for="txtFDates"><%=Core.Properties.Resources.From%></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtFDates" ClientIDMode="Static"></asp:TextBox>
                </div>
            </div>
            <div class="col-xs-6">
                <div class="form-group">
                    <label for="txtLDates"><%=Core.Properties.Resources.To%></label>
                    <asp:TextBox runat="server" CssClass="form-control ical" ID="txtLDates" ClientIDMode="Static"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="ddOrganisator"><%=Core.Properties.Resources.VisitOrganizedby%></label>
                <asp:DropDownList runat="server" ID="ddOrganisator" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="ddTransportType"><%=Core.Properties.Resources.Vehicletype%></label>
                <asp:DropDownList runat="server" ID="ddTransportType" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="txtDestination"><%=Core.Properties.Resources.Destinationplace%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtDestination" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtHostName"><%=Core.Properties.Resources.HostsName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtHostName" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtHostContact"><%=Core.Properties.Resources.HostContact%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtHostContact" ClientIDMode="Static"></asp:TextBox>
            </div>

            <h4><%=Core.Properties.Resources.EmergencyContacts%></h4>
            <div class="form-group">
                <label for="txtFName1"><%=Core.Properties.Resources.FirstName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFName1" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtLName1"><%=Core.Properties.Resources.LastName%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtLName1" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtAddress1"><%=Core.Properties.Resources.Address%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress1" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtMobile1"><%=Core.Properties.Resources.Telephone%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile1" ClientIDMode="Static"></asp:TextBox>
            </div>

            <h4>განსახორციელებელი პროექტი</h4>

            <div class="form-group">
                <label for="txtProject"><%=Core.Properties.Resources.ProjectImplemented%></label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProject" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtPropjectStatus">ვიზიტორის სტატუსი პროექტში</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtPropjectStatus" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtProjectName">პროექტის დასახელება</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectName" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtProjectGoal">პროექტის მიზანი</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectGoal" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtProjectFDate">დაწყების თარიღი</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectFDate" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtProjectLDate">დასრულების თარიღი</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectLDate" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtLocalPartner">ადგილობრივი პარტნიორი</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtLocalPartner" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="ddIsSent">გამოგზავნილია თუ არა სამინისტროში პროექტი ოკუპირებულ ტერიტორიაზე საქმიანობის წარმართვის წესების მიხედვით?</label>
                <asp:DropDownList runat="server" ID="ddIsSent" ClientIDMode="Static" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <div class="form-group descgroup" id="groupDescEN">
                <label for="txtNote">დამატებითი ინფორმაცია</label>
                <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtNote" ClientIDMode="Static"></asp:TextBox>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
