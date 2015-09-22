<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="NotifForm1.aspx.cs" Inherits="SMR.Notifications.NotifForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            $(".nav-tabs a").click(function () {

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
        <div class="col-xs-12">
            <ul class="nav nav-tabs" data-tabclass=".notifgroup">
                <li role="presentation" class="active"><a href="#groupnotif1">სანოტიფიკაციო ფორმა 1</a></li>
                <li role="presentation"><a href="#groupnotif2">სანოტიფიკაციო ფორმა 2</a></li>
                <li role="presentation"><a href="#groupnotif3">სანოტიფიკაციო ფორმა 3</a></li>
            </ul>
            <div id="groupnotif1">
                <h4>საქართველოს ოკუპირებულ ტერიტორიებზე გადაუდებელი ჰუმანიტარული დახმარების წარმართვისათვის</h4>
                <h5>ზოგადი ინფორმაცია</h5>

                <div class="form-group notifgroup">
                    <label for="txtOrgName">ორგანიზაციის სახელი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrgName" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtAddress">მისამართი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtMobile">ტელეფონი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtEmail">ელ-ფოსტა</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtWebPage">ვებ გვერდი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtWebPage" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
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

                <div class="form-group notifgroup">
                    <label for="txtMissionDesc">ორგანიზაციის მისიის აღწერა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtMissionDesc" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtContact">საკონტაქტო პირი (სახელი, გვარი, ტელეფონი)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtContact" ClientIDMode="Static"></asp:TextBox>
                </div>

                <h4>ინფორმაცია გადაუდებელი ჰუმანიტარული დახმარების აუცილებლობის შესახებ</h4>

                <div class="form-group notifgroup">
                    <label for="txtDesc1">ჰუმანიტარული მდგომარეობის აღწერა (რით არის გამოწვეული, რომელ გეოგრაფიულ არეალს მოიცავს ჰუმანიტარული მდგომარეობის მიერ გამოწვეული შედეგები)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDesc1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtDesc2">ჰუმანიტარული დახმარების აღწერა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDesc2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtNumber">ჰუმანიტარული დახმარების რაოდენობა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtNumber" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtDonors">დონორები</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonors" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtTerms">გადაუდებელი ჰუმანიტარული დახმარების გაცემის ვადა (ერთჯერადი, მრავალჯერადი)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTerms" ClientIDMode="Static"></asp:TextBox>
                </div>


                <div class="form-group notifgroup">
                    <label for="txtProportions">გადაუდებელი ჰუმანიტარული დახმარების შეტანის მიმართულება და პროპორციები</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProportions" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="fuURLNote">დამატებითი ინფორმაცია. დასაშვები</label>
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
            <div id="groupnotif2">
                <h4>სახელმწიფოთაშორისი ორგანიზაციებისა და საერთაშორისო განვითარების ორგანიზაციებისათვის, რომლებიც ახორციელებენ საქმიანობას ოკუპირებულ ტერიტორიებზე საქართველოს მთავრობასთან დადებული შეთანხმებების თანახმად</h4>
                <h5>ზოგადი ინფორმაცია</h5>
                <div class="form-group notifgroup">
                    <label for="txtOrgName1">ორგანიზაციის სახელი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrgName1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtAddress1">მისამართი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtMobile1">ტელეფონი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtEmail1">ელ-ფოსტა</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtWebPage1">ვებ გვერდი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtWebPage1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtMissionDesc1">ორგანიზაციის მისიის აღწერა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtMissionDesc1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtContact1">საკონტაქტო პირი (სახელი, გვარი, ტელეფონი)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtContact1" ClientIDMode="Static"></asp:TextBox>
                </div>
                <h4>ინფორმაცია განსახორციელებელი პროექტის შესახებ</h4>

                <div class="form-group notifgroup">
                    <label for="txtProjectTitle">პროექტის დასახელება</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectTitle" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtProjectStatus">პროექტის სტატუსი (მიმდინარე, იდეა, დაფინანსებული, გაგრძელებული)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectStatus" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtDonors1">დონორები (დასახელება და საკონტაქტო ინფორმაცია)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonors1" ClientIDMode="Static"></asp:TextBox>
                </div>
                პროექტის მიზანი
                <div class="form-group notifgroup">
                    <label for="txtProjectGoal1">პროექტის მიზანი</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectGoal1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtProjectResults1">პროექტის მოსალოდნელი შედეგები</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectResults1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtProjectFDate">დაწყების თარიღი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectFDate" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtProjectLDate">დასრულების თარიღი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectLDate" ClientIDMode="Static"></asp:TextBox>
                </div>
                <div class="form-group notifgroup">
                    <label for="fuURLNote1">დამატებითი ინფორმაცია. დასაშვები</label>
                    <asp:FileUpload runat="server" ID="FileUpload2" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal2" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField2" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>

                </div>
            </div>
            <div id="groupnotif3">
                <h4>ოკუპირებულ ტერიტორიებზე არასამეწარმეო საქმიანობის განხორციელებისათვის</h4>
                <h5>ზოგადი ინფორმაცია</h5>

                <div class="form-group notifgroup">
                    <label for="txtOrgName2">ორგანიზაციის სახელი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrgName2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtDonors2">პროექტი ერთობლივად არის წარდგენილი დონორისა და პროექტის წარმდგენელის მიერ (კი/არა). დადებითი პასუხის შემთხვევაში: დონორ(ებ)ის დასახელება</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonors2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtAddress2">მისამართი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtMobile2">ტელეფონი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMobile2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtEmail2">ელ-ფოსტა</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="txtWebPage2">ვებ გვერდი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtWebPage2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="fuURL2">ინფორმაცია რეგისტრაციის შესახებ (რეგისტრაციის არსებობის შემთხვევაში)</label>
                    <asp:FileUpload runat="server" ID="FileUpload3" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal3" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField3" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtMission2">ორგანიზაციის მისიის აღწერა</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtMission2" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtIsActive2">პროექტები (მიმდინარე/დასრულებული)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtIsActive2" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtContactInfo2">საკონტაქტო პირი (სახელი, გვარი, ტელეფონი)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtContactInfo2" ClientIDMode="Static"></asp:TextBox>
                </div>
                <h5>ინფორმაცია განსახორციელებელი პროექტის შესახებ</h5>
                
                <div class="form-group notifgroup">
                    <label for="txtProjectTitle2">პროექტის დასახელება</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectTitle2" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtProjectStatus2">პროექტის სტატუსი (მიმდინარე, იდეა, დაფინანსებული, გაგრძელებული)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectStatus2" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtDonorContacts">დონორები (დასახელება და საკონტაქტო ინფორმაცია)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDonorContacts" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtProjectGoal2">პროექტის მიზანი</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectGoal2" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtProjectResults2">პროექტის მოსალოდნელი შედეგები</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtProjectResults2" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtProjectFDate1">დაწყების თარიღი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtProjectFDate1" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtProjectLDate">დასრულების თარიღი</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox2" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtFinanceInfo">ფინანსური ინფორმაცია (მოსალოდნელი ბიუჯეტი, რესურსები, საბანკო ინფორმაცია)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtFinanceInfo" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtPartnerInfo">ინფორმაცია ადგილობრივი პარტნიორების შესახებ (დასახელება და საკონტაქტო ინფორმაცია)</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtPartnerInfo" ClientIDMode="Static"></asp:TextBox>
                </div>
                
                <div class="form-group notifgroup">
                    <label for="txtDepart">ოკუპირებულ ტერიტორიებზე გამგზავრების მოსალოდნელი განრიგი</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDepart" ClientIDMode="Static"></asp:TextBox>
                </div>

                <div class="form-group notifgroup">
                    <label for="fuURLNote2">დამატებითი ინფორმაცია. დასაშვები</label>
                    <asp:FileUpload runat="server" ID="FileUpload4" ClientIDMode="Static" />
                    <p class="help-block" style="font-size: 10px;">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
                    <p class="text-danger">
                        <asp:Literal ID="Literal4" runat="server" />
                    </p>
                    <asp:HiddenField runat="server" ID="HiddenField4" ClientIDMode="Static" />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="fuURL" Display="Dynamic"
                        ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
