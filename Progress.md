### Progress: Day 40 / 365
### Completion: 10.96%

# DAY 40
Today I learned about runtime errors, validation, and preventing failures.
## Task 1
- Practiced telling the difference between compile-time errors, runtime errors, and logic errors.
- Used small examples to show how each type of problem is different.
## Task 2
- Practiced validating number input with int.TryParse.
- Learned how to safely check whether text can be converted into an integer.
## Task 3
- Practiced checking input before doing division.
- Learned that division should only happen when both values are valid numbers and the second number is not zero.
## Task 4
- Practiced working with arrays together with user input.
- Continued training input validation and storing values safely in an array.
## Task 5
- Practiced checking for null before using a string.
- Learned how to avoid null-related runtime problems by checking a value before accessing its members.
### Conclusion
Today I learned that many runtime problems can be prevented before they happen by validating input and checking values carefully. I practiced recognizing different error types, using TryParse for safer number conversion, checking division safety, working with arrays, and handling null values safely.

# DAY 39
Today I learned more advanced pattern matching in C#.
## Task 1
- Practiced classifying numeric values with pattern matching;
- Created a Score method that used relational and logical patterns to print Invalid score, Fail, Pass, Good, or Excellent;
- Tested the method with five different scores: -10, 30, 68, 85, and 100.
## Task 2
- Practiced checking age ranges with pattern matching;
- Created an AgeChecker method that printed Invalid age, Child, Teen, Adult, or Senior;
- Also used a not pattern to print whether the person was an adult or not;
- Tested the method with several different ages.
## Task 3
- Practiced using property patterns with objects;
- Created a Product class with Name, Price, and InStock properties;
- Wrote a CheckProduct method that matched product properties to print Premium product in stock, Cheap product in stock, Out of stock, or Regular product;
- Tested the method with four different product objects.
## Task 4
- Practiced using nested property patterns;
- Created Customer and Order classes and stored a customer object inside each order;
- Wrote a CheckOrder method that matched both the customer's IsPremium value and the order's TotalAmount;
- Tested four orders that covered premium big, premium small, regular big, and regular small orders.
## Task 5
- Practiced tuple pattern matching with two values at once;
- Created a Point method that used a switch expression on (x, y);
- Classified points as Origin, On X-axis, On Y-axis, or one of the four quadrants;
- Tested the method with seven different coordinate pairs.
### Conclusion
Today I learned how advanced pattern matching can make condition logic much cleaner and more expressive. I practiced relational patterns, logical patterns with and/or/not, property patterns, nested property patterns, and tuple patterns.

# DAY 38
Today I learned the basics of pattern matching in C#.
## Task 1
- Practiced using the is keyword with a type pattern.
- Checked whether an object contained a string and safely used it through a new variable.
- Printed both the string and its length.
## Task 2
- Practiced checking whether an object contained an integer.
- Used pattern matching to extract the int value and work with it.
- Printed the number and the number multiplied by 2.
## Task 3
- Learned how to use pattern matching with null.
- Checked whether an object was null and printed different messages depending on the result.
## Task 4
- Practiced constant pattern matching with exact values like "start", "stop", and "pause".
- Used a switch to print the correct message for each command.
## Task 5
- Practiced using pattern matching inside a switch statement.
- Matched values by type such as int, string, bool, and null.
- Learned how switch pattern matching can describe different kinds of values cleanly.
### Conclusion
Today I learned that pattern matching in C# makes it easier to check what a value is and use it safely without manual casting. I practiced matching types with is, checking for null, matching exact constant values, and using switch pattern matching to handle different kinds of inputs.

# DAY 37
Today I learned how to use interfaces in a more practical way to design flexible programs.
## Task 1
- Practiced creating an interface and implementing it in different classes.
- Used Song and Video through the same IPlayable contract.
## Task 2
- Practiced passing an interface into a method as a parameter.
- Used IDamageable so the same method could work with both Player and Enemy.
## Task 3
- Practiced storing different classes inside one array by using a shared interface type.
- Used IPrintable[] to store Book, Movie, and Game objects and call the same method on all of them.
## Task 4
- Learned that one class can implement more than one interface.
- Used Robot with both IMovable and IRechargeable.
## Task 5
- Practiced building a small interaction system using an interface.
- Used IInteractable so Door, Chest, and NPC could all be handled through the same contract.
### Conclusion
Today I learned more about interface-based design and how interfaces help make code more flexible. I practiced using interfaces as contracts, passing them into methods, storing different objects in interface arrays, and letting one class implement multiple interfaces.

# DAY 36
Today I learned how interfaces work in C# and how they are used as contracts.
## Task 1
- Created my first interface, IAnimal, with the method Speak().
- Implemented the interface in the Dog class and printed "Woof!".
- Practiced that a class must provide the members required by the interface contract.
## Task 2
- Created two different classes, Dog and Cat, that both implemented the same IAnimal interface.
- Practiced how different classes can follow the same contract but have different behavior.
- Used Speak() in both classes and printed different outputs.
## Task 3
- Learned how to use an interface as the variable type instead of the class type.
- Created an IPlayable reference and assigned it a Song object.
- Practiced interface-based polymorphism in a simple way.
## Task 4
- Learned how to use an interface as a method parameter.
- Created Document and Photo classes that both implemented IPrintable.
- Used one StartPrinting(IPrintable item) method to work with different object types through the same contract.
## Task 5
- Practiced implementing multiple interfaces in one class.
- Created a Machine class that implemented both IStartable and IStoppable.
- Learned that a class can inherit from only one base class, but it can implement multiple interfaces.
### Conclusion
Today I learned that interfaces are contracts that define what a class must implement. I practiced creating interfaces, implementing them in classes, using interface references, passing interfaces into methods, and implementing multiple interfaces in one class.

# DAY 35
Today I learned how abstract classes and polymorphism work in C#.
## Task 1
- Created an abstract Animal class with a Name property and an abstract MakeSound() method.
- Created a Dog class that inherited from Animal and overrode MakeSound().
- Practiced that abstract classes cannot be instantiated directly.
## Task 2
- Learned that an abstract class can also contain normal methods, not only abstract ones.
- Added a Sleep() method to Animal and used it with Dog and Cat objects.
- Practiced overriding abstract methods in multiple derived classes.
## Task 3
- Practiced basic polymorphism by storing Dog and Cat objects in Animal variables.
- Learned that the base type can reference different derived objects.
- Saw that the correct overridden method is called depending on the real object type.
## Task 4
- Created an abstract Shape class with an abstract GetArea() method.
- Made Rectangle and Circle classes that override GetArea() in their own way.
- Practiced polymorphism again by assigning Rectangle and Circle objects to Shape variables.
## Task 5
- Created an abstract Character class with an abstract Attack() method.
- Made multiple derived classes with different Attack() behaviors.
- Used an array of Character and a loop to call Attack() on different object types through one shared base type.
### Conclusion
Today I learned that abstract classes are used as base blueprints for related classes and that they can contain both normal members and abstract members. I practiced writing abstract methods, overriding them in derived classes, and using polymorphism so one base type could represent many different child objects.

# DAY 34
Today I learned how method overriding works in C# using virtual methods in base classes and override methods in derived classes.
## Task 1
- Created a base class Animal with a virtual MakeSound() method.
- Created a derived class Dog that overrode MakeSound() with its own behavior.
- Practiced calling methods on both base and derived class objects.
## Task 2
- Practiced overriding the same base method in multiple derived classes.
- Created Vehicle, Car, and Bicycle classes and gave each class its own Move() behavior.
## Task 3
- Learned that a base class reference can point to a derived class object.
- Practiced that when an overridden method is called, the derived version runs based on the real object type.
## Task 4
- Learned how to use base.MethodName() inside an overridden method.
- Created Person and Student classes and called the base version before adding extra derived class behavior.
## Task 5
- Practiced overriding the built-in ToString() method.
- Created a Book class with properties and returned a custom text representation of the object.
### Conclusion
Today I learned that overriding allows a derived class to replace a virtual method from a base class with its own version. I practiced creating virtual and override methods, saw how overridden methods behave when using base class references, used base to call the parent version of a method, and overrode ToString() to customize how an object is printed.

# DAY 33
Today I learned how inheritance works in C# with base classes and derived classes.
## Task 1
- Created a base class and a derived class.
- Practiced inheriting fields and methods from the base class and adding a new method in the derived class.
## Task 2
- Practiced extending a base class with extra members in the derived class.
- Used inherited members together with new fields and methods specific to the derived class.
## Task 3
- Learned how protected members work in inheritance.
- Practiced accessing a protected field from a derived class while keeping it hidden from outside code.
## Task 4
- Learned how a derived class can call a base class constructor with base(...).
- Practiced splitting shared data into the base class and extra data into the derived class.
## Task 5
- Practiced building a slightly fuller inheritance example with constructors.
- Used a derived class to reuse base class data and add its own specific information.
### Conclusion
Today I learned that inheritance lets one class build on another class. I practiced creating base and derived classes, using inherited members, working with protected fields, and calling base class constructors with base(...).

# DAY 32
Today I learned about ToString(), Equals(), and GetHashCode().
## Task 1
- Created a Book class with Title and Author properties.
- Overrode ToString() to return a readable string representation of the object.
- Printed the object to see how ToString() works in practice.
## Task 2
- Created a Car class and compared two different objects with the same values.
- Learned that Equals() returns false by default for classes because it compares references, not values.
## Task 3
- Overrode Equals() in a Student class to compare object data instead of references.
- Checked equality between objects with same and different values.
## Task 4
- Learned how GetHashCode() works together with Equals().
- Overrode GetHashCode() using HashCode.Combine().
- Verified that equal objects produce the same hash code.
## Task 5
- Combined ToString(), Equals(), and GetHashCode() in a Movie class.
- Compared multiple objects and printed their values and hash codes.
### Conclusion
Today I learned how objects behave when converted to strings, how equality works by default for reference types, and how to override Equals() to compare actual data. I also understood why GetHashCode() must match Equals() and how all three methods are commonly used together in real applications.

# DAY 31
Today I learned about object equality, especially the difference between value equality and reference equality in C#.
## Task 1
- Practiced comparing simple value types with ==.
- Used int, double, and bool values to see that value types compare the actual stored values.
## Task 2
- Learned that normal class objects compare by reference by default.
- Created two separate Book objects with the same data and saw that they were still not equal.
## Task 3
- Practiced assigning one object variable to another.
- Learned that when two variables point to the same object, changing one reference affects the same shared object, and equality checks return true.
## Task 4
- Practiced struct equality with Equals().
- Learned that structs are value types, so equality is based on their stored data.
## Task 5
- Practiced comparing strings with both == and Equals().
- Learned that even though string is a reference type, it compares by text content.
### Conclusion
Today I learned that equality in C# can mean different things depending on the type. Value types such as int and structs usually compare the data they store, while normal class objects usually compare whether they are the exact same object in memory. I also learned that strings are a special reference type because they compare their text content.

# DAY 30
Today I learned what records are and how immutability works in C#.
## Task 1
- Created a Book record and compared two separate objects with the same values.
- Learned that records use value equality, so two record objects with the same data can be equal.
## Task 2
- Practiced writing a record with a normal body and using init properties.
- Learned that init allows values to be assigned during object creation, but not changed later like set.
## Task 3
- Practiced using the with expression to create a modified copy of a record.
- Learned that with creates a new object while leaving the original one unchanged.
## Task 4
- Compared a record class and a record struct in one program.
- Learned that a record class is a reference type, while a record struct is a value type with writable positional properties by default.
## Task 5
- Practiced using a record that contains an array and printed its data through a separate class.
- Learned that even if the record itself looks immutable, the array inside it can still be changed, which is called shallow immutability.
### Conclusion
Today I learned that records are useful for data-focused types and make it easier to work with value equality and immutable-style design. I practiced creating records, using init-only properties, copying records with with, comparing record class and record struct behavior, and understanding shallow immutability when a record contains mutable reference-type data.

# DAY 29
Today I completed 5 console tasks about structs and value types.
## Task 1
- Practiced explaining what value types and structs are in my own words;
- Learned that structs and enums are value types, while classes are reference types.
## Task 2
- Practiced creating a simple struct with fields and assigning values to it;
- Built a Point struct and used it to store related coordinate data.
## Task 3
- Practiced creating a struct with properties, a constructor, and methods;
- Built a Rectangle struct and used it to calculate and print area information.
## Task 4
- Practiced copying a struct and comparing the copied value with the original;
- Learned that changing one struct copy does not affect the other because structs are copied by value.
## Task 5
- Practiced building a struct with validation, a conversion method, and a print method;
- Built a Temperature struct and learned the difference between returning a value and using a void method.
### Conclusion
Today I practiced how structs work in C# and how they differ from classes. I understood much better that structs are value types, which means copying them creates separate data instead of another reference to the same object.

# DAY 28
Today I learned how to declare enums.
## Task 1
- Created a Season enum and printed one of its named values.
## Task 2
- Practiced comparing enum values with if, else if, and else.
- Used a TrafficLight enum to print different messages for red, yellow, and green.
## Task 3
- Practiced using enums together with switch statements.
- Used DayType to print different messages for weekday and weekend.
## Task 4
- Learned how to pass an enum value into a method as a parameter.
- Used EnemyState in a method and printed different messages depending on the passed state.
## Task 5
- Practiced building a slightly fuller program with an enum and matching logic.
- Used OrderStatus to represent order stages and printed the correct message for each status.
### Conclusion
Today I learned that enums are useful when a variable should only store one value from a fixed list of named options. I practiced declaring enums, storing enum values in variables, comparing them with if statements, using them in switch statements, and passing them into methods.

# DAY 27
Today I completed 4 console tasks about refactoring large classes.
## Task 1
- Practiced identifying why a class is too large and poorly organized;
- Found that the class mixed different responsibilities such as car data, driver data, and other unrelated behavior;
- Explained that low cohesion and too many jobs in one class make the code harder to maintain and expand.
## Task 2
- Practiced refactoring a large class by extracting related data into a separate class;
- Created a Driver class with its own fields and kept car-related data inside the Car class;
- Connected the objects by storing a Driver object inside Car and printed both car and driver information.
## Task 3
- Practiced refactoring a long method into smaller and clearer helper methods;
- Moved validation into a separate method, moved price calculation into its own method, and kept the final printing logic short;
- Improved the structure so the class became easier to read, test, and update.
## Task 4
- Practiced removing duplicated logic from a class;
- Replaced repeated temperature validation code with one shared helper method;
- Kept the output clear for morning, afternoon, and evening while making the code shorter and cleaner.
### Conclusion
Today I learned how to recognize when a class is doing too many things and how to improve it by splitting responsibilities, extracting methods, and removing duplication. Refactoring helped me see that cleaner code is not only shorter, but also easier to understand, maintain, and expand later.

# DAY 26
Today I completed 4 console tasks about UML-style thinking for C# classes.
## Task 1
- Practiced reading a UML-style class and identifying the class name, private members, public members, data members, and methods;
- Correctly identified most members in the Player class.
## Task 2
- Practiced explaining a UML-style class in simple words by describing what data an object stores and what actions it can do;
- Correctly identified the Lamp class actions, fields, and property.
## Task 3
- Practiced converting a written class description into UML-style format;
- Correctly wrote the Car class structure with properties, a private field, and methods.
## Task 4
- Practiced turning a UML-style class into a full C# program with private fields, public properties, a constructor, and a PrintInfo() method;
- Built the Movie class correctly.
### Conclusion
Today I practiced reading UML-style class plans and turning them into actual C# code. 
I understand the general idea of class boxes, access symbols, data members, and methods much better.

# DAY 25
Today I completed 6 console tasks about association and dependency between objects.
## Task 1
- Practiced explaining composition, association, and dependency in my own words;
- Wrote real-life examples for each relationship type.
## Task 2
- Practiced identifying whether object pairs show composition, association, or dependency;
- Revised the difference between strong ownership, weaker connection, and temporary use.
## Task 3
- Practiced creating an association between objects with Teacher and Student classes;
- Connected two different Student objects to the same Teacher object.
## Task 4
- Continued the Teacher and Student task by printing the student's name, age, teacher's name, and teacher's subject;
- Added and fixed the null check so the program handles a missing teacher correctly.
## Task 5
- Practiced association again with Reader and Book classes;
- Connected a reader to one book and then reassigned the favorite book to another one.
## Task 6
- Practiced dependency with Message and ChatApp classes;
- Passed a Message object into a method and used it temporarily without storing it inside ChatApp.
### Conclusion
Today I learned the difference between composition, association, and dependency more clearly. 
I practiced both theory and coding tasks, and I correctly used association by storing object references inside other objects and dependency by passing objects into methods only for temporary use.

# DAY 24
Today I completed 3 console tasks about composition with classes inside classes.
## Task 1
- Practiced creating a Book class that contains an Author object;
- Practiced checking if the author object exists before reading its values;
- Printed the book title, author name, and author country through composition.
## Task 2
- Practiced creating a Phone class that contains a Battery object;
- Learned that the inner object must be created first before its values can be used;
- Added validation for battery capacity and percentage and printed the phone information.
## Task 3
- Practiced creating an Owner class that contains a Pet object;
- Practiced checking for null before accessing the pet's name and animal type;
- Printed a sentence using values from the inner Pet object.
### Conclusion
Today I practiced composition by building classes that contain other class objects. 
I got more comfortable with creating inner objects, assigning them to outer objects, accessing nested values with dot notation, 
and checking for null in the correct order before using inner object data.

# DAY 23
Today I completed 9 console tasks about object references and null in objects.
## Task 1
- Practiced creating and using one object;
- Created a Car class with Brand and Year properties;
- Created one Car object, assigned values to it, and printed its data.
## Task 2
- Practiced assigning one object reference to another variable;
- Created a Dog class with Name and Age properties;
- Made dog2 point to the same object as dog1;
- Changed the values through the second variable and printed both variables to see that they shared the same object.
## Task 3
- Practiced comparing two variables that point to the same object;
- Created a Student class with Name and Grade properties;
- Added an IsEqual() method that compared two objects with ==;
- Assigned student2 to student1 and printed that they were equal.
## Task 4
- Practiced comparing two separate objects with the same data;
- Created a Book class with Title and Pages properties;
- Created two different Book objects and gave them identical values;
- Compared them with == through an IsEqual() method and printed that they were not equal.
## Task 5
- Practiced working with null-related checks in an object;
- Created a Phone class with Model and Price properties;
- Added a PrintInfo() method that checked whether Model was null;
- Printed a message when the model was null, then assigned a model and printed the phone data.
## Task 6
- Practiced preventing problems with null object references;
- Created a Player class with Name and Health properties;
- Added a PrintInfo() method that checked whether the Player object was null before accessing it;
- Printed a warning for a null player, then created a real Player object and printed its data.
## Task 7
- Practiced changing object data and checking for missing values;
- Created a Laptop class with Brand and Ram properties;
- Printed the laptop data through a PrintInfo() method;
- Set the Brand property to null and printed a message showing that the name did not exist yet.
## Task 8
- Practiced using a method with an object parameter and null-related checks;
- Created a Character class with Name and Level properties;
- Added a PrintCharacter() method that checked whether the object or its Name was null;
- Called the method with one Character that had data and one Character whose Name was null.
## Task 9
- Practiced combining shared references, comparisons, and null checks;
- Created an Item class with Name and Value properties;
- Made item2 point to the same object as item1 and created item3 as a separate object;
- Compared item1 with item2 and item1 with item3;
- Changed the Name through item2 and printed item1.Name to confirm the shared reference;
- Created item4 as null and safely checked it before printing.
### Conclusion
Today I practiced how object variables can point to the same object, how separate objects can contain the same data without being equal, and how null affects object usage. I got more comfortable with reference comparison, shared references, and checking for null before accessing object data.

# DAY 22
Today I completed 9 console tasks about computed properties.
## Task 1
- Practiced creating a computed property in a Rectangle class;
- Added Width and Height properties;
- Added an Area property that returned Width * Height;
- Created a rectangle object and printed its width, height, and area.
## Task 2
- Practiced creating another computed property in a Rectangle2 class;
- Added Width and Height properties;
- Added a Perimeter property that returned the rectangle perimeter;
- Created an object and printed the perimeter.
## Task 3
- Practiced making a computed text property;
- Created a Person class with FirstName and LastName properties;
- Added a FullName property that combined the first and last name;
- Created a person object and printed the full name.
## Task 4
- Practiced making a computed bool property;
- Created a Student class with Name and Score properties;
- Added an IsPassing property that checked if the score was at least 50;
- Created a student object and printed the name, score, and passing result.
## Task 5
- Practiced making a computed property based on health;
- Created a GameCharacter class with Name and Health properties;
- Added an IsDead property that returned true when Health was 0 or less;
- Created two character objects and printed whether they were dead.
## Task 6
- Practiced using a computed property with prices and discounts;
- Created a Product class with Name, Price, and Discount properties;
- Added a FinalPrice property that used Price and Discount in a calculation;
- Created several product objects and printed their price information.
## Task 7
- Practiced converting one value into another with a computed property;
- Created a Temperature class with a Celsius property;
- Added a Fahrenheit property using the conversion formula;
- Created an object and printed both Celsius and Fahrenheit.
## Task 8
- Practiced creating a computed property from two money-related values;
- Created a BankAccount class with OwnerName, Balance, and Loan properties;
- Added a NetWorth property that returned Balance - Loan;
- Created two account objects and printed their net worth.
## Task 9
- Practiced combining multiple computed results in one class;
- Created a PlayerStats class with Wins and Losses properties;
- Added a TotalGames property that returned Wins + Losses;
- Added a WinText property that displayed wins, losses, and total games in one string.
### Conclusion
Today I practiced computed properties in many different ways. I learned that a computed property does not store its own separate value, 
but instead calculates it from other properties whenever it is accessed. I used computed properties for numbers, text, and true or false checks.

# DAY 21
Today I completed 5 console tasks about validation inside classes.
## Task 1
- Practiced validating data inside a constructor;
- Created a Person class with Name and Age properties;
- Made negative ages store as 0;
- Created and printed three different Person objects, including age 0 and a negative age.
## Task 2
- Practiced validating values inside both a constructor and methods;
- Created a BankAccount class with OwnerName and Balance properties;
- Made negative starting balance store as 0;
- Added Deposit() and Withdraw() methods with checks for invalid amounts and withdrawing more than the balance;
- Tested invalid and valid deposits and withdrawals and printed the account info after each step.
## Task 3
- Practiced validating a value range inside a class;
- Created a Student class with Name and Grade properties;
- Made grades outside the 0 to 100 range store as 0;
- Created and printed five different Student objects with valid and invalid grade values.
## Task 4
- Practiced validating product data and stock-changing actions inside a class;
- Created a Product class with Name, Price, and Stock properties;
- Added constructor validation so negative price and stock store as 0;
- Added AddStock() and Sell() methods with checks for invalid amounts and selling more than available stock;
- Tested adding stock and different selling cases, including invalid and valid amounts.
## Task 5
- Practiced validating multiple values inside one constructor;
- Created a UserAccount class with Username and PasswordLength properties;
- Made invalid usernames store as "Unknown";
- Made password lengths below 6 store as 6;
- Created and printed five different UserAccount objects with valid and invalid usernames and password lengths.
### Conclusion
Today I practiced putting validation rules inside classes so objects could not store invalid data.
I used constructors and methods to check values like age, balance, grade, stock, username, and password length before saving or changing them.

# DAY 20
Today I completed 7 console tasks about fields, properties, and methods.
## Task 1
- Practiced identifying which class members should be fields, properties, and methods;
- Classified price, score, and isOpen as private fields;
- Classified Name, Level, and Age as properties;
- Classified PrintInto(), TakeDamage(), Jump(), and OpenDoor() as methods.
## Task 2
- Practiced creating a class with public fields;
- Created a Book class with title, author, and pages fields;
- Added a PrintInfo() method to display the field values;
- Created and printed two different book objects.
## Task 3
- Practiced replacing public fields with public properties;
- Created a Book2 class with Title, Author, and Pages properties;
- Added a PrintInfo() method to display the property values;
- Created and printed two different book objects using properties.
## Task 4
- Practiced using private fields with public properties;
- Created a Movie class with private title and year fields;
- Added full properties Title and Year with get and set;
- Added a PrintInfo() method and printed two movie objects.
## Task 5
- Practiced combining a private field, public properties, and a method in one class;
- Created a Student class with a private name field and public Name and Grade properties;
- Added a PrintInfo() method to print the student's data;
- Created a student object and displayed its information.
## Task 6
- Practiced using methods to change an object's internal state;
- Created a Lamp class with a private isOn field and a public Brand property;
- Added TurnOn(), TurnOff(), and ShowState() methods;
- Tested both lamp states by turning it on and off and printing the result each time.
## Task 7
- Practiced designing a more functional class with private data, public properties, and action methods;
- Created a GameCharacter class with private health and isAlive fields and public Name and ClassType properties;
- Added TakeDamage(), Heal(), and ShowInfo() methods;
- Added extra validation for invalid damage and healing amounts;
- Added extra logic for death, max health, full healing, and preventing healing after death;
- Tested multiple different cases to make the character behavior more complete.
### Conclusion
Today I practiced the difference between fields, properties, and methods by building several classes step by step. 
I started with simple public fields, then moved to properties, then to the common pattern of private fields with public properties. 
I also practiced using methods for actions instead of treating everything like plain data.

# DAY 19
Today I completed 3 console tasks about encapsulation in practice.
## Task 1
- Practiced creating a private field age inside a Person class;
- Practiced controlling value changes with a SetAge(int newAge) method;
- Practiced returning a private field value with a GetAge() method;
- Tested both a valid age and an invalid age.
## Task 2
- Practiced creating a BankAccount class with a private balance field;
- Practiced adding money through a public Deposit(double amount) method instead of changing the balance directly;
- Added validation so only amounts greater than 0 are accepted;
- Practiced displaying the balance with a separate method.
## Task 3
- Continued the BankAccount class by adding a Withdraw(double amount) method;
- Practiced checking that withdrawal amounts must be greater than 0;
- Practiced checking that withdrawal amounts cannot be bigger than the current balance;
- Combined deposit and withdrawal logic into one encapsulated class.
### Conclusion
Today I practiced encapsulation in a more practical way by hiding fields like age and balance and controlling them through methods.

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