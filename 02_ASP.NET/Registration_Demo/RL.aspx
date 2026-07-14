<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="RL.aspx.cs" Inherits="Registration_Demo.RL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container d-flex justify-content-center align-items-center vh-100">

    <div class="card shadow p-4" style="width:350px;">

        <h3 class="text-center mb-4">Login</h3>

        <div class="mb-3">
            <label>Email</label>
            <asp:TextBox ID="txtEmail" runat="server"
                CssClass="form-control"
                TextMode="Email"
                placeholder="Enter Email">
            </asp:TextBox>
        </div>

        <div class="mb-3">
            <label>Password</label>
            <asp:TextBox ID="txtPassword" runat="server"
                CssClass="form-control"
                TextMode="Password"
                placeholder="Enter Password">
            </asp:TextBox>
        </div>

        <div class="d-grid">
            <asp:Button ID="btnLogin"
                runat="server"
                Text="Login"
                CssClass="btn btn-primary"
                OnClick="btnLogin_Click" />
        </div>

        <div class="text-center mt-3">
            <asp:HyperLink ID="HyperLink1"
                runat="server"
                NavigateUrl="~/Register.aspx">
                Create New Account
            </asp:HyperLink>
        </div>

    </div>

</div>

</asp:Content>