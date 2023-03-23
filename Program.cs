using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TableOfContent.Table_Of_Content_Of_Chapters; // Trong C# 6, có thể sử dụng using static/no.<namespace>.<class> khi có 2 namespace khác tên nhau
using Choice;

namespace TheFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTheChapters(); // Hiển thị mục lục của các chương
            ChapterSelection.Run();                                                                                              
            Console.Read();
        }
    }
}