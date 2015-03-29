## MhmGreeter - MHM Academy project #1

MhmGreeter is a C# console application that:

1. Welcomes users to the program
2. Prompts users to select from a set of available greetings
3. Prints the selected greeting to the console
4. Repeats steps 2-3 until the user chooses  to exit the program

Example session:

```
$ ./MhmGreeter
Welcome to MhmGreeter!
Please select one of the following Greetings:
 a) English speaking person
 b) Dog
 c) Cat
 d) French speaking person
 e) Multilingual greeting
 f) Random greeting
 g) Impatient person
 x) Exit the application
>> a
Hello

Would you like to select another greeting? ('X' to exit):
 a) English speaking person
 b) Dog
 c) Cat
 d) French speaking person
 e) Multilingual greeting
 f) Random greeting
 g) Impatient person
 x) Exit the application
>> b
Bark!

Would you like to select another greeting? ('X' to exit):
 a) English speaking person
 b) Dog
 c) Cat
 d) French speaking person
 e) Multilingual greeting
 f) Random greeting
 g) Impatient person
 x) Exit the application
>> x
Goodbye!
```


Additional specifications: 
* The *Multilingual* greeting should randomly greet the user in French, Spanish, OR English
* The *Impatient* greeting should be polite twice, but say something rude the third time it is selected.
