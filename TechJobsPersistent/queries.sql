--Part 1
/*List the columns and their data types in the Jobs table*/
SHOW COLUMNS
FROM techjobs.jobs;

--Part 2
/*Write a query to list the names of the employers in St. Louis City.*/
SELECT Name
FROM techjobs.employers
WHERE Location = "St. Louis";

--Part 3
/*Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order. If a skill does not have a job listed, it should not be included in the results of this query.*/
SELECT techjobs.skills.Name, Description
FROM techjobs.skills
INNER JOIN techjobs.jobskills ON techjobs.skills.Id = techjobs.jobskills.SkillId
WHERE techjobs.jobskills.JobId IS NOT NULL
ORDER BY techjobs.skills.Name ASC;
