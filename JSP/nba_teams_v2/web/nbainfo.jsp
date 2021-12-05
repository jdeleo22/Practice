<%-- 
    Document   : nbainfo
    Author     : John
--%>
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
       
        String radioInput;
        radioInput = request.getParameter("rbKey");
        
       //String sqlQuery = "Select * from nba_table where match(Team,YearFounded,NBAWins,YearofWin) against('"+userSearch+"' in natural language mode)";
       String sqlQuery = "";
          
       
       if (radioInput.equals("(i)")){     
       sqlQuery = "Select * from nba_table";
    }   //all
       else if (radioInput.equals("(ii)")){
       sqlQuery = "SELECT * FROM nba_table ORDER BY `YearFounded` ASC, `NBAWins` ASC limit 5";
    }//top 5 oldest
       else if (radioInput.equals("(iii)")){
       sqlQuery = "SELECT * FROM nba_table ORDER BY `YearFounded` DESC, `NBAWins` ASC limit 5";
    } //not done
       else if (radioInput.equals("(iv)")){
       sqlQuery = "SELECT * FROM nba_table ORDER BY `NBAWins` DESC limit 1";
    }
       else if (radioInput.equals("(v)")){
       sqlQuery = "select * from nba_table where YearofWin like '%1970%' OR YearofWin like '%1980%' OR YearofWin like '%1990%'";
    }
       
       Statement stmt = conn.createStatement();
      ResultSet results = stmt.executeQuery(sqlQuery);
      
      String team = "";
      String yearfounded="";
      String nbawins="";
      String yearofwin = "";
      String info = "";
      boolean foundMatch = false;
       
       if (results.next()){
          //if match
          foundMatch = true;
          //move back 1 line
          results.beforeFirst();
       out.println("<table border='1'>");
          out.println("<tr><th colspan='4'>Search Result(s)</th></tr>");
          out.println("<tr><th>Team</th><th>Year Founded</th><th>Number of Championships</th><th>Winning years</th></tr>");   
          
          
          while (results.next()){
              
              team = results.getString("Team");
         yearfounded = results.getString("YearFounded");
         nbawins = results.getString("NBAWins");
         yearofwin = results.getString("YearofWin");
         
         if (foundMatch = true){
             
             out.println("<tr><td>"+team+"</td><td>"+yearfounded+"</td><td>"+nbawins+"</td><td>"+yearofwin+"</td></tr>");
             
             //out.println("team: "+team+" yearfound "+yearfounded+" wins "+nbawins+" years of win "+yearofwin);
             
         }
          }
       }
       out.println("</table>");
    }
    catch(Exception e){
        out.println(e);
    }

    %>