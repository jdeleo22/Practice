<%--  Document   : processxml--%>
<%@page import="javax.xml.parsers.DocumentBuilder"%>
<%@page import="org.w3c.dom.Document"%>
<%@page import="org.w3c.dom.NodeList"%>
<%@page import="javax.xml.parsers.DocumentBuilderFactory"%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<body>
    <h2>
        WSJ Daily News Feeds
    </h2>
        <p></p>
        <h3>News & Commentary</h3>
        <p></p>
        
<!--JSP CODE-->
<%
    String userChoice = request.getParameter("choice");
   
    String URL = "";
    String Item = "";
    
    
    
if(userChoice.equalsIgnoreCase("choice")){
    URL = "https://feeds.a.dj.com/rss/RSSOpinion.xml";
    Item = "Opinion";
}
else if (userChoice.equalsIgnoreCase("worldnews")){
    URL = "https://feeds.a.dj.com/rss/RSSWorldNews.xml";
    Item = "World News";
}
else if (userChoice.equalsIgnoreCase("usbusiness")){
    URL = "https://feeds.a.dj.com/rss/WSJcomUSBusiness.xml";
    Item = "US Business";
}
else if (userChoice.equalsIgnoreCase("marketnews")){
    URL = "https://feeds.a.dj.com/rss/RSSMarketsMain.xml";
    Item = "Markets";
}
else if (userChoice.equalsIgnoreCase("technology")){
    URL = "https://feeds.a.dj.com/rss/RSSWSJD.xml";
    Item = "Technology";
}
else if (userChoice.equalsIgnoreCase("lifestyle")){
    URL = "https://feeds.a.dj.com/rss/RSSLifestyle.xml";
    Item = "LifeStyle";
}

    //create docbuilder
    DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
    DocumentBuilder db = dbf.newDocumentBuilder();
    
    //read xml
    Document doc = db.parse(URL);
    
    //parse trhrough in array of NodeList
    NodeList itemArray = doc.getElementsByTagName("item");
    
    out.println("<p><big>"+Item+ ":</big></p>");
    
    //loop through items
    for (int i=0; i<itemArray.getLength(); i++){
        
        NodeList title = doc.getElementsByTagName("title");
        String titleValue = title.item(i+2).getFirstChild().getNodeValue();
        
        NodeList link = doc.getElementsByTagName("link");
        String linkValue = link.item(i+2).getFirstChild().getNodeValue();
        
        out.println("<p><a href='"+linkValue+"'>"+titleValue+"</a></p>");

    }
    
    %>
    </body>
</html>