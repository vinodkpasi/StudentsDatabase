using StudentsManager;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class Common
    {
        [BeforeScenario]
        public void ClearDatabase()
        {
           Students.ClearAll();
        }
    }
}
