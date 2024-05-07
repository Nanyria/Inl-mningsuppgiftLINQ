using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;
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
                Join.JoinTeacher(dbContext);
            }

            Console.ReadKey();

        }
    }
}
