using System;
using System.Collections;

namespace CollectionsApplication{

class Him

{

static void Main()
{
 Stack st = new Stack();

  st.Push('1');
  st.Push('2');
  st.Push('3');
Console.WriteLine("Current stack is");
foreach(char c in st)
{
 Console.WriteLine(c+ " ");
}
Console.WriteLine();

}
}


}