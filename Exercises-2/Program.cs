Ex-01
using System;

public class TemperatureConverter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập số độ Celsius bạn muốn chuyển đổi:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double kelvin = celsius + 273;
        double fahrenheit = celsius * 18 / 10 + 32;
        Console.WriteLine("kelvin= " + kelvin);
        Console.WriteLine("fahrenheit= " + fahrenheit);
    }
}



using System;

public class SphereCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập bán kính của hình cầu:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double pi = Math.PI;
        double surface = 4 * pi * Math.Pow(radius, 2);
        double volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);
        Console.WriteLine("Surface: " + Math.Round(surface, 2));
        Console.WriteLine("Volume: " + Math.Round(volume, 2));



using System;

public class MathOperations
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập số thứ nhất:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số thứ hai:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
        if (num2 != 0)
        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2));
        }
        else
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0.");
        }
    }
}




Ex-02


  using System;

public class MathOperationSelector
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập số thứ nhất:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số thứ hai:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập phép toán (+, -, *, /, %):");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Lỗi: Không thể chia cho 0.");
                    return;
                }
                break;
            case '%':
                if (num2 != 0)
                {
                    result = num1 % num2;
                }
                else
                {
                    Console.WriteLine("Lỗi: Không thể chia cho 0.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Phép toán không hợp lệ.");
                return;
        }
        Console.WriteLine("Kết quả là: " + result);
    }
}




      using System;

public class FunctionCalculator
{
    public static void Main(string[] args)
    {
        // Hiển thị tiêu đề
        Console.WriteLine("Các giá trị của hàm số x = y^2 + 2y + 1:");

        // Sử dụng vòng lặp for để duyệt các giá trị y từ -5 đến 5
        for (int y = -5; y <= 5; y++)
        {
            // Tính giá trị của x
            double x = Math.Pow(y, 2) + 2 * y + 1;

            // Hiển thị kết quả
            Console.WriteLine("y = " + y + ", x = " + x);
        }
    }
}




      using System;

public class SpeedCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chào mừng bạn đến với chương trình tính tốc độ!");
        Console.Write("Vui lòng nhập quãng đường (đơn vị km): ");
        if (!double.TryParse(Console.ReadLine(), out double distanceKm))
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng chạy lại chương trình.");
            return;
        }
        Console.Write("Vui lòng nhập giờ: ");
        if (!int.TryParse(Console.ReadLine(), out int hours))
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng chạy lại chương trình.");
            return;
        }

        Console.Write("Vui lòng nhập phút: ");
        if (!int.TryParse(Console.ReadLine(), out int minutes))
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng chạy lại chương trình.");
            return;
        }

        Console.Write("Vui lòng nhập giây: ");
        if (!int.TryParse(Console.ReadLine(), out int seconds))
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng chạy lại chương trình.");
            return;
        }
        if (distanceKm < 0 || hours < 0 || minutes < 0 || seconds < 0)
        {
            Console.WriteLine("Giá trị nhập vào không được âm. Vui lòng chạy lại chương trình.");
            return;
        }
        double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);
        if (totalHours == 0)
        {
            Console.WriteLine("Thời gian không thể bằng 0. Vui lòng chạy lại chương trình.");
            return;
        }
        double speedKmH = distanceKm / totalHours;
        double speedMilesH = speedKmH * 0.621371;-- Kết quả ---");
        Console.WriteLine($"Tốc độ của bạn là: {speedKmH:F2} km/h");
        Console.WriteLine($"Tốc độ của bạn là: {speedMilesH:F2} miles/h");
        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}





      using System;

public class SphereCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chào mừng bạn đến với chương trình tính toán hình cầu!");
        Console.WriteLine("Chương trình này sẽ tính diện tích bề mặt và thể tích của một hình cầu.");
        Console.Write("Vui lòng nhập bán kính của hình cầu (r): ");
        double radius;
        if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Bán kính phải là một số dương.");
            return;
        }
        double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine("\n--- Kết quả ---");
        Console.WriteLine($"Bán kính của hình cầu (r) = {radius:F2}");
        Console.WriteLine($"Diện tích bề mặt (A) = {surfaceArea:F2}");
        Console.WriteLine($"Thể tích (V) = {volume:F2}");
        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}



      using System;

public class CharacterChecker
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chào mừng bạn đến với chương trình kiểm tra ký tự!");
        Console.Write("Vui lòng nhập một ký tự bất kỳ: ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input) || input.Length > 1)
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng chỉ nhập một ký tự.");
            return;
        }
        char character = input[0];
        if (char.IsLetter(character))
        {
            char lowerChar = char.ToLower(character);

            if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            {
                Console.WriteLine($"Ký tự '{character}' là một nguyên âm.");
            }
            else
            {
                Console.WriteLine($"Ký tự '{character}' là một phụ âm.");
            }
        }
        else if (char.IsDigit(character))
        {
            Console.WriteLine($"Ký tự '{character}' là một chữ số.");
        }
        else
        {
            Console.WriteLine($"Ký tự '{character}' là một ký hiệu đặc biệt.");
        }
        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}



