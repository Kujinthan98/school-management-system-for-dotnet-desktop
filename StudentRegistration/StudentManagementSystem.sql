-- Create Grades Table
CREATE TABLE grades (
    id INT PRIMARY KEY IDENTITY(1,1),
    grade_name VARCHAR(10),
    grade_group VARCHAR(10),
    grade_order INT,
    created_at TIMESTAMP,
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME
);

-- Create Students Table
CREATE TABLE students (
    id INT PRIMARY KEY IDENTITY(1,1),
    admission_no VARCHAR(20) UNIQUE,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    full_name VARCHAR(100),
    gender VARCHAR(10),
    date_of_birth DATE,
    stu_nic_no VARCHAR(12),
    tp_no VARCHAR(10),
    grade_id INT,
    medium VARCHAR(10),
    date_of_admission DATE,
    resident_address VARCHAR(100),
    created_at TIMESTAMP,
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME,
	-- One-to-Many Relationship: Each student belongs to one grade, but each grade can have many students.
    FOREIGN KEY (grade_id) REFERENCES grades(id) 
);

-- Create Subjects Table
CREATE TABLE subjects (
    id INT PRIMARY KEY IDENTITY(1,1),
    subject_name VARCHAR(100),
    subject_index INT,
    subject_number VARCHAR(50),
    subject_order INT,
    created_at TIMESTAMP,
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME
);

-- Create Student_Subject Table
CREATE TABLE student_subject (
    id INT PRIMARY KEY IDENTITY(1,1),
    subject_id INT,
    admission_no VARCHAR(20),
	-- Many-to-Many Relationship: Each student can take many subjects, and each subject can be taken by many students.
    FOREIGN KEY (subject_id) REFERENCES subjects(id),
    FOREIGN KEY (admission_no) REFERENCES students(admission_no)
);

-- Create Grade_Subject Table
CREATE TABLE grade_subject (
    id INT PRIMARY KEY IDENTITY(1,1),
    grade_id INT NOT NULL,
    subject_id INT NOT NULL,
	-- Many-to-Many Relationship: Each grade can have many subjects, and each subject can be taught in many grades.
    FOREIGN KEY (grade_id) REFERENCES grades(id), 
    FOREIGN KEY (subject_id) REFERENCES subjects(id)
);
