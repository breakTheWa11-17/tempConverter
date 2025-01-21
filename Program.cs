using System;

namespace tempConverter
{
    class temps
    {
        private static int celsius;
        private static int fahrenheit;

        public static void Main(string[] args)
        {
            int intNumToConvert;
            double dblNumToConvert;
            bool stop = false;
            do
            {
                try
                {
                    intNumToConvert = 0;
                    dblNumToConvert = 0;

                    Console.WriteLine("Enter the temp you want converted");
                    var numberToConvert = Console.ReadLine();
                    while (!double.TryParse(numberToConvert, out dblNumToConvert) && !int.TryParse(numberToConvert, out intNumToConvert))
                    {
                        Console.WriteLine("You must enter a valid number, please try again");
                        numberToConvert = Console.ReadLine();
                    }
                    if (intNumToConvert > 0)
                    {
                        convertTemp(intNumToConvert);
                    }
                    else
                    {
                        convertTemp(dblNumToConvert);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You need to enter a number");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number you entered is too big");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to convert another temp? (Y for yes, any key for no)");
                    char more;
                    while (!char.TryParse(Console.ReadLine(), out more))
                    {
                        Console.WriteLine("Pleaase enter a valid character, try again...");
                    }
                    if (Char.ToLower(more) != 'y')
                        stop = true;
                }
            } while (!stop);

        }
        private static void convertTemp(int intNumToConvert)
        {
            try
            {
               
                int fahrenheit = (intNumToConvert * 9 / 5) + 32;
                Console.WriteLine($"{intNumToConvert} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
                int celsius = (intNumToConvert - 32) * 5 / 9;
                Console.WriteLine($"{intNumToConvert} degrees Fahrenheit is {celsius} degrees Celsius.");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Arithmetic Exeption Thrown. PLease try again");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred, please try again.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (celsius == 0 && fahrenheit == 0)
                {
                    Console.WriteLine("Temperature conversion failed.");
                }
                else
                {
                    Console.WriteLine($"{celsius} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
                }
                
            }
        
        }
        private static void convertTemp(double intNumToConvert)
        {
            try
            {

                double fahrenheit = (intNumToConvert * 9 / 5) + 32;
                Console.WriteLine($"{intNumToConvert} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
                double celsius = (intNumToConvert - 32) * 5 / 9;
                Console.WriteLine($"{intNumToConvert} degrees Fahrenheit is {celsius} degrees Celsius.");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Arithmetic Exeption Thrown. PLease try again");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred, please try again.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (celsius == 0 && fahrenheit == 0)
                {
                    Console.WriteLine("Conversion Complete.");
                }
                else
                {
                    Console.WriteLine($"{celsius} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
                }

            }

        }
    }

    }

