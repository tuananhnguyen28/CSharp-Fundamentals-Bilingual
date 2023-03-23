using System;
using Template;
using SubFuntions;
using static Prompt.ChaptersAndLessonsReturningSelection;

namespace Choice
{
    public class SubLessionSelection
    {
        public static void RunSubLessonsOfLesson3Chapter3()
        {
            SubLessonsSelectionTemplate.Show();
            double subSelectLesson = Convert.ToDouble(Console.ReadLine());
            switch(subSelectLesson)
            {
                case 3.1:
                    SubLessonsOfLesson3Chapter3.Lesson3_3_1_AssignmentOperator();
                    break;
                case 3.2:
                    SubLessonsOfLesson3Chapter3.Lesson3_3_2_AssignmentOperator();
                    break;
                case 3.3:
                    SubLessonsOfLesson3Chapter3.Lesson3_3_3_AssignmentOperator();
                    break;
                default:
                    break;
            }
        }

        public static void RunSubLessonsOfLesson1Chapter4()
        {
            SubLessonsSelectionTemplate.Show();
            double subSelectLesson = Convert.ToDouble(Console.ReadLine());
            switch (subSelectLesson)
            {
                case 4.1:
                    SubLessonsOfLesson1Chapter4.Lesson4_1_1_Array();
                    break;
                case 4.2:
                    SubLessonsOfLesson1Chapter4.Lesson4_1_2_Array();
                    break;
                default:
                    break;
            }
        }
        public static void RunSubLessonsOfLesson2Chapter4()
        {
            SubLessonsSelectionTemplate.Show();
            double subSelectLesson = Convert.ToDouble(Console.ReadLine());
            switch (subSelectLesson)
            {
                case 4.1:
                    SubLessonsOfLesson2Chapter4.Lesson4_2_1_String();
                    break;
                case 4.2:
                    SubLessonsOfLesson2Chapter4.Lesson4_2_2_String();
                    break;
                default:
                    break;
            }
        }
        public static void RunSubLessonsOfLesson3Chapter4()
        {
            SubLessonsSelectionTemplate.Show();
            double subSelectLesson = Convert.ToDouble(Console.ReadLine());
            switch (subSelectLesson)
            {
                case 4.1:
                    SubLessonsOfLesson3Chapter4.Lesson4_3_1_List();
                    break;
                case 4.2:
                    SubLessonsOfLesson3Chapter4.Lesson4_3_2_List();
                    break;
                default:
                    break;
            }
        }
        public static void RunSubLessonsOfLesson4Chapter4()
        {
            SubLessonsSelectionTemplate.Show();
            double subSelectLesson = Convert.ToDouble(Console.ReadLine());
            switch (subSelectLesson)
            {
                case 4.1:
                    SubLessonsOfLesson4Chapter4.Lesson4_4_1_PassByValue();
                    break;
                case 4.2:
                    SubLessonsOfLesson4Chapter4.Lesson4_4_2_PassByReference();
                    break;
                default:
                    break;
            }
        }

        public static void RunSubLessonsOfLesson2Chapter6()
        {
            SubLessonsSelectionTemplate.Show();
            double subSelectLesson = Convert.ToDouble(Console.ReadLine());
            switch (subSelectLesson)
            {
                case 6.1:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_1_If_Statement();
                    break;
                case 6.2:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_2_Inline_If();
                    break;
                case 6.3:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_3_Switch_Statement();
                    break;
                case 6.4:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_4_ForLoop();
                    break;
                case 6.5:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_5_ForeachLoop();
                    break;
                case 6.6:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_6_WhileLoop();
                    break;
                case 6.7:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_7_DoWhile();
                    break;
                case 6.8:
                    SubLessonsOfLesson2Chapter6.Lesson6_2_8_Jump_Statements();
                    break;
                default:
                    break;
            }
        }

        public static void RunSubLessonsOfLesson1Chapter11()
        {
            SubLessonsSelectionTemplate.Show();
            double subSelectLesson = Convert.ToDouble(Console.ReadLine());
            switch(subSelectLesson) {
                case 11.1: 
                    SubLessonsOfLesson1Chapter11.Lesson11_1_1_ReadTextFile_TryCatch();
                    break;
                case 11.2:
                    SubLessonsOfLesson1Chapter11.Lesson11_1_2_ReadTextFile_FileExists();
                    break;
                default:
                    break;
            }
        }
    }
}
