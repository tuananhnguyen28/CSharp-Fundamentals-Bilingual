using System;
using static TableOfContent.Table_Of_Content_Of_Lessons;
using static Prompt.ChaptersReturningSelection;
using Template;
using static MiniProject.TheProgram;

namespace Choice
{
    public class ChapterSelection
    {
        public static void Run()
        {
            ChaptersSelectionTemplate.Show();
            int selectChapter = Convert.ToInt32(Console.ReadLine());
            switch (selectChapter)
            {
                case 1:
                    ShowLessonsOfChapter1();
                    BackToAllChapters();
                    break;
                case 2:
                    ShowLessonsOfChapter2();
                    BackToAllChapters();
                    break;
                case 3:
                    ShowLessonsOfChapter3();
                    LessionSelection.RunLessonsOfChapter3();
                    break;
                case 4:
                    ShowLessonsOfChapter4();
                    LessionSelection.RunLessonsOfChapter4();
                    break;
                case 5:
                    ShowLessonsOfChapter5();
                    LessionSelection.RunLessonsOfChapter5();
                    break;
                case 6:
                    ShowLessonsOfChapter6();
                    LessionSelection.RunLessonsOfChapter6();
                    break;
                case 7:
                    ShowLessonsOfChapter7();
                    LessionSelection.RunLessonsOfChapter7();
                    break;
                case 8:
                    ShowLessonsOfChapter8();
                    LessionSelection.RunLessonsOfChapter8();
                    break;
                case 9:
                    ShowLessonsOfChapter9();
                    LessionSelection.RunLessonsOfChapter9();
                    break;
                case 10:
                    ShowLessonsOfChapter10();
                    LessionSelection.RunLessonsOfChapter10();
                    break;
                case 11:
                    ShowLessonsOfChapter11();
                    LessionSelection.RunLessonsOfChapter11();
                    break;
                case 12:
                    RunMiniProject();
                    break;
                case 0:
                    break;
            }
        }
    }
}
