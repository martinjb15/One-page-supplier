<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="One_page_supplier.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/app.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 100px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-inverse">
            <div class="container">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="http://atintranet/default.aspx">Atintranet</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="http://web. .ie/search/WebForm2.aspx"> Search</a></li>
                        <li><a href="http://web. .ie/personaldetails/">Staff Personal Details Form</a></li>
                        <li><a href="http://web. .ie/holiday/">Staff Weekend Requests</a></li>
                        <li><a href="http://web. .ie/cashadvance/">Cash Advance Form</a></li>
                        <li><a href="http://web. .ie/overtimeform/">Overtime Form</a></li>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->
            </div>
            <!-- /.container-fluid -->
        </nav>
        <div class="container">
            <div id="content">
                <div class="jumbotron">
                    <h1>One Page Supplier</h1>
                    <h4>Welcome to the one page supplier form.</h4>
                    <h4>Please enter your supplier code in the box below and click the search button to find the suppliers details.</h4>
                    <h4>The search page can be found on the top left hand corner above</h4>

                </div>
                <div class="radio-inline">
                    <asp:Label ID="Label3" runat="server" Text="Database"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Text="Scotland" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Ireland" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Moloney and Kelly" Value="2"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <asp:Label ID="Label9" runat="server" Text="Supplier Code" CssClass="auto-style109"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server" AutoCompleteType="Search"></asp:TextBox>
                <asp:Button ID="Button10" runat="server" Text="Search" OnClick="Button10_Click" />


                <br />
                <br />


                <div class="row">
                    <div class="col-md-4 col-lg-4">

                        <table id="table3" class="table table-striped" runat="server">

                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Stay must start on"></asp:Label></td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Monday" /></td>
                                <td>
                                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Tuesday" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Wednesday" /></td>
                                <td>
                                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Thursday" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox5" runat="server" Text="Friday" /></td>
                                <td>
                                    <asp:CheckBox ID="CheckBox6" runat="server" Text="Saturday" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox7" runat="server" Text="Sunday" /></td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Room Policy"></asp:Label></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox8" runat="server" Text="Single" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="CheckBox9" runat="server" Text="Twin" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox10" runat="server" Text="Double" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="CheckBox11" runat="server" Text="Triple" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox12" runat="server" Text="Quad" /></td>
                                <td>
                                    <asp:CheckBox ID="CheckBox13" runat="server" Text="Other" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="col-md-4">

                        <tr>
                            <td></td>

                            <td></td>
                        </tr>
                        <table class="table table-striped">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="Label1" runat="server" Text="Company Name"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" BorderColor="White" ReadOnly="True" Style="height: 21px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>

                        </table>
                    </div>
                    

                    <div class="col-md-4">
                        <table id="table4" class="table table-striped" runat="server">
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Branch"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox14" runat="server" BorderColor="White" ReadOnly="True" CssClass="auto-style11"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Department"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox15" runat="server" BorderColor="White" ReadOnly="True" Style="height: 21px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="Account"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox16" runat="server" BorderColor="White" ReadOnly="True" Style="height: 21px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="Bank"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox17" runat="server" BorderColor="White" ReadOnly="True" Style="height: 21px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text="Bank branch"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox18" runat="server" BorderColor="White" ReadOnly="True" Style="height: 21px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text="Bank Account"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox19" runat="server" BorderColor="White" ReadOnly="True" Style="height: 21px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Text="Account Name"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox20" runat="server" BorderColor="White" ReadOnly="True" Style="height: 21px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>

                <iframe id="myiFrame" runat="server" width="80%" height="350px"></iframe>
                 <asp:Label ID="Label21" runat="server" Text="There are no coordinates inserted for this supplier" Visible="false"></asp:Label>

                <table>

                    <tr>

                        <td class="auto-style99"></td>
                    </tr>
                </table>

                <table id="Table5" runat="server" class="auto-style22" align="center">
                    <tr>
                        <td class="auto-style92">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:GridView ID="GridView1" CssClass="table col-md-12 col-sm-10 table-hover" runat="server" AllowPaging="true"  OnPageIndexChanging="GridView1_PageIndexChanging">
                        <PagerSettings Mode="NumericFirstLast" Position="Bottom" PageButtonCount="10"/>
                         

                            </asp:GridView>
                        </td>
                    </tr>
                    </table>
                 <asp:GridView ID="GridView3" CssClass="table col-md-12 col-sm-10 table-hover" runat="server" AllowPaging="true" PagerSettings-PreviousPageText="Previous"
                      OnPageIndexChanging="GridView3_PageIndexChanging">                     
                        <PagerSettings Mode="NumericFirstLast" Position="Bottom" PageButtonCount="10"/>

                            </asp:GridView>
                <br />
                <asp:LinkButton ID="Button1" CssClass="btn btn-default btn-lg" runat="server" OnClick="Button1_Click">Show Descriptions In All Languages</asp:LinkButton>
                <asp:LinkButton ID="LinkButton1" CssClass="btn btn-default btn-lg" runat="server" Visible="false" OnClick="LinkButton1_Click">Hide Descriptions For All Languages</asp:LinkButton>
             
                  <br />
                <br />
                <div class="row">
                    <div class="col-md-4 col-lg-4">
                        <div class="row">
                            <div class="col-md-2">
                                <asp:Label ID="Label14" runat="server" Text="English" Visible="false"></asp:Label>
                            </div>
                            <div class="col-md-10">
                                <asp:TextBox ID="TextBox21" runat="server" Font-Strikeout="False" TextMode="MultiLine" Height="210px" Width="90%" Visible="false"></asp:TextBox>
                            </div>
                        </div>
                </div>

                <div class="col-md-4 col-lg-4">
                    <div class="row">
                        <div class="col-md-2">
                            <asp:Label ID="Label15" runat="server" Text="French" Visible="false"></asp:Label>
                        </div>
                        <div class="col-md-10">
                            <asp:TextBox ID="TextBox23" runat="server" Font-Strikeout="False" TextMode="MultiLine" Height="210px" Width="90%" Visible="false"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-lg-4">
                    <div class="row">
                        <div class="col-md-2">
                            <asp:Label ID="Label17" runat="server" Text="German" Visible="false"></asp:Label>
                        </div>
                        <div class="col-md-10">
                            <asp:TextBox ID="TextBox24" runat="server" Font-Strikeout="False" TextMode="MultiLine" Height="210px" Width="90%" Visible="false"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>

                <div class="row">
                    <div class="col-md-4 col-lg-4">
                        <div class="row">
                            <div class="col-md-2">
                                <asp:Label ID="Label18" runat="server" Text="Italian" Visible="false"></asp:Label>
                            </div>
                            <div class="col-md-10">
                                <asp:TextBox ID="TextBox25" runat="server" Font-Strikeout="False" TextMode="MultiLine" Height="212px" Width="90%" Visible="false"></asp:TextBox>
                            </div>
                        </div>
                        </div>
                        <div class="col-md-4 col-lg-4">
                            <div class="row">
                                <div class="col-md-2">
                                    <asp:Label ID="Label19" runat="server" Text="Spanish" Visible="false"></asp:Label>
                                </div>
                                <div class="col-md-10">
                                    <asp:TextBox ID="TextBox26" runat="server" Font-Strikeout="False" TextMode="MultiLine" Height="212px" Width="90%" Visible="false"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                         </div>

                        <br />
                <br />
                 <asp:GridView ID="GridView2" CssClass="table col-md-12 col-sm-10 table-hover" runat="server" AllowPaging="True" AutoGenerateColumns="false" BorderColor="White" RowStyle-BorderColor="WHITE">
                            <Columns>

                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("imgs")%>' Width="250px" Height="200px" />
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>


                            <PagerSettings Mode="NumericFirstLast" Position="Bottom" PageButtonCount="3" />

                        </asp:GridView>
                    </div>
               
    </form>
</body>
</html>
