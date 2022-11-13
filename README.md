# Maximal sum of elements

The repository contains my work on self-completion of a study Task 
while taking specialized online courses for training C# developers.

An experienced Mentor checked the result and made his remarks on 
the quality of the work performed. The Task could not be completed 
until the Mentor decided that the result was up to industry standards.

The commit called “First implementation of the Task” is my original 
implementation, without any hints. All subsequent commits (if any) 
are the results of my attempts to solve Mentor's remarks and his 
suggestions for improvement the work.

According to the conditions of the school, the Mentor does not provide 
ways to solve shortcomings and sources of information. The search for 
the necessary educational information was carried out independently.
<br/><br/>

## Task Conditions

Program should find the maximum sum of elements in line from the list of lines.
<br/><br/>
Program will take path to file as input (user can enter path in console application or send as command line interface argument if they exist).
<br/><br/>
Each line of the file contains a number set (number sepatator is comma, decimal separator is point).
<br/><br/>
Result should be the number of the line with a maximum sum of elements in line.
<br/><br/>
If line contains non numeric elements - line marked as broken.
<br/><br/>
As a separate list, write a number of lines with non numeric elements ("wrong elements").
<br/><br/>

## Solution Structure

📁ParsingProject<br/>
 ┗ 📄Parsing.cs<br/>
__📁SumProject__<br/>
 ┣ 📄ConsoleInterface.cs<br/>
 ┣ 📄example.txt<br/>
 ┣ 📄Messages.cs<br/>
 ┗ 📄Program.cs<br/>
📁Task3UnitTestProject<br/>
 ┗ 📄ParsingTest.cs
 <br/><br/>

## Prerequisites

Microsoft Visual Studio 2019 or newer

* Workloads<br/>
    * ASP.NET and web development

- Individual components<br/>
    - .NET Core 3.1 Runtime (LTS) 
<br/><br/>

## Getting Started

Clone the remote repository on your local machine.<br/>
`$ git clone https://github.com/Shkurlatov/Maximal-sum-of-elements.git`
<br/><br/>
Go to the project directory.<br/>
`$ cd Maximal-sum-of-elements`
<br/><br/>
Open project solution in Microsoft Visual Studio.<br/>
`$ start Task3.sln`
<br/><br/>
There are three suggested ways to use the program:<br/>
* Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> to run the application.<br/>
Input <kbd>0</kbd> for parsing the built-in example file.<br/><br/>
* Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> to run the application.<br/>
Input the full path to the content file.<br/><br/>
* Press <kbd>Ctrl</kbd>+<kbd>`</kbd> to open an integrated Terminal.<br/>
In the Terminal enter the following command, including the full path to the content file:<br/>
    <pre>dotnet run --project SumProject <kbd>path</kbd></pre>

Press <kbd>Ctrl</kbd>+<kbd>R</kbd>,<kbd>A</kbd> to run tests.
<br/><br/>

## Usage Example
<br/>
<pre>
Please, enter file path or enter 0 for using example content file.
0

String number 11 has a maximum sum of elements.

String number 1 is incorrect!
String number 2 is incorrect!
String number 3 is incorrect!
String number 4 is incorrect!
String number 5 is incorrect!
String number 6 is incorrect!
String number 7 is incorrect!
String number 8 is incorrect!

Press any key to close this window . . .
</pre>

For a better understanding of example result output, the content of the __example.txt__ file is shown below:<br/>
<table>
<td align="center">
<img width="80" height="0">
<p>
&nbsp;1<br/>
&nbsp;2<br/>
&nbsp;3<br/>
&nbsp;4<br/>
&nbsp;5<br/>
&nbsp;6<br/>
&nbsp;7<br/>
&nbsp;8<br/>
&nbsp;9<br/>
10<br/>
11<br/>
12<br/>
13<br/>
14<br/>
15<br/>
16<br/>
17
</p>
</td>
<td align="left">
<img width="2000" height="0">
<p> 
100,100,10 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 1010 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; dsalkf<br/>
100'100<br/>
10,14 300,18<br/>
1_000<br/>
1000+1000<br/>
(3000/2)<br/>
abcdef<br/>
200.000.1<br/>
10,19<br/>
1000<br/>
200.20,812.45896069036<br/>
1,2,3,4,5<br/>
1.1,2.2,3.3,4.4,5.5<br/>
-1,-2,-3,-4,-5<br/>
1,&nbsp;2,&nbsp;3,&nbsp;4,&nbsp;5<br/>
10,10,200 &nbsp; &nbsp; &nbsp;<br/>
&nbsp; &nbsp; 20,42,500
</p>
</td>
</table>