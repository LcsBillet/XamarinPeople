using SQLite;

namespace Categories.Models
{
    [Table("categorie")]
    public class Categorie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Lib { get; set; }

        [MaxLength(250)]
        public string Img { get; set; }
    }
}