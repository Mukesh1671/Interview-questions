using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    int [] duplicate = new int [5] {5,3,4,2,2};
    int [] sortedDuplicate = new int [duplicate.Length];
    Array.Copy(duplicate, sortedDuplicate, duplicate.Length);
    Array.Sort(sortedDuplicate);
    
    
        for(int i = 0; i<duplicate.Length-1; i++){
            if(sortedDuplicate[i]!=sortedDuplicate[i+1]){
                continue;
                
            }
            else
            {
                Console.WriteLine(sortedDuplicate[i]);
            }
        }
   
    
  }
}
