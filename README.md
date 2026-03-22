# Learning Diary
A C# learning diary where I practice every day, starting from the basics and slowly moving into more advanced topics.

### Progress: Day 18 / 365
### Completion: 4.93%

# DAY 18
Today I completed 3 console tasks about inheritance.
## Task 1
- Practiced creating a base class Animal with shared properties Name and Age;
- Practiced making Dog and Cat inherit from Animal;
- Practiced using an inherited method ShowInfo() from the parent class;
- Practiced adding child-only methods Bark() and Meow();
- Practiced creating both a dog and a cat object and calling their inherited and own methods.
## Task 2
- Practiced constructor inheritance with a base class Person and a child class Student;
- Practiced making a constructor in the child class call the parent constructor with : base(name);
- Practiced storing extra child-class data with the Grade property;
- Practiced printing both inherited data and child-class data in ShowStudentInfo().
## Task 3
- Practiced using a protected field in a parent class so a child class can access it;
- Practiced making Warrior inherit from Character;
- Practiced calling the parent constructor from the child constructor with : base(health);
- Practiced reducing health in a child-class method TakeDamage();
- Practiced preventing health from going below 0 and testing the result by printing health before and after damage.
### Conclusion
Today I learned how inheritance works in C#. I practiced making child classes reuse properties and methods from a parent class,
adding their own extra methods, and calling parent constructors with base(...).
I also practiced how protected lets a child class access data from the parent class.

# DAY 17
Today I completed 5 console tasks about the this keyword, class methods, and a shared List<Player>.
## Task 1
- Practiced creating a Player class with the properties Name, Health, Mana, and Level;
- Practiced writing a constructor with parameters for all 4 values;
- Practiced using this.Name, this.Health, this.Mana, and this.Level inside the constructor;
- Created 2 different Player objects with different starting stats.
## Task 2
- Practiced making a PrintInfo() method;
- Printed each player's name, health, mana, and level;
- Called the method for both players to display their starting information.
## Task 3
- Practiced creating methods that change object data: TakeDamage(), Heal(), UseMana(), and RestoreMana();
- Added checks so invalid amounts show error messages;
- Improved UseMana() so mana cannot go below 0;
- Improved TakeDamage() so health cannot go below 0 and a dead player cannot take damage again;
- Tested all 4 methods on both player objects.
## Task 4
- Practiced creating a LevelUp() method;
- Increased Level by 1, Health by 10, and Mana by 5 inside the method;
- Called LevelUp() twice for player1 and once for player2;
- Printed the players again after leveling up and changing their stats.
## Task 5
- Practiced creating a shared static List<Player>;
- Added the 2 existing player objects into the list;
- Added 1 more new Player directly into the list with Add(new Player(...));
- Used a for loop to go through the full list and print every player's information;
- Practiced accessing a class-level list with Player.players from another class.
### Conclusion
Today I practiced using "this" inside a constructor and understood more clearly that it refers to the current object. I
also practiced making class methods that modify object data like health, mana, and level, and I learned how a static
List<Player> can be shared by the whole class and filled from another class.

# DAY 16
Today I completed 4 console tasks about classes, private fields, methods, and a bigger student grade program.
## Task 1
- Practiced creating a Person class with a Name property and a private age field;
- Practiced making a SetAge(int newAge) method that only changes the age if the value is 0 or more;
- Practiced making a ShowInfo() method that prints the person's name and age;
- Practiced testing the class with valid and invalid age values to see that a negative age does not replace the previous one.
## Task 2
- Practiced creating a BankAccount class with an Owner property and a private balance field;
- Practiced making a Deposit(double amount) method that adds money only if the amount is positive;
- Practiced making a Withdraw(double amount) method that removes money only when the amount is positive and small enough;
- Practiced making a ShowBalance() method that prints the owner's name and current balance;
- Practiced testing both successful and unsuccessful deposit and withdrawal cases.
## Task 3
- Practiced creating a Temperature class with a private celcius field;
- Practiced making a SetTemperature(double temp) method that only accepts values from -100 to 100;
- Practiced making a ShowTemperature() method that prints the current temperature;
- Practiced testing the class with one valid temperature and one invalid temperature to see that the invalid value does not replace the saved one.
## Task 4
- Practiced creating a bigger Student class with Name and StudentId properties and a private List<int> for grades;
- Practiced making an AddGrade(int grade) method that only accepts grades from 0 to 100;
- Practiced making methods to calculate the average grade and find the highest and lowest grades;
- Practiced making a HasPassed() method that checks whether the average is at least 50;
- Practiced making a ShowGrades() method and a ShowReport() method that prints the full student information;
- Practiced reading the student's name, ID, number of grades, and grade values from user input in the console;
- Practiced showing the final full report after all grades were entered.
### Conclusion
Today I practiced using classes with private fields and methods to control how data is changed.
In the first three tasks I focused on smaller classes that stored one piece of information and updated it only when the value was valid.
In the fourth task I combined several ideas into one larger Student program with a list of grades, calculations, user input, and a full report.

# DAY 15
Today I completed 15 console tasks about instance methods and static methods.
## Task 1
- Practiced creating a class with a property and constructor;
- Practiced calling an instance method from an object.
## Task 2
- Practiced storing object data like name and age;
- Practiced using an instance method to print object information.
## Task 3
- Practiced creating multiple objects from the same class;
- Learned that the same instance method can work with different object values.
## Task 4
- Practiced making a class describe its own data;
- Revised using properties inside an instance method.
## Task 5
- Practiced changing an object's value with an instance method;
- Learned how methods can update object state.
## Task 6
- Practiced using methods to turn a value on and off;
- Learned how instance methods can control an object's behavior.
## Task 7
- Practiced updating balance values with deposit and withdraw methods;
- Revised how methods can modify data stored inside an object.
## Task 8
- Practiced creating multiple song objects;
- Practiced calling the same instance method on different objects.
## Task 9
- Practiced using object values in a calculation;
- Learned how an instance method can calculate and print a result.
## Task 10
- Practiced increasing a stored value through a method;
- Revised that instance methods can repeatedly change object data.
## Task 11
- Practiced creating static methods in a class;
- Learned how to return values from static methods and print them in Main.
## Task 12
- Practiced making a helper-style class with a static method;
- Learned that static methods are useful when no object data is needed.
## Task 13
- Practiced writing a static conversion method;
- Revised returning a calculated value from a method.
## Task 14
- Practiced combining instance methods and a static method in one class;
- Learned more clearly when behavior belongs to the object and when it belongs to the class.
## Task 15
- Practiced deciding whether a method should be instance or static;
- Strengthened understanding of the difference between object behavior and class-level behavior.
### Conclusion
Today I learned the difference between instance methods and static methods much more clearly.
I understood that instance methods belong to specific objects and usually work with that object's own data,
while static methods belong to the class itself and are used when no specific object is needed.
I also practiced changing object values through methods, returning values from methods, and calling methods in the correct way.

# DAY 14
Today I completed 9 console tasks about constructors and properties, with extra focus on get and set.
## Task 1
- Practiced creating a class with one property;
- Practiced setting a property value and reading it back.
## Task 2
- Practiced using multiple properties in one class;
- Practiced storing and printing several values from an object.
## Task 3
- Practiced changing a property after object creation;
- Learned that properties can be updated later, not only when the object is created.
## Task 4
- Practiced combining properties with a constructor;
- Learned how a constructor can assign starting values to properties.
## Task 5
- Practiced using a constructor for one value and a property for another;
- Understood better how constructors and properties can work together.
## Task 6
- Practiced taking user input and storing it into properties;
- Practiced adding validation so invalid values are not accepted.
## Task 7
- Practiced writing a full manual property with a private field, get, and set;
- Learned more clearly what auto-properties hide in the background.
## Task 8
- Practiced using a property with validation logic;
- Learned how set can control what values are allowed before saving them.
## Task 9
- Practiced making another validated property with user input;
- Reinforced the difference between the private field and the incoming value inside set.
### Conclusion
Today I practiced properties in much more detail, especially how get and set work. I learned that get returns
the stored value and set receives a new value from outside and can check it before saving it. I also understood much better
how properties and constructors work together – constructors help give values when an object is created, while properties
let me control and change values later. After fixing my mistakes with value and the private field,
I now feel much more confident using constructors, properties, and validation inside setters.

# DAY 13
Today I completed 10 console tasks about constructors, properties, and encapsulation.
## Task 1
- Practiced creating a constructor inside a class;
- Learned how to pass values into an object at the moment it is created.
## Task 2
- Practiced creating multiple objects with the same constructor;
- Learned that each object can store different values even when they come from the same class.
## Task 3
- Practiced using auto-properties with 'get; set;';
- Learned that properties can be used like normal values from outside the class.
## Task 4
- Practiced combining properties with a constructor;
- Learned how constructor parameters can be assigned into properties.
## Task 5
- Practiced using properties, constructors, and a method in the same class;
- Learned how an object method can print the object's own information.
## Task 6
- Practiced making a private field and a public property;
- Learned how 'set' can be used to block invalid values.
## Task 7
- Practiced using 'private set';
- Learned that a value can be readable from outside the class but only changeable inside the class itself.
## Task 8
- Practiced validation inside a property with a rule for minimum temperature;
- Learned how a property can protect data from impossible values.
## Task 9
- Practiced making a property with only 'get';
- Learned that a property can calculate and return a value instead of storing it directly.
## Task 10
- Practiced combining constructor, properties, validation, private fields, and methods in one class;
- Revised how encapsulation helps control and protect object data.
### Conclusion
Today I learned more about how classes can control their own data. I think I understand constructors quite well now,
especially how they set starting values when an object is created. I also practiced 'get' and 'set', private fields, validation, and 'private set',
but I still need more practice with fully understanding how properties work behind the scenes.

# DAY 12
Today I completed 12 console tasks about classes and objects.
## Task 1
- Practiced creating my first custom class;
- Learned how to make an object and assign values to its fields.
## Task 2
- Practiced creating multiple objects from the same class;
- Learned that each object can store different values.
## Task 3
- Practiced adding a method inside a class;
- Learned how an object can print its own information with that method.
## Task 4
- Practiced working with several objects of the same class;
- Revised calling methods on multiple different instances.
## Task 5
- Practiced making a class with both data and behavior;
- Learned how methods like Bark() can use the object’s field values.
## Task 6
- Practiced designing a simple game-related class;
- Learned how to group character stats and actions inside one object.
## Task 7
- Practiced storing user input inside an object;
- Learned how classes can be combined with Console.ReadLine() and parsing.
## Task 8
- Practiced changing an object’s data through a method;
- Learned how calling a method can update field values.
## Task 9
- Practiced comparing field values from two different objects;
- Revised using if statements with object data.
## Task 10
- Practiced combining arrays with classes;
- Learned how to create an array of objects and loop through it.
## Task 11
- Practiced making a method that changes a value inside an object;
- Learned more clearly how objects can update their own state.
## Task 12
- Practiced making a method that returns a value;
- Learned how to use return to calculate and then print an object’s result.
### Conclusion
Today I learned the basics of classes and objects in C#. I practiced creating custom types, making objects with new,
assigning values to fields, and calling methods on those objects.
I also learned how classes can work together with earlier topics like arrays, conditions, methods, and user input.

# DAY 11
Today I completed 15 console tasks about List<T>.
## Task 1
- Practiced creating a List<int> with values already inside it;
- Practiced printing list values with a for loop.
## Task 2
- Practiced accessing the first and last items in a list by index;
- Revised using .Count to find the last position.
## Task 3
- Practiced creating an empty list;
- Learned how to add values one by one with Add().
## Task 4
- Practiced changing a value inside a list by index;
- Learned that list items can be replaced directly.
## Task 5
- Practiced checking how many items a list has;
- Revised the difference between .Count for lists and .Length for arrays.
## Task 6
- Practiced removing an item from a list by value;
- Learned how Remove() changes the list contents.
## Task 7
- Practiced removing an item from a list by index;
- Revised how indexes shift after removing an item.
## Task 8
- Practiced checking whether a value exists in a list;
- Learned how to use Contains() for simple checks.
## Task 9
- Practiced placing a new item into a specific position in a list;
- Learned more about how Insert() works with indexes.
## Task 10
- Practiced printing list items with foreach;
- Learned that foreach gives each value directly instead of using indexes.
## Task 11
- Practiced summing all numbers in a list;
- Revised using a running total while looping.
## Task 12
- Practiced combining multiple list actions in one program;
- Revised adding, removing, printing, and counting items in a list.
## Task 13
- Practiced finding the largest number in a list;
- Revised comparing values while looping through data.
## Task 14
- Practiced counting how many times a word appears in a list;
- Learned how to check repeated values one by one.
## Task 15
- Practiced reading user input into a list;
- Learned more clearly when to use Add() instead of assigning by index in an empty list.
### Conclusion
Today was very useful because I learned how List<T> works and how it differs from arrays. I never used lists before.
I practiced adding, removing, inserting, checking, and looping through dynamic collections.

# DAY 10
Today I completed 12 console tasks about strings.
## Task 1
- Practiced creating string variables;
- Practiced printing text values to the console.
## Task 2
- Practiced joining strings together;
- Learned how to combine first name and last name into one text value.
## Task 3
- Practiced reading text input from the user;
- Practiced using string interpolation to print multiple values in one sentence.
## Task 4
- Practiced using .Length with strings;
- Learned how to check how many characters a word contains.
## Task 5
- Practiced accessing characters by index;
- Learned how to print the first and last character of a word.
## Task 6
- Practiced changing text case;
- Learned how to use .ToUpper() and .ToLower().
## Task 7
- Practiced removing extra spaces from text;
- Learned how .Trim() changes both the text and its length.
## Task 8
- Practiced checking whether text contains specific content;
- Learned how to use .Contains().
## Task 9
- Practiced checking how text begins and ends;
- Learned how to use .StartsWith() and .EndsWith().
## Task 10
- Practiced replacing part of a string with different text;
- Learned how to use .Replace().
## Task 11
- Practiced using escape characters in strings;
- Learned how to print a new line with \n and quotation marks with \".
## Task 12
- Practiced combining multiple string features in one program;
- Revised length, indexing, uppercase, and lowercase together.
### Conclusion
Today was a good revision and practice day. I learned more about what strings can do in C#,
especially how to check, change, and analyze text in different ways.

# DAY 9
Today I completed 7 console tasks about useful array tools and light array revision.
## Task 1
- Practiced creating a string array;
- Practiced printing array values with a for loop.
## Task 2
- Practiced printing array values with foreach;
- Learned the difference between for and foreach for arrays.
## Task 3
- Practiced using Array.IndexOf();
- Learned that it returns -1 when the value is not found.
## Task 4
- Practiced using Array.Sort();
- Learned that sorting changes the original array.
## Task 5
- Practiced using Array.Reverse();
- Learned how to print the changed array after reversing it.
## Task 6
- Practiced sorting an array and then reading specific values from it;
- Learned how to get the smallest and biggest value after sorting.
## Task 7
- Practiced filling an array with user input;
- Combined input, printing, sorting, and finding the smallest and biggest values.
### Conclusion
Today was a nice and easy practice day. I learned a tiny bit more, but mostly I was revising
and strengthening what I already know. It felt light and manageable, which was good for a tired day.

# DAY 8
Today I completed 12 console tasks about nested loops and 2D arrays.
## Task 1
- Practiced creating and printing a 2D array as a grid;
- Learned how nested loops move through rows and columns.
## Task 2
- Practiced accessing specific values in a 2D array by using row and column indexes;
- Revised how first, last, and other positions are found in a grid.
## Task 3
- Practiced creating an empty 2D array with a fixed size;
- Learned how to assign values manually into specific row and column positions.
## Task 4
- Practiced filling a 2D array with user input;
- Learned how to use nested loops to read values into a grid.
## Task 5
- Practiced summing all values inside a 2D array;
- Revised how to use a running total with nested loops.
## Task 6
- Practiced finding the biggest and smallest values in a 2D array;
- Learned how to compare values while looping through a grid.
## Task 7
- Practiced printing each 2D array value together with its position;
- Learned how indexes and values connect inside a grid.
## Task 8
- Practiced searching for a target value in a 2D array;
- Learned how to store and print the row and column of a found value.
## Task 9
- Practiced checking values in a 2D array with conditions;
- Learned how to count even and odd numbers in a grid.
## Task 10
- Practiced calculating the sum of each row separately;
- Learned how the outer loop can control which row is currently being processed.
## Task 11
- Practiced working toward calculating the sum of each column separately;
- Revised the idea that row-based and column-based logic use nested loops differently.
## Task 12
- Practiced finding the biggest value and its position in a 2D array;
- Learned how to track both the value and its row and column while looping.
### Conclusion
Today felt very productive: I learned how nested loops really work and created 2D arrays for the first time.
I now understand much better how rows and columns are accessed, how grids are printed,
and how nested loops can be used to search, count, and calculate inside 2D arrays.

# DAY 7
Today I completed 12 console tasks about arrays in more detail.
## Task 1
- Practiced creating an integer array with chosen values;
- Practiced printing all array values with a for loop;
- Practiced printing the first and last value of an array.
## Task 2
- Practiced creating a string array;
- Practiced printing each value with a foreach loop;
- Learned more about arrays storing text, not only numbers.
## Task 3
- Practiced changing values inside an array;
- Revised accessing array elements by index;
- Practiced printing array contents before and after changes.
## Task 4
- Practiced reading user input into an array;
- Practiced storing entered values one by one;
- Practiced printing all entered numbers and calculating their sum.
## Task 5
- Practiced finding the largest number in an array;
- Practiced finding the smallest number in an array;
- Revised comparing values while looping through an array.
## Task 6
- Practiced checking array values with conditions;
- Practiced counting even and odd numbers;
- Revised using % 2 == 0.
## Task 7
- Practiced printing array indexes together with values;
- Learned more clearly when a for loop is better than foreach;
- Practiced displaying index and value in the same output line.
## Task 8
- Practiced sorting an array with Array.Sort();
- Practiced reversing an array with Array.Reverse();
- Learned how built-in array methods change the original array.
## Task 9
- Practiced searching for a value in an array;
- Learned how to use Array.IndexOf();
- Practiced checking whether a value exists or not.
## Task 10
- Practiced clearing elements in an array with Array.Clear();
- Learned that cleared integer values become default values;
- Practiced printing the array before and after clearing elements.
## Task 11
- Practiced sorting and reversing a string array;
- Learned that array methods also work with strings;
- Revised printing array values multiple times after changes.
## Task 12
- Practiced creating an array with a size chosen by the user;
- Practiced filling the array dynamically with input;
- Practiced printing all values and calculating the total sum.
### Conclusion
Today I went deeper into arrays and practiced much more than just basic indexing and .Length.
I worked with both integer and string arrays, used both for and foreach, and learned when each loop is more useful.
I also practiced important built-in array tools like sorting, reversing, searching, and clearing,
while continuing to strengthen my understanding of input, loops, and working with multiple values in one structure.

# DAY 6
Today I revisited the earliest C# topics in much greater depth instead of rushing forward.
From now on, my learning strategy is to study each topic in layers: first the core syntax, then practical usage,
then deeper related features, common mistakes, and code quality details.
This means I’ll rebuild my foundation properly day by day before climbing back up to arrays and beyond.
## Task 1
- Practiced basic data types again: int, float, double, string, char, and bool;
- Revised the difference between declaring a variable and assigning a value;
- Learned more clearly that float values need the f suffix;
- Revised that char uses single quotes, not double quotes.
## Task 2
- Practiced reassigning variable values;
- Learned how to update a variable using itself, like x = x + 10;
## Task 3
- Practiced arithmetic operators: +, -, *, /, and %;
- Revised how to print calculation results clearly.
## Task 4
- Learned the difference between integer division and decimal division;
- Revised that int / int cuts off the decimal part;
- Learned that float and double division can keep decimal values.
## Task 5
- Practiced compound assignment operators: +=, -=, *=, /=;
- Understood more clearly how they are shorter versions of normal reassignment.
## Task 6
- Practiced increment and decrement with ++ and --;
## Task 7
- Revised the difference between Console.WriteLine() and Console.Write();
- Understood more clearly how WriteLine() moves to the next line while Write() stays on the same line.
## Task 8
- Practiced string concatenation with +;
- Practiced string interpolation with $"...";
- Learned more clearly that interpolation is often easier to read.
## Task 9
- Practiced escape characters like \n, \t, \", and \\;
- Learned why verbatim strings with @ are useful, especially for file paths;
- Practiced writing quotation marks inside both normal and verbatim strings;
- Noticed a small code quality detail: spelling in output matters, for example sentence instead of sentance.
## Task 10
- Learned how to use const for values that should never change;
- Learned that constants are usually written in PascalCase in C#.
## Task 11
- Combined variables, const, interpolation, arithmetic expressions, bool, and char in one mini challenge;
- Practiced writing clearer and more accurate output messages;
- Revised that naming should be clear and descriptive for better code quality.
### Conclusion
Today was important because I started rebuilding my C# foundation properly instead of only moving forward quickly.
I revised the earliest topics in much greater depth and also paid attention to small code quality details like clearer naming,
correct constant naming style, accurate output wording, and correct spelling in printed text.

# DAY 5
Today I completed 9 console tasks about arrays.
## Task 1
- Practiced creating an integer array;
- Practiced printing array values with a for loop.
## Task 2
- Practiced accessing specific array elements by index;
- Learned how to print the first and last value of an array.
## Task 3
- Practiced changing values inside an array;
- Learned that printing an array variable directly shows its type, not its contents.
## Task 4
- Practiced using .Length;
- Learned how to check how many elements an array has.
## Task 5
- Practiced looping through an array and summing all values;
- Revised using a variable to store a running total.
## Task 6
- Practiced finding the largest number in an array;
- Learned how to compare values while looping.
## Task 7
- Practiced creating an empty array with new int[5];
- Learned how to read user input and store it into array positions one by one.
## Task 8
- Practiced checking numbers in an array with conditions;
- Learned how to count how many values are even.
## Task 9
- Combined arrays, loops, user input, sum calculation, and largest-value checking in one task;
- Also learned the difference between Console.Write() and Console.WriteLine() more clearly.
### Conclusion
I learned how arrays work, how indexing works, how to loop through arrays, and how to calculate values from array contents.
I also understood better how console output formatting works when using Write() and WriteLine().

# DAY 4
Today I practiced methods in C# and completed the Day 4 console tasks.
## Task 1
- Created a basic void method;
- Practiced calling a method from Main().
## Task 2
- Practiced methods with parameters;
- Used a string parameter to print a personalized message.
## Task 3
- Practiced methods with multiple parameters;
- Used a method to calculate and print a sum.
## Task 4
- Learned how to return a value from a method;
- Practiced storing the returned result in a variable.
## Task 5
- Practiced returning calculated values from methods;
- Used a method to return the square of a number.
## Task 6
- Practiced methods that return bool;
- Used % to check whether a number is even.
## Task 7
- Practiced using if / else if / else inside a method;
- Returned a string value based on age categories.
## Task 8
- Combined user input with methods;
- Separated calculation logic from Main().
## Task 9
- Practiced returning and combining strings;
- Used a method to create a full name.
## Task 10
- Practiced returning clothing advice based on temperature;
- Noticed a small range mistake and fixed it after review.
## Task 11
- Combined multiple methods in one program;
- Practiced reusing methods for different calculations.
### Conclusion
Today I got comfortable with the basics of methods and understood the difference between void methods and methods that return values.
I also practiced parameters, return values, and organizing code into smaller reusable parts.

# DAY 3
Today I practiced loops in C#.
## Task 1
- Practiced using while loops;
- Learned how to repeat code until a condition becomes false.
## Task 2
- Practiced using for loops;
- Learned how to count backwards with a loop.
## Task 3
- Practiced combining user input with loops;
- Repeated output based on a number entered by the user.
## Task 4
- Practiced loop-based output formatting;
- Learned how to print repeated symbols.
## Task 5
- Practiced multiplication with loops;
- Used string interpolation to format output.
## Task 6
- Combined loops with if / else;
- Practiced counting attempts and checking conditions.
### Conclusion
Today I learned how loops work in C# and how to use them to repeat actions automatically. I also practiced combining loops with input, output, and conditions.

# DAY 2
Today I completed 8 console tasks and practiced how programs make decisions.
## Task 1
- Practiced arithmetic operators: +, -, *, /, %;
- Asked the user for two integers and calculated sum, difference, product, division, and remainder.
## Task 2
- Practiced basic if / else if / else statements;
- Checked whether a number is positive, negative, or zero.
## Task 3
- Practiced using the remainder operator %;
- Checked whether a number is even or odd.
## Task 4
- Practiced comparing values with conditions;
- Classified age into child, teenager, or adult.
## Task 5
- Practiced logical OR (||);
- Checked whether a discount applies based on age.
## Task 6
- Practiced longer if / else if chains;
- Evaluated a score and printed the correct result category.
## Task 7
- Practiced logical AND (&&);
- Checked whether a number is inside or outside the range 10 to 20.
## Task 8
- Practiced comparing strings and combining conditions;
- Created a simple login check with username and password.
### Conclusion
I practiced arithmetic, comparisons, boolean logic, and if/else statements. I understand better how C# programs make decisions based on conditions.
I’m still not focusing on input validation/error handling yet. I’ll add that later once the basics feel comfortable.

# DAY 1
Today I set up the GitHub repository and completed 4 console tasks.
## Task 1
- Practiced basic variable types (int, string, float, bool);
- Practiced printing output with Console.WriteLine().
## Task 2
- Practiced formatting output using string interpolation ($"...{var}...") and string concatenation ("..." + var).
## Task 3
- Learned how to read user input with Console.ReadLine();
- Converted input to numbers using int.Parse().
## Task 4
- Converted input to decimals using float.Parse();
- Practiced basic branching with switch (I’ll also learn the if/else alternative).
### Conclusion
Today felt productive: I learned new things and revised what I already knew.
I’m not focusing on input validation/error handling yet. I’ll add that later once the basics feel comfortable.