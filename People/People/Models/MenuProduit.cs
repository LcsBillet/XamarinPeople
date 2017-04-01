using SQLite;

namespace MenuProduits.Models
{
    [Table("menuproduit")]
    public class MenuProduit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(15)]
        public int Prod { get; set; }

        [MaxLength(15)]
        public float Menu { get; set; }
    }
}