<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PalindromeCheckPage.aspx.cs" Inherits="ProgrammersNET.PalindromeCheckPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
        <div class="col-md-12">
            <h2>Palindrome Check</h2>
            <p>
                This page is responsible to check if a page is palindrome or not.
            </p>
        </div>
    </div>
    <div class="row">
        <form>
            <div class="col-md-8">
                <div class="form-group">
                    <label for="lblValueToCheck">Value To Check</label>
                    <input runat="server" type="number" min="1" class="form-control" id="valueInput" aria-describedby="amountHelp" placeholder="Enter a positive number:">
                    <small id="valueInputHelp" class="form-text text-muted">The number to check if it is Palindrome or not.</small>
                    <p>
                        <br />
                        <button type="submit" class="btn btn-primary">Check</button>
                    </p>
                </div>
                <div class="form-group">
                    <label for="lblResult">Result</label>
                    <input runat="server" type="text" class="form-control" id="txtResult" disabled>
                </div>
            </div>
        </form>

    </div>

</asp:Content>
