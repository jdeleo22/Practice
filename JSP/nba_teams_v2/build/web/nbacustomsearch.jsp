<%-- Document   : nbacustomsearch--%>

<%@page import="java.sql.ResultSet"%>
<%@page import="java.sql.Statement"%>
<%@page import="java.sql.DriverManager"%>
<%@page import="java.sql.Connection"%>

<%
    try{
      String UN = "root";
      String PW = "";

      //setup parameters
        String database = "jdbc:mysql://localhost:3306/final_nba_db";
        
        Class.forName("com.mysql.jdbc.Driver");
       Connection conn = DriverManager.getConnection(database,UN,PW);
       
       String userSearch;
       userSearch =  request.getParameter("searchKey");

       String sqlQuery="select * from nba_table where match(Team,YearFounded,NBAWins,YearofWin) against('"+userSearch+"' in natural language mode)";

       Statement stmt = conn.createStatement();
      ResultSet results = stmt.executeQuery(sqlQuery);
      
 

      
      boolean foundMatch = false;
       
       if (results.next()){
          //if match
          foundMatch = true;
          //move back 1 line
          results.beforeFirst();
          
          out.println("<select id='teamList' size='10' style='width:350px;border:none' onchange='teaminfo()'>");
          out.println("<option value=''>Select a Team</option>");
          
          while (results.next()){
              
         String team = results.getString("Team");
         String yearfounded = results.getString("YearFounded");
         String nbawins = results.getString("NBAWins");
         String yearofwin = results.getString("YearofWin");
         
         //weblogo return as website/logo
         //String weblogo = teamLogoWebsite(team);
         

         String info = yearfounded + "/" + nbawins + "/" + yearofwin;
                 
         out.println("<option value='" + info +"'>"+team+"</option>");
          

         
          }
       }
    }
    catch(Exception e){
        
    }
    
%>
