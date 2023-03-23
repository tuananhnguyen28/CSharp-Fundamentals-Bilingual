using System;

namespace Template
{
    public class ChaptersAndLessonsReturningTemplate
    {
        public static void Show()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| 1. Quay lại danh sách các bài học trước |");
            Console.WriteLine("| 2. Quay lại danh sách các chương        |");
            Console.WriteLine("| 0. Thoát chương trình!                  |");
            Console.WriteLine("-------------------------------------------");
            Console.Write("----------> Nhập giá trị: ");
        }
    }
}
