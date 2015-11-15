<%@ Page Title="ItemKeyword Details" Language="C#" MasterPageFile="~/Site.Master" CodeBehind="Details.aspx.cs" Inherits="Nokkelord.ItemKeywords.Details" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div>
		<p>&nbsp;</p>
      
        <asp:FormView runat="server"
            ItemType="Nokkelord.Models.ItemKeyword" DataKeyNames="ItemKeywordID"
            SelectMethod="GetItem"
            OnItemCommand="ItemCommand" RenderOuterTable="false">
            <EmptyDataTemplate>
                Cannot find the ItemKeyword with ItemKeywordID <%: Request.QueryString["ItemKeywordID"] %>
            </EmptyDataTemplate>
            <ItemTemplate>
                <fieldset class="form-horizontal">
                    <legend>ItemKeyword Details</legend>
							<div class="row">
								<div class="col-sm-2 text-right">
									<strong>Varenøkkelordnavn</strong>
								</div>
								<div class="col-sm-4">
									<asp:DynamicControl runat="server" DataField="ItemKeywordName" ID="ItemKeywordName" Mode="ReadOnly" />
								</div>
							</div>
							<div class="row">
								<div class="col-sm-2 text-right">
									<strong>ItemNo</strong>
								</div>
								<div class="col-sm-4">
									<asp:DynamicControl runat="server" DataField="ItemNo" ID="ItemNo" Mode="ReadOnly" />
								</div>
							</div>
							<div class="row">
								<div class="col-sm-2 text-right">
									<strong>Beskrivelse </strong>
								</div>
								<div class="col-sm-4">
									<asp:DynamicControl runat="server" DataField="Description" ID="Description" Mode="ReadOnly" />
								</div>
							</div>
							<div class="row">
								<div class="col-sm-2 text-right">
									<strong>KeywordID</strong>
								</div>
								<div class="col-sm-4">
									<%#: Item.Keyword != null ? Item.Keyword.KeywordName : "" %>
								</div>
							</div>
                 	<div class="row">
					  &nbsp;
					</div>
					<div class="form-group">
						<div class="col-sm-offset-2 col-sm-10">
							<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Back" CssClass="btn btn-default" />
						</div>
					</div>
                </fieldset>
            </ItemTemplate>
        </asp:FormView>
    </div>
</asp:Content>

