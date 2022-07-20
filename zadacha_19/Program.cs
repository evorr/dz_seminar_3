// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Check(int number)
{
    if (number>=10000&&number<=99999)return number;
    else{
        Console.Write("Введите пятизначное число: ");
        int newnum = Convert.ToInt32(Console.ReadLine());
        return Check(newnum);
    }
}
int cor_num = Check(num);
int Palindrome (int numb)
{
    int pal_number=0;
    while(numb>0)
    {
        int rem=numb%10;
        pal_number=pal_number*10+rem;
        numb=numb/10;
    }
    return pal_number;
}
int pal_num=Palindrome(cor_num);

if(cor_num==pal_num) Console.WriteLine($"{cor_num} -> да");
else Console.WriteLine($"{cor_num} -> нет");
