<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RepaderProduct._default" %>
<%@ Import Namespace="RepaderProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Urun{
            width:200px;
            background-color:aqua;
            margin:10px;
            color:yellow;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <% 
        using (NorthwindEntities db=new NorthwindEntities())
        {
            List<Product> productlist = db.Products.ToList();
            foreach (var item in productlist)
            {
                %>
        <div class="Urun" id='<%=item.ProductID%>' 
            onmouseover="Degıstır"(<%=item.ProductID %>"
            onmouseout="Prevcolor"(<%=item.ProductID %>
            <p><b><i><%=item.ProductName%></i></b></p>
        
        </div>
        <%
            }
        }
        %>
    </div>
    </form>
    <script>
        function Degıstır(id){
            document.getElementById(id).style.backgroundColor = "blue";
        }
        function PrevColor(id){
            document.getElementById(id).style.backgroundColor = "blue"
        }
    </script>
</body>
</html>
