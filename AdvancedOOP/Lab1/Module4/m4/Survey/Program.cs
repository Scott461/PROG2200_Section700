using System;

namespace Survey 
{
    enum Months {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5, 
        June = 6, 
        July = 7,
        August = 8,
        September = 9, 
        October = 10,
        November = 11,
        December = 12
    }

    class Data {
        private string name;
        private Months month;
        private int day;

        public string Name { get => name; set => name = value; }

        public void setMonth(int input) 
        {
            month = (Months)input;
        }

        public int getMonth() 
        {
            return (int) month;
        }

        public int Day { get => day; set => day = value; }

        public string calZod() {
            string output = name + ", you are a ";

            switch (month) {
                case Months.January: //January
                    if (Day <= 19)
                        output += "Capricon";
                    else
                        output += "Aquarius";
                    break;

                case Months.February: //Feb
                    if (Day <= 18)
                        output += "Aquarius";
                    else
                        output += "Pisces";
                    break;
                case Months.March: //March
                    if (Day <= 20)
                        output += "Pisces";
                    else
                        output += "Aries";
                    break;
                case Months.April: //April
                    if (Day <= 19)
                        output += "Aries";
                    else
                        output += "Tarus";
                    break;
                case Months.May: //May
                    if (Day <= 20)
                        output += "Tarus";
                    else
                        output += "Gemini";
                    break;
                case Months.June: //June
                    if (Day <= 20)
                        output += "Gemini";
                    else
                        output += "Cancer";
                    break;
                case Months.July: //July
                    if (Day <= 22)
                        output += "Cancer";
                    else
                        output += "Leo";
                    break;

                case Months.August: //Aug
                    if (Day <= 22)
                        output += "Leo";
                    else
                        output += "Virgo";
                    break;
                case Months.September: //Sept
                    if (Day <= 22)
                        output += "Virgo";
                    else
                        output += "Libra";
                    break;
                case Months.October: //Oct
                    if (Day <= 22)
                        output += "Libra";
                    else
                        output += "Scorpio";
                    break;
                case Months.November: //Nov
                    if (Day <= 21)
                        output += "Scorpio";
                    else
                        output += "Sagittarius";
                    break;
                case Months.December: //Dec
                    if (Day <= 21)
                        output += "Sagittarius";
                    else
                        output += "Capricorn";
                    break;
            }
            return output;

        }
    }

        class Program
    {
            static void Main(string[] args) {
                Data user = new Data(); // used to hold our info

                Console.WriteLine("What is your name?");
                user.Name = Console.ReadLine();

                Console.WriteLine("What month were you born in (int please)?");
            user.setMonth(int.Parse(Console.ReadLine()));
            

                Console.WriteLine("Enter your birth day?");
                user.Day = int.Parse(Console.ReadLine());
            Console.WriteLine(user.calZod());
            Console.ReadLine();
            }


        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}

