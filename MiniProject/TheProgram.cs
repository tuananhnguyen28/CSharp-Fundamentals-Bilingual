using System;
using System.IO;
using static Prompt.ChaptersReturningSelection;
using static SubFuntions.SubLessonsOfLesson1Chapter11;

namespace MiniProject
{
    public class TheProgram
    {
        public static void RunMiniProject()
        {
            List<Staff> myStaff = new List<Staff>();
            FileReadAndWrite fr = new FileReadAndWrite();
            int month = 0, year = 0;
            while (year == 0)
            {
                Console.Write("Nhập năm: ");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message + " Please retry input the year");
                }
            }
            while(month == 0)
            {
                Console.Write("Nhập tháng: ");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if(month < 1 || month > 12)
                    {
                        Console.WriteLine("Tháng nhập vào phải nằm từ 1 đến 12, vui lòng nhập lại");
                        month = 0;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message + " Please retry input the month.");
                }
            }

            // Đọc file
            myStaff = fr.ReadFile();
            for(int i = 0; i < myStaff.Count; i++)
            {
                try
                {
                    Console.Write("Nhập số giờ làm việc (Hour Worked) of {0} employee: ", myStaff[i].NameOfStaff);
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                    myStaff[i].CalculatePay();
                    Console.WriteLine(myStaff[i].ToString());

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            PaySlip ps = new PaySlip(month, year);
            ps.GeneratePaySlip(myStaff);
            BackToAllChapters();
        }
    }

    class Staff
    {
        // Declare the fields
        private float hourlyRate;
        private int hWorked;

        // Declare the properties
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string? NameOfStaff { get; private set; }
        public int HoursWorked 
        {
            get { return hWorked; }
            set 
            {
                if(value > 0) { hWorked = value; }
                else { hWorked = 0; }
            }
        }

        // Declare the constructor
        public Staff(string name, float rate) 
        {
            NameOfStaff = name; 
            hourlyRate = rate;
        }

        // Declare the methods
        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }
        public override string ToString()
        {
            return "Hourly Rate = " + hourlyRate + " | Hours Worked = " + HoursWorked + " | TotalPay = " + TotalPay 
                    + " | BasicPay = " + BasicPay + " | Name Of Staff: " + NameOfStaff + ".";
        }
    }

    class Manager : Staff
    {
        private const float managerHourlyRate = 50;

        public int Allowance { get; private set; }

        public Manager(string name) : base(name, managerHourlyRate) {}

        public override void CalculatePay()
        {
            base.CalculatePay();    // gọi phương thức ảo trong lớp cha
            Allowance = 1000;
            if(HoursWorked> 160) {
                TotalPay = HoursWorked + Allowance;
            }
        }

        public override string ToString()
        {
            return "Manager Hourly Rate: " + managerHourlyRate + " | Hours Worked: " + HoursWorked + " | TotalPay: " 
                    + TotalPay + " | Basic Pay: " + BasicPay + " | Name Of Staff: " + NameOfStaff + " | Allowance: " + Allowance + ".";
        }
    }

    class TheAdmin : Staff
    {
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;
        public float Overtime { get; private set; }
        public TheAdmin(string name) : base(name, adminHourlyRate) {}
        public override void CalculatePay()
        {
            base.CalculatePay();
            if(HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
            }
        }
        public override string ToString()
        {
            return "Admin Hourly Rate: " + adminHourlyRate + " | Hours Worked: " + HoursWorked + " | TotalPay: " 
                    + TotalPay + " | Basic Pay: " + BasicPay + " | Name Of Staff: " + NameOfStaff + " | Overtime: " + Overtime + ".";
        }
    }

    class FileReadAndWrite
    {
        public static string CheckingThePathIsNull(string? text) 
        {
            if(text is null)
            {
                throw new ArgumentException(text);
            }
            return text;
        }
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[]? result = new string[2];
            string[] seperator = { "," };

            // Phương thức kiểm tra tệp "staff.txt" có tồn tại hay không?
            Console.WriteLine("Kiểm tra file staff.txt có tồn tại hay không?");
            string existingFile = "staff.txt";
            string creatingFile = "FinalStaff.txt";
            string existingPath = Path.GetFullPath(existingFile); // Lấy đường dẫn tương đối (cùng cấp với thư mục - root directory) cùng với tên tệp cho trước
            string destinationPath = Path.GetFullPath(creatingFile);
            
            if(File.Exists(existingPath))
            {
                using(StreamReader sr = new StreamReader(CheckingThePathIsNull(existingPath)))
                {
                    while(sr.EndOfStream != true)
                    {
                        string? line = sr.ReadLine();
                        if(line != null)
                        {
                            result = line.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                            if(result[1] == "Manager")
                            {
                                myStaff.Add(new Manager(result[0]));
                            }
                            else if(result[1] == "Admin")
                            {
                                myStaff.Add(new TheAdmin(result[0]));
                            }
                        }
                    }
                    // Dùng câu lệnh LinQ - Select để parse List<Staff>() to List<string>
                    List<string> myStaffOfStringType = myStaff.Select(staff => staff.ToString()).ToList();

                    // Check điều kiện, nếu không có dữ liệu được thêm vào thì thông báo cho người dùng.
                    if(myStaffOfStringType.Count == 0) {
                        Console.WriteLine("Danh sách rỗng, file FinalStaff.txt không được ghi!");
                    }
                    else
                    {
                        File.WriteAllLines(destinationPath, myStaffOfStringType);
                        Console.WriteLine("FinalStaff.txt được ghi thành công!!!");
                    }
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("Tên tệp bạn nhập vào không tồn tại!");
            }
            
            return myStaff;
        }
    }

    class PaySlip
    {
        private int month;
        private int year;
        enum MonthsOfYear
        {
            JAN = 1, FEB = 2, MAR = 3, APR = 4, MAY = 5, JUN = 6, JUL = 7, AUG = 8, SEP = 9, OCT = 10, NOV = 11, DEC = 12
        }
        public PaySlip(int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }
        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string generatedPath;
            foreach(Staff f in myStaff)
            {
                string employeeOfPaySlipName = f.NameOfStaff + ".txt";
                generatedPath = Path.GetFullPath(employeeOfPaySlipName);
                using(StreamWriter sw = new StreamWriter(CheckingThePathIsNull(generatedPath), true))
                {
                    sw.WriteLine("PAYSLIP FOR DEC 2010");
                    sw.WriteLine("==========================");
                    sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                    sw.WriteLine("Hour Worked: {0}", f.HoursWorked);
                    sw.WriteLine();
                    sw.WriteLine("Basic Pay: ${0:C}", f.BasicPay);
                    if(f.GetType() == typeof(Manager))
                    {
                        sw.WriteLine("Allowance: {0:C}", ((Manager)f).Allowance);
                    }
                    else if(f.GetType() == typeof(TheAdmin))
                    {
                        sw.WriteLine("Overtime: {0:C}", ((TheAdmin)f).Overtime);
                    }
                    sw.WriteLine();
                    sw.WriteLine("==========================");
                    sw.WriteLine("Total Pay: {0:C}", f.TotalPay);
                    sw.WriteLine("==========================");
                    sw.Close();
                }
            }
            
        }
    }

}