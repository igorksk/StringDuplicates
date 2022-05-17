using StringDuplicates;

Console.WriteLine("Hello, World!");

string test1 = "qwerty";

bool testResult1 = DuplicatesChecker.CheckForDuplicates(test1);

Console.WriteLine("String " + test1 + (testResult1? " contains duplicates" : " doesn't contain duplicates"));

string test2 = "qwertyqu";

bool testResult2 = DuplicatesChecker.CheckForDuplicates(test2);

Console.WriteLine("String " + test2 + (testResult2 ? " contains duplicates" : " doesn't contain duplicates"));
