Feature: GetStudent
	Get the student information by id

Scenario: Get the student information by valid id
	Given database is already having record with record name as "Tom" age as 20 branch as "ME" and section as "D"
	When I get the record with id as 1 
	Then I should get the record name as "Tom" age as 20 branch as "ME" and section as "D"

Scenario: Get the student information by invalid id
	Given database is not having any record with record id as 3 
	When I get the record with id as 3 
	Then I should get the error message as "No record found." 