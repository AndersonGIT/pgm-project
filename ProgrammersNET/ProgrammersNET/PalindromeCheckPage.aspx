<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PalindromeCheckPage.aspx.cs" Inherits="ProgrammersNET.PalindromeCheckPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        $(document).ready(function () {
            $("#btnPalindromeCheckAjax").click(function () {
                var valueInput = $("#valueInput").val();

                if (!valueInput) {
                    alert('The input is not a valid positive number, try again.');
                } else {
                    $.ajax({
                        type: "POST",
                        url: '<%= ResolveUrl("PalindromeCheckPage.aspx/IsPalindrome") %>',
                        data: JSON.stringify({ number: valueInput }),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            if (response.d) {
                                $('#txtResult').val(valueInput + ' is Palindrome.');
                            } else {
                                $("#txtResult").val(valueInput + ' is NOT Palindrome.');
                            }
                        },
                        error: function (xhr, status, error) {
                            console.error("Error: " + error);
                        }
                    });
                }
            });
        });
    </script>
    <div class="row">
        <div class="col-md-12">
            <h2>Palindrome Check</h2>
            <p>
                This page is responsible to check if a page is palindrome or not.
            </p>
            <br />
        </div>
    </div>
    <div class="row">
        <form>
            <div class="col-md-8">
                <div class="form-group">
                    <label for="lblValueToCheck">Value To Check</label>
                    <input runat="server" type="number" min="1" class="form-control" id="valueInput" ClientIdMode="Static" aria-describedby="amountHelp" placeholder="Enter a positive number:">
                    <small id="valueInputHelp" class="form-text text-muted">The number to check if it is Palindrome or not.</small>
                    <p>
                        <br />
                        <button type="submit" class="btn btn-primary" id="btnPalindromeCheck">Check</button>
                        <button type="button" class="btn btn-info" id="btnPalindromeCheckAjax" ClientIdMode="Static">Check by Ajax</button>
                    </p>
                </div>
                <div class="form-group">
                    <label for="lblResult">Result</label>
                    <input runat="server" type="text" class="form-control" ClientIdMode="Static" id="txtResult" disabled>
                </div>
            </div>
        </form>
        
    </div>

</asp:Content>
