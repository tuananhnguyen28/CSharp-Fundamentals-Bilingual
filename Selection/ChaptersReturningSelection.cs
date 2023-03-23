using System;
using static TableOfContent.Table_Of_Content_Of_Chapters;
using Choice;
using Template;

namespace Prompt
{
    public class ChaptersReturningSelection
    {
        public static void BackToAllChapters()
        {
            ChaptersReturningTemplate.Show();
            int inputPrompt = Convert.ToInt32(Console.ReadLine());
            switch (inputPrompt)
            {
                case 1:
                    ShowTheChapters();
                    ChapterSelection.Run();
                    break;
                case 0:
                    break;
                default: break;
            }
        }
    }
}
