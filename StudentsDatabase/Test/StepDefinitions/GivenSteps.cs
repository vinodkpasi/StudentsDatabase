using StudentsManager;
using System;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public sealed class GivenSteps
    {
        ScenarioContext scenarioContext;
        public GivenSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"database is already having record with record name as ""(.*)"" age as (.*) branch as ""(.*)"" and section as ""(.*)""")]
        public void GivenDatabaseIsAlreadyHavingRecordWithRecordNameAsAgeAsBranchAsAndSectionAs(string name, int age, string branch, string section)
        {
            Student student = new Student() { Name = name, Age = age, Branch = (int)Enum.Parse(typeof(Branch), branch), Section = (int)Enum.Parse(typeof(Section), section) };
            DataResult dataResult = new DataResult();
            dataResult.Add(student);
        }
        
        [When(@"I add the record with duplicate name as ""(.*)"" age as (.*) branch as ""(.*)"" and section as ""(.*)""")]
        [When(@"I add the record with name as ""(.*)"" age as (.*) branch as ""(.*)"" and section as ""(.*)""")]
        public void WhenIAddTheRecordWithRecordNameAsAgeAsBranchAsAndSectionAs(string name, int age, string branch, string section)
        {
            Student student = new Student() { Name=name,Age=age,Branch= (int)Enum.Parse(typeof(Branch), branch),Section= (int)Enum.Parse(typeof(Section), section) };
            DataResult dataResult = new DataResult();
            dataResult.Add(student);
            scenarioContext.Add("DataResult", dataResult);
        }

        [Given(@"database is not having any record with record id as (.*)")]
        public void GivenDatabaseIsNotHavingAnyRecordWithRecordIdAs(int id)
        {
            Students.RemoveById(id);
        }

        [Given(@"database is not having any record with record name as (.*)")]
        public void GivenDatabaseIsNotHavingAnyRecordWithRecordIdAs(string name)
        {
            Students.RemoveByName(name);
        }
    }
}
