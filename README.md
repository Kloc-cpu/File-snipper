# File-snipper

**File snipper takes your .XML file and desects it into smaller .XML files.**

you have to select the path to your .XML and the destination to which the new files will be saved to.
The amount of items per file will determine how many files will be outputed, and the root will automaticly be printed in the new file, they will be named after your orignial file and a unique number.

_example:
example.XML -> example1.XML, example2.XML ,..._

The file snipper works by determening how many nodes there are in your file, that and the number of items per file decides how many files you'll have which is saved into a for loop. if the numbers are not devisible then a if sentence will activate and make a variable check = 1 which will then add one more file.

_example:
5 nodes / 2 nodes per file = 2.5 -> (int)2
5 % 2 > 0 (which is true here)
check = 1_
