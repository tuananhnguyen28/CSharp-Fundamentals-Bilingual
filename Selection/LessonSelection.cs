using System;
using Template;
using TheFunctions;
using static Prompt.ChaptersAndLessonsReturningSelection;

namespace Choice
{
    public class LessionSelection
    {
        public static void RunLessonsOfChapter3()
        {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch (selectLesson)
            {
                case 1:
                    {
                        LessonsOfChapter3.Lesson1_TheVariable();
                        BackToLessonsOfChapter3();
                        break;
                    }
                case 2:
                    {
                        LessonsOfChapter3.Lesson2_TypesOfVariable();
                        BackToLessonsOfChapter3();
                        break;
                    }
                case 3:
                    {
                        LessonsOfChapter3.Lesson3_AssignmentOperator();
                        BackToLessonsOfChapter3();
                        break;
                    }
                case 4:
                    {
                        LessonsOfChapter3.Lesson4_TypeCasting();
                        BackToLessonsOfChapter3();
                        break;
                    }
                default:
                    break;
            }
        }

        public static void RunLessonsOfChapter4()
        {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch (selectLesson)
            {
                case 1:
                    {
                        LessonsOfChapter4.Lesson1_Array();
                        BackToLessonsOfChapter4();
                        break;
                    }
                case 2:
                    {
                        LessonsOfChapter4.Lesson2_String();
                        BackToLessonsOfChapter4();
                        break;
                    }
                case 3:
                    {
                        LessonsOfChapter4.Lesson3_List();
                        BackToLessonsOfChapter4();
                        break;
                    }
                case 4:
                    {
                        LessonsOfChapter4.Lesson4_PassByValue_PassByReference();
                        BackToLessonsOfChapter4();
                        break;
                    }
                default:
                    break;
            }
        }

        public static void RunLessonsOfChapter5()
        {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch (selectLesson)
            {
                case 1:
                    {
                        LessonsOfChapter5.Lesson1();
                        BackToLessonsOfChapter5();
                        break;
                    }
                case 2:
                    {
                        LessonsOfChapter5.Lesson2();
                        BackToLessonsOfChapter5();
                        break;
                    }
                case 3:
                    {
                        LessonsOfChapter5.Lesson3();
                        BackToLessonsOfChapter5();
                        break;
                    }
                case 4:
                    {
                        LessonsOfChapter5.Lesson4();
                        BackToLessonsOfChapter5();
                        break;
                    }
                case 5:
                    {
                        LessonsOfChapter5.Lesson5();
                        BackToLessonsOfChapter5();
                        break;
                    }
                default:
                    break;
            }
        }

        public static void RunLessonsOfChapter6()
        {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch (selectLesson)
            {
                case 1:
                    {
                        LessonsOfChapter6.Lesson1();
                        BackToLessonsOfChapter6();
                        break;
                    }
                case 2:
                    {
                        LessonsOfChapter6.Lesson2();
                        BackToLessonsOfChapter6();
                        break;
                    }
                case 3:
                    {
                        LessonsOfChapter6.Lesson3();
                        BackToLessonsOfChapter6();
                        break;
                    }
                case 4:
                    {
                        LessonsOfChapter6.Lesson4();
                        BackToLessonsOfChapter6();
                        break;
                    }
                default:
                    break;
            }
        }

        public static void RunLessonsOfChapter7()
        {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch (selectLesson)
            {
                case 1:
                {
                    Staff.Lesson1();
                    BackToLessonsOfChapter7();
                    break;
                }
                case 2:
                {
                    MyClass.Lesson2();
                    MyStaticClass.Lesson2();
                    BackToLessonsOfChapter7();
                    break;
                }
                case 3:
                {
                    ArrayAndListAsParameters.Lesson3();
                    ArrayAndListBeReturningFromOneMethod.Lesson3();
                    BackToLessonsOfChapter7();
                    break;
                }
                case 4: {
                    ParamsInvoking.Lesson4();
                    BackToLessonsOfChapter7();
                    break;
                }
                case 5: {
                    PassByValueAndReference.Lesson5();
                    BackToLessonsOfChapter7();
                    break;
                }
                default:
                    break;
            }
        }

        public static void RunLessonsOfChapter8() {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch(selectLesson) {
                case 1:
                {
                    Test_TinhKeThua.Test();
                    BackToLessonsOfChapter8();
                    break;
                }
                case 2:
                {
                    Test_TinhDaHinh.Test();
                    Test_TinhDaHinh.Test_GetType_and_typeof();
                    BackToLessonsOfChapter8();
                    break;
                }
                case 3:
                {
                    AbstractClass.Test();
                    BackToLessonsOfChapter8();
                    break;
                }
                case 4:
                {
                    InheritInterface.Test();
                    BackToLessonsOfChapter8();
                    break;
                }
                case 5:
                {
                    AccessModifier_Child.Test();
                    AccessModifier_External.Test();
                    BackToLessonsOfChapter8();
                    break;
                }
            }
        }

        public static void RunLessonsOfChapter9() {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch(selectLesson) {
                case 1: 
                {
                    Enumm.Test_Enum();
                    BackToLessonsOfChapter9();
                    break;
                }
                case 2:
                {
                    MyStruct.Test_Struct();
                    BackToLessonsOfChapter9();
                    break;
                }
            }
        }

        public static void RunLessonsOfChapter10() {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch(selectLesson) {
                case 1: 
                {
                    LinQ.TestLinQ_1();
                    BackToLessonsOfChapter10();
                    break;
                }
                case 2:
                {
                    LINQSecond.TestLinQ_2();
                    BackToLessonsOfChapter10();
                    break;
                }
            }
        }

        public static void RunLessonsOfChapter11() {
            LessonsSelectionTemplate.Show();
            int selectLesson = Convert.ToInt32(Console.ReadLine());
            switch(selectLesson) {
                case 1: 
                {
                    FileHandling.ReadFromTextFile();
                    BackToLessonsOfChapter11();
                    break;
                }
                case 2:
                {
                    FileHandling.WriteToTextFile();
                    BackToLessonsOfChapter11();
                    break;
                }
            }
        }
    }
}
