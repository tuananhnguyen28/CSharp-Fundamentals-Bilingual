using System;
using Choice;
using Template;
using static TableOfContent.Table_Of_Content_Of_Lessons;
using static TableOfContent.Table_Of_Content_Of_Chapters;

namespace Prompt
{
    public class ChaptersAndLessonsReturningSelection
    {
        public static bool BackToLessonsOfChapter3()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch(inputPrompt)
            {
                case 1:
                    ShowLessonsOfChapter3();
                    LessionSelection.RunLessonsOfChapter3();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0:
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter4()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch (inputPrompt)
            {
                case 1:
                    ShowLessonsOfChapter4();
                    LessionSelection.RunLessonsOfChapter4();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0:
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter5()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch (inputPrompt)
            {
                case 1:
                    ShowLessonsOfChapter5();
                    LessionSelection.RunLessonsOfChapter5();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0:
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter6()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch (inputPrompt)
            {
                case 1:
                    ShowLessonsOfChapter6();
                    LessionSelection.RunLessonsOfChapter6();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0:
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter7()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch (inputPrompt)
            {
                case 1:
                    ShowLessonsOfChapter7();
                    LessionSelection.RunLessonsOfChapter7();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0:
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter8()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch(inputPrompt) {
                case 1:
                    ShowLessonsOfChapter8();
                    LessionSelection.RunLessonsOfChapter8();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0: 
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter9()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch(inputPrompt) {
                case 1:
                    ShowLessonsOfChapter9();
                    LessionSelection.RunLessonsOfChapter9();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0: 
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter10()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch(inputPrompt) {
                case 1:
                    ShowLessonsOfChapter10();
                    LessionSelection.RunLessonsOfChapter10();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0: 
                    return false;
                default: return false;
            }
        }

        public static bool BackToLessonsOfChapter11()
        {
            ChaptersAndLessonsReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch(inputPrompt) {
                case 1:
                    ShowLessonsOfChapter11();
                    LessionSelection.RunLessonsOfChapter11();
                    return true;
                case 2:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    return true;
                case 0: 
                    return false;
                default: return false;
            }
        }
    }
}
