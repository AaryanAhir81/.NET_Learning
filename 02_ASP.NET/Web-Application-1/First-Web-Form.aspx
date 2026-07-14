<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First-Web-Form.aspx.cs" Inherits="Web_Application_1.First_Web_Form" %>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "You selected :" + Calendar1.SelectedDate.ToString();
        Label1.Text = "Day Of Week :" + Calendar1.SelectedDate.DayOfWeek.ToString();
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="Calendar1_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        RADIO DEMO<br />
        <br />
        <asp:RadioButton ID="MALE_BTN" runat="server" GroupName="GENDER" Text="MALE" />
        <asp:RadioButton ID="FEMALE_BTN" runat="server" GroupName="GENDER" Text="FEMALE" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        CHECKBOX DEMO&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:CheckBox ID="C" runat="server" AutoPostBack="True" Text="C" />
        <br />
        <br />
        <asp:CheckBox ID="C_SHARP" runat="server" AutoPostBack="True" Text="C_SHARP" />
        <br />
        <br />
        <asp:CheckBox ID="JAVA" runat="server" AutoPostBack="True" Text="JAVA" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <br />
        <br />
        LISTBOX DEMO<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem>Aaryan</asp:ListItem>
            <asp:ListItem>Smit</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>