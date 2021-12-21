// See https://aka.ms/new-console-template for more information

using Name_Sorter.SortingMethods;

// Found on microsoft docs & stack overflow 
string path = @"C:\Users\Windows Signature\source\repos\Name Sorter\Name Sorter\bin\Debug\net6.0\unsorted-names-list.txt";

// Importing the file into a list. Got this from stackoverflow. Learnt from a yt video to use a list instead of an array because a list can grow and shrink in size
var namesFile = File.ReadAllLines(path);
var namesList = new List<string>(namesFile);

// Creating our new class UnsortedNames which contains the method & logic to sort our list.
UnsortedNames UnsortedNamesList = new UnsortedNames();

// Calling our sorting method from the UnsortedNames class method.
UnsortedNamesList.SortNames(namesList);


// Found this on a youtube video. Writing the lines to a txt document.
File.WriteAllLinesAsync("sorted-names-list.txt", namesList);

