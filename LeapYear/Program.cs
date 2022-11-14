using System;
 namespace LeapYears
 {
 class FindLeapYear
{
     public int currentYear;
     public int  total = 20;
     public int count = 0;
     public void LeapYear( int currentYear)
{
      while (count < total)
   {
   currentYear = currentYear += 1;
     if((currentYear % 4 == 0) && (currentYear  % 100 != 0) || (currentYear % 400 == 0))
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



