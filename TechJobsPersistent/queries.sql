--Part 1

SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE 
TABLE_NAME = 'jobs';

--Part 2

SELECT Name, Location
FROM employers
WHERE Location = "St. Louis City";

--Part 3

SELECT skills.Name AS "Skill name", skills.Description, jobs.Name AS "Job name"
FROM skills
INNER JOIN jobskills ON Skills.Id = jobskills.SkillId
INNER JOIN jobs ON jobskills.JobId = jobs.Id
ORDER BY skills.Description ASC;
