using System;
using System.Collections.Generic;
using System.Linq;
using static CustomExtensions.IntegerExtensions;
using System.IO;

namespace SubFuntions
{
    public class SubLessonsOfLesson3Chapter3
    {
        public static void Lesson3_3_1_AssignmentOperator()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("| Các phép toán cơ bản |");
            Console.WriteLine("------------------------");
            int x = 3, y = 5;
            Console.WriteLine("3 + 5 = {0}", x + y);
            Console.WriteLine("3 - 5 = {0}", x - y);
            Console.WriteLine("3 * 5 = {0}", x * y);
            Console.WriteLine("3 / 5 = {0}", x / y);
            Console.WriteLine("3 % 5 = {0}", x % y);
            Console.WriteLine("7 / 2 = {0}", 7 / 2);
            Console.WriteLine("7.0 / 2 = {0}",  7.0 / 2);
            Console.WriteLine("7 / 2.0 = {0}", 7 / 2.0);
            Console.WriteLine("7.0 / 2.0 = {0}", 7.0 / 2.0);
        }
        public static void Lesson3_3_2_AssignmentOperator()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("| Toán tử gán (+= -= *=) |");
            Console.WriteLine("-------------------------");
            int x = 1; Console.WriteLine("x = {0}", x);
            x += 2; // x = x + 2
            Console.WriteLine("x += 2 có giá trị = {0} (x = x + 2)", x);
            int y = 10; Console.WriteLine("y = {0}", y);
            y -= 2; // y = y - 2
            Console.WriteLine("y -= 2 có giá trị = {0} (y = y - 2)", y);
            int z = 15; Console.WriteLine("z = {0}", z);
            z *= 2; // z = z * 2
            Console.WriteLine("z *= 2 có giá trị = {0} (z = z * 2)", z);
        }
        public static void Lesson3_3_3_AssignmentOperator()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("| Toán tử tăng/giảm giá trị (++ --) |");
            Console.WriteLine("-------------------------------------");
            int a = 1, b = 1;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("a++ (toán tử ++ sau tên biến, tăng sau - in trước) = {0}", a++);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("//////////");
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("++b (toán tử ++ trước tên biến, tăng trước - in sau) = {0} ", ++b);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("//////////");
            Console.WriteLine("Tương tự với toán tử giảm giá trị (--)");
        }
    }

    public class SubLessonsOfLesson1Chapter4
    {
        public static void Lesson4_1_1_Array()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Khai báo và khởi tạo mảng |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-***** [] chỉ ra rằng biến là một mảng thay vì một biến bình thường, lưu trữ các giá trị int");
            int[] userAge = { 21, 22, 23, 24, 25 }; // Khai báo và khởi tạo
            int[] userAge2;  //Khai báo trước
            userAge2 = new[] { 21, 22, 23, 24, 25 }; // Khởi tạo sau
            int[] userAge3 = new int [5];  // Khai báo mảng gồm các phần tử mặc định (giá trị là 0)
            Console.WriteLine("Các giá trị của mảng userAge: [{0}]", string.Join(", ", userAge.ToList())); // In tất cả các giá trị trong mảng thông qua
            Console.WriteLine("Các giá trị của mảng userAge3: [{0}]", string.Join(" - ", userAge3.ToList()));

            Console.WriteLine("-------------------");
            Console.WriteLine("| Sử dụng chỉ mục |");
            Console.WriteLine("-------------------");
            int[] userAge4 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("-***** Cập nhật giá trị của một phần tử trong mảng");
            Console.WriteLine("Các giá trị của mảng userAge4 ban đầu: [{0}]", string.Join(", ", userAge4.ToList()));
            userAge4[1] = 0;  
            userAge4[2] += 7;
            Console.WriteLine("Các giá trị của mảng userAge4 sau khi cập nhật giá trị mới: [{0}]", string.Join(", ", userAge4.ToList()));
        }
        public static void Lesson4_1_2_Array()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Thuộc tính của mảng |");
            Console.WriteLine("-----------------------");
            int[] arrayFirst = { 3, 5, 10, 6, 9 };
            Console.WriteLine("Chiều dài của mảng: {0}", arrayFirst.Length);    // 5
            Console.WriteLine("--------------------");
            Console.WriteLine("| Phương thức mảng |");
            Console.WriteLine("--------------------");
            double[] arraySource = { 2.1, 4.5, 3.0, 10.2 };
            double[] arrayDest = { 4, 3.5, 2.7, 2.2 };
            Array.Copy(arraySource, arrayDest, 2);
            Console.WriteLine("Mảng arrayDest sau khi copy từ mảng arraySource: [{0}]", string.Join(", ", arrayDest.ToList()));
            int[] arrayNumbers = { 4, 2, 1, 5, 10, 8 };
            Array.Sort(arrayNumbers);
            Console.WriteLine("Mảng arrayNumbers sau khi sắp xếp tăng dần: [{0}]", string.Join(", ", arrayNumbers.ToList()));
            String[] arrayNames= { "Tung", "Tuan", "Tu", "Trang" };
            int indexResultNoFind = Array.IndexOf(arrayNames, "Hoa");
            int indexResultFind = Array.IndexOf(arrayNames, "Tuan");
            Console.WriteLine("Kết quả tìm từ 'Hoa' trong mảng 'Tung, Tuan, Tu, Trang' : {0}", indexResultNoFind); // index = -1
            Console.WriteLine("Kết quả tìm từ 'Tuan' trong mảng 'Tung, Tuan, Tu, Trang' : {0}", indexResultFind); // index = 1 (vị trí thứ 2)
        }
    }
    public class SubLessonsOfLesson2Chapter4
    {
        public static void Lesson4_2_1_String()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Khai báo và khởi tạo chuỗi |");
            Console.WriteLine("-----------------------------");
            string helloString = "Hello CSharp";    // Khai báo và khởi tạo giá trị
            string emptyString = "";    // có thể khởi tạo chuỗi rỗng
            string myName = "The CSharp " + "là một ngôn ngữ lập trình cấp cao, hướng đối tượng.";
            Console.WriteLine("Chuỗi hellloString: {0}", helloString);
            Console.WriteLine("Chuỗi emptyString: {0}", emptyString);
            Console.WriteLine("Chuỗi myName: {0}", myName);
        }
        public static void Lesson4_2_2_String()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Thuộc tính của chuỗi |");
            Console.WriteLine("-----------------------");
            string stringOne = "The programming";
            Console.WriteLine("Độ dài của chuỗi 'The programming' = {0}", stringOne.Length);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Các phương thức của chuỗi |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-***** SubString() method");
            string message = "The message for C#";
            Console.WriteLine("Chuỗi ban đầu: {0}", message);
            Console.WriteLine("Chuỗi con được trích xuất (vị trí 2 và lấy 4 ký tự): {0}", message.Substring(2, 4));
            Console.WriteLine("-***** Equals() method: so sánh 2 chuỗi");
            string stringCompare1 = "That is the cat";
            string stringCompare2 = "For the sun";
            Console.WriteLine(stringCompare1.Equals("That is the cat"));    // true
            Console.WriteLine(stringCompare1.Equals(stringCompare2));   // false
            Console.WriteLine("-***** Split() method: trả về một mảng kết quả có chứa các chuỗi con và loại bỏ các dấu phân cách");
            string initialString = "Tuan, Hoang; Ma. Le,, Trang";
            string[] seperator = { ",", ";", "." };    // Nếu có nhiều dấu phân cách khác nhau, cần khai báo một mảng chứa các dấu phân cách để loại bỏ
            string[] subString = initialString.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Mảng initial sau khi sử dụng phương thức Split: [{0}]", string.Join("", subString.ToList()));
        }
    }
    public class SubLessonsOfLesson3Chapter4
    {
        public static void Lesson4_3_1_List()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("| Khai báo và khởi tạo danh sách |");
            Console.WriteLine("----------------------------------");
            List<int> userList1 = new List<int>();   // Khai báo
            Console.WriteLine("\nCapacity: {0}", userList1.Capacity);
            userList1.Add(10);  // Khởi tạo giá trị sau
            userList1.Add(20);
            List<int> userList2 = new List<int> { 1, 2, 3, 4 }; // Khai báo đồng thời khởi tạo giá trị của danh sách
            Console.WriteLine("Danh sách userList1");
            foreach (int a in userList1) { Console.WriteLine(a); }
            Console.WriteLine("Danh sách userList2");
            foreach (int b in userList2) { Console.WriteLine(b); }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("| Truy vấn giá trị phần từ trong danh sách |");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Giá trị của phần tử thứ 2 trong ds '1, 2, 3, 4' là: {0}", userList2.ElementAt(2));    // 3
        }
        public static void Lesson4_3_2_List()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("| Thuộc tính của danh sách |");
            Console.WriteLine("----------------------------");
            // Thuộc tính Count: đếm số phần tử trong danh sách
            List<double> firstList = new List<double> { 3.2, 5.5, 10.5 };
            int count = firstList.Count;
            Console.WriteLine("-*****>>> Số lượng phần tử trong danh sách firstList = {0}", count);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("| Các phương thức của danh sách |");
            Console.WriteLine("---------------------------------");
            // Phương thức Add()
            firstList.Add(4.9);
            firstList.Add(3.7);
            Console.WriteLine("-*****>>> Danh sách firstList '3.2 5.5 10.5' sau khi thêm 4.9 và 3.7 vào danh sách");
            foreach (double element in firstList) { Console.WriteLine(element); }
            // Phương thức Insert()
            List<float> secondList = new List<float> { 4.99f, 7.11f, 3.14f };
            secondList.Insert(2, 9.99f);
            Console.WriteLine("-*****>>> Danh sách secondList '4.99f 7.11f 3.14f' sau khi thêm 9.99f vào vị trí thứ 2");
            foreach(float element in secondList) { Console.WriteLine(element); }
            // Phương thức Remove()
            List<int> thirdList = new List<int> { 1, 5, 6, 7, 3 };
            thirdList.Remove(5);
            Console.WriteLine("-*****>>> Danh sách thirdList '1, 5, 6, 7, 3' sau khi remove 5");
            foreach (int element in thirdList) { Console.WriteLine(element); }
            // Phương thức RemoveAt()
            List<string> fourthList = new List<string> { "ABC", "DEF", "GHI" };
            fourthList.RemoveAt(1); // Xóa phần tử ở vị trí thứ 2 (chỉ mục 1)
            Console.WriteLine("-*****>>> Danh sách fourthList 'ABC, DEF, GHI' sau khi remove ở vị trí thứ 2 (chỉ mục 1)");
            foreach(string element in fourthList) { Console.WriteLine(element); }
            // Phương thức Contains
            List<string> fifthList = new List<string> { "Jane", "Lie", "Mask", "Fouie" };
            bool logicContain = fifthList.Contains("Fouie");
            Console.WriteLine("-*****>>> Kiểm tra phần tử Fouie có nằm trong danh sách 'Jane, Lie, Mask, Fouie' không? -> {0}", logicContain);
            // Phương thức Clear()
            List<int> sixthList = new List<int> { 3, 4, 5 };
            Console.WriteLine("Danh sách sixthList '3 4 5' ban đầu");
            foreach (int item in sixthList) { Console.WriteLine(item); }
            sixthList.Clear();
            Console.WriteLine("-*****>>> Danh sách sixthList sau khi sử dụng phương thức Clear");
            foreach(int item in sixthList) { Console.WriteLine(item); }
        }
    }
    public class SubLessonsOfLesson4Chapter4 /* Resource Link: https://codelearn.io/sharing/tham-chieu-va-tham-tri-trong-csharp */
    {
        #region 1.Tham trị
        public static void Lesson4_4_1_PassByValue()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("| Truyền tham trị |");
            Console.WriteLine("-------------------");
            int number1 = 5, number2 = 8;
            Console.WriteLine("number1 và number2 trước khi swap (tham trị): {0} {1}", number1, number2);
            Swap_PassByValue(number1, number2);
            Console.WriteLine("number1 và number2 sau khi swap (tham trị): {0} {1}", number1, number2);
        }
        public static void Swap_PassByValue(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        #endregion
        
        #region 2.Tham chiếu
        public static void Lesson4_4_2_PassByReference()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("| Truyền tham chiếu |");
            Console.WriteLine("---------------------");
            int number1 = 10, number2 = 15;
            Console.WriteLine("number1 và number2 trước khi swap (tham chiếu): {0} {1}", number1, number2);
            Swap_PassByReference(ref number1, ref number2);
            Console.WriteLine("number1 và number2 sau khi swap (tham chiếu): {0} {1}", number1, number2);
        }
        public static void Swap_PassByReference(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }

    public class SubLessonsOfLesson2Chapter6
    {
        public static void Lesson6_2_1_If_Statement()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("| Câu lệnh If |");
            Console.WriteLine("---------------");
            Console.Write("Nhập tuổi để kiểm tra: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if(userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid age. The age must between 0 and 100.");
            }
            else if(userAge < 18)
            {
                Console.WriteLine("The age is underage.");
            }
            else if(userAge < 21)
            {
                Console.WriteLine("The age need parental consent.");
            }
            else
            {
                Console.WriteLine("The age is valid.");
            }
        }

        public static void Lesson6_2_2_Inline_If()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("| Câu lệnh rút gọn |");
            Console.WriteLine("--------------------");
            Console.WriteLine("Được sử dụng khi muốn gán giá trị cho một biến tùy thuộc vào kết quả của 1 điều kiện.");
            bool checkLessThan = 5 > 3 ? true : false;
            Console.WriteLine("Kết quả khi kiểm tra 5 > 3: {0}", checkLessThan);
        }

        public static void Lesson6_2_3_Switch_Statement()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("| Câu lệnh Switch |");
            Console.WriteLine("-------------------");
            Console.Write("Nhập điểm của bạn: ");
            string? userGrade = Console.ReadLine();
            switch(userGrade)
            {
                case "A+":
                case "A":
                    Console.WriteLine("Distinction");
                    break;
                case "B":
                    Console.WriteLine("B Grade");
                    break;
                case "C":
                    Console.WriteLine("C Grade");
                    break;
                default:
                    Console.WriteLine("Failed.");
                    break;
            }
        }

        public static void Lesson6_2_4_ForLoop()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("| Vòng lặp for |");
            Console.WriteLine("----------------");
            int[] initialArray = { 1, 3, 4, 10, 5 };
            Console.Write("Các giá trị của mảng: ");
            for (int i = 0; i < initialArray.Length; i++)
            {
                Console.Write(initialArray[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static void Lesson6_2_5_ForeachLoop()
        {
            #region 1-Foreach (Array type)
            Console.WriteLine("--------------------");
            Console.WriteLine("| Vòng lặp foreach |");
            Console.WriteLine("--------------------");
            char[] gretting = { 'H', 'e', 'l', 'l', 'o' };
            Console.Write("Các ký tự trong câu chào: ");
            foreach(var character in gretting)
            {
                Console.Write(character);
                Console.Write(" ");
            }
            Console.WriteLine();
            #endregion

            #region 2-Foreach (List type)
            List<string> listOfSubjects = new List<string>() { "Programming", "Math", "Marketing" };
            Console.Write("Các môn học trong danh sách: ");
            foreach(var subject in listOfSubjects)
            {
                Console.Write(subject);
                Console.Write(" ");
            }
            Console.WriteLine();
            #endregion
        }

        public static void Lesson6_2_6_WhileLoop()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("| Vòng lặp While |");
            Console.WriteLine("------------------");
            int count = 5;
            while(count > 0)
            {
                Console.Write("Count = {0}", count);
                count--;    // Phải có bộ biến dếm để cuối cùng điều kiện đánh giá là sai và dừng chương trình
                Console.Write(" | ");
            }
            Console.WriteLine();
        }

        public static void Lesson6_2_7_DoWhile()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("| Vòng lặp DoWhile |");
            Console.WriteLine("--------------------");
            int count = 100;
            do
            {
                Console.Write("Count = {0}", count);
                count++;
            } while (count < 0);    // vòng lặp do while chạy ít nhất một lần (vì điều kiện đặt sau dấu ngoặc nhọn đóng)
            Console.WriteLine();
        }

        public static void Lesson6_2_8_Jump_Statements()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("| Câu lệnh nhảy (Jump statement) |");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("-*****>>> Từ khóa Break (trường hợp trong vòng lặp for) <<<*****-");
            for(int i = 0; i < 5; i++) {
                Console.WriteLine("i = {0}", i);
                if(i == 2) 
                break;
            }

            Console.WriteLine("-*****>>> Từ khóa Continue <<<*****-");
            for(int j = 0; j < 5; j++) {
                Console.WriteLine("j = {0}", j);
                if(j == 2)
                continue;
                Console.WriteLine("Will not be printed when j=2\n");
            }
            
        }
    }

    public class SubLessonsOfLesson1Chapter11 
    {
        // Tạo một thể hiện mới của lớp ArgumentException để thông báo lỗi khi chuỗi truyền vào bị rỗng
        public static string CheckingThePathIsNull(string? text) {
            if(text is null) {
                throw new ArgumentException(nameof(text));
            }
            return text;
        }
        public static void Lesson11_1_1_ReadTextFile_TryCatch()
        {
            Console.WriteLine(">>>>> Đọc dữ liệu từ file: Try...Catch <<<<<");
            Console.Write("Nhập đường dẫn chứa file trên máy cục bộ: ");
            string? path = Console.ReadLine();
            {
                try {
                    using(StreamReader sr = new StreamReader(CheckingThePathIsNull(path)))
                    {
                        while(sr.EndOfStream != true) 
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                        sr.Close();
                    }
                }
                catch(FileNotFoundException e)
                {
                    Console.Write("--->>> ");
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void Lesson11_1_2_ReadTextFile_FileExists()
        {
            Console.WriteLine(">>>>> Đọc dữ liệu từ file: File.Exists() <<<<<");
            Console.Write("Nhập đường dẫn chứa file trên máy cục bộ: ");
            string? path = Console.ReadLine();
            if(File.Exists(path)) {
                using(StreamReader sr = new StreamReader(CheckingThePathIsNull(path), true)) 
                {
                    while(sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            else {
                Console.WriteLine("===> Tệp nhập vào không tồn tại!!!");
            }
        }
    }
}
