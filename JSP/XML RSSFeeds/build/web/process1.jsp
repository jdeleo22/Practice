<%-- Document   : process1--%>

<%@page import="org.w3c.dom.NodeList"%>
<%@page import="org.w3c.dom.Document"%>
<%@page import="javax.xml.parsers.DocumentBuilder"%>
<%@page import="javax.xml.parsers.DocumentBuilderFactory"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <body><h2></h2>
        
        <%
        //create obj of DocumentBuilderFactory for XML parser
        
        DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
        DocumentBuilder db = dbf.newDocumentBuilder();
        
        //user chooses xml file determine based on if statement
        //category can determine which records are shown
        
        String xmlFile = "";
        
        String opinionfile = "https://feeds.a.dj.com/rss/RSSOpinion.xml";
        String worldnewsfile = "https://feeds.a.dj.com/rss/RSSWorldNews.xml";
        String businessfile = "https://feeds.a.dj.com/rss/WSJcomUSBusiness.xml";
        String marketsfile = "https://feeds.a.dj.com/rss/RSSMarketsMain.xml";
        String techfile = "https://feeds.a.dj.com/rss/RSSWSJD.xml";
        String lifestylefile = "https://feeds.a.dj.com/rss/RSSLifestyle.xml";
        
        //create doc object
        Document doc = db.parse(xmlFile);
        
        //create nodelist array
         NodeList channel = doc.getElementsByTagName("channel");
         
        NodeList item = doc.getElementsByTagName("item");
        
        //for each item-
        
        NodeList title = doc.getElementsByTagName("title");
        String Jtitle = title.item(0).getTextContent();
        
        NodeList link = doc.getElementsByTagName("link");
         String Jlink = link.item(0).getTextContent();
         
        NodeList desc = doc.getElementsByTagName("description");
         String Jdesc = desc.item(0).getTextContent();
         
        NodeList content = doc.getElementsByTagName("");
         String Jcontent = content.item(0).getTextContent();
         
        NodeList pubdate = doc.getElementsByTagName("pubDate");
         String Jpubdate = pubdate.item(0).getTextContent();
         
        NodeList guid = doc.getElementsByTagName("guid");
         String Jguid = guid.item(0).getTextContent();
         
        NodeList category = doc.getElementsByTagName("category");
         String Jcategory = category.item(0).getTextContent();
         
        NodeList articletype = doc.getElementsByTagName("wsj:articletype");
         String Jarticletype = articletype.item(0).getTextContent();
         
                
        //display value of tag
        out.println("Channel: " + channel.item(0).getFirstChild().getNodeValue());
        out.println("Title: " + title.item(0).getFirstChild().getNodeValue());
        

        out.println("<table border='1'>");
        out.println("<<tr><th colspan='9'>News</th></tr>");
        out.println("<tr><th>Title</th><th>Link</th><th>Description</th><th>Info</th><th>Publish Date</th><th>Category</th></tr>");
        out.println("<tr><td>"+Jtitle+"</td><td>"+Jlink+"</td><td>"+Jdesc+"</td><td>"+Jpubdate+"</td><td>"+Jcategory+"</td></tr>");
        out.println("</table>");

        
        


      %>
      
    </body>
</html>
