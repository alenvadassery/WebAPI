namespace ProductAPI.EntityModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tblProduct")]
    public partial class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }
    }
}
