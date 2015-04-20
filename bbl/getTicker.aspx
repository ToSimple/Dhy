<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getTicker.aspx.cs" Inherits="bbl.getTicker" %>
<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body onload="fun()">
    <form id="form1" runat="server">   
        <div>
            <input type="text"  value="<%= GetVariableStr %>" />                                                                             
        </div>
    </form>
</body>
</html>
