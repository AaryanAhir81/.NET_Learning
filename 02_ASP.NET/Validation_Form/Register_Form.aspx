<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_Form.aspx.cs" Inherits="Validation_Form.Register_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Student Registration Form</h2>

        Name :
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="rfvName"
            runat="server"
            ControlToValidate="txtName"
            ErrorMessage="Enter Name"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <br /><br />

        Email :
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="rfvEmail"
            runat="server"
            ControlToValidate="txtEmail"
            ErrorMessage="Enter Email"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="revEmail"
            runat="server"
            ControlToValidate="txtEmail"
            ValidationExpression="\w+([-.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ErrorMessage="Invalid Email"
            ForeColor="Red">
        </asp:RegularExpressionValidator>

        <br /><br />

        Contact No :
        <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="rfvContact"
            runat="server"
            ControlToValidate="txtContact"
            ErrorMessage="Enter Contact Number"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="revContact"
            runat="server"
            ControlToValidate="txtContact"
            ValidationExpression="^[6-9]\d{9}$"
            ErrorMessage="Invalid Contact Number"
            ForeColor="Red">
        </asp:RegularExpressionValidator>

        <br /><br />

        Age :
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <asp:RangeValidator
            ID="rvAge"
            runat="server"
            ControlToValidate="txtAge"
            MinimumValue="18"
            MaximumValue="60"
            Type="Integer"
            ErrorMessage="Age must be between 18 and 60"
            ForeColor="Red">
        </asp:RangeValidator>

        <br /><br />

        Password :
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="rfvPassword"
            runat="server"
            ControlToValidate="txtPassword"
            ErrorMessage="Enter Password"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <br /><br />

        Confirm Password :
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator
            ID="cvPassword"
            runat="server"
            ControlToValidate="txtConfirmPassword"
            ControlToCompare="txtPassword"
            ErrorMessage="Password does not match"
            ForeColor="Red">
        </asp:CompareValidator>

        <br /><br />

        <asp:Button
            ID="btnSubmit"
            runat="server"
            Text="Register"
            OnClick="btnSubmit_Click" />

        <br /><br />

        <asp:ValidationSummary
            ID="ValidationSummary1"
            runat="server"
            HeaderText="Please correct the following errors:"
            ForeColor="Blue" />

    </form>
</body>
</html>
