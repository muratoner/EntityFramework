using System.ComponentModel.DataAnnotations.Schema;

namespace SQLite
{
    [Table("Person")]
    public class Person
    {
        //SQLite'daki tür karşılığı INTEGER'dır
        public long Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
