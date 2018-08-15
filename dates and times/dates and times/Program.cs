using System;

namespace dates_and_times
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime myValue = DateTime.Now;

            //below are the conversions you'll use all the time, just remember short and long. Are you trying to get short and readable or alot of detail
            //Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());


            //below is all date time math
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            
            //below just gives you the name of the month, theres also day of week etc. 
            //Console.WriteLine(myValue.Month);


            //this is how you declare a specific date and time 
            // DateTime myBirthday = new DateTime(1991, 01, 4); 
            //Console.WriteLine(myBirthday.ToShortDateString());

            //using parse also declares the date time like the above 
            //if you want to do math between two dates you can use timespan. in this you can subtract unlike above. 
            DateTime myBirthday = DateTime.Parse("09/21/1990");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
