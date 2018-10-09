<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getDataList.aspx.cs" Inherits="ProjectDemoWebAPI.获取数据列表.getDataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
              <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td style="width: 150px; height: 22px;">
                                    <asp:CheckBox ID="ID" runat="server"  Text='<%#Eval("Id") %>' ToolTip='<%#Eval("Id") %>'
                                        onclick="che(this)" />
                                </td>
                                 <td style="width: 150px; height: 22px;">
                                    <asp:CheckBox ID="CardName" runat="server"  Text='<%#Eval("CardName") %>' ToolTip='<%#Eval("CardName") %>'
                                        onclick="che(this)" />
                                </td>
                                 <td style="width: 150px; height: 22px;">
                                    <asp:CheckBox ID="BankName" runat="server"  Text='<%#Eval("BankName") %>' ToolTip='<%#Eval("BankName") %>'
                                        onclick="che(this)" />
                                </td>
                                 <td style="width: 150px; height: 22px;">
                                    <asp:CheckBox ID="BankCard" runat="server"  Text='<%#Eval("BankCard") %>' ToolTip='<%#Eval("BankCard") %>'
                                        onclick="che(this)" />
                                </td>
                               
                            </tr>
                        </table>
                    </ItemTemplate>
        </asp:DataList>
        </div>
       
        <div>
            <asp:Button ID="Button2" runat="server" Text="事务提交数据" OnClick="Button1_Click2" /><br />
            姓名:  <asp:TextBox ID="Name" runat="server" Text=""   CssClass="input1"></asp:TextBox><br />
            年龄:  <asp:TextBox ID="Age" runat="server" Text=""   CssClass="input1"></asp:TextBox><br />
            分数:  <asp:TextBox ID="ScoreNum" runat="server" Text=""   CssClass="input1"></asp:TextBox><br />
        </div>
    </form>
</body>
</html>
