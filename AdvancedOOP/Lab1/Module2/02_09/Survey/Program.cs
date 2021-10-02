using System;

namespace Survey 
{
    class Data {
        private string name;
        private int month;
        private int day;

        public string Name { get => name; set => name = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }

        public string calZod() {
            string output = name + ", you are a ";

            switch (month) {
                case 1: //January
                    if (Day <= 19)
                        output += "Capricon";
                    else
                        output += "Aquarius";
                    break;

                case 2: //Feb
                    if (Day <= 18)
                        output += "Aquarius";
                    else
                        output += "Pisces";
                    break;
                case 3: //March
                    if (Day <= 20)
                        output += "Pisces";
                    else
                        output += "Aries";
                    break;
                case 4: //April
                    if (Day <= 19)
                        output += "Aries";
                    else
                        output += "Tarus";
                    break;
                case 5: //May
                    if (Day <= 20)
                        output += "Tarus";
                    else
                        output += "Gemini";
                    break;
                case 6: //June
                    if (Day <= 20)
                        output += "Gemini";
                    else
                        output += "Cancer";
                    break;
                case 7: //July
                    if (Day <= 22)
                        output += "Cancer";
                    else
                        output += "Leo";
                    break;

                case 8: //Aug
                    if (Day <= 22)
                        output += "Leo";
                    else
                        output += "Virgo";
                    break;
                case 9: //Sept
                    if (Day <= 22)
                        output += "Virgo";
                    else
                        output += "Libra";
                    break;
                case 10: //Oct
                    if (Day <= 22)
                        output += "Libra";
                    else
                        output += "Scorpio";
                    break;
                case 11: //Nov
                    if (Day <= 21)
                        output += "Scorpio";
                    else
                        output += "Sagittarius";
                    break;
                case 12: //Dec
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
                user.Month = int.Parse(Console.ReadLine());

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

