using System;

namespace Template
{
    public class ChaptersReturningTemplate
    {
        public static void Show()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| 1. Quay lại danh sách các chương |");
            Console.WriteLine("| 0. Thoát chương trình!           |");
            Console.WriteLine("------------------------------------");
            Console.Write("----------> Nhập giá trị: ");
        }
    }
}
