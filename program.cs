using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
      var n = Convert.ToInt32(Console.ReadLine());
     
      Dictionary<String,int> phoneBookDic = new Dictionary<String,int>();
        
      for(var i=0; i<n; i++)
      {
          var info = Console.ReadLine().Split(' ');
          var name = info[0];
          var phone = int.Parse(info[1]);
          phoneBookDic.Add(name,phone);  
      }
      
       for(var j=0; j<n; j++)
       {
            var name = Console.ReadLine();
            if(phoneBookDic.ContainsKey(name))
            {
                var phone = phoneBookDic[name];
                Console.WriteLine("{0}={1}",name,phone);
            }
           
            else
            {
                Console.WriteLine("Not found");    
            }
       }
      
       
        
      }
} 
