
public class InvalidRangeExceptionException : Exception
{
    public InvalidRangeExceptionException() { }
    public InvalidRangeExceptionException(string message) : base(message) { }
    public InvalidRangeExceptionException(string message, System.Exception inner) : base(message, inner) { }
    
}

class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("-----------Exercise 1----------");
                Console.WriteLine("Enter a number: ");
                double num1 = double.Parse(Console.ReadLine());
                double sqrtNum = Math.Sqrt(num1);
                Console.WriteLine($"Square Root: {sqrtNum}");

                Console.WriteLine("-----------Exercise 2----------");
                Console.WriteLine("Enter the starting number: ");
                int startNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the ending number: ");
                int endNum = int.Parse(Console.ReadLine());

                
                
                if(startNum>=endNum){
                    throw new InvalidRangeExceptionException("Ending number must be greater than starting number. ");
                }
                
                Console.WriteLine($"Enter (end - (start-1)) numbers: ");
                ReadNum(startNum, endNum);

            }

            catch(InvalidRangeExceptionException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            catch(Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
            
            
            
            finally
            {
                Console.WriteLine("Good bye");
            }

            static void ReadNum(int startNum, int endNum)
            {

                for(int i = startNum; i <= endNum; i++){

                    Console.WriteLine($"[{i}] Enter a number: ");
                    int num = int.Parse(Console.ReadLine());

                    if(num <=1 || num >= 100)
                    {
                        throw new ArgumentException("Number must be greater than 1 and less than 100.");
                    }


                }

                



            }

            Console.ReadKey();



        }
    }
