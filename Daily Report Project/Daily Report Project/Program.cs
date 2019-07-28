using System;


class program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy" + "\r\n" + "Student Daily Report");

        Console.WriteLine("What course are you on?: ");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number are you on?: ");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false': ");
        bool helpResponse = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveShare = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string otherFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?: ");
        int studyHours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
       

        //Console.WriteLine(courseName);
        //Console.WriteLine(pageNumber);
        //Console.WriteLine(helpResponse);
        //Console.WriteLine(positiveShare);
        //Console.WriteLine(otherFeedback);
        //Console.WriteLine(studyHours);
       
        Console.ReadLine();
    }
}
