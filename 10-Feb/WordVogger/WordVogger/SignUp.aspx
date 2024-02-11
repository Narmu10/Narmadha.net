<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WordVogger.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SIGN UP</title>
    <style type="text/css">
        #form1 {
            width: 1668px;
            margin-left: 0px;
        }
        body{
            background-image:url("https://plus.unsplash.com/premium_photo-1673480195911-3075a87738b0?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
           background-repeat: no-repeat;
background-size: cover;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 1048px">
        </div>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" Height="535px" OnCreatedUser="CreateUserWizard1_CreatedUser2" Width="633px" style="margin-left: 254px">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
            <StartNavigationTemplate>
                <asp:Button ID="StartNextButton" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CommandName="MoveNext" Font-Names="Verdana" ForeColor="#284E98" Text="Next" />
            </StartNavigationTemplate>
            <StepNavigationTemplate>
                <asp:Button ID="StepPreviousButton" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="MovePrevious" Font-Names="Verdana" ForeColor="#284E98" Text="Previous" />
                <asp:Button ID="StepNextButton" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CommandName="MoveNext" Font-Names="Verdana" ForeColor="#284E98" Text="Next" />
            </StepNavigationTemplate>
        </asp:CreateUserWizard>
    </form>
</body>
</html>
