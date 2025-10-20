<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AmountConvertPage.aspx.cs" Inherits="ProgrammersNET.AmountConvertPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12">
            <h2>Amount Converter</h2>
            <p>
                This page is responsible to convert the amount into text extension value.
            </p>
        </div>
    </div>
    <div class="row">
        <form>

            <div class="col-md-8">
                <div class="form-group">
                    <label for="lblAmount">Amount</label>
                    <input runat="server" type="number" min="0.1" step="any" class="form-control" id="amountValue" aria-describedby="amountHelp" placeholder="Enter amount">
                    <small id="amountHelp" class="form-text text-muted">The amount value to be writen in extension.</small>
                    <p>
                        <br />
                        <button type="submit" class="btn btn-primary">Submit</button>
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
