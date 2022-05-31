# Temperature Converter 
A simple temperature converter for Celsius, Farenheit, and Kelvin to learn SOLID Principles

# Add badge to view if tests are passing
![Tests](https://github.com/Adstefnum/temp-conv-csharp/actions/workflows/tests.yml/badge.svg)

# TODO
- write some failing tests
- write tests to cover:
    - program main
    - other functions in program class
    - factory class functions
- Abstract Console.writeline and Console.Readline as they are external dependecies. They should be supplied as a type of reader or writer

# Information
- ```
I decided not to create an abstract class that is inherited by the converter classes in which there are fields for source 
and destination units and a function in the factory class that checks if the user inputed units match the class specfic units 
as implementations that I found for this would instantiate each class to call the match function which I felt would be too 
costly even though the code would be more concise than the dictionary I am using which finds the appropriate class and makes a single instance.
``` 
- ```
    To add a new temperature scale. We simply create new classes for them and
    extend the factory class dictionary with the newly created converter classes.
 ```
