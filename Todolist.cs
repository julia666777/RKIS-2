using System;

public class UserInfo{
    public static void Main(string[] args){
        Console.WriteLine("������ ��������� ������� ���� � �������� ���� 3833");

        Console.WriteLine("������� ���:");
        string firstName = Console.ReadLine();

        Console.WriteLine("������� �������:");
        string lastName = Console.ReadLine();
        Console.WriteLine("������� ��� ��������:");
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