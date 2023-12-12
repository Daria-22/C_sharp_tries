using System;

namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;


      // Number of students in a group
      int groupSize = 5;


      // Does groupSize go evenly into students?
      int remainer = students % groupSize;
      Console.WriteLine(students % groupSize);
      
      if (remainer == 0) 
      {
        Console.WriteLine($"You can devid this group into groups of {groupSize}");

      }
      else
      {
        Console.WriteLine($"You can't divide this group in groups of {groupSize}");
      }
