string[] text = new string[10];
int[] array1 = new int[10];
int[] array2 = new int[10];
int[] array3 = new int[10];
string message;
char space = ' ';
string word = "";
int Array1Length = 0;
int Array2Length = 0;

for (int i = 0; i < 10; i++) text[i] = "0";                                         //задаем сразу массивам нули на случай, если введется меньше 10 чисел
Console.Clear();

for (int repeat = 0; repeat < 2; repeat++)
{                                                                                   //цикл повторяется 2 раза, чтобы записать сначала 1й массив (array1), затем 2й (array2)

    System.Console.WriteLine($"Введите 10 чисел массива array{repeat + 1} в одном сообщении. Если введете больше 10, будут считаться только первые 10. Разделяйте числа только пробелами (можно по несколько):");
    message = Console.ReadLine() + "";
    message = message.Trim();

    for (int i = 0; i < 10; i++)                                                    // Цикл повторяется по количеству слов в строке (10 по условию)
    {
        if (repeat == 1 && i == 0) for (int j = 0; j < 10; j++) text[j] = "0";      // Если мы только начали заполнять второй массив array2, то очищаем массив text, в который заполняли слова из прошлого ввода

        int indexofSpace = message.IndexOf(space);                                  // смотрим, каким по счету идет ближайший разделитель слова "пробел"
        word = "";                                                                  // переменная, в которую будет по одному попадать числа в виде строки
        int count = 0;                                                              // счетчик букв. Когда дойдет до пробела - цикл foreach остановится

        foreach (char s in message)                                                 // + Выделяет первое слово из строки message  + 
        {
            if (count < indexofSpace) word = string.Concat(word, s);                // Будет перебирать буквы, пока не дойдет до пробела, и вносить их в переменную word
            else                                                                    // когда дойдет до пробела - обрезаем исходную строку 'до пробела + сам пробел'. И прерываем цикл записи символов из строки message в слово word.
            {
                message = message.Substring(indexofSpace + 1);
                break;
            }
            count++;
        }
        if (repeat == 0) Array1Length = i + 1;                                      // считает сколько чисел в массиве1
        if (repeat == 1) Array2Length = i + 1;                                      // считает сколько чисел в массиве2

        if (indexofSpace == 0) i--;                                                 // Проверяем, если длина слова равна нулю, значит запишется пустое слово - отнимем счетчик на 1, чтобы перезаписать элемент массива
        if (indexofSpace != 0) text[i] = word;                                      // присваиваю выделенное слово word текущему элементу массива, если его длина не равна 0 
        if (indexofSpace < 0)                                                       // Если в строке не осталось слов - завершить цикл и присвоить оставшееся слово текущему элементу массива (перед этим мы в него записали пустое слово, которое осталось в "word")
        {
            text[i] = message;
            break;
        }
    }

    int k = 0;
    foreach (string ss in text)                                                     // переносим числа из строкового формата в числовой в int-овые массивы
    {
        if (repeat == 0) array1[k] = Int32.Parse(text[k]);
        if (repeat == 1) array2[k] = Int32.Parse(text[k]);
        k++;
    }
    System.Console.WriteLine();
}

for (int i = 0; i < 10; i++) array3[i] = array1[i] + array2[i];

System.Console.WriteLine();                                                         // по условию задачи надо сообщить, если длина массивов разная. Сообщит в случае, если разное количество чисел и хотя бы одно меньше 10. В противном случае нам это неважно
if (Array1Length != Array2Length) System.Console.WriteLine($"Ата-та, разная длина массивов!  У певого {Array1Length}, у второго {Array2Length} чисел");

System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("\tArray1\t\tArray2\t\tArray3");
for (int i = 0; i < 10; i++) System.Console.WriteLine($"\t{array1[i]}\t\t{array2[i]}\t\t{array3[i]}");

System.Console.WriteLine();
System.Console.WriteLine();