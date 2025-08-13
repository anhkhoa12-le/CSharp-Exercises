        1. Cộng / Tổng hai số
        Console.WriteLine("--- 1. Cộng hai số ---");
        int num1 = 10;
        int num2 = 25;
        int sum = num1 + num2;
        Console.WriteLine($"Tổng của {num1} và {num2} là: {sum}");
       

        2. Hoán đổi giá trị của hai biến
        Console.WriteLine("--- 2. Hoán đổi giá trị hai biến ---");
        int a = 5;
        int b = 10;
        Console.WriteLine($"Trước khi hoán đổi: a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Sau khi hoán đổi: a = {a}, b = {b}");
       

        3. Nhân hai số thực
        Console.WriteLine("--- 3. Nhân hai số thực ---");
        double float1 = 12.5;
        double float2 = 3.2;
        double product = float1 * float2;
        Console.WriteLine($"Tích của {float1} và {float2} là: {product}");

        4. Chuyển đổi feet sang mét
        Console.WriteLine("--- 4. Chuyển đổi Feet sang Mét ---");
        double feet = 10;
        double meters = feet * 0.3048;
        Console.WriteLine($"{feet} feet = {meters} mét");

        5. Chuyển đổi Celsius sang Fahrenheit và ngược lại
        Console.WriteLine("--- 5. Chuyển đổi nhiệt độ ---");
        double celsius = 30;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        double fahrenheit2 = 86;
        double celsius2 = (fahrenheit2 - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit2}°F = {celsius2}°C");
        
        6. Tìm kích thước của các kiểu dữ liệu
        Console.WriteLine("--- 6. Kích thước của các kiểu dữ liệu ---");
        Console.WriteLine($"Kích thước của int: {sizeof(int)} bytes");
        Console.WriteLine($"Kích thước của long: {sizeof(long)} bytes");
        Console.WriteLine($"Kích thước của double: {sizeof(double)} bytes");
        Console.WriteLine($"Kích thước của float: {sizeof(float)} bytes");

        7. In giá trị ASCII
        Console.WriteLine("--- 7. In giá trị ASCII ---");
        char ch = 'A';
        int asciiValue = ch;
        Console.WriteLine($"Giá trị ASCII của ký tự '{ch}' là: {asciiValue}");

        8. Tính diện tích hình tròn
        Console.WriteLine("--- 8. Tính diện tích hình tròn ---");
        double radius = 7.0;
        double circleArea = Math.PI * radius * radius;
        Console.WriteLine($"Diện tích hình tròn có bán kính {radius} là: {circleArea}");

        9. Tính diện tích hình vuông
        Console.WriteLine("--- 9. Tính diện tích hình vuông ---");
        double side = 5.0;
        double squareArea = side * side;
        Console.WriteLine($"Diện tích hình vuông có cạnh {side} là: {squareArea}");

        10. Chuyển đổi ngày sang năm, tuần và ngày
        Console.WriteLine("--- 10. Chuyển đổi ngày sang năm, tuần và ngày ---");
        int totalDays = 1500;
        int years = totalDays / 365;
        int remainingDaysAfterYears = totalDays % 365;
        int weeks = remainingDaysAfterYears / 7;
        int days = remainingDaysAfterYears % 7;
        Console.WriteLine($"{totalDays} ngày = {years} năm, {weeks} tuần và {days} ngày");
