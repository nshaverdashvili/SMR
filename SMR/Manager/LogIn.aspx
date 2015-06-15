<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="SMR.Manager.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />

    <asp:Literal ID="litPlugins" runat="server"></asp:Literal>
    <link href="../Content/css/managerStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div class="container-fluid">
            <header>
                <div class="row">
                    <asp:LinkButton Text="Ge" runat="server" ID="btnGe" OnClick="btnLang_Click" />
                    | 
                    <asp:LinkButton Text="Ru" runat="server" ID="btnRu" OnClick="btnLang_Click" />
                        | 
                    <asp:LinkButton Text="En" runat="server" ID="btnEn" OnClick="btnLang_Click" />
                </div>
            </header>
            <div class="content login">
                <div class="row">
                    <div class="form-group">
                        <label for="txtUserName" class="col-sm-3 control-label"><%=Core.Properties.Resources.UserName  %></label>
                        <div class="col-sm-9">
                            <asp:TextBox runat="server" ID="txtUserName" ClientIDMode="Static" placeholder="Username" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="txtPassword" class="col-sm-3 control-label"><%=Core.Properties.Resources.Password  %></label>
                        <div class="col-sm-9">
                            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" ClientIDMode="Static" placeholder="Password" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <div class="checkbox">
                                <label>
                                    <asp:CheckBox Text="" runat="server" ID="chkRemember" />
                                    <%=Core.Properties.Resources.RememberMe%>
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <asp:Button runat="server" ID="btnLogin" class="btn btn-primary btn-block" OnClick="btnLogin_Click"/>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <p class="bg-danger">
                        <asp:Literal runat="server" ID="litErrorMessage" /></p>
                </div>
            </div>
        </div>
    </form>
    <footer></footer>
</body>
</html>
