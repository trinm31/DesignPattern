using Example_Factory_Method.Page;

namespace Example_Factory_Method.Document
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new BiliographyPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new ResultsPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new ConclusionPage());
        }
    }
}