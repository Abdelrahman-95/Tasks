namespace Task5
{
    class Instractor
    {
        public Instractor(int instractorID, string name, string specialization)
        {
            InstractorID = instractorID;
            Name = name;
            Specialization = specialization;
        }
        public int InstractorID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public string PrintDetails()
        {
            return $"Instractor ID : {InstractorID} Name : {Name} Specialization : {Specialization}";
        }
    }

    class Course
    {
        public Course(int courseID, string tilte, Instractor Instractor)
        {
            CourseID = courseID;
            Tilte = tilte;
            this.Instractor = Instractor;
        }
        public int CourseID { get; set; }
        public string Tilte { get; set; }
        public Instractor Instractor { get; set; }
        public string PrintDetails()
        {
            return $"Course ID : {CourseID} Tilte: {Tilte} Instractor ID : {Instractor.InstractorID}  Instractor Name : {Instractor.Name}  Instractor Specialization : {Instractor.Specialization}";
        }
    }
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        List<Course> Courses = new List<Course>();
        public Student(int studentID, string name, int age, List<Course> courses)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Courses = courses;
        }
        public bool Enroll(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (course.Tilte == Courses[i].Tilte)
                {
                    Console.WriteLine("This Course Already Exists!");
                    return false;
                }
            }
            Courses.Add(course);
            Console.WriteLine("Course added successfully.");
            return true;
        }
    }
    class StudentManager
    {
        public List<Student> students = new List<Student>();
        public List<Course> courses = new List<Course>();
        public List<Instractor> instractors = new List<Instractor>();
        public StudentManager(List<Student> students, List<Course> courses, List<Instractor> instractors)
        {
            this.students = students;
            this.courses = courses;
            this.instractors = instractors;
        }
        public bool AddStudent(Student student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (student.StudentID == students[i].StudentID)
                {
                    Console.WriteLine("This Student Already Exists!");
                    return false;
                }
            }
            students.Add(student);
            Console.WriteLine("student added successfully.");
            return true;
        }
        public bool AddInstractor(Instractor instractor)
        {
            for (int i = 0; i < instractors.Count; i++)
            {
                if (instractor.InstractorID == instractors[i].InstractorID)
                {
                    Console.WriteLine("This Instractor Already Exists!");
                    return false;
                }
            }
            instractors.Add(instractor);
            Console.WriteLine("Instractor added successfully.");
            return true;
        }

        public bool AddCourse(Course course)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].CourseID == course.CourseID)
                {
                    Console.WriteLine("This course Already Exists!");
                    return false;
                }
            }
            courses.Add(course);
            Console.WriteLine("Course added successfully.");
            return true;
        }
        public Student FindStudent(int studentID)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (studentID == students[i].StudentID)
                {
                    return students[i];
                }
            }
            return null;
        }

        public Course FindCourse(int courseID)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courseID == courses[i].CourseID)
                {
                    return courses[i];
                }
            }
            return null;
        }

        public Instractor FindInstractor(int instractorID)
        {
            for (int i = 0; i < instractors.Count; i++)
            {
                if (instractorID == instractors[i].InstractorID)
                {
                    return instractors[i];
                }
            }
            return null;
        }

        public bool EnrollStudentInCourse(int studentId, int courseId) 
        {
           
            Student currentStudent = FindStudent(studentId);
            Course targetCourse = FindCourse(courseId);
            if (currentStudent != null && targetCourse != null)
            {
                return currentStudent.Enroll(targetCourse);
            }
            else
            {
                Console.WriteLine("Error: Student or Course not found!");
                return false;
            }

        }
        public string GetInstructorByCourseName(string courseName)
        {
            foreach (Course c in courses)
            {
                if (c.Tilte == courseName) 
                {
                    return c.Instractor.Name;
                }
            }
            return "Course not found!"; 
        }

        static void Main(string[] args)
        {
          
            StudentManager school = new StudentManager(new List<Student>(), new List<Course>(), new List<Instractor>());

            while (true) 
            {
                Console.WriteLine("\n========== Student Management System ==========");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find the student by ID");
                Console.WriteLine("9. Find the course by ID");
                Console.WriteLine("10. Get instructor name by course name ");
                Console.WriteLine("11. Exit");
                Console.WriteLine("===============================================");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student ID: ");
                        int sId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string sName = Console.ReadLine();
                        Console.Write("Enter Student Age: ");
                        int sAge = Convert.ToInt32(Console.ReadLine());

                        school.AddStudent(new Student(sId, sName, sAge, new List<Course>()));
                        break;

                    case 2: 
                        Console.Write("Enter Instructor ID: ");
                        int iId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Instructor Name: ");
                        string iName = Console.ReadLine();
                        Console.Write("Enter Specialization: ");
                        string spec = Console.ReadLine();

                        school.AddInstractor(new Instractor(iId, iName, spec));
                        break;

                    case 3: 
                        Console.Write("Enter Course ID: ");
                        int cId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Course Title: ");
                        string cTitle = Console.ReadLine();
                        Console.Write("Enter Instructor ID for this course: ");
                        int instId = Convert.ToInt32(Console.ReadLine());
                        Instractor inst = school.FindInstractor(instId);

                        if (inst != null)
                        {
                            school.AddCourse(new Course(cId, cTitle, inst));
                        }
                        else
                        {
                            Console.WriteLine("Instructor not found! You must add the instructor first.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Student ID: ");
                        int enrollSId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Course ID: ");
                        int enrollCId = Convert.ToInt32(Console.ReadLine());

                        school.EnrollStudentInCourse(enrollSId, enrollCId);
                        break;

                    case 5: 
                        Console.WriteLine("\n--- All Students ---");
                        if (school.students.Count == 0) Console.WriteLine("No students available.");
                        foreach (Student s in school.students)
                        {
                            Console.WriteLine($"ID: {s.StudentID} | Name: {s.Name} | Age: {s.Age}");
                        }
                        break;

                    case 6: 
                        Console.WriteLine("\n--- All Courses ---");
                        if (school.courses.Count == 0) Console.WriteLine("No courses available.");
                        foreach (Course c in school.courses)
                        {
                           
                            Console.WriteLine(c.PrintDetails());
                        }
                        break;

                    case 7:
                        Console.WriteLine("\n--- All Instructors ---");
                        if (school.instractors.Count == 0) Console.WriteLine("No instructors available.");
                        foreach (Instractor i in school.instractors)
                        {
                            Console.WriteLine(i.PrintDetails());
                        }
                        break;

                    case 8: 
                        Console.Write("Enter Student ID to find: ");
                        int searchSId = Convert.ToInt32(Console.ReadLine());
                        Student foundStudent = school.FindStudent(searchSId);

                        if (foundStudent != null)
                            Console.WriteLine($"Found! ID: {foundStudent.StudentID} | Name: {foundStudent.Name} | Age: {foundStudent.Age}");
                        else
                            Console.WriteLine("Student not found.");
                        break;

                    case 9: 
                        Console.Write("Enter Course ID to find: ");
                        int searchCId = Convert.ToInt32(Console.ReadLine());
                        Course foundCourse = school.FindCourse(searchCId);

                        if (foundCourse != null)
                            Console.WriteLine($"Found! {foundCourse.PrintDetails()}");
                        else
                            Console.WriteLine("Course not found.");
                        break;

                    case 10: 
                        Console.Write("Enter Course Name (Title): ");
                        string searchCourseName = Console.ReadLine();
                        string instructorName = school.GetInstructorByCourseName(searchCourseName);
                        Console.WriteLine($"Instructor Name: {instructorName}");
                        break;

                    case 11: 
                        Console.WriteLine("Exiting the system... Goodbye!");
                        return; 

                    default:
                        Console.WriteLine("Invalid choice! Please select a number from 1 to 10.");
                        break;
                }
            }
        }
    }
}
