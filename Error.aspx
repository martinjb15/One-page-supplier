<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Error.aspx.cs" Inherits="Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>  Tours Survey</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />

</head>
<body style="text-align: center; position: static; font-family: Times New Roman;">
<div id="wrapper">
    <form id="form1" runat="server">
        <table style="width: 617px; height: 304px; padding-right: 0px; padding-left: 0px; padding-bottom: 0px; padding-top: 0px;">
            <tr>
                <td align="center" colspan="1" style="width: 298px; height: 26px">
                    <br />
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/irlfooter.jpg" /><br />
                    <br />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="1">
                    <span style="color: navy"><span style="font-family: Calibri">
                        <br />
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Sorry...."></asp:Label><br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Sorry, there has been an error. <br /><br />Please start again or email admin@ .ie if the error continues.<br /><br />Kind regards.<br /><br />  Tours<br />"></asp:Label><br />
                        <br />
                        <asp:Label ID="Label3" runat="server"></asp:Label></span></span></td>
            </tr>
            <tr>
                <td align="right" valign="top">
                    <span style="font-family: Calibri Light">
                        <br />
                        <br />
                        <br />
                        <br />
                        </span></td>
            </tr>
            <tr>
                <td align="right" colspan="1" style="width: 298px; height: 31px; text-align: center">
                    <br />
                    <span style="font-size: 10pt; font-family: Calibri Light">
                        <br />
                    </span>
                </td>
            </tr>
        </table> 
        <br />
                    <hr />
                    <span style="font-size: 10pt; font-family: Calibri Light">Copyright � 2015   Tours
                        Ltd. All rights reserved.&nbsp;</span>
    </form>
    </div>
</body>
</html>
