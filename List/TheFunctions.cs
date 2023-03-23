using System;
using Choice;
using static TableOfContent.Table_Of_Content_Of_SubLessons;
using System.IO;
using static SubFuntions.SubLessonsOfLesson1Chapter11;

namespace TheFunctions
{
    public class LessonsOfChapter3
    {
        public static void Lesson1_TheVariable()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("| Biến và các kiểu dữ liệu |");
            Console.WriteLine("----------------------------");
            /* int initialVariable; */    // Khai báo biến
            byte userAge = 20;      // Khởi tạo giá trị của biến
            int numberOfEmployees = 510;
            double grade = 9.5;
            float averageGrade = 8.5f;
            decimal totalGrade = 18.5m;
            char charA = 'A';
            bool logic = true;
            byte studentAge = 15, classNumber = 6;
            Console.WriteLine("Typeof userAge: {0}", userAge.GetType());
            Console.WriteLine("Typeof numberOfEmployees: {0}", numberOfEmployees.GetType());
            Console.WriteLine("Typeof grade: {0}", grade.GetType());
            Console.WriteLine("Typeof averageGrade: {0}", averageGrade.GetType());
            Console.WriteLine("Typeof totalGrade: {0}", totalGrade.GetType());
            Console.WriteLine("Typeof charA: {0}", charA.GetType());
            Console.WriteLine("Typeof logic: {0}", logic.GetType());
            Console.WriteLine("Typeof studentAge: {0} and classNumber {1}", studentAge.GetType(), classNumber.GetType());
        }

        public static void Lesson2_TypesOfVariable()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("| Thao tác với các biến. |");
            Console.WriteLine("--------------------------");
            int x = 5, y = 10;
            x = y;  // Thao tác gán giá trị cho một biến
            Console.WriteLine("x = 5; y = 10 | x = y (thao tác gán) => x = ? and y = ?");
            Console.WriteLine("Giá trị của x sau khi gán y cho x: x = {0}", x);
            Console.WriteLine("Giá trị của y sau khi gán y cho x: y = {0}", y);
        }
        public static void Lesson3_AssignmentOperator()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("| Các toán tử |");
            Console.WriteLine("---------------");
            ShowSubLessonsOfLesson3Chapter3();
            SubLessionSelection.RunSubLessonsOfLesson3Chapter3();
        }
        public static void Lesson4_TypeCasting()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("| Ép kiểu trong C# |");
            Console.WriteLine("--------------------");
            Console.WriteLine("-***** Ép một số không nguyên thành số nguyên *****-");
            float numberA = 20.9f;
            int typeCastingToInt = (int)numberA;
            Console.WriteLine("---> Giá trị của numberA sau khi ép kiểu sang integer (không làm tròn mà bị cắt bớt sau dấu ,) = {0}", typeCastingToInt);
            Console.WriteLine("***** Lưu ý: các số không phải là số nguyên mặc định là double trong C# *****");
            Console.WriteLine("-***** Ép một số thực kiểu double thành số thực kiểu float và decimal *****-");
            double numberB = 100.35;
            float typeCastingToFloat = (float)numberB;
            decimal typeCastingToDecimal = (decimal)numberB;
            Console.WriteLine("---> Giá trị của số thực double numberB khi ép kiểu sang float = {0}", typeCastingToFloat);
            Console.WriteLine("---> Giá trị của số thực double numberB khi ép kiểu sang decimal = {0}", typeCastingToDecimal);
        }
    }

    public class LessonsOfChapter4
    {
        public static void Lesson1_Array()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Mảng, thuộc tính và phương thức mảng |");
            Console.WriteLine("----------------------------------------");
            ShowSubLessonsOfLesson1Chapter4();
            SubLessionSelection.RunSubLessonsOfLesson1Chapter4();
        }

        public static void Lesson2_String()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Chuỗi, thuộc tính và phương thức chuỗi |");
            Console.WriteLine("------------------------------------------");
            ShowSubLessonsOfLesson2Chapter4();
            SubLessionSelection.RunSubLessonsOfLesson2Chapter4();
        }

        public static void Lesson3_List()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("| Danh sách, các thuộc tính và phương thức của danh sách |");
            Console.WriteLine("----------------------------------------------------------");
            ShowSubLessonsOfLesson3Chapter4();
            SubLessionSelection.RunSubLessonsOfLesson3Chapter4();
        }

        public static void Lesson4_PassByValue_PassByReference()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Kiểu giá trị và kiểu tham chiếu |");
            Console.WriteLine("-----------------------------------");
            ShowSubLessonsOfLesson4Chapter4();
            SubLessionSelection.RunSubLessonsOfLesson4Chapter4();
        }
    }

    public class LessonsOfChapter5
    {
        public static void Lesson1()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("| Hiển thị thông báo cho người dùng |");
            Console.WriteLine("-------------------------------------");

            #region 1- Hiển thị một chuỗi đơn giản
            Console.WriteLine("***** Hiển thị một chuỗi đơn giản *****");
            Console.WriteLine("CSharp Programming.\n");
            #endregion

            #region 2- Hiển thị giá trị của một biến
            Console.WriteLine("***** Hiển thị giá trị của một biến *****");
            int userAge = 30;
            Console.WriteLine(userAge + "\n"); // Không đặt tên biến trong dấu ngoặc kép
            #endregion

            #region 3- Kết hợp hai hoặc nhiều chuỗi để hiển thị chúng
            Console.WriteLine("***** Kết hợp hai hoặc nhiều chuỗi để hiển thị chúng *****");
            Console.WriteLine("This is the " + "C# " + "that I'm learning\n");
            #endregion

            #region 4- Sử dụng dấu nối để kết hợp một chuỗi và một biến
            Console.WriteLine("***** Sử dụng dấu nối để kết hợp một chuỗi và một biến *****");
            int resultAdd, a = 10, b = 15;
            resultAdd = a + b;
            Console.WriteLine("Kết quả của phép tính 10 + 15 = " + resultAdd + " => a + b = 25\n");
            #endregion

            #region 5- Sử dụng dấu nối để kết hợp chuỗi và biến (sử dụng trình giữ chỗ)
            Console.WriteLine("***** Sử dụng dấu nối để kết hợp chuỗi và biến (sử dụng trình giữ chỗ) *****");
            int ethnicNumbers = 54;
            Console.WriteLine("{0} is a country with {1} ethnic groups.{2}", "Vietnam", ethnicNumbers, "\n");
            Console.WriteLine("***** Bộ định dạng F: chỉ định số thập phân mà một số sẽ được hiển thị *****");
            Console.WriteLine("Số thập phân ban đầu: 123.4567");
            Console.WriteLine("The number is (lấy 3 số thập phân và làm tròn): {0:F3}", 123.4567);
            Console.WriteLine("The number is (lấy 1 số thập phân và làm tròn): {0:F1}\n", 123.4567);
            Console.WriteLine("***** Bộ định dạng C: dùng để định dạng tiền tệ, thêm biểu tượng $ trước số tiền *****");
            Console.WriteLine("Số tiền ban đầu: 12345 và 5345.909");
            Console.WriteLine("Deposit = {0:C}, Account banlance = {1:C} => tất cả đều thêm dấu phần ngàn và được làm tròn 2 chũ số thập phân.\n", 12345, 5345.909);
            #endregion

            #region 6- Sử dụng Console.WriteLine() để in kết quả của một phương thức mà không cần gán cho nó một biến hoặc hiển thị giá trị của 1 thuộc tính
            Console.WriteLine("***** Hiển thị kết quả của một phương thức ******");
            Console.WriteLine("Chuỗi con gồm 3 ký tự bắt đầu từ vị trí thứ 1 (chỉ mục 0) của Microsoft là: " + "Microsoft".Substring(0, 3) + "\n");
            Console.WriteLine("***** Hiển thị kết quả của một thuộc tính ******");
            Console.WriteLine("Chiều dài của chuỗi Microsoft là: {0} ký tự\n", "Microsoft".Length);
            #endregion
        }

        public static void Lesson2()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("| Ký tự đặc biệt |");
            Console.WriteLine("------------------");
            Console.WriteLine("Nếu chỉ cần in một số ký tự đặc biệt thì dùng ký tự '\'( gạch chéo ngược) để thoát các ký tự có ý nghĩa khác.");
            Console.WriteLine("***** In dấu tab *****");    // dùng \t
            Console.WriteLine("The \t programming CSharp\n");
            Console.WriteLine("***** In một dòng mới *****");   // dùng \n
            Console.WriteLine("The programming \nJava\n");
            Console.WriteLine("***** In chính dấu gạch chéo ngược ****");    // dùng \\
            Console.WriteLine("The programming \\ NodeJs\n");   
            Console.WriteLine("***** In dấu ngoặc kép nhưng không kết thúc chuỗi ****");    // dùng \"
            Console.WriteLine("The programming \" Python\n");
        }

        public static void Lesson3()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| Chấp nhận đầu vào của người dùng |");
            Console.WriteLine("------------------------------------");
            Console.Write("Nhập dữ liệu: ");
            string? userInput = Console.ReadLine();  // Nhận đầu vào của người dùng
            Console.WriteLine("Dữ liệu người dùng nhập vào là: {0}", userInput);
        }

        public static void Lesson4()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("| Chuyển đổi một chuỗi thành một số |");
            Console.WriteLine("-------------------------------------");
            Console.Write("Nhập dữ liệu đầu vào là chuỗi để chuyển đổi sang số: ");
            string? userInput = Console.ReadLine();
            int newUserInput = Convert.ToInt32(userInput);
            Console.WriteLine("Kết quả phép tính của 10 + số vừa nhập ({0}) => 10 + {1} = {2}", newUserInput, newUserInput, 10 + newUserInput);
        }

        public static void Lesson5()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("| Ứng dụng nhỏ - HelloCSharpAgain |");
            Console.WriteLine("---------------------------------");
            string? userName = "";
            int userAge = 0;
            Console.Write("Nhập tên người dùng: ");
            userName = Console.ReadLine();
            Console.Write("Nhập tuổi người dùng: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My name is {0}, {1} ages and I was born in {2}.", userName, userAge, DateTime.Now.Year - userAge);
            // Lưu ý: đối số "DateTime.Now.Year - userAge" có thể thực hiện bằng phép toán và hiển thị kết quả
        }
    }

    public class LessonsOfChapter6
    {
        public static void Lesson1()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("| Câu lệnh điều kiện |");
            Console.WriteLine("----------------------");
            #region 1- Câu lệnh so sánh
            Console.WriteLine("********** Câu lệnh so sánh **********");
            Console.WriteLine("***** Không bằng (!=) *****");
            Console.WriteLine("=> Trả về true nếu bên trái không bằng bên phải.");
            Console.WriteLine("***** Lớn hơn (>) *****");
            Console.WriteLine("=> Trả về true nếu bên trái lớn hơn bên phải.");
            Console.WriteLine("***** Nhỏ hơn (<) *****");
            Console.WriteLine("=> Trả về true nếu bên trái nhỏ hơn bên phải.");
            Console.WriteLine("***** Nhỏ hơn (>=) *****");
            Console.WriteLine("=> Trả về true nếu bên trái lớn hơn hoặc bằng bên phải.");
            Console.WriteLine("***** Nhỏ hơn (<=) *****");
            Console.WriteLine("=> Trả về true nếu bên trái nhỏ hơn hoặc bằng bên phải.");
            Console.WriteLine("***** Nhỏ hơn (<=) *****");
            Console.WriteLine("=> Trả về true nếu bên trái nhỏ hơn hoặc bằng bên phải.\n");
            #endregion

            #region 2- Toán tử logic
            Console.WriteLine("********** Toán tử logic **********");
            Console.WriteLine("***** Toán tử AND (&&) (và) *****");
            Console.WriteLine("=> Trả về true nếu tất cả các điều kiện được đáp ứng, còn lại trả về false.");
            Console.WriteLine("***** Toán tử OR (||) (hoặc) *****");
            Console.WriteLine("=> Trả về true nếu ít nhất một điều kiện được đáp ứng, còn lại trả về false.");
            #endregion
        }

        public static void Lesson2()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Câu lệnh luồng điều khiển |");
            Console.WriteLine("-----------------------------");
            ShowSubLessonsOfLesson2Chapter6();
            SubLessionSelection.RunSubLessonsOfLesson2Chapter6();
        }

        public static void Lesson3()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("| Xử lý ngoại lệ |");
            Console.WriteLine("------------------");
            int numerator, denominator;
            Console.Write("Nhập tử số: ");
            numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            denominator = Convert.ToInt32(Console.ReadLine());
            try {
                Console.WriteLine("Kết quả của tử số / mấu số = {0}", numerator/denominator);
            }
            catch(Exception e) { 
                Console.WriteLine("The error message: {0}", e.Message);
            }
            finally {
                Console.WriteLine("-----End of Error Handling Example-----");
            }
        }

        public static void Lesson4()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("| Các lỗi cụ thể |");
            Console.WriteLine("------------------");
            int choice;
            int[] numbers = {10, 11, 12, 13, 14, 15}; // Index: 0 1 2 3 4 5 (6 elements)
            foreach(int element in numbers) { Console.Write(element + "\t"); }
            Console.WriteLine();
            Console.Write("Please enter the index of the array: ");
            try {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("numbers[choice] (1) = {0}{1}", numbers[choice], "\n");
                Console.Write("numbers[choice] (2) = {0}{1}", numbers[choice], "\n");
                Console.WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
            }
            catch(IndexOutOfRangeException) {
                Console.WriteLine("Error: The index should be from 0 to 5.");
            }
            catch(FormatException) {
                Console.WriteLine("Error: You didn't enter a integer.");
            }
            catch(Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }

    #region *** LessonsOfChapter7 ***

    public class Staff 
    {
        // Khai báo các trường trong lớp Staff (trường: một biến được khai báo trong một lớp)
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        // Khai báo các thuộc tính trong lớp Staff
        public int HoursWorked {
            get { return hWorked; }
            set {
                if(value > 0) { hWorked = value; }
                else hWorked = 0;
            }
        }
        /*  Hoặc cách viết khác:
            1. public int HoursWorked { get; set; }
            2. public int HoursWorked { get; private set; }
        */

        // Phương thức - Methods
        public void PrintMessage() { Console.WriteLine("Calculating Pay..."); }
        public int CalculatePay() {
            PrintMessage();
            int staffPay = hWorked * hourlyRate;
            if(hWorked > 0) { return staffPay; }
            else return 0;
        }
        
        // Nạp chồng (phương thức)
        public int CalculatePay(int bonus, int allowance) {
            PrintMessage();
            if(hWorked > 0) { return hWorked * hourlyRate + bonus + allowance; }
            else return 0;
        }

        // Phương thức ToString(): sử dụng từ khóa override để ghi đè phương thức ToString có sẵn trong lớp Staff
        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + " - Hours of worked = " + hWorked + " - Hourly Rate = " + hourlyRate + ".";
        }

        /* 
            Hàm tạo - Constructor
            1. thường được sử dụng để khởi tạo các trường của lớp 
            2. hàm tạo mặc định chỉ đơn giản khởi tạo các trường trong lớp thành các giá trị mặc định
        */
        public Staff(string name) {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------");
        }

        public Staff(string firstName, string lastName) {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------");
        }

        #region 1-Khái niệm về lập trình hướng đối tượng
        public static void Lesson1()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Khái niệm về lập trình hướng đối tượng |");
            Console.WriteLine("------------------------------------------");
            int validPay, invalidPay;
            // Khởi tạo một đối tượng
            Staff staff = new Staff("Tuan");
            staff.HoursWorked = 160;
            validPay = staff.CalculatePay(400, 1200);
            Console.WriteLine("Tiền trả cho nhân viên = {0}", validPay);
            // Đối số hiểu nôm na là giá trị thực, truyền các giắ trị cho các tham số của phương thức.
            // Vi dụ khác: giá trị gán vào thuộc tính không hợp lệ (value < 0 thay vì >0)
            Staff staff2 = new Staff("Nguyen Anh", "Tuan");
            staff.HoursWorked = -10;
            invalidPay = staff2.CalculatePay(100, 200);
            Console.WriteLine("Tiền phải trả cho nhân viên (giá trị giờ làm việc không hợp lệ) = {0}", invalidPay);
        }
        #endregion 1-Khái niệm về lập trình hướng đối tượng
    }

    # region 2- Từ khóa tĩnh
    class MyClass {
        
        // Non-static members
        public string messsage = "Hello, world!";
        public string? Name {get; set; }
        public void DisplayName() {
            Console.WriteLine("Name = {0}", Name);
        }

        // Static Members
        public static string greetings = "Good morning";
        public static int Age {get; set;}
        public static void DisplayAge() {
            Console.WriteLine("Age = {0}", Age);
        }

        
        public static void Lesson2() {

            Console.WriteLine(">>>>> Truy cập các thành viên tĩnh trong lớp không tĩnh, có thể tạo đối tượng hoặc không từ lớp đó <<<<<");

            // Truy cập các thành viên không tĩnh, cần khởi tạo đối tượng
            MyClass classA = new MyClass(); // instance reference (tham chiếu cá thể)
            Console.WriteLine(classA.messsage);
            classA.Name = "Tuan";
            classA.DisplayName();

            // Truy cập các thành viên tĩnh, không cần khởi tạo đối tượng, chỉ cần sử dụng tên lớp để truy cập chúng
            Console.WriteLine(MyClass.greetings);
            MyClass.Age = 30;
            MyClass.DisplayAge();

        }
    }

    class MyStaticClass {
        public static int a = 5;
        public static int B { get; set; }
        public static int Sum() { return a + B; }

        public static void Lesson2() {
            Console.WriteLine(">>>>> Lớp tĩnh (truy cập trực tiếp các thành viên, không cần thông qua tên lớp) <<<<<");
            MyStaticClass mySC = new MyStaticClass();   // đối với lớp tĩnh, không cần khởi tạo đối tượng, vì dù có tạo, nó sẽ có giá trị null
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("a + B = {0}", Sum());
        }

        /*
            Ngoài ra, một số lớp viết sẵn trong C# được khai báo sẵn là lớp tĩnh.
            Ví dụ như lớp Console, không cần khởi tạo đối tượng Console khi sử dụng các phương thức từ lớp này.
            Chỉ cần viết đơn giản là: Console.WriteLine("Hello Csharp!");
        */
    }

    #endregion 2- Từ khóa tĩnh

    #region 3- Các khái niệm về phương thức nâng cao

    public static class ArrayAndListAsParameters {
        
        // (tham số trong khai báo phương thức)
        // (đối số truyền vào giá trị thực của biến khi gọi phương thức)

        // 3.1 Dùng mảng làm tham số 
        private static int[] myArray = { 1, 2, 3 };
        private static void PrintFisrtElement(int[] a)
        {
            Console.WriteLine("The first element is: {0}\n", a[2]);
        }
        
        // 3.2 Dùng danh sách làm tham số
        private static List<int> myList = new List<int>{1, 2, 3, 4};
        private static void PrintFirstListElement(List<int> a) {
            Console.WriteLine("The first list element is: {0}\n", a[1]);
        }

        public static void Lesson3() {
            Console.WriteLine(">>>>> Dùng mảng làm tham số <<<<<");
            ArrayAndListAsParameters.PrintFisrtElement(myArray);
            Console.WriteLine(">>>>> Dùng list làm tham số <<<<<");
            ArrayAndListAsParameters.PrintFirstListElement(myList);
        }
    }

    public static class ArrayAndListBeReturningFromOneMethod {

        // 3.3 Trả về mảng từ một phương thức
        public static int[] ReturnUserInput() {
            int[] newArray = new int[3];
            for(int i = 0; i < newArray.Length; i++) {
                Console.Write("Enter an integer: ");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to array.");
            }
            return newArray;
        }

        // 3.4 Trả về danh sách từ một phương thức
        public static List<int> ReturnListUserInput() {
            List<int> newList = new List<int>();
            int input;
            for(int i = 0; i < 3; i ++) { 
                Console.Write("Enter an integer: ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to list.");
                newList.Add(input);
            }
            return newList;
        }

        public static void Lesson3() {
            int[] resultArray = ArrayAndListBeReturningFromOneMethod.ReturnUserInput();
            Console.WriteLine(">>>>> Trả về mảng từ một phương thức <<<<<");
            Console.WriteLine("Các giá trị của mảng resultArrray [{0}]", string.Join(", ", resultArray.ToList()));
            List<int> resultList = ArrayAndListBeReturningFromOneMethod.ReturnListUserInput();
            Console.WriteLine(">>>>> Trả về danh sách từ một phương thức <<<<<");
            Console.Write("Danh sách resultList: ");
            foreach(var item in resultList) { Console.Write(item + " "); }
            Console.WriteLine();
        }
    }

    #endregion 3- Các khái niệm về phương thức nâng cao

    #region 4- Sử dụng từ khóa params

    // - Khi chúng ta không biết trước số lượng đối số của 1 phương thức
    // - Nên sử dụng một mảng làm tham số và thêm từ khóa params vào trước nó

    public class Params {
        public static void PrintNames(params string[] names) {
            for(int i = 0; i < names.Length; i++){
                Console.WriteLine(names[i] + "");
            }
            Console.WriteLine();
        }
    }

    public class ParamsInvoking {
        public static void Lesson4() {
            Params par = new Params();
            Console.WriteLine(">>>>> Từ khóa params <<<<<");
            Params.PrintNames("ABC", "DEF");
            Params.PrintNames("Ghye", "Hode", "Misk");
        }
    }

    /*
        Không có tham số bổ sung nào nằm phía sau từ khóa params
        -> Hợp lệ:
            public static void PrintNames(double a, int b, string[] employees, params string[] names)
        -> Không hợp lệ: 
            public static void PrintNames(params string[] names, double b)
            public static void PrintNames(params string[] names, params int[] numbers) -> không được có 2 từ khóa params trở lên
    */

    #endregion 4- Sử dụng từ khóa params

    #region 5- Truyền tham trị và truyền tham số
    // Một biến kiểu tham trị: int, float, double, string, char,..
    // Một biến kiểu tham chiếu: mảng hoặc danh sách

    public class PassByValueAndReference {

        // Truyền tham trị: giá trị chỉ có giá trị trong phương thức, thoát khỏi phương thức giá trị không thay đổi
        public static void PassByValue(int a) {
            a = 10;
            Console.WriteLine("a inside method = {0}", a);
        }

        // Truyền tham chiếu: đều có giá trị sau khi kết thúc phương thức
        public static void PassByReference(int[] b) {
            b[0] = 5;
            Console.WriteLine("b[0] inside method = {0}", b[0]);
        }

        public static void Lesson5() {
            int a = 3;
            int[] b = { 1, 3, 7 };
            PassByValueAndReference obj = new PassByValueAndReference();
            Console.WriteLine(">>>>> Truyền tham trị (không thay đổi giá trị khi phương thức kết thúc) <<<<<");
            Console.WriteLine("a before method = {0}", a);
            PassByValueAndReference.PassByValue(a);
            Console.WriteLine("a after method = {0}", a);
            Console.WriteLine(">>>>> Truyền tham chiếu (thay đổi giá trị khi phương thức kết thúc) <<<<<");
            Console.WriteLine("b[0] before method = {0}", b[0]);
            PassByValueAndReference.PassByReference(b);
            Console.WriteLine("b[0] after method = {0}", b[0]);
        }

    }

    #endregion 5- Truyền tham trị và truyền tham số

    #endregion *** LessonsOfChapter7 ***

    #region *** LessonsOfChapter8 ***

    
    #region Tính kế thừa

    /* Tính kế thừa */
    // Viết lớp cha: trường bảo vệ chỉ có thể truy cập được trong lớp mà nó khai báo và bất kỳ lớp nào được dẫn xuất từ nós
    public class Member {
        protected int annualFee;
        private string? name;
        private int memberID;
        private int memberSince;
        public override string ToString()
        {
            return "\nName: " + name + "\nMemberID: " + memberID + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;
        }
        public Member() { Console.WriteLine("Parent Constructor with no parameters."); }
        public Member(string pName, int pMemberID, int pMemberSince) {
            Console.WriteLine("Parent Constructor with 3 parameters!");
            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }
    }

    // Viết lớp con: 
    /* 
        Các lớp dẫn xuất được gọi là lớp con, các lớp mà chúng được dẫn xuất từ đó gọi là lớp cha hoặc lớp cơ sở
        Một lớp dẫn xuất kế thừa tất cả các thành viên công khai và được bảo vệ từ lớp cha.
        Hàm tạo của lớp con được xây dựng dựa trên hàm tạo của lớp cha, bất cứ khi nào ta tạo một đối tượng con, phương thức khởi tạo của lớp cha luôn được gọi trước
    */
    public class NormalMember : Member {

        public NormalMember() {
            Console.WriteLine("Child constructor with no parameter");
        }

        // Cách khác để khai báo một hàm tạo từ lớp con, sủ dụng dấu hai chấm (:) và từ khóa cơ sở để gọi một hàm tạo không tham số trong lớp cha.
        // Chuyển các đối số thông qua hàm tạo con
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince) { // tham số name, memberID, memberSince đươc chuyển làm đối số cho hàm tạo cha
            Console.WriteLine("Child Constructor with 4 parameters.");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        // Một phương thức trong lớp con có quyền truy cập vào tất cả các trường công khai và được bảo vệ trong lớp cha của nó.
        // Lớp con không cần tạo một interface của lớp cha để truy cập vào các trường được bảo vệ của nó.
        public void CalculaterAnnualFee() {
            annualFee = 100 + 12 * 30;
        }
    
    }

    /*
        Lớp dẫn xuất là lớp VIPMember
    */

    class VIPMember : Member {
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince) {
            Console.WriteLine("Child constructor (VIPMember child  class) with 3 parameters.");
        }
        public void CalculateAnnualFee() { annualFee = 1200; }
    }

    class Test_TinhKeThua {

        // Khi khai báo hàm tạo trên, C# sẽ tìm một hàm tạo không tham số trong lớp cha và gọi nó đầu tiên trước khi thực thi mã trong hàm tạo con
        public static void Test() {
            Console.WriteLine(">>>>> Hàm tạo của lớp con (lớp dẫn xuất) kế thừa từ lớp cha (lớp cơ sở) <<<<<");
            NormalMember member = new NormalMember();
            Console.WriteLine(">>>>> Hàm tạo con với cách sử dụng khác <<<<<");
            NormalMember normalMember = new NormalMember("Special Marks", "Joe", 123, 2005);
            VIPMember vipMember = new VIPMember("Rock", 479, 2010);
        
            // Kết quả của các trường hợp gọi phương thức từ một đối tượng
            Console.WriteLine(">>>>> Gọi các phương thức trong 2 lớp con <<<<<");
            normalMember.CalculaterAnnualFee();
            vipMember.CalculateAnnualFee();

            // Sử dụng phương thức ToString() từ lớp cha (Member) -> phương thức ToString thuộc về lớp cha nên normalMember và vipMember đều kế thừa phương thức này
            // Điều này cho phép sử dụng lại mã vì không cần phải viết lại phương thức ToString() ở hai lớp con
            Console.WriteLine(normalMember.ToString());
            Console.WriteLine(vipMember.ToString());
        }

    }

    #endregion Tính kế thừa

    #region Tính đa hình

    class Person
    {
        protected int annualFee;
        private string? personName;
        private int personID;
        private int personSince;
        public override string ToString()
        {
            return "\nPersonName: " + personName + "\nPersonID: " + personID + "\nPersonSince: " + personSince + "\nTotal Annual Fee: " + annualFee;
        }
        public Person() {
            Console.WriteLine("The constructor of Person class no parameter.");
        }
        public Person(string pPersonName, int pPersonID, int pPersonSince) 
        {
            Console.WriteLine("The constructor of Person class have 3 parameters.");
            personName = pPersonName;
            personID = pPersonID;
            personSince = pPersonSince;
        }

        public virtual void CalculateFee() { // Từ khóa virtual cho biết phương thức này có thể được ghi đè trong các lớp dẫn xuất
            annualFee = 0;
        }
    }

    class Child1_Of_Person : Person {
        public Child1_Of_Person() {
            Console.WriteLine("The constructor of Child1_Of_Person class no parameter.");
        }
        public Child1_Of_Person(string remarks, string personName, int personID, int personSince) : base(personName, personID, personSince) {
            Console.WriteLine("The constructor of Child1_Of_Person have four parameters.");
            Console.WriteLine("Remarks of Child1_Of_Person class = {0}", remarks);
        }
        public override void CalculateFee() { // Dùng từ khóa override để khai báo rằng trong lớp dẫn xuất sẽ ghi đè phương thức trong lớp cha
            annualFee = 100 * 8;
        }
    }

    class Child2_Of_Person : Person {
        public Child2_Of_Person(string personName, int personID, int personSince) : base(personName, personID, personSince) {
            Console.WriteLine("The constructor of Child2_Of_Person have three parameters.");
        }
        public override void CalculateFee() {
            annualFee = 1500;
        }
    }

    class Test_TinhDaHinh {

        public static void Test() {
            Console.WriteLine("<<<<< Kiểm tra tính đa hình của lớp cha và các lớp dẫn xuất >>>>>");
            Person[] employeePersons = new Person[3];
            employeePersons[0] = new Child1_Of_Person("Child 1_1", "Ken", 6, 1995);
            employeePersons[1] = new Child1_Of_Person("Child 1_2", "Ming", 5, 2001);
            employeePersons[2] = new Child2_Of_Person("Huis", 10, 1998);

            // Sử dụng vòng lặp foreach để tính phí hàng năm cho từng nhân viên
            foreach(Person per in employeePersons) {
                per.CalculateFee();
                Console.WriteLine(per.ToString());
            }
        }

        /*
            Kết quả của tính đa hình:
            - Tại thời điểm chạy, chương trình xác định rằng 2 thành viên đầu tiên của employeePersons là kiểu Child1_Of_Person và thực thi phương thức CalculateFee() từ lớp đó.
            - Nó cũng xác định rằng thành viên cuối cùng thuộc kiểu Child2_Of_Person và thực thi phương thức tương tự từ lớp đó.
        */


        // GetType(): trả về kiểu thời gian chạy của một đối tượng và typeof(): lấy tên của một kiểu dữ liệu
        public static void Test_GetType_and_typeof() {
            Person[] employeePersons = new Person[2];
            employeePersons[0] = new Child1_Of_Person("Child_1", "Child", 1, 2);
            employeePersons[1] = new Child2_Of_Person("Child", 1, 2);
            Console.WriteLine(">>>>>>>>>> The example about GetType() and typeof() <<<<<<<<<<");
            Console.WriteLine("employeePersons[0].GetType(): {0}", employeePersons[0].GetType());
            Console.WriteLine("typeof(Child1_Of_Person): {0}", typeof(Child1_Of_Person));
            if(employeePersons[0].GetType() == typeof(Child1_Of_Person)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }

    #endregion Tính đa hình

    #region Các lớp và phương thức trừu tượng

    /* 
        - Không thể tạo đối tượng từ lớp trừu tượng
        - Không có các thành viên tĩnh
        - Có thể có một kiểu phương thức đặc biệt được gọi là phương thức trừu tượng (không có phần thân và phải thực hiện trong lớp dẫn xuất)
        ...
    */

    abstract class AbstractClass
    {
        private string message = "Hello Abstract class and methods.";
        public void PrintMessage() { Console.WriteLine("This is message in abstract class."); }
        public abstract void PrintMessageInAbstractClass();

        public static void Test() 
        { 
            // AbstractClass newAbstractObject = new AbstractClass();
            InheritFromAbstractClass newObject = new InheritFromAbstractClass();
            Console.WriteLine(">>>>>>>>>> The abstract class and methods as well <<<<<<<<<<");
            Console.WriteLine("The message of field in Abstract class: {0}", newObject.message);
            newObject.PrintMessage();
            newObject.PrintMessageInAbstractClass();
        }
    }

    class InheritFromAbstractClass : AbstractClass 
    {
        public override void PrintMessageInAbstractClass()
        {
            Console.WriteLine("The message in Derived class from Abstract class.");
        }
    }

    #endregion Các lớp và phương thức trừu tượng

    #region Giao diện

    /*
        - Mang tính khái niệm hơn là các lớp trừu tượng
        - Chúng chỉ có các phương thức không có phần thân
        - Ngoài ra, chúng không thể chứa các trường nhưng có thể chứa các thuộc tính
        - Không thể có các thành viên tĩnh
        - Khi lớp con kế thừa từ một giao diện, chúng ta nói rằng nó thực thi giao diện
        - Điểm đặc biệt khác: Một lớp chỉ có thể kế thừa một lớp giao diện, nhưng có thể triển khai nhiều giao diện
        - Các thuộc tính và phương thức trong một giao diện là công khai -> không cần thêm các công cụ sửa đổi quyền truy cập vào chúng
    */

    interface IShape {
        int MyNumber { get; set; }
        void InterfaceMethod();
    }

    class InheritInterface : IShape {
        private int myNumber;
        public int MyNumber {
            get { return myNumber; }
            set {
                if(value < 0) myNumber = 0;
                else myNumber = value;
            }
        }
        public void InterfaceMethod() {
            Console.WriteLine("The number is {0}", MyNumber);
        }

        public static void Test() {
            InheritInterface inhInterface = new InheritInterface();
            inhInterface.MyNumber = 10;
            Console.WriteLine(">>>>> Interfacee (giao diện) <<<<<");
            inhInterface.InterfaceMethod();
        }
    }

    #endregion Giao diện
    
    #region Công cụ sửa đổi truy cập

    /*
        - Một lớp dẫn xuất có thể truy cập bất kỳ trường nào được bảo vệ (protected) và công khai (public)
        - Chỉ có thể truy cập một trường riêng tư ngay trong chính lớp đó
        - Nếu một lớp không được dẫn xuất từ một lớp cơ sở, cần khởi tạo đối tượng và chỉ có thể truy cập vào trường công khai, trường được bảo vệ và trường riêng tư không thể truy cập
    */

    public class AccessModifier {
        /*
            This is the field can't access from child or external class
            => private int numberA = 1;
        */
        protected int numberB = 2;
        public int numberC = 3;
    }

    public class AccessModifier_Child : AccessModifier {
        public void PrintNumberOfChildClass() {
            Console.WriteLine(">>>>>>>>>> Công cụ sửa đổi truy cập <<<<<<<<<<");
            Console.WriteLine("Number B in child class = {0}", numberB);   // can access
            Console.WriteLine("Number C in child class = {0}", numberC);   // can access
            // Console.WriteLine("Number A = {0}", numberA);   // can not accesss
        }

        public static void Test() {
            AccessModifier_Child newObj = new AccessModifier_Child();
            newObj.PrintNumberOfChildClass();
        }
    }

    public class AccessModifier_External {
        AccessModifier newAccs = new AccessModifier();
        public void PrintNumberOfExternalClass() {
            Console.WriteLine("The number C in external class = {0}", newAccs.numberC);   // can access
            // Console.WriteLine("The number A = {0}", newAccs.numberA);   // can not access
            // Console.WriteLine("The number B = {0}", newAccs.numberB);   // can not access
        }
        public static void Test() {
            AccessModifier_External newObj = new AccessModifier_External();
            newObj.PrintNumberOfExternalClass();
        }
    }

    #endregion Công cụ sửa đổi truy cập
    
    #endregion *** LessonsOfChapter8 ***

    #region *** LessonsOfChapter9 ***

    #region Enum
    class Enumm
    {
        /*
            - Enum là một kiểu dữ liệu đặc biệt cho phép người lập trình cung cấp các tên có ý nghĩa cho một tập hợp các hằng số tích phân
            - Mỗi thành viên trong enum được gán một giá trị số nguyên mặc định, bắt đầu từ 0...
            - Có thể chuyển một biến kiểu enum thành số nguyên int và ngược lại
        */

        // Khai báo enum
        enum DaysOfWeek
        {
            Sun, Mon, Tue, Wed, Thurs, Fri, Sat
        }

        // Gán một tập hợp các số nguyên khác cho Enum
        enum DaysOfWeekTwo
        {
            Sun = 5, Mon = 10, Tue, Wed, Thurs, Fri, Sat
        }

        // Nếu muốn thay đổi kiểu dữ liệu tất cả các enum, thêm dấu hai chấm sau tên enum
        enum Origin_Numbers
        {
            One, Two, Three
        }
        enum Origin_Numbers_After_Changing_Type_Of_Variable : byte
        {
            One, Two, Three
        }

        public static void Test_Enum()
        {
            Console.WriteLine(">>>>> Enum <<<<<");
            // Khai báo và khởi tạo một biến enum
            DaysOfWeek myDays = DaysOfWeek.Mon;
            Console.WriteLine("My day is: {0}", myDays);
            Console.WriteLine("--- Chuyển DaysOfWeek thành số nguyên (int) ---> {0}", (int)myDays);
            Console.WriteLine("--- Cung cấp giá trị cho số nguyên 1 ---> {0}", (DayOfWeek) 1);
            Console.WriteLine("----- Gán một tập hợp các số nguyên khác cho Enum -----");
            Console.WriteLine("Sunday: {0}, Monday = {1}, Tuesday = {2}, Wednesday = {3}, Thursday = {4}, Friday = {5}, Saturday = {6}", 
                DaysOfWeekTwo.Sun, DaysOfWeekTwo.Mon, DaysOfWeekTwo.Tue, DaysOfWeekTwo.Wed, DaysOfWeekTwo.Thurs, DaysOfWeekTwo.Fri, DaysOfWeekTwo.Sat);
            Console.WriteLine("Chuyển DaysOfWeekTwo thành số nguyên (int)");
            Console.WriteLine("Sunday: {0} - Monday: {1} - Tuesday: {2} ...", Convert.ToInt32(DaysOfWeekTwo.Sun), Convert.ToInt32(DaysOfWeekTwo.Mon), Convert.ToInt32(DaysOfWeekTwo.Tue));
            Console.WriteLine("----- Thay đổi kiểu dữ liệu của enum -----");
            Console.WriteLine((Origin_Numbers_After_Changing_Type_Of_Variable.Two).GetType());
        }
    }

    #endregion Enum

    #region Struct

    /*
        - Có cấu trúc tương tự như một lớp
        - Cho phép nhóm các thành viên có liên quan vào một gói duy nhất để bạn có thể thao tác chúng như một nhóm
        - Các cấu trúc (và các lớp) có thể chứa các biến enum và các phiên bản của các cấu trúc và các lớp dưới dạng các trường
        - Một enum, struct hoặc class có thể được lồng vào bên trong struct hoặc class khác
        * 2 điểm khác biệt giữa Struct và Class:
            + Kiểu dữ liệu Struct không hỗ trợ tính kế thừa và một Struct có thể triển khai một giao diện
            + Struct là kiểu giá trị trong khi Class là kiểu tham chiếu
    */

    struct MyStruct 
    {
        // Fields
        private int x, y;
        private AnotherMyClass myClass;
        private Days myDays;

        // Constructor
        public MyStruct(int a, int b, int c) {
            myClass = new AnotherMyClass();
            myClass.number = a;
            x = b;
            y = c;
            myDays = Days.Mon;
        }

        // Method
        public void PrintMessage() {
            Console.WriteLine("x = {0}, y = {1}, a = {2}, myDays = {3}", x, y, myClass.number, myDays);
        }

        public static void Test_Struct()
        {
            MyStruct newExample = new MyStruct(2, 3, 6);
            Console.WriteLine(">>>>>>>>>> Struct trong C# <<<<<<<<<<");
            newExample.PrintMessage();
        }
    }

    class AnotherMyClass
    {
        public int number;
    }

    enum Days { Mon, Tue, Wed }

    #endregion Struct
    
    #endregion *** LessonsOfChapter9 ***

    #region *** LessonsOfChapter10 ***

    /* LINQ: (Language-Integrated Query)
        - Cho phép truy vấn dữ liệu trong chương trình
        - Sử dụng một tên biến bất kỳ để đại diện các mục riêng lẻ trong mảng
        - Chọn tất cả các yếu tố thỏa mãn tiêu chí bằng 'select'
        - Dùng từ khóa new để chọn nhiều trường từ các đối tượng
    */

    // Example 1:
    public class LinQ {
        public static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void TestLinQ_1() {
            var evenNumQuery =
                from num in numbers
                where (num % 2) == 0
                select num;
            Console.WriteLine("<<<<<---------- LINQ ---------->>>>>");
            Console.WriteLine("<<< LinQ (1): Lấy các số chẵn trong mảng cho trước >>>");
            foreach(int num in evenNumQuery) {
                Console.WriteLine("{0} is an even number", num);
            }
        }
    }

    // Example 2:
    public class Customer {
        private string Name;
        private string Phone;
        private string Address;
        private float Balance;
        public string pName {
            get { return Name; }
        }
        public string pPhone {
            get { return Phone; }
        }
        public string pAddress {
            get { return Address; }
        }
        public float pBalance {
            get { return Balance; }
        }
        public Customer(string pName, string pPhone, string pAddress, float pBalance) {
            Name = pName;
            Phone = pPhone;
            Address = pAddress;
            Balance = pBalance;
        }
    }

    public class LINQSecond {
        public static void TestLinQ_2() {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Hiyo", "+84993992100", "Street 1", 5.67f));
            customers.Add(new Customer("Danes", "+5688929994562", "Street 2", -12.7f));
            customers.Add(new Customer("Yound", "+2209328374232", "Street 3", 2.75f));
            customers.Add(new Customer("Dash", "+101887374632", "Street 4", -1.22f));
            customers.Add(new Customer("Siwu", "+99013988237872", "Street 5", -0.18f));

            // Using LinQ query: Lấy các khách hàng có số dư tài khoản âm
            var overdue = 
                from cust in customers
                where cust.pBalance < 0
                orderby cust.pBalance ascending
                select new { cust.pName, cust.pBalance };
            Console.WriteLine("<<< LinQ (2): Lấy các khách hàng có số dư âm >>>");
            foreach(var item in overdue) {
                Console.WriteLine("Customer {0} with name: {1} have the balance is {2} less than 0.", item, item.pName, item.pBalance);
            }
        }
    }

    #endregion  *** LessonsOfChapter10 ***

    #region *** LessonsOfChapter11 ***

    public class FileHandling {
        public static void ReadFromTextFile() {
            Console.WriteLine("-------------");
            Console.WriteLine("| Xử lý tệp |");
            Console.WriteLine("-------------");
            ShowSubLessonsOfLesson1Chapter11();
            SubLessionSelection.RunSubLessonsOfLesson1Chapter11();
        }
        public static void WriteToTextFile() 
        {
            /*
                >>>>> Ghi vào tệp văn bản <<<<<
                - Sử dụng lớp StreamWriter
                - Để nối dữ liệu vào một tệp: StreamWriter sw = new StreamWriter(path, true)
                - Để ghi đè: StreamWriter sw = new StreamWriter(path)
                - Khi tạo thể hiện sw, hàm tạo sẽ tìm kiếm tệp tại đường dẫn đã cho, nếu không tìm thấy nó sẽ tạo tệp
                - Nếu không cung cấp đường dẫn đầy đủ của file, tệp văn bản sẽ được tạo trong cùng thư mục root của chương trình
            */

            // Ghi vào tệp văn bản
            Console.WriteLine(">>>>> Ghi vào tệp văn bản <<<<<");
            Console.Write("Nhập vào đường dẫn muốn ghi tệp: ");
            string? path = Console.ReadLine();
            using(StreamWriter sw = new StreamWriter(CheckingThePathIsNull(path), true)) 
            {
                sw.WriteLine("GHI");
                sw.WriteLine("KLM");
                sw.Close();
            }

            // Gọi lại hàm đọc tệp văn bản (File.Exists())
            Lesson11_1_2_ReadTextFile_FileExists();
        }
    }

    #endregion *** LessonsOfChapter11 ***

}