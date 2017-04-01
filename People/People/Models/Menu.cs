using SQLite;

namespace Menus.Models
{
    [Table("menu")]
    public class Menu
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Lib { get; set; }

        [MaxLength(250)]
        public string Img { get; set; }
    }
}