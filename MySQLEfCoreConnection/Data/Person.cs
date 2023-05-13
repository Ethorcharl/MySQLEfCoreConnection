using System.ComponentModel.DataAnnotations;

namespace MySQLEfCoreConnection.Data
{
    public class Person
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        public int Age { get; set; }
        public bool IsPlayer { get; set; }

    }
}
