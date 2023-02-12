import java.util.regex.Pattern;
import java.util.regex.Matcher;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class RegexPrac {
  public RegexPrac() {}
  
  public static void main(String[] args) {
    String fileName;
    File file;
    Scanner scanner;
    String line;
    Matcher matcher;

    for(int fileNum = 1; fileNum <= 5; fileNum++){
      fileName = "TestFile" + fileNum + ".txt";
      try{
        file = new File(fileName);
        scanner = new Scanner(file);
        while(scanner.hasNextLine()){
          line = scanner.nextLine();
          Pattern pattern = Pattern.compile("\\d+");

          matcher = pattern.matcher(line); 
          if(matcher.find()){
            System.out.println(fileName + ":" + line);
          }
        }
      }catch(FileNotFoundException e){
        System.out.println("Problem Opening File");
        e.printStackTrace();
        return;
      }
      scanner.close();
    }
  }
}