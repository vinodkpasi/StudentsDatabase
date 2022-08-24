using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public sealed class WhenSteps
    {
        ScenarioContext scenarioContext;
        public WhenSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"I get the record with id as (.*)")]
        public void WhenIGetTheRecordWithIdAs(int id)
        {
            DataResult dataResult = new DataResult();
            dataResult = dataResult.GetById(id);
            scenarioContext.Add("DataResult", dataResult);
        }
    }
}
