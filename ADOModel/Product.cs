using System;
using System.ComponentModel.DataAnnotations;


namespace ADOModel
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int ProductPrice { get; set; }

        [Required]
        public int ProductCategoryId { get; set; }

        [Required]
        public string DateCreated { get; set; }
    }
}
