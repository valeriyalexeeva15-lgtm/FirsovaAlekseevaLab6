
//try
//{
//    int x = Convert.ToInt32(Console.ReadLine();
//    int y = x / 0;
//    Console.WriteLine($"Результат: (у");
//}
//catch (DivideByZeroException ex)
//{

//}
//catch (FormatException ex)
//{

//}
//catch (Exception ex)
//{

//    Console.WriteLine("Конец программы");
//}
//Console.Write("Введите первое число: ");
//double number1 = Convert.ToDouble(Console.ReadLine();
//Console.Write("Введите второе число: ");
//double number2 = Convert.ToDouble(Console.ReadLine();
//Console.Write("Введите операцию (+, -, *, /): ");
//string? op = Console.ReadLine();
//double result = 0;
//if (op == "+") result = number1 + number2;
//else if (op == "-") result = number1 - number2;
//else if (op == "*") result = number1 * number2;
//else if (op == "/") result = number1 / number2;
//else Console.WriteLine("Неизвестная операция!");
//switch (op)
//{
//    case "+": result = number1 + number2; break;
//    case "-": result = number1- number2; break;
//    case "*": result = number1* number2; break;
//    case "/": result = number1 / number2; break;
//    default: Console.WriteLine("Неизвестная операция!"); return;
//        try
//        {
//            switch (op)
//            {
//                case "+": result = number1 + number2; break;
//                case "-": result = number1 - number2; break;
//                case "*": result = number1 * number2; break;
//                case "/": result = number1 / number2; break;
//                default: Console.WriteLine("Неизвестная операция!"); return;
//            }
//        } catch {
//              case "/":
//                if (number2 == 0)
//                    throw new DivideByZeroException("Нельзя делить на ноль!");
//                result = number1 / number2; break;
//            } catch (FormatException)
//        {
//            Console.WriteLine("Ошибка ввода! Введите корректные числа.");
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
//        }

//        finally {
//            Console.WriteLine("Работа калькулятора завершена."); }

//int number = 12;
//Console.WriteLine(number.ToString());
//bool boolean = true;
//Console.WriteLine(boolean.ToString());
//DateTime now = DateTime.Now;
//Console.WriteLine(now.ToString());
//object me = new();
//Console.WriteLine(me.ToString());
//int age=int.Parse("27"); 
//DateTime birthday = DateTime.Parse("4 July 1980");
//Console.WriteLine($"I was born {age} years ago.");
//Console.WriteLine($"My birthday is {birthday}.");
//Console.WriteLine($"My birthday is {birthday:D}.");
//int count = int.Parse("abc");
//Console.Write("Какой максимальный балл по дисциплинам? ");
//string? input = Console.ReadLine();
//if (int.TryParse(input, out int count))
//{
//    Console.WriteLine($"Это (count) баллов.");
//}
//else
//{
//    Console.WriteLine("Некорректный ввод.");
//}

//Console.Write("Введите сумму: ");
//string? amount = Console.ReadLine();
//try
//{
//    decimal amountValue = decimal.Parse(amount);
//}
//catch (FormatException) when (amount.Contains("$"))
//{
//    Console.WriteLine("В суммах нельзя использовать знак доллара!");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Суммы должны содержать только цифры!");
//}
//int x = int.MaxValue - 1;
//Console.WriteLine($"Initial value: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//checked {
//int x = int. MaxValue -1;
//Console.WriteLine($"Initial value: {x}");
//x++;
//Console.WriteLine($"After incrementing: [x]");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//x++;
//Console.WriteLine($"After incrementing: [x]");
//}
//checked
//{
//    int x = int.MaxValue - 1;
//    Console.WriteLine($"Initial value: {x}");
//    x++;
//    Console.WriteLine($"After incrementing: {x}");
//    x++;
//    Console.WriteLine($"After incrementing: {x}"); 
//    x++;
//    Console.WriteLine($"After incrementing: {x}");
//try
//{
//    checked
//    {
//        int x = int.MaxValue 1;
//        Console.WriteLine $"Initial value: {x}");
//        x++;
//        Console.WriteLine $"After incrementing: {x}");
//        x++;
//        Console.WriteLine $"After incrementing: {x}");
//        x++;
//        Console.WriteLine $"After incrementing: {x}");
//    }
//}
//catch (OverflowException)
//{
//    Console.WriteLine("The code overflowed but I caught the exception.");
//}
//static double Add(double a, double b)
//{
//    return a * b; // Преднамеренная ошибка!
//}
//double a = 4.5;
//double b = 2.5;
//double answer =Add(a, b);
//Console.WriteLine($"{a} + {b} = {answer}");
//Console.WriteLine("Нажмите ENTER чтобы продолжить.");
//Console.ReadLine(); 


