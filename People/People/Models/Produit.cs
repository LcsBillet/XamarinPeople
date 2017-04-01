using SQLite;

namespace Catalogue.Models
{
    [Table("produit")]
    public class Produit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Lib { get; set; }

        [MaxLength(250)]
        public string Img { get; set; }

        [MaxLength(15)]
        public int Cat { get; set; }

        [MaxLength(15)]
        public float Glu_lents { get; set; }

        [MaxLength(15)]
        public float Glu_rapides { get; set; }

        [MaxLength(15)]
        public int Ens { get; set; }
    }
}