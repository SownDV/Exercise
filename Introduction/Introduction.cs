using System;

class Program
{
    static void Main()
    {
        // --- Part 1: In một chuỗi ra màn hình ---
        Console.WriteLine("Chào mừng bạn đến với lập trình C#!");

        // --- Part 2: Lấy dữ liệu từ người dùng và in ra ---
        Console.WriteLine("\nHãy nhập tên của bạn:");
        string name = Console.ReadLine();
        Console.WriteLine("Xin chào, " + name + "!");

        // --- Part 3: Lấy hai đầu vào và in trên các dòng riêng biệt (dùng \n) ---
        Console.WriteLine("\nNhập sở thích thứ nhất của bạn:");
        string hobby1 = Console.ReadLine();

        Console.WriteLine("Nhập sở thích thứ hai của bạn:");
        string hobby2 = Console.ReadLine();

        // Sử dụng \n để tạo dòng mới trong cùng một câu lệnh in
        Console.WriteLine("\nDanh sách sở thích của bạn là:\n" + hobby1 + "\n" + hobby2);
    }
}