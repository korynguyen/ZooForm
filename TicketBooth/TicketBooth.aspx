<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketBooth.aspx.cs" Inherits="TicketBooth.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <label style="margin-left: 80px"> TICKET BOOTH</label>
        </div>
        <div style="margin: 10px">
            <asp:TextBox ID="BoothID" runat="server"/>
            <label style="margin-left: 10px"> BoothID: </label>
        </div>
        <div style="margin: 10px"> 
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit"/>
        </div>
        
    </form>
</body>
</html>
