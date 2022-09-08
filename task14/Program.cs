// 4. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// // 161 -> да

Console.Write("Введите число которое, будите сравнивать: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsCratno (int num1, int num2,int number)

{
return number % num1 == 0 && number % num2 ==0;
}

bool result = IsCratno(num1,num2,number);

if (result) {

Console.WriteLine($"Число {number} кратно {num1} и {num2} ");
}
else {
Console.WriteLine($"Число {number} не кратно {num1} и {num2} ");
}