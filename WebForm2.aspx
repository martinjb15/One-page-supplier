<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="One_page_supplier.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/app.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet" />
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
                    <li class="active"><a href="http://web. .ie/search/WebForm1.aspx">One Page Supplier</a></li>
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
        <div>
            <div class="container">
                <div id="content">
                    <div class="jumbotron">

                        <h1>Welcome To The   Finder</h1>

                        <br />
                        <h2>Please use the search functions below to find what you are looking for.</h2>
                        <h3>Instructions:</h3>
                        <div id="instructions">
                            <ol>
                                <li>You will have 3 item's you must fill in for this search to work(Under the required field below )
                                <ul>
                                    <li>Database</li>
                                    <li>Country</li>
                                    <li>Search Type</li>
                                </ul>
                                </li>
                                <li>If you want to filter your search by more then 1 keyword please add a space between the items e.g:
                                <ul>
                                    <li>castle guide</li>
                                    <li>tea coffee dinner</li>
                                </ul>

                                </li>
                                <li>If you are looking for the one page supplier please click the one page supplier on the navigation bar above</li>
                            </ol>
                        </div>
                    </div>

                    <br />
                    <h4>Required</h4>
                    <div>

                        <div class="radio-inline">
                            <asp:Label ID="Label5" runat="server" Text="Database"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem Text="Scotland" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Ireland" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Moloney and Kelly" Value="2"></asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <asp:Label ID="Label1" runat="server" Text="Country"></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Please Select .......</asp:ListItem>
                        </asp:DropDownList>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Required" InitialValue="Please Select ......."></asp:RequiredFieldValidator>

                        <asp:Label ID="Label6" runat="server" Text="Search Type"></asp:Label>
                        <asp:DropDownList ID="DropDownList4" runat="server">
                            <asp:ListItem>Please select ......</asp:ListItem>
                            <asp:ListItem Value="0">Search notes</asp:ListItem>
                            <asp:ListItem Value="1">Search Description</asp:ListItem>
                            <asp:ListItem Value="2">Search Comments
                            </asp:ListItem>
                        </asp:DropDownList>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList4" ErrorMessage="RequiredField" InitialValue="Please select ......"></asp:RequiredFieldValidator>

                    </div>

                    <h4>Additional</h4>

                    <asp:Label ID="Label2" runat="server" Text="County"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Please Select .......</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label3" runat="server" Text="Service Type"></asp:Label>
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem Value="ps">Please Select .......</asp:ListItem>
                    </asp:DropDownList>

                    <asp:Label ID="Label4" runat="server" Text="Keyword"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />

                </div>


                <p>
                    <asp:GridView ID="GridView1" runat="server" CssClass="table" PagerSettings-FirstPageText="First" AutoGenerateColumns="false" PagerSettings-LastPageText="Last" Mode="NextPreviousFirstLast" NextPageText="Next" PagerSettings-Mode="NextPrevious" PagerSettings-NextPageText="Next" PagerSettings-PreviousPageText="Previous" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" PageSize="50" AllowCustomPaging="False">
                        <Columns>
                            <asp:TemplateField HeaderText="Supplier Code">
                                <ItemTemplate>
                                    <asp:Label ID="LB_Desc" runat="server" Enabled="false" Height="20px" Text='<%# Bind("code")%>'></asp:Label><br />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Code" DataField="code" Visible="false" />
                            <asp:BoundField HeaderText="Name" DataField="name" />
                            <asp:BoundField HeaderText="Address" DataField="address1" />
                            <asp:BoundField HeaderText="Description" DataField="description" />
                        </Columns>
                    </asp:GridView>

                    <asp:GridView ID="GridView2" runat="server" CssClass="table"
                        PagerSettings-FirstPageText="First"
                        AutoGenerateColumns="false"
                        PagerSettings-LastPageText="Last"
                        NextPageText="Next"
                        PagerSettings-Mode="NextPrevious"
                        PagerSettings-NextPageText="Next"
                        PagerSettings-PreviousPageText="Previous"
                        OnPageIndexChanging="GridView2_PageIndexChanging"
                        AllowPaging="True" PageSize="10" OnRowCommand="GridView2_RowCommand"
                        OnRowDataBound="GridView2_RowDataBound">
                        <PagerSettings Mode="NumericFirstLast" Position="Bottom" PageButtonCount="10" />

                        <Columns>

                            <asp:TemplateField HeaderText="Supplier Code">
                                <ItemTemplate>
                                    <asp:Label ID="LB_Desc0" runat="server" Enabled="false" Height="20px" Text='<%# Bind("code")%>'></asp:Label><br />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Code" DataField="code" Visible="false" />
                            <asp:BoundField HeaderText="Name" DataField="name" />
                            <asp:BoundField HeaderText="Address" DataField="address1" />
                            <asp:ButtonField ButtonType="Button" CommandName="updating" HeaderText="Note Description" ShowHeader="True" Text="show" />
                            <asp:BoundField HeaderText="Notes" DataField="MESSAGE_TEXT" />
                        </Columns>
                  
                        
                        
                        
                          </asp:GridView>
                       <asp:GridView ID="GridView3" runat="server" CssClass="table" PagerSettings-FirstPageText="First" AutoGenerateColumns="false" PagerSettings-LastPageText="Last" Mode="NextPreviousFirstLast" NextPageText="Next" PagerSettings-Mode="NextPrevious" PagerSettings-NextPageText="Next" PagerSettings-PreviousPageText="Previous" AllowPaging="True" PageSize="50" AllowCustomPaging="False" OnPageIndexChanging="GridView3_PageIndexChanging">
                       
                       

                        <Columns>

                            <asp:TemplateField HeaderText="Supplier Code">
                                <ItemTemplate>
                                    <asp:Label ID="LB_Desc0" runat="server" Enabled="false" Height="20px" Text='<%# Bind("code")%>'></asp:Label><br />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Code" DataField="code" Visible="false" />
                            <asp:BoundField HeaderText="Name" DataField="name" />
                            <asp:BoundField HeaderText="Address" DataField="address1" />
                             <asp:BoundField HeaderText="Comments" DataField="comment" />
                        </Columns>
                    </asp:GridView>
                </p>

            </div>
        </div>

    </form>
    <p>
        &nbsp;
    </p>
</body>
</html>
