<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ProjectVB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Anderson Diego's Project - Visual Basic</h1>
            <img style="width: 240px" width="200" src="https://media.licdn.com/dms/image/v2/D4D03AQELbw4IClyCrA/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1722708715493?e=1762387200&v=beta&t=ic4OXY9A7eYdHnCyzoioqohMquTLaDaqDItRWlZgZow" alt="Anderson Diego - Linkedin Profile Picture">
            <p class="lead">This is a project built in .NET using ASP.NET WebForms.</p>
            <p>This WebForm project has two pages to attend the challenge.</p>
        </section>

        <div class="row">
            <div class="col-md-6">
                <h2>Amount Converter</h2>
                <p>
                    In this program, the user will input an amount of value, and will be able to convert the amount into text for extention.
                </p>
                <p>
                    <a class="btn btn-default" href="/AmountConvertPage">Amount Converter &raquo;</a>
                </p>
            </div>
            <div class="col-md-6">
                <h2>Palindrome Check</h2>
                <p>
                    In this other program, the user will input a number, and the system will return the information if this is a palindrome or not;
                </p>
                <p>
                    <a class="btn btn-default" href="/PalindromeCheckPage">Palindrome Check &raquo;</a>
                </p>
            </div>
        </div>
    </main>

</asp:Content>
