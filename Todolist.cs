using System;

public class UserInfo{
    public static void Main(string[] args){
        Console.WriteLine("������ ��������� ������� ���� � �������� ���� 3833");

        Console.WriteLine("������� ���:");        
        Console.WriteLine("������� �������:");
        Console.WriteLine("������� ��� ��������:");

        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string birthYearString = Console.ReadLine();

        int birthYear;
        bool isBirthYearValid = int.TryParse(birthYearString, out birthYear); 

        if (!isBirthYearValid){
            Console.WriteLine("������: ������������ ��� ��������. ����������, ������� ����� �����.");
            return;}

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"�������� ������������ {firstName} {lastName}, ������� - {age}");
    }
}