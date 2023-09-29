using System;
using System.IO;
using System.Text;
public static class MyNotes
{
    public static string VariablesPageOne =
class Test
{
    public static void Main()
    {
        string path = @"c:SourceCodeProHansenberg\MeinNotes\Varibles1.txt";

        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // Create a file to write to.
            string createText = "Hello and Welcome" + Environment.NewLine;
            File.WriteAllText(path, createText);
        }

        // This text is always added, making the file longer over time
        // if it is not deleted.
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText);

        // Open the file to read from.
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
    }
}
;

    public static string VariablesPageTwo =
@"...
varibles 2
";

    public static string VariablesPageThree =
@"...
E
";

public static string BasicDataTypesPageOne = 
@"...
BDT 1
";

public static string BasicDataTypesPageTwo = 
@"...
BDT 2
";

public static string BasicDataTypesPageThree = 
@"...
BDT 3
";

public static string BasicDataTypesPageFour = 
@"...
BDT 4
";

public static string ConditionalsPageOne = 
@"...
C1
";

public static string ConditionalsPageTwo = 
@"...
C2
";

public static string ConditionalsPageThree = 
@"...
C3
";

public static string ConditionalsPageFour = 
@"...
C4
";

public static string ConditionalsPageFive = 
@"...
C5
";

public static string ArraysPageOne = 
@"...
A1
";

public static string ArraysPageTwo = 
@"...
A2
";

public static string ArraysPageThree =
@"...
A3
";

public static string LoopsPageOne =
@"...
L1
";

public static string LoopsPageTwo =
@"...
L2
"; 
public static string LoopsPageThree =
@"...
L3
";
public static string LoopsPageFour =
@"...
L4
";
public static string LoopsPageFive =
@"...
L5
";
public static string LoopsPageSix =
@"...
L6
";
public static string LoopsPageSeven =
@"...
L7
";
public static string MethodsPageOne =
@"...
M1
";
public static string MethodsPageTwo =
@"...
M2
";
public static string OOPPageOne =
@"...
O1
";

public static string OOPPageTwo =
@"...
O2
";
public static string OOPPageThree =
@"...
O3
";
public static string OOPPageFour =
@"...
O4
";
public static string OOPPageFive =
@"...
O5
";
}