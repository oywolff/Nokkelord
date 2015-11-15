<%@ Page Title="ItemKeyword Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ItemKeywordDetail.aspx.cs" Inherits="Nokkelord.ItemKeywordDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="itemkeywordDetail" runat="server" ItemType="Nokkelord.Models.ItemKeyword" SelectMethod ="GetItemKeyword" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ItemKeywordName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                       <%#:Item.ItemKeywordName %>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>ItemNo:</b>&nbsp;<%#:Item.ItemNo %></span>
                        <br />
                        <span><b>ItemKeyword Number:</b>&nbsp;<%#:Item.ItemKeywordID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>