
//enjoy the chaos ( ͡° ͜ʖ ͡°)

using System; using System.Collections.Generic; using System.Linq; using System.Text;
using System.Threading.Tasks; namespace ConsoleApp2{class Program{static void Main(string[] args){while
(true){Console.WriteLine("Give me a thing"); string I1 = Console.ReadLine(); Console.WriteLine("Give me " +
"another thing"); string I2 = Console.ReadLine(); int intC; if (int.TryParse(I1, out intC)){ Console.WriteLine("Thanks for the" +
" numbers :D"); int w = int.Parse(I1); int p = int.Parse(I2); int m = w; int o = p; int result; void Calculate() { if (m == o) { result = (m + o) * 3; } else
 result = m + o; } Calculate(); Console.WriteLine("Result:"); Console.WriteLine(result); Console.ReadLine(); }else {Console.WriteLine("Thanks for" +
" the words :D");int L1 = I1.Length;int L2 = I2.Length;int m = L1; int o = L2; int result;void Calculate() { if (m == o) { result = (m + o) * 
 3; } else result = m + o; } Calculate(); Console.WriteLine("Result:"); Console.WriteLine(result); Console.ReadLine();}Console.ReadLine();}}}}

// - Louise PJ 