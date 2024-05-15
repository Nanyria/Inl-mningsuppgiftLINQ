using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using InlämningsuppgiftLINQ.Models.CombinedMethodCollections;
using InlämningsuppgiftLINQ.Models.MethodCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ
{
    internal class scrap
    {

        //using SchoolDbContext db = new SchoolDbContext();

        //var subjects = new List<Subject>()
        //{
        //        new Subject()
        //        {
        //            //SubjectID = 101,
        //            SubjectsName = "Math 1",
        //            //Teachers = new List<Teacher>()
        //            //{
        //            //    ////"Anas",
        //            //    //TeacherID = 101,
        //            //    ////"Reidar"
        //            //    //102
        //            //},
        //            //CourseID = 101

        //        },
        //        new Subject()
        //        {
        //            //SubjectID = 102,
        //            SubjectsName = "Math 2",
        //        //    Teachers = new List<Teacher>()
        //        //    {
        //        //    //    //"Reidar",
        //        //    //    102,
        //        //    //    //"Tobias"
        //        //    //    103
        //        //},
        //        //CourseID = 102
        //        },
        //        new Subject()
        //        {
        //            //SubjectID = 103,
        //            SubjectsName = "Programming 1",
        //            //Teachers = new List<Teacher>()
        //            //{
        //            ////    //"Anas",
        //            ////    101,
        //            ////    //"Tobias"
        //            ////    103
        //            //},
        //            //CourseID = 101
        //        },
        //        new Subject()
        //        {
        //            //SubjectID = 104,
        //            SubjectsName = "Programming 2",
        //            //Teachers = new List<Teacher>()
        //            //{
        //            ////    //"Anas",
        //            ////    101,
        //            ////    //"Reidar",
        //            ////    102,
        //            ////    //"Tobias"
        //            ////    103
        //            //},
        //            //CourseID = 102

        //        }
        //    };


        //var teachers = new List<Teacher>()
        //    {
        //        new Teacher()
        //        {
        //            //TeacherID = 101,
        //            TeacherName = "Anas",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //    103,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        },
        //        new Teacher()
        //        {
        //            //TeacherID = 102,
        //            TeacherName = "Reidar",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //    102,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        },
        //        new Teacher()
        //        {
        //            //TeacherID = 103,
        //            TeacherName = "Tobias",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //    103,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        }
        //    };
        //var subjectsUpdate = new List<Subject>()
        //    {
        //        new Subject()
        //        {
        //            SubjectID = 101,
        //            SubjectsName = "Math 1",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                101,
        //                102
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        },
        //        new Subject()
        //        {
        //            SubjectID = 102,
        //            SubjectsName = "Math 2",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                102,
        //                103
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        },
        //        new Subject()
        //        {
        //            SubjectID = 103,
        //            SubjectsName = "Programming 1",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                101,
        //                103
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        },
        //            new Subject()
        //        {
        //            SubjectID = 104,
        //            SubjectsName = "Programming 2",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                101,
        //                102,
        //                103
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        }
        //    };


        //var courses = new List<Course>()
        //    {

        //        new Course()
        //        {
        //            //CourseID = 101,
        //            Name = "SUT22",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //    103,
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        },
        //        new Course()
        //        {
        //            //CourseID = 102,
        //            Name = "SUT21",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        }
        //    };

        //var students = new List<Student>()
        //    {
        //        new Student()
        //        {
        //            //StudentID = 101,
        //            FirstName = "Anna",
        //            LastName = "Andersson",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        },
        //        new Student()
        //        {
        //            //StudentID = 102,
        //            FirstName = "Bert",
        //            LastName = "Beritsson",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        },
        //        new Student()
        //        {
        //            //StudentID = 103,
        //            FirstName = "Cecilia",
        //            LastName = "Carm",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        },
        //        new Student()
        //        {
        //            //StudentID = 104,
        //            FirstName = "Dani",
        //            LastName = "Denire",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        }
        //};

        ////CourseCollection trycourses = new CourseCollection();
        ////foreach (var c in trycourses.GetAll())
        ////{
        ////    Console.WriteLine($"CourseID: {c.CourseID}\n" +
        ////        $"Course name: {c.Name}\n" +
        ////        $"Subjects: {c.Subjects}\n" +
        ////        $"Students: {c.Students}\n");
        ////}

        //foreach (var subject in subjects)
        //{
        //    db.Subjects.Add(subject);
        //}

        //var cc = new List<CourseStudentsCollection>()
        //{
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 100,
        //        CourseID = 107,
        //    },
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 101,
        //        CourseID = 107,
        //    },
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 103,
        //        CourseID = 106,
        //    },
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 104,
        //        CourseID = 106,
        //    }
        //};

        //foreach (var cc in students)
        //{
        //    db.Students.Add();
        //}
        //    public class StudentTeacherRelationshipManager
        //    {
        //        private readonly SchoolDbContext _dbContext;

        //        public StudentTeacherRelationshipManager(SchoolDbContext dbContext)
        //        {
        //            _dbContext = dbContext;
        //        }

        //        public void MapStudentTeacherRelationships()
        //        {
        //            // Retrieve existing students and teachers from the database
        //            var students = _dbContext.Students.ToList();
        //            var teachers = _dbContext.Teachers.ToList();

        //            // Your business logic to determine student-teacher relationships
        //            // For this example, let's assume every student is assigned to every teacher

        //            foreach (var student in students)
        //            {
        //                foreach (var teacher in teachers)
        //                {
        //                    // Create an instance of StudentTeachersCollection and populate it
        //                    var relationship = new StudentTeachersCollection
        //                    {
        //                        StudentID = student.StudentID,
        //                        TeacherID = teacher.TeacherID
        //                    };

        //                    // Add the relationship to the StudentTeachersCollection table
        //                    _dbContext.StudentTeachersCollections.Add(relationship);
        //                }
        //            }

        //            // Save changes to persist the relationships in the database
        //            _dbContext.SaveChanges();
        //        }
        //    }
        //}

        //db.SaveChanges();
        //var studentsTeachers = (from student in studentCollection.GetAll()
        //                        join studentCourse in courseStudentMethods.GetAll()
        //                        on student.StudentID equals studentCourse.StudentID

        //                        // join med courseSubject för att hitta ämne till kurs 
        //                        join courseSubject in courseSubjectsMethods.GetAll()
        //                        on studentCourse.CourseID equals courseSubject.CourseID

        //                        //join med subjectTeacher för att hitta lärare till ämne
        //                        join subjectTeacher in subjectsTeacherMethods.GetAll()
        //                        on courseSubject.SubjectID equals subjectTeacher.SubjectID

        //                        //join med teacher för att få fram lärarnamn
        //                        join thisTeacher in teacherCollection.GetAll()
        //                        on subjectTeacher.TeacherID equals thisTeacher.TeacherID

        //                        //kollar ämnen för Anas
        //                        join anasSubject in courseSubjectsMethods.GetAll()
        //                        on courseSubject.SubjectID equals anasSubject.SubjectID

        //                        join anasTeacher in teacherCollection.GetAll()
        //                        on subjectTeacher.TeacherID equals anasTeacher.TeacherID

        //                        //Kollar ämnen för Reidar
        //                        join reidarSubject in courseSubjectsMethods.GetAll()
        //                        on courseSubject.SubjectID equals reidarSubject.SubjectID

        //                        //
        //                        join reidarTeacher in teacherCollection.GetAll()
        //                        on subjectTeacher.TeacherID equals reidarTeacher.TeacherID



        //                        where thisTeacher.TeacherName == "Anas"
        //                        && anasTeacher.TeacherName == "Anas"
        //                        && reidarTeacher.TeacherName == "Reidar"
        //                        && anasSubject.SubjectID == reidarSubject.SubjectID
        //                        select new
        //                        {
        //                            teacherName = thisTeacher.TeacherName,
        //                            subjectID = courseSubject.SubjectID,
        //                            StudentName = ($"{student.FirstName} + {student.LastName}")
        //                        }).ToList();


        // Check if Anas and Reidar teach the same subjects for the specified student
        //if (TeachersTeachingSameSubject(dbContext, studentId))
        //{
        //     Proceed with updating the student record

        //     Assuming you have a method to update the student record in your StudentCollection class
        //    StudentCollection studentCollection = new StudentCollection(dbContext);
        //    TeacherCollection teacherCollection = new TeacherCollection(dbContext);
        //    StudentTeacherMethod studentTeachersMethod = new StudentTeacherMethod(dbContext);

        //     Retrieve the student entity that needs to be updated
        //    var studentToUpdate = studentCollection.Find(studentId);
        //    if (studentToUpdate != null)
        //    {
        //         Find the current teacher of the student
        //        var currentTeacher = studentToUpdate.StudentTeachers.FirstOrDefault()?.Teacher;

        //         Find the new teacher (Reidar)
        //        var newTeacher = teacherCollection.GetAll().FirstOrDefault(t => t.TeacherName == "Reidar");

        //        if (currentTeacher != null && newTeacher != null)
        //        {
        //             Update the StudentTeachersCollection table to associate the student with the new teacher
        //            var studentTeacher = studentToUpdate.StudentTeachers.FirstOrDefault();
        //            studentTeacher.Teacher = newTeacher;
        //            studentTeacher.TeacherID = newTeacher.TeacherID;

        //             Save changes to the database
        //            dbContext.SaveChanges();

        //            Console.WriteLine("Student's teacher updated successfully.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Failed to find current or new teacher.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student record not found.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Anas and Reidar do not teach the same subjects for the specified student.");
        //     Handle the case where Anas and Reidar do not teach the same subjects
        //}


        //public static void ChangeTeacherForStudent(SchoolDbContext dbContext)
        //{

        //    //Uppdatera en student record om deras lärare är Anas till Reidar.
        //    CourseCollection courseCollection = new CourseCollection(dbContext);
        //    StudentCollection studentCollection = new StudentCollection(dbContext);
        //    SubjectCollection subjectCollection = new SubjectCollection(dbContext);
        //    TeacherCollection teacherCollection = new TeacherCollection(dbContext);

        //    SubjectsTeacherMethods subjectsTeacherMethods = new SubjectsTeacherMethods(dbContext);
        //    StudentTeacherMethod studentTeachersMethod = new StudentTeacherMethod(dbContext);

        //    //join student med coursestudent för att kunna koppla student med studentteacher
        //    var studentsTeachers = (from student in studentCollection.GetAll()
        //                            join studentTeacher in studentTeachersMethod.GetAll()
        //                            on student.StudentID equals studentTeacher.StudentID

        //                            // join med teacher för att hitta namn på lärare
        //                            join teacher in teacherCollection.GetAll()
        //                            on studentTeacher.TeacherID equals teacher.TeacherID

        //                            //join med subjectTeacher för att hitta lärare till ämne
        //                            join subjectTeacher in subjectsTeacherMethods.GetAll()
        //                            on teacher.TeacherID equals subjectTeacher.TeacherID

        //                            //kollar ämnen för Anas
        //                            join anasSubject in courseSubjectsMethods.GetAll()
        //                            on courseSubject.SubjectID equals anasSubject.SubjectID

        //                            join anasTeacher in teacherCollection.GetAll()
        //                            on subjectTeacher.TeacherID equals anasTeacher.TeacherID

        //                            //Kollar ämnen för Reidar
        //                            join reidarSubject in courseSubjectsMethods.GetAll()
        //                            on courseSubject.SubjectID equals reidarSubject.SubjectID

        //                            //
        //                            join reidarTeacher in teacherCollection.GetAll()
        //                            on subjectTeacher.TeacherID equals reidarTeacher.TeacherID



        //                            where thisTeacher.TeacherName == "Anas"
        //                            && anasTeacher.TeacherName == "Anas"
        //                            && reidarTeacher.TeacherName == "Reidar"
        //                            && anasSubject.SubjectID == reidarSubject.SubjectID
        //                            select new
        //                            {
        //                                teacherName = thisTeacher.TeacherName,
        //                                subjectID = courseSubject.SubjectID,
        //                                StudentName = ($"{student.FirstName} + {student.LastName}")
        //                            }).ToList();



        //    foreach (var item in studentsTeachers)
        //    {
        //        // Ensure both Anas and Reidar teach the same subject
        //        if (item.SubjectsTaught == item.ReidarTeacher.SubjectsTaught)
        //        {
        //            // Update the teacher for each student to Reidar
        //            item.Student.Teacher = "Reidar";
        //            // Update the student record in the database
        //            studentCollection.Update(item.Student.StudentID, item.Student);
        //        }
        //    }

        //}
        //public static void ChangeTeacherForStudent(SchoolDbContext dbContext, int studentId)
        //{
        //    CourseStudentMethods courseStudentMethods = new CourseStudentMethods(dbContext);
        //    CourseSubjectsMethods courseSubjectsMethods = new CourseSubjectsMethods(dbContext);
        //    SubjectsTeacherMethods subjectsTeacherMethods = new SubjectsTeacherMethods(dbContext);
        //    TeacherCollection teacherCollection = new TeacherCollection(dbContext);

        //var studentsTeachers = (
        //    from student in courseStudentMethods.GetAll()
        //    where student.StudentID == studentId
        //    //Söker reda på studentid vi vill ändra lärare för

        //    // join med courseSubject för att hitta ämne till kurs 
        //    join courseSubject in courseSubjectsMethods.GetAll()
        //    on student.CourseID equals courseSubject.CourseID

        //    //join med subjectTeacher för att hitta lärare till ämne
        //    join subjectTeacher in subjectsTeacherMethods.GetAll()
        //    on courseSubject.SubjectID equals subjectTeacher.SubjectID

        //    //join med teacher för att få fram lärarnamn
        //    join teacher in teacherCollection.GetAll()
        //    on subjectTeacher.TeacherID equals teacher.TeacherID

        //        where teacher.TeacherName == "Anas" || teacher.TeacherName == "Reidar"
        //        group courseSubject.SubjectID
        //        by teacher.TeacherName into g
        //        where g.Count() == 2 // Både Anas och Reidar måste undervisa minst 1 samma ämne
        //        select new
        //        {
        //            TeacherName = g.Key,
        //            SubjectIDs = g.ToList()
        //        }
        //    ).ToList();

        //    var subjectsTaughtByAnas = studentsTeachers.FirstOrDefault(x => x.TeacherName == "Anas")?.SubjectIDs;
        //    var subjectsTaughtByReidar = studentsTeachers.FirstOrDefault(x => x.TeacherName == "Reidar")?.SubjectIDs;

        //    if (subjectsTaughtByAnas != null && subjectsTaughtByReidar != null &&
        //        subjectsTaughtByAnas.SequenceEqual(subjectsTaughtByReidar))
        //    {
        //        Console.WriteLine("Anas and Reidar teach the same subjects for the specified student.");
        //        // Proceed with updating the student record
        //    }
        //    else
        //    {
        //        Console.WriteLine("Anas and Reidar do not teach the same subjects for the specified student.");
        //        // Handle the case where Anas and Reidar do not teach the same subjects
        //    }
        //}
        public class StudentCourseRelationshipManager
        {
            private readonly SchoolDbContext _dbContext;

            public StudentCourseRelationshipManager(SchoolDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void MapStudentCourseRelationships()
            {
                // Retrieve existing students and teachers from the database
                var students = _dbContext.Students.ToList();
                var courses = _dbContext.Courses.ToList();

                // Your business logic to determine student-teacher relationships
                // For this example, let's assume every student is assigned to every teacher

                foreach (var student in students)
                {
                    foreach (var course in courses)
                    {
                        // Create an instance of StudentTeachersCollection and populate it
                        var relationship = new CourseStudentsCollection
                        {
                            StudentID = student.StudentID,
                            CourseID = course.CourseID
                        };

                        // Add the relationship to the StudentTeachersCollection table
                        _dbContext.CourseStudentsCollections.Add(relationship);
                    }
                }

                // Save changes to persist the relationships in the database
                _dbContext.SaveChanges();
            }
        }

        //Att göra:koppla lärare till kurs, fortsätta lärare-student

        public class SubjectCourseRelationshipManager
        {
            private readonly SchoolDbContext _dbContext;

            public SubjectCourseRelationshipManager(SchoolDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void MapSubjectCourseRelationships()
            {
                // Retrieve existing students and teachers from the database
                var subjects = _dbContext.Subjects.ToList();
                var courses = _dbContext.Courses.ToList();

                // Your business logic to determine student-teacher relationships
                // For this example, let's assume every student is assigned to every teacher

                foreach (var subject in subjects)
                {
                    foreach (var course in courses)
                    {
                        // Create an instance of StudentTeachersCollection and populate it
                        var relationship = new CourseSubjectsCollection
                        {
                            SubjectID = subject.SubjectID,
                            CourseID = course.CourseID
                        };

                        // Add the relationship to the StudentTeachersCollection table
                        _dbContext.CourseSubjectsCollections.Add(relationship);
                    }
                }

                // Save changes to persist the relationships in the database
                _dbContext.SaveChanges();
            }
        }
        public class StudentPrimatyTeacherRelationship
        {
            private readonly SchoolDbContext _dbContext;

            public StudentPrimatyTeacherRelationship(SchoolDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void MapPrimaryTecherStudent()
            {
                // Retrieve existing students and teachers from the database
                var students = _dbContext.Students.ToList();

                // Your business logic to determine student-teacher relationships
                // For this example, let's assume every student is assigned to every teacher

                foreach (var student in students)
                {

                    if (student.courseID == 106)
                    {
                        var relationship = new PrimaryTeacherStudent
                        {
                            StudentID = student.StudentID,
                            TeacherID = 100
                        };

                        // Add the relationship to the StudentTeachersCollection table
                        _dbContext.primaryTeacherStudents.Add(relationship);
                    }

                    if (student.courseID == 107)
                    {
                        var relationship = new PrimaryTeacherStudent
                        {
                            StudentID = student.StudentID,
                            TeacherID = 101
                        };

                        // Add the relationship to the StudentTeachersCollection table
                        _dbContext.primaryTeacherStudents.Add(relationship);
                    }


                }

                // Save changes to persist the relationships in the database
                _dbContext.SaveChanges();
            }
        }

        //Att göra:koppla lärare till kurs, fortsätta lärare-student
    }

}


