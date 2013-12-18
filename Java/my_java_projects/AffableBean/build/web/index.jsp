<%-- 
    Document   : index
    Created on : Dec 13, 2013, 1:00:27 PM
    Author     : admin
--%>

<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@taglib prefix="sql" uri="http://java.sun.com/jsp/jstl/sql"%>

<sql:query var="categories" dataSource="jdbc/affablebean">
    SELECT * FROM category
</sql:query>

<%--
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
    "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" type="text/css" href="css/affablebean.css">
        <title>The Affable Bean</title>
    </head>
    <body>
        <div id="main">
            <div id="header">
                <div id="widgetBar">

                    <div class="headerWidget">
                        [ language toggle ]
                    </div>

                    <div class="headerWidget"></div>

                    <div class="headerWidget">
                        [ shopping cart widget ]
                    </div>

                </div>

                <a href="#">
                    <img src="#" id="logo" alt="Affable Bean logo">
                </a>

                <img src="#" id="logoText" alt="the affable bean">
            </div>

            <sql:query var="categories" dataSource="jdbc/affablebean">
                SELECT * FROM category
            </sql:query>
    --%>
            
            <div id="indexLeftColumn">
                <div id="welcomeText">
                    <p style="font-size: larger">Welcome to the online home of the Affable Bean Green Grocer.</p>
                    
                    <p>Enjoy browsing and learning more about our unique home delivery
                        service bringing you fresh organic produce, dairy, meats, breads
                        and other delicious and healthy items to your doorstep.</p>
                    
                    <!-- test to access context parameters -->
                    <!--categoryImagePath: ${initParam.categoryImagePath}-->
                    <!--productImagePath: ${initParam.productImagePath}-->
        
                </div>
            </div>

            <div id="indexRightColumn">
                
                <c:forEach var="category" items="${categories.rows}">
                    <div class="categoryBox">
                        <a href="category?${category.id}">

                            <span class="categoryLabel"></span>
                            <span class="categoryLabelText">${category.name}</span>

                            <img src="${initParam.categoryImagePath}${category.name}.jpg"
                                 alt="${category.name}">
                        </a>
                    </div>
                </c:forEach>
            </div>

<%--
            <div id="footer">
                <hr>
                <p id="footerText">[ footer text ]</p>
            </div>
        </div>
    </body>
</html>
--%>