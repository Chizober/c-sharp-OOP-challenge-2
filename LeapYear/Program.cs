using System;
 namespace LeapYears
 {
 class FindLeapYear
{
      int currentYear;
      int  total = 20;
      int count = 0;
      int first = 4;
      int  second = 0;
      int third = 0;
      int fourth = 400;
     public void LeapYear( int currentYear)
{
      while (count < total)
   {
   currentYear = currentYear += 1;
     if((currentYear % first == second) && (currentYear  % third != second) || (currentYear % fourth == second))
     {
      count +=1;
      Console.WriteLine($"{currentYear} is a leap year");
     };
   }
   }
}
 class Program{
    static void Main(string[] args)
  {
 FindLeapYear nextTwenty = new FindLeapYear();
nextTwenty.LeapYear(20);
    
  }
 }
};



