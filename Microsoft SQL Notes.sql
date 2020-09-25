-- (LocalDb)\mssqllocaldb

----------

-- Create a new table
USE AspIT
CREATE TABLE Students (
	StudentID int IDENTITY(1,1) PRIMARY KEY, -- Microsoft SQL Auto Increment
	FirstName varchar(100),
	LastName varchar(100),
	Age int,
	CurrentSubject varchar(25)
	);

----------

-- Add rows to the table
USE AspIT
INSERT INTO 
	Students (FirstName, LastName, Age, CurrentSubject) -- StudentID not required due to Auto Increment
VALUES
	('Layan', 'Mack', 20, 'Softwarekonstruktion'),
	('Cadence', 'Wagner', 19, 'Teknik'),
	('Emmanuella', 'Beaumont', 18, 'Visualisering'),
	('Faiza', 'Kent', 19, 'Teknik'),
	('Holli', 'Ali', 20, 'Visualisering'),
	('Halle', 'Humphrey', 20, 'Teknik'),
	('Omar', 'Coffey', 19, 'Teknik'),
	('Tonicha', 'Diaz', 21, 'Softwarekonstruktion'),
	('Wilbur', 'Buckley', 22, 'Visualisering'),
	('Bianka', 'Conroy', 22, 'Softwarekonstruktion'),
	('Stacie', 'Mcneil', 20, 'Softwarekonstruktion'),
	('Tea', 'Hartley', 24, 'Softwarekonstruktion'),
	('Ammarah', 'Herbert', 23, 'Teknik'),
	('Wojciech', 'Vargas', 22, 'Visualisering'),
	('Noah', 'Dudley', 22, 'Teknik'),
	('Yazmin', 'Bennett', 24, 'Teknik'),
	('Mack', 'Blevins', 25, 'Softwarekonstruktion'),
	('Tomos', 'Calderon', 19, 'Visualisering'),
	('Colby', 'Bourne', 18, 'Visualisering'),
	('Tilly', 'Laing', 20, 'Teknik'),
	('Barnaby', 'Faulkner', 21, 'Teknik'),
	('Reanne', 'Boyd', 21, 'Softwarekonstruktion'),
	('Hina', 'Field', 25, 'Softwarekonstruktion'),
	('Matei', 'Monroe', 18, 'Visualisering'),
	('Riaan', 'Crosby', 24, 'Visualisering');

----------

USE AspIT
CREATE TABLE Teachers (
	TeacherID int IDENTITY(1,1) PRIMARY KEY, -- Microsoft SQL Auto Increment
	FirstName varchar(100),
	LastName varchar(100),
	Age int,
	CurrentlyTeaching varchar(25)
	);

----------

USE AspIT
INSERT INTO Teachers (FirstName, LastName, Age, CurrentlyTeaching) -- StudentID not required due to Auto Increment
VALUES
	('Myles', 'Duffy', 30, 'Softwarekonstruktion'),
	('Bjorn', 'Sears', 36, 'Teknik'),
	('Hollie', 'Witt', 38, 'Visualisering');

----------

USE AspIT
CREATE TABLE Classrooms (
	ClassroomID int IDENTITY(1,1) PRIMARY KEY, -- Microsoft SQL Auto Increment
	CurrentSubject varchar(25),
	StudentSeatCount int
	);

----------

USE AspIT
INSERT INTO Classrooms (CurrentSubject, StudentSeatCount) -- StudentID not required due to Auto Increment
VALUES
	('Softwarekonstruktion', 6),
	('Visualisering', 6),
	('Teknik', 7),
	('Lab', 4),
	('Quality Assurance', 4);

----------

-- Select all students that have an 'e' in their first name
USE AspIT
SELECT * FROM Students
WHERE FirstName LIKE '%e%';

----------

-- Order students by what they're currently studying
USE AspIT
SELECT * FROM Students
ORDER BY CurrentlyStudying;

----------

-- Create a temporary table by joining different tables that have a related column between them (The subject being studied in this case)
USE AspIT
-- Selects the columns from the different tables and gives them a temporary name
SELECT Students.FirstName AS 'First Name', Students.LastName AS 'Last Name', Students.CurrentlyStudying AS 'Current Subject', Teachers.FirstName AS 'Teacher'
FROM Classrooms
-- Combine rows from two or more tables, based on a related column between them
FULL OUTER JOIN Students ON Classrooms.CurrentSubject=Students.CurrentlyStudying
FULL OUTER JOIN Teachers ON Classrooms.CurrentSubject=Teachers.CurrentlyTeaching
--WHERE Students.CurrentlyStudying='Softwarekonstruktion'

----------

USE AspIT
-- Selects the columns from the different tables and gives them a temporary name
SELECT Students.FirstName AS 'First Name', Students.LastName AS 'Last Name', Students.CurrentlyStudying AS 'Current Subject', Teachers.FirstName AS 'Teacher'
FROM Students
-- Combine rows from two or more tables, based on a related column between them
FULL OUTER JOIN Teachers ON Students.CurrentlyStudying=Teachers.CurrentlyTeaching

WHERE CurrentlyStudying='Softwarekonstruktion';

/* Alternative
-- Combine rows from two or more tables, based on a related column between them
FULL OUTER JOIN Teachers ON Students.FirstName=Teachers.FirstName

WHERE CurrentlyStudying='Softwarekonstruktion' OR CurrentlyTeaching='Softwarekonstruktion';
*/

----------

USE AspIT
-- Selects the columns from the different tables and gives them a temporary name
SELECT Students.FirstName AS 'First Name', Students.LastName AS 'Last Name', Teachers.FirstName AS 'Teacher', Students.Age AS 'S Age', Teachers.Age AS 'T Age'
FROM Students
-- Combine rows from two or more tables, based on a related column between them
FULL OUTER JOIN Teachers ON Students.Age=Teachers.Age

ORDER BY Students.Age, Teachers.Age;

----------

USE AspIT
CREATE TABLE InternshipConsultant (
	ConsultantID int IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(100),
	LastName varchar(100),
	Age int,
	SupportingStudentYear varchar(6)
	);
	
----------

USE AspIT
INSERT INTO InternshipConsultant
VALUES
	('Albus',
	'Dumbledore',
	115);
	
----------

-- Add a new column for the students to keep track of their current year
USE AspIT
ALTER TABLE Students
ADD
	StudentYear varchar(6);
	
----------

-- Set the year for several students using their ID
USE AspIT
UPDATE Students
SET
	StudentYear = 'Year 1'
WHERE StudentID BETWEEN 1 AND 9;

-- WHERE StudentID BETWEEN 10 AND 17
-- WHERE StudentID BETWEEN 18 AND 25

----------

USE AspIT
UPDATE InternshipConsultant
SET
	SupportingStudentYear = 'Year 3'
WHERE ConsultantID=1;

----------

USE AspIT
SELECT InternshipConsultant.FirstName AS 'Consultant', Students.FirstName, Students.LastName, Students.StudentYear
FROM InternshipConsultant
RIGHT JOIN Students ON InternshipConsultant.SupportingStudentYear=Students.StudentYear

WHERE Students.StudentYear='Year 3';

----------

--- Union experimentation
USE AspIT
SELECT StudentID AS 'Student/Teacher ID', FirstName, LastName, Age, CurrentlyStudying AS 'Current Subject' FROM Students
UNION ALL
SELECT TeacherID, FirstName, LastName, Age, CurrentlyTeaching FROM Teachers;