using Example_Factory_Method.Page;

namespace Example_Factory_Method.Document
{
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new BiliographyPage());
            Pages.Add(new ConclusionPage());
        }
    }
}