using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsManager;
using System;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public sealed class ThenSteps
    {
        ScenarioContext scenarioContext;
        public ThenSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"I should get the record name as ""(.*)"" age as (.*) branch as ""(.*)"" and section as ""(.*)""")]
        public void ThenIShouldGetTheRecordNameAsAgeAsBranchAsAndSectionAs(string name, int age, string branch, string section)
        {
            DataResult dataResult = scenarioContext.Get<DataResult>("DataResult");
            Student student = dataResult.Data;
            Assert.AreEqual(student.Name, name);
            Assert.AreEqual(student.Age, age);
            Assert.AreEqual(student.Branch, (int)Enum.Parse(typeof(Branch), branch));
            Assert.AreEqual(student.Section, (int)Enum.Parse(typeof(Section), section));
        }

        [Then(@"I should get the error message as ""(.*)""")]
        public void ThenIShouldGetTheErrorMessageAs(string errorMessage)
        {
            DataResult dataResult = scenarioContext.Get<DataResult>("DataResult");
            Assert.IsNull(dataResult.Data);
            Assert.AreEqual(dataResult.ErrorMessage,errorMessage);
        }
    }
}
