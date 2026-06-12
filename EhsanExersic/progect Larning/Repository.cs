

using Microsoft.EntityFrameworkCore;
using progect_Larning.Mudels;

namespace progect_Larning
{
    public class Repository
    {
        private object id;

        public void AddPerson(string Name, string LastName)
        {
            Person person = new()
            {
                Name = Name,
                LastName = LastName
            };
            EfIntorDbContext _context = new EfIntorDbContext();
            _context.People.Add(person);
            _context.SaveChanges();
        }
        public void UpdatePerson(int Id, string Name, string LastName)
        {
            using var _context = new EfIntorDbContext();
            var person = _context.People.Find(Id);
            if (person != null)
            {
                person.Name = Name;
                person.LastName = LastName;
                _context.SaveChanges();
            }
        }
        public void PrintPerson()
        {
            EfIntorDbContext _Context = new EfIntorDbContext();
            var peopel = _Context.People.AsNoTracking().ToList();
            foreach (var item in peopel)
            {
                Console.WriteLine($"Person Id:{item.Id}" +
                    $",FirestName:{item.Name},Family:{item.LastName}");
            }
        }
        public void DeletePerson(int id)
        {
            EfIntorDbContext _context= new EfIntorDbContext();
            Person person=_context.People.Find(id);
            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }
        }
    }
}
