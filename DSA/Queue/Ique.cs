using System;
using System.Collections.Generic;

namespace Queue1{
class Pro
{
static void Main()
{

string[] course ={
"MCA",
"BCA",
"MBA",
"BCA",
"BBA",
"BTech",
"Mtech"
};

Queue <string> queue1 = new Queue <string>();
Queue <string> queue2 = new Queue <string>(course);
Queue <string> queue3 = new Queue <string>(4);


Console.WriteLine(queue1.Count);
Console.WriteLine(queue2.Count);
Console.WriteLine(queue3.Count);
}
}}