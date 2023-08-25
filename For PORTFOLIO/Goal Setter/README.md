<picture><img src="https://img.shields.io/badge/GOAL SETTER-purple?label=c-sharp"></picture><br>
<br>
<picture><img src="https://img.shields.io/badge/DESCRIPTION:-blue"></picture><br>
The program is designed as a versatile goal tracking system with a focus on various goal types and user interaction. It's structured into several classes that work together to provide goal creation, tracking, and management capabilities.<br>
<br>
* The `Program` class acts as the core of the application. It initiates the interaction with the user, prompting for their name and creating a user instance. It then presents a menu where users can create new goals, list existing goals, save and load goal progress, record events, and exit the program. This demonstrates the ability to handle user input and manage a dynamic menu system.<br>
* The `Goal` abstract class serves as the blueprint for different types of goals. It holds common attributes like name, description, points, and completion status. Derived classes like `SimpleGoal`, `EternalGoal`, and `ChecklistGoal` provide specialized implementations for various goal types. This showcases inheritance, abstraction, and polymorphism, fundamental concepts in object-oriented programming.<br>
* The `User` class is responsible for managing user-specific data. It enables the creation of new goals, display of existing goals, saving and loading goals to/from a file, and recording events related to goal completion. This part of the program emphasizes file I/O, list management, and conditional logic to handle various goal types.<br>
<br>
Each specific goal type class, such as SimpleGoal, EternalGoal, and ChecklistGoal, implements its unique behavior while adhering to the shared structure defined in the Goal class. This demonstrates proper encapsulation, method overriding, and specialization based on goal types.<br>
<br>
Overall, the program showcases my proficiency in various programming concepts including user interaction, object-oriented design principles, inheritance, abstraction, polymorphism, file handling, and data management.<br>
<br>
Also, there is a PDF file with the UML DESIGN, that's where I planned and designed my ideas and how I wanted the program to work before I actually started coding. Even though the final design ended up a bit different, it worked as a mockup design of the main goal.
