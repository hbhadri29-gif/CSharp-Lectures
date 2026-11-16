using System; 
  
class CodeExample { 
  
    // Private members
    private string str1; 
  
    public void setdata(string s) 
    { 
        str1= s; 
    } 
  
    // Displaying the value of str1
    public void Display() 
    { 
        Console.WriteLine("String is: " + str1); 
    } 
  
    // Method for returning object 
    public CodeExample Astr(CodeExample ex) 
    { 
  
        // Creating object of CodeExample 
        CodeExample obj = new CodeExample(); 
        obj.str1= str1+ ex.str1; 
  
        // Returning the object 
        return obj; 
    } 
} 
  
// Driver Class 
class CodingNinjas { 
  
    // Main method 
    static void Main() 
    {
        CodeExample o1 = new CodeExample(); 
        CodeExample o2 = new CodeExample();
        o1.setdata("CODING "); 
        o2.setdata("NINJAS"); 
        CodeExample o3 = o1.Astr(o2);
        o1.Display(); 
        o2.Display(); 
        o3.Display(); 
    } 
}