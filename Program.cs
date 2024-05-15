using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using InlämningsuppgiftLINQ.Models.CombinedMethodCollections;
using InlämningsuppgiftLINQ.Models.MethodCollections;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace InlämningsuppgiftLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SchoolDbContext())
            {
                // Call JoinTeacher method and pass the dbContext
                //Join.JoinTeacher(dbContext);
                //Join.ChangeName(dbContext);
                //Join.CheckName(dbContext);

                Join.StudentTeachers(dbContext, 102);
                //Console.WriteLine("\n Change teacher from anas to reidar");
                Join.ChangeTeacherForThisStudent(dbContext, 102);
                //Console.WriteLine("\n print info again");
                //Join.StudentTeachers(dbContext, 101);'
                Join.StudentTeachers(dbContext, 102);


                Console.ReadKey();
            }
        }






    }
}


