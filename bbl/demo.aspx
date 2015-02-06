<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="bbl.demo" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script type="text/javascript">
        function fun() {
            var str = '<%= DateTime.Now %>';
            //前台位置1，绑定的是第三种变量类型（也是第二种方式，?因为Now是个属性）
            alert(str);
        }
    </script>
</head>
<body onload="fun()">
    <form id="form1" runat="server">   
        <div>
             <input type="text"  value="<%= GetVariableStr %>" />                                              
             "<%= GetFunctionStr() %>"                                              
        </div>
    </form>
</body>
</html>

