Feature: AddStudent
	Add the student 

Scenario: Add the student  
	Given database is not having any record with record name as "Peter"
    When I add the record with name as "Peter" age as 26 branch as "CIVIL" and section as "A"
	Then I should get the record name as "Peter" age as 26 branch as "CIVIL" and section as "A"

Scenario: Add the student with duplicate name
	Given database is already having record with record name as "Joe" age as 21 branch as "EE" and section as "E"
	When I add the record with duplicate name as "Joe" age as 25 branch as "CS" and section as "B"
	Then I should get the error message as "Student record with same name already exists." 