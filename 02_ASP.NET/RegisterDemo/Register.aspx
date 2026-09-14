<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs"
    Inherits="RegisterDemo.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Register</title>
</head>

<body>

    <form id="form1" runat="server">

        <div>

            <h2>Register</h2>

            <!-- Name -->
            <asp:Label
                ID="lblName"
                runat="server"
                Text="Name">
            </asp:Label>

            <br />

            <asp:TextBox
                ID="Name"
                runat="server">
            </asp:TextBox>

            <br />

            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator2"
                runat="server"
                ControlToValidate="Name"
                ErrorMessage="Name is required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br /><br />


            <!-- Email -->
            <asp:Label
                ID="lblEmail"
                runat="server"
                Text="Email">
            </asp:Label>

            <br />

            <asp:TextBox
                ID="Email"
                runat="server">
            </asp:TextBox>

            <br />

            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator3"
                runat="server"
                ControlToValidate="Email"
                ErrorMessage="Email is required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br />

            <asp:RegularExpressionValidator
                ID="RegularExpressionValidator1"
                runat="server"
                ControlToValidate="Email"
                ErrorMessage="Enter a valid email address"
                ForeColor="Red"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
            </asp:RegularExpressionValidator>

            <br /><br />


            <!-- Password -->
            <asp:Label
                ID="lblPassword"
                runat="server"
                Text="Password">
            </asp:Label>

            <br />

            <asp:TextBox
                ID="txtPassword"
                runat="server"
                TextMode="Password">
            </asp:TextBox>

            <br />

            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator4"
                runat="server"
                ControlToValidate="txtPassword"
                ErrorMessage="Password is required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br /><br />


            <!-- Confirm Password -->
            <asp:Label
                ID="lblConfirmPassword"
                runat="server"
                Text="Confirm Password">
            </asp:Label>

            <br />

            <asp:TextBox
                ID="txtConfirmPassword"
                runat="server"
                TextMode="Password">
            </asp:TextBox>

            <br />

            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator5"
                runat="server"
                ControlToValidate="txtConfirmPassword"
                ErrorMessage="Confirm password is required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br />

            <asp:CompareValidator
                ID="CompareValidator1"
                runat="server"
                ControlToValidate="txtConfirmPassword"
                ControlToCompare="txtPassword"
                ErrorMessage="Passwords do not match"
                ForeColor="Red">
            </asp:CompareValidator>

            <br /><br />


            <!-- Register Button -->
            <asp:Button
                ID="btnRegister"
                runat="server"
                Text="Register"
                OnClick="btnRegister_Click" />

        </div>

    </form>

</body>

</html>