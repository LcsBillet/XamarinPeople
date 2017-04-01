using SQLite;

namespace Enseignes.Models
{
    [Table("enseigne")]
    public class Enseigne
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Lib { get; set; }

        [MaxLength(250)]
        public string Img { get; set; }
    }
}