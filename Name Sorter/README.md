Name Sorter 

The challenge requirement is as follows: 

“Build a name sorter. Given a set of names, order that set first by last name, then by any given names the person may have. A name must have at least 1 given name and may have up to 3 given names.”

Currently the program is not fully complete. It is missing unit testing & and a way for the user to enter a there own txt file full of names. Currently the path is hard coded to my own folder. And you also need to open the sorted list manually.
 ---
#Installation 

Download the Git repository (kolj6386/name-sorter) onto your machine. 

The application is written in c# and requires an installation of Microsoft Visual Studio Code or equivalent to run.
---
#User Manual 

The application is based on a command line user interface. Please issue the following command in the console prompt to run the application: 

Name Sorter ./unsorted-names-list.txt
----
#Unit Testing Using xUnit


----
#Application Design

This application contains 2 main files. 

Program.cs: Which contains the code to execute the Name Sorter program

Name_Sorter.cs: Which contains the UnsortedNames class and the class method SortNames which will take a list of names as a parameter and sort them, then return the sorted list. 


----
#Final Thoughts

Learnt a few things about c# in this challenge. I assumed coming in that it was a very “primitive” language and that I would have to do a lot more on my end but it turns out the methods are actually pretty powerful. 

For example the .Sort & and the forEach methods surprised me. 

If I had a month to work on it, I would make it so that you would be able to select your intended file and sorting method (postcode, age, first name, last name, address)  with a MVC style architecture. 
