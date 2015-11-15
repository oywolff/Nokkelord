	<%@ Page Title="ItemKeywords" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ItemKeywordList.aspx.cs" Inherits="Nokkelord.ItemKeywordList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="ItemKeyword" runat="server" 
                DataKeyNames="ItemKeywordID" GroupItemCount="4"
                ItemType="Nokkelord.Models.ItemKeyword" SelectMethod="GetItemKeywords">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ItemKeywordDetail.aspx?ItemKeywordID=<%#:Item.ItemKeywordID%>">
                                        </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ItemKeywordDetail.aspx?ItemKeywordID=<%#:Item.ItemKeywordID%>">
                                        <span>
                                            <%#:Item.ItemKeywordName%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <%#:Item.ItemNo%>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>