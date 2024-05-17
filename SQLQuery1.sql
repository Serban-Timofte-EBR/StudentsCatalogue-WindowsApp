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
