CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY,
    FamilyName NVARCHAR(50),
    GivenName NVARCHAR(50),
    DateOfBirth DATE,
    Email NVARCHAR(100),
    Address NVARCHAR(200),
    Gender CHAR(1),
    PhoneNumber NVARCHAR(20),
    YearOfStudy INT,
    University NVARCHAR(100),
    Faculty NVARCHAR(100),
    ProgramOfStudy NVARCHAR(100),
    EnrollmentStatus NVARCHAR(20),
    EnrollmentDate DATETIME,
    Mean FLOAT
);

CREATE TABLE UnivClasses (
    ClassId INT PRIMARY KEY IDENTITY,
    UnivClassName NVARCHAR(50),
    Description NVARCHAR(200),
    ProfessorName NVARCHAR(100),
    Credits INT
);

CREATE TABLE ClassStudent (
    ClassId INT,
    StudentId INT,
    Grade FLOAT,
    PRIMARY KEY (ClassId, StudentId),
    FOREIGN KEY (ClassId) REFERENCES UnivClasses(ClassId),
    FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
);


INSERT INTO Students (
    FamilyName, GivenName, DateOfBirth, Email, Address, Gender, PhoneNumber, YearOfStudy, 
    University, Faculty, ProgramOfStudy, EnrollmentStatus, EnrollmentDate, Mean
) VALUES (
    'Popescu', 'Ion', '2000-04-25', 'ion.popescu@example.com', 'Strada Principala, Nr. 1, Bucuresti', 
    'M', '0700000001', 1, 'Universitatea Bucuresti', 'Facultatea de Matematica si Informatica', 
    'Informatica', 'ACTIV', GETDATE(), 9.5
);

INSERT INTO Students (
    FamilyName, GivenName, DateOfBirth, Email, Address, Gender, PhoneNumber, YearOfStudy, 
    University, Faculty, ProgramOfStudy, EnrollmentStatus, EnrollmentDate, Mean
) VALUES (
    'Ionescu', 'Maria', '1999-07-15', 'maria.ionescu@example.com', 'Strada Libertatii, Nr. 4, Cluj-Napoca', 
    'F', '0700000002', 2, 'Universitatea Babes-Bolyai', 'Facultatea de Istorie', 
    'Istorie', 'ACTIV', GETDATE(), 9.7
);

INSERT INTO Students (
    FamilyName, GivenName, DateOfBirth, Email, Address, Gender, PhoneNumber, YearOfStudy, 
    University, Faculty, ProgramOfStudy, EnrollmentStatus, EnrollmentDate, Mean
) VALUES (
    'Vasilescu', 'Andrei', '2001-11-05', 'andrei.vasilescu@example.com', 'Strada Secundara, Nr. 10, Iasi', 
    'M', '0700000003', 1, 'Universitatea Alexandru Ioan Cuza', 'Facultatea de Filosofie si Stiinte Social-Politice', 
    'Sociologie', 'GRADUATED', GETDATE(), 8.9
);
