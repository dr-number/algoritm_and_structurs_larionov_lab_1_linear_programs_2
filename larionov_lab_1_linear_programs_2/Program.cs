namespace LarionovLab1LinearPrograms2 //Пространство имён
{
    class Class1    //Класс
    {
        static void Main(string[] args)     //Главная функция
        {
            void functionMyZ1(double x, bool isMore = true)  //Функция вычисляющая значение z1
            {
                Console.WriteLine("      x^2 + 2x - 3 + (x+1) * Корень из (x^2 - 9)");          //Выводим на экран исходную формулу
                Console.WriteLine("Z1 = --------------------------------------------------");   //Выводим на экран исходную формулу
                Console.WriteLine("      x^2 - 2x - 3 + (x-1) * Корень из (x^2 - 9)\n\n");      //Выводим на экран исходную формулу

                Console.WriteLine($"      {x}^2 + 2 * {x} - 3 + ({x} + 1) * Корень из ({x}^2 - 9)");    //Выводим на экран исходную формулу со значением x
                Console.WriteLine($"Z1 = --------------------------------------------------");          //Выводим на экран исходную формулу со значением x
                Console.WriteLine($"      {x}^2 - 2 * {x} - 3 + ({x} - 1) * Корень из ({x}^2 - 9)\n\n");//Выводим на экран исходную формулу со значением x

                //part 1
                double val1 = Math.Pow(x, 2); //Вычисление промежуточных значений
                double val2 = 2 * x;            //Вычисление промежуточных значений
                double val3 = x + 1;            //Вычисление промежуточных значений
                double val4 = Math.Pow(x, 2);   //Вычисление промежуточных значений
                double val5 = x - 1;        //Вычисление промежуточных значений

                double underRoot = val4 - 9;

                if (underRoot < 0)    //если значение под корнем отрицательное
                {
                    Console.ForegroundColor = ConsoleColor.Red;         //выведем ошибку красным цветом
                    Console.WriteLine($"Невозможно извлечь корень из: {underRoot}!\n\n");   //Выводим информацию для пользователя
                    Console.ResetColor();   //сбросим цвета консоли
                    return; //Выходим из функции
                }

                double val6 = Math.Sqrt(underRoot);  //Вычисление промежуточных значений

                //part 2
                double val7 = val1 + val2 - 3;   //Вычисление промежуточных значений
                double val8 = val1 - val2 - 3;   //Вычисление промежуточных значений

                double val10 = val6 * val3;   //Вычисление промежуточных значений
                double val11 = val6 * val5;   //Вычисление промежуточных значений

                //part3
                double val12 = val7 + val10; //Вычисление промежуточных значений
                double val13 = val8 + val11; //Вычисление промежуточных значений

                if (isMore) //Если нужно отобразить ход вычислений
                {
                    //part1
                    Console.WriteLine($"      {val1} + {val2} - 3 + {val3} * Корень из ({val4} - 9)");       //Выводим вычисление
                    Console.WriteLine($"Z1 = --------------------------------------------------");           //Выводим вычисление
                    Console.WriteLine($"      {val1} - {val2} - 3 + {val5} * Корень из ({val4} - 9)\n\n");       //Выводим вычисление

                    Console.WriteLine($"      {val1} + {val2} - 3 + {val3} * Корень из ({underRoot})");       //Выводим вычисление
                    Console.WriteLine($"Z1 = --------------------------------------------------");           //Выводим вычисление
                    Console.WriteLine($"      {val1} - {val2} - 3 + {val5} * Корень из ({underRoot})\n\n");   //Выводим вычисление

                    Console.WriteLine($"      {val1} + {val2} - 3 + {val3} * {val6}");       //Выводим вычисление
                    Console.WriteLine($"Z1 = --------------------------------------------------");       //Выводим вычисление
                    Console.WriteLine($"      {val1} - {val2} - 3 + {val5} * {val6}\n\n");   //Выводим вычисление
                
                    //part2
                    Console.WriteLine($"      {val7} + {val10}");     //Выводим вычисление
                    Console.WriteLine($"Z1 = --------------------------------------------------");   //Выводим вычисление
                    Console.WriteLine($"      {val8} + {val11}\n\n");     //Выводим вычисление
                
                    //part3
                    Console.WriteLine($"      {val12}");  //Выводим вычисление
                    Console.WriteLine($"Z1 = --------------------------------------------------");  //Выводим вычисление
                    Console.WriteLine($"      {val13}\n\n");  //Выводим вычисление
                }


                if (val13 == 0) //Проверяем не равен ли делитель нулю
                {
                    Console.ForegroundColor = ConsoleColor.Red;         //выведем ошибку красным цветом
                    Console.WriteLine("Деление на ноль невозможно!");   //Выводим информацию для пользователя
                    Console.ResetColor();   //сбросим цвета консоли
                }
                else //Если делитель не равен нулю
                    Console.WriteLine($"Z1 = {val12 / val13}\n\n");  //Выводим конечный результат

            }

            void functionMyZ2(double x, bool isMore = true) //Функция вычисляющая значение z2
            {
                Console.WriteLine("Z2 = Корень из (x+3/x-3)");  //Выводим на экран исходную формулу

                double var1 = x + 3;    //Вычисление промежуточных значений
                double var2 = x - 3;    //Вычисление промежуточных значений

                if (isMore)  //Если нужно отобразить ход вычислений
                {
                    Console.WriteLine($"Z2 = Корень из ({x}+3/{x}-3)");      //Выводим вычисление
                    Console.WriteLine($"Z2 = Корень из ({var1}/{var2})");    //Выводим вычисление
                }


                if (var2 != 0)  //Если делитель не равен нулю
                {
                    double var3 = var1 / var2;       //Вычисление промежуточных значений

                    if (var3 < 0)    //если значение под корнем отрицательное
                    {
                        Console.ForegroundColor = ConsoleColor.Red;         //выведем ошибку красным цветом
                        Console.WriteLine($"Невозможно извлечь корень из: {var3}!\n\n");   //Выводим информацию для пользователя
                        Console.ResetColor();   //сбросим цвета консоли
                        return;
                    }

                    double var4 = Math.Sqrt(var3);   //Вычисление промежуточных значений (Извлекаем квадратный корень)

                    if (isMore)  //Если нужно отобразить ход вычислений
                    {
                         Console.WriteLine($"Z2 = Корень из ({var3})");   //Выводим вычисление
                    }

                    Console.WriteLine($"Z2 = {var4}\n");     //Выводим конечный результат

                }
                else  //Если делитель равен нулю
                {
                    Console.ForegroundColor = ConsoleColor.Red;     //выведем ошибку красным цветом
                    Console.WriteLine("Деление на ноль невозможно!");   //Выводим информацию для пользователя
                    Console.ResetColor();       //сбросим цвета консоли
                }

            }

            Console.WriteLine("Варинат №16. Ларионов Никита Юрьевич. гр. 110з\n");  //Выводим информацию о студенте и варианте работы

            Console.WriteLine("      x^2 + 2x - 3 + (x+1) * Корень из (x^2 - 9)");          //Выводим формулу №1
            Console.WriteLine("Z1 = --------------------------------------------------");   //Выводим формулу №1
            Console.WriteLine("      x^2 - 2x - 3 + (x-1) * Корень из (x^2 - 9)\n");        //Выводим формулу №1

            Console.WriteLine("Z2 = Корень из (x+3/x-3)\n");    //Выводим формулу №2

            string xStr = "";   //Переменная для строкового значения "x"
            bool isNumber = false, isMore = true;    //Переменные для определения является ли "x" числом и отображать ли ход вычислений
            string kFileName = "data.txt";  //Имя файла с исходными данными

            while (true)     //Цикл из-за которого завершение программы контролируется пользователем
            {
                Console.WriteLine("\nХотите видеть ход вычислений? [y/n]"); //Задаём вопрос пользователю
                isMore = Console.ReadLine()?.ToLower() != "n";  //Определяем режим показа информации

                Console.WriteLine($"\nВведите значение X (число). Для чтения данных из файла {kFileName} введите \"F\""); //Определяем режим работы программы
                Console.WriteLine("Для выхода введите \"Z\": ");    //Сообщаем пользователю возможность выхода из программы

                xStr = Console.ReadLine().ToLower();    //получаем значение "x"

                isNumber = double.TryParse(xStr, out var x);    //проверяем является ли "x" числом

                if (xStr == "z")     //проверяем не хочет ли пользователь прекратить работу программы
                {
                    break;   //прекращаем работу программы
                }
                else if (xStr == "f")   //проверяем не хочет ли пользователь прочитать данные из файла
                {

                    if (File.Exists(kFileName))  //Проверяем наличие файла (в папке с исполняемым файлом)
                    {
                        try //Исключение поможет избежать краха программы в случае ошибки или если прочитать данные из существующего файла не получиться 
                        {

                            StreamReader file = new StreamReader(kFileName);    //открываем файл для чтения

                            int countStrings = 0, countProcessingStrings = 0;   //переменные для подсчета значений в файле и успешных вычислений

                            while (!file.EndOfStream)   //чтение файла
                            {
                                ++countStrings; //считаем строки в файле

                                xStr = file.ReadLine(); //читаем строку
                                isNumber = double.TryParse(xStr, out x);    //проверяем является ли она числом если да, то заносим результат в переменную "x"

                                if (isNumber)   //если строка является числом
                                {
                                    Console.WriteLine("================================================================");  //начало вычислений
                                    Console.WriteLine($"X({countStrings}) = {x}\n");    //Выводим номер строки и значение числа "x"

                                    Console.ForegroundColor = ConsoleColor.Green;    //Z1 выведем зеленым цветом
                                    functionMyZ1(x, isMore);     //вычислим значение Z1 со значением "x" с учетом режима вывода информации

                                    Console.ForegroundColor = ConsoleColor.Blue;    //Z2 выведем синим цветом
                                    functionMyZ2(x, isMore);    //вычислим значение Z2 со значением "x" с учетом режима вывода информации


                                    Console.ResetColor();   //сбросим цвета консоли
                                    Console.WriteLine("================================================================\n");    //конец вычислений

                                    ++countProcessingStrings;   //инкрементируем значение успешных вычислений
                                }
                                else //если строка не число
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;  //выведем красным цветом сообщение об ошибке
                                    Console.WriteLine($"X({countStrings}) = {xStr} - не число!\n"); //Выводим номер строки и значение числа "x" с текстом ошибки
                                    Console.ResetColor();   //сбросим цвета консоли
                                }
                            }

                            file.Close();    //закрываем файл

                            Console.WriteLine($"\nКоличество строк (чисел) в файле {kFileName}: {countStrings}");   //Выводим информацию для пользователя

                            Console.ForegroundColor = ConsoleColor.Green;   //выведем текст зеленым цветом
                            Console.WriteLine($"Количество успешных вычислений: {countProcessingStrings}"); //Выводим информацию для пользователя

                            if (countStrings > countProcessingStrings)  //если не все строки в файле оказались числами
                            {
                                Console.ForegroundColor = ConsoleColor.Red;  //выведем ошибку красным цветом
                                Console.WriteLine($"Количество ошибок: {countStrings - countProcessingStrings}");   //Выводим информацию для пользователя

                            }
                        }
                        catch (Exception e) //Ловим исключение
                        {
                            Console.ForegroundColor = ConsoleColor.Red;     //выведем ошибку красным цветом
                            Console.WriteLine($"Ошибка: {e.Message}");       //Выводим информацию для пользователя
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // выведем ошибку красным цветом
                        Console.WriteLine($"Файл {kFileName} не существует!");  //Выводим информацию для пользователя
                    }

                }
                else if (!isNumber) //Если введенные пользователем данные не являются числом
                {
                    Console.ForegroundColor = ConsoleColor.Red; // выведем ошибку красным цветом
                    Console.WriteLine("\nНекорректный ввод!\n");    //Выводим информацию для пользователя
                }
                else  //Если введенные пользователем данные являются числом
                {
                    Console.WriteLine($"\nX = {x}\n");   //Выведем значение переменной "x"

                    Console.ForegroundColor = ConsoleColor.Green;   //выведем текст зеленым цветом
                    functionMyZ1(x, isMore);    //вычислим значение Z1 со значением "x" с учетом режима вывода информации

                    Console.ForegroundColor = ConsoleColor.Blue;    //выведем текст синим цветом
                    functionMyZ2(x, isMore);    //вычислим значение Z2 со значением "x" с учетом режима вывода информации
                }


                Console.ResetColor();    //сбросим цвета консоли


            }

        }
    }
}