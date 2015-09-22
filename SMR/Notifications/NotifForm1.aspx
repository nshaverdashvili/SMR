<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="NotifForm1.aspx.cs" Inherits="SMR.Notifications.NotifForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="col-xs-12">


            <ul class="nav nav-tabs" data-tabclass=".notifgroup">
                <li role="presentation" class="active"><a href="#groupnotif1">სანოტიფიკაციო ფორმა 1</a></li>
                <li role="presentation"><a href="#groupnotif2">სანოტიფიკაციო ფორმა 2</a></li>
                <li role="presentation"><a href="#groupnotif3">სანოტიფიკაციო ფორმა 3</a></li>
            </ul>
            <div>
                <h4>საქართველოს ოკუპირებულ ტერიტორიებზე გადაუდებელი ჰუმანიტარული დახმარების წარმართვისათვის</h4>
                <h5>ზოგადი ინფორმაცია</h5>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtOrgName">ორგანიზაციის სახელი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrgName" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtAddress">მისამართი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtMobile">ტელეფონი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtEmail">ელ-ფოსტა</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtWebPage">ვებ გვერდი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtWebPage" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="fuURL">ინფორმაცია რეგისტრაციის შესახებ (რეგისტრაციის არსებობის შემთხვევაში)</label>
                    <asp:FileUpload runat="server" ID="fuURL" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
                    <p class="text-danger">
                        <asp:Literal ID="litUrl" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="hfURL" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="valfuURL" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>

                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtMissionDesc">ორგანიზაციის მისიის აღწერა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtMissionDesc" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtContact">საკონტაქტო პირი (სახელი, გვარი, ტელეფონი)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtContact" ClientIDMode="Static"></asp:TextBox>
                </div>

                <h4>ინფორმაცია გადაუდებელი ჰუმანიტარული დახმარების აუცილებლობის შესახებ</h4>

                ჰუმანიტარული მდგომარეობის აღწერა (რით არის გამოწვეული, რომელ გეოგრაფიულ არეალს მოიცავს ჰუმანიტარული მდგომარეობის მიერ გამოწვეული შედეგები)
 ჰუმანიტარული დახმარების აღწერა 
                s<div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtDesc1">ჰუმანიტარული მდგომარეობის აღწერა (რით არის გამოწვეული, რომელ გეოგრაფიულ არეალს მოიცავს ჰუმანიტარული მდგომარეობის მიერ გამოწვეული შედეგები)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDesc1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtDesc2">ჰუმანიტარული დახმარების აღწერა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDesc2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtNumber">ჰუმანიტარული დახმარების რაოდენობა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtNumber" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtDonors">დონორები</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonors" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtTerms">გადაუდებელი ჰუმანიტარული დახმარების გაცემის ვადა (ერთჯერადი, მრავალჯერადი)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTerms" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="txtProportions">გადაუდებელი ჰუმანიტარული დახმარების შეტანის მიმართულება და პროპორციები</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProportions" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif1">
                    <label for="fuURLNote">ინფორმაცია რეგისტრაციის შესახებ (რეგისტრაციის არსებობის შემთხვევაში)</label>
                    <asp:FileUpload runat="server" ID="FileUpload1" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal1" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField1" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>

                </div>
            </div>
            <div>
                <h4>სახელმწიფოთაშორისი ორგანიზაციებისა და საერთაშორისო განვითარების ორგანიზაციებისათვის, რომლებიც ახორციელებენ საქმიანობას ოკუპირებულ ტერიტორიებზე საქართველოს მთავრობასთან დადებული შეთანხმებების თანახმად</h4>
                <h5>ზოგადი ინფორმაცია</h5>
                <div class="form-group notifgroup hidden" id="groupnotif2">
                    <label for="txtOrgName">ორგანიზაციის სახელი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif2">
                    <label for="txtAddress">მისამართი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif2">
                    <label for="txtMobile">ტელეფონი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox3" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif2">
                    <label for="txtEmail">ელ-ფოსტა</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox4" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup" id="groupnotif2">
                    <label for="txtWebPage">ვებ გვერდი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox5" ClientIDMode="Static"></asp:TextBox>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
