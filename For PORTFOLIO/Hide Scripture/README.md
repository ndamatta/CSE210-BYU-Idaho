<picture><img src="https://img.shields.io/badge/HIDE SCRIPTURE-purple?label=c-sharp"></picture><br>
<br>
<picture><img src="https://img.shields.io/badge/DESCRIPTION:-blue"></picture><br>
The program facilitates the memorization of scripture passages by allowing users to interactively hide words in selected verses.<br>
It consists of four classes: Program, Reference, Scripture, and Word.<br>
<br>
* The `Program` class, the users can choose a scripture from a menu. The program initializes different scripture passages and sets up a user interface through the _UserInterface_ method. Users can hide words from the scripture, and the program tracks whether all words are hidden using the _IsCompletelyHidden_ method.<br>
* The `Reference` class handles scripture references. It provides constructors for single and double verses and generates formatted references using the _GetReference_ method.<br>
* The `Scripture` class is responsible for managing scripture passages. It splits a given text into words, allows users to hide words through the _HideWords_ method, and provides the original text with the _GetText_ method. The class also checks if all words are hidden using the _IsCompletelyHidden_ method.<br>
* The `Word` class represents individual words. It allows words to be hidden using the _Hide_ method and checks if a word is hidden using the _IsHidden_ method.<br>
<br>
Throughout the program, various programming concepts are showcased, including object creation and interaction, user input handling, data encapsulation, string manipulation, list management, randomization, and conditional logic.<br>
Overall, the program offers a practical demonstration of interactive text manipulation. It underscores my proficiency in string processing, object-oriented design, user interaction, and the implementation of conditional checks.<br>
<br>
Also, there is a PDF file with the UML DESIGN, that's where I planned and designed my ideas and how I wanted the program to work before I actually started coding. Even though the final design ended up a bit different, it worked as a mockup design of the main goal.