using System;

class MainClass {
  public static void Main (string[] args) {
     
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());

    int flag=0;  

    for(int counter = 2;counter < number;counter++){
     
       if (number % counter == 0) {
        flag++;            
        break;     
      }
    }  
        
    if (flag==0)
    {
      Console.WriteLine("Prime");
    }
    else
    {
      Console.WriteLine("Non Prime");
    }
    
  }
}
        
        
        
        

        
          
      
         
        
      
      
       

