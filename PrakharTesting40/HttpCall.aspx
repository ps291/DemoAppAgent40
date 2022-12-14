<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HttpCall.aspx.cs" Inherits="PrakharTesting40.HttpCall" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<script>

    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        document.getElementById("demo").value =
            this.responseText;
    }
    xhttp.open("GET", "https://gorest.co.in/public/v2/users");
    xhttp.send();



    var http = new XMLHttpRequest();
    var url = 'https://httpbin.org/post';
    var params = '';
    http.open('POST', url, true);

    //Send the proper header information along with the request
    http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');

    //http.onreadystatechange = function () {//Call a function when the state changes.
    //    if (http.readyState == 4 && http.status == 200) {
    //        alert(http.responseText);
    //    }
    //}
    http.send(params);

</script>
<div>
    <h1>Http Call</h1>
    <br /><br />
    <h6>HTTP Call Successfully [GET, POST]</h6>
    <code>
        <ul>
            <li>Post https://httpbin.org/post </li>
            <br />
            <li>Get Data https://gorest.co.in/public/v2/users </li>
        </ul>
    </code>
    <br /><br />
    <input id="demo" type="text" style="max-width: 1000px !important; width: 1000px !important; height: 50px !important" />
    <br />
    <br />
    <a href="https://google.com">Redirect to Google.com</a>
</div>
</asp:Content>
