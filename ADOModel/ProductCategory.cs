using System.ComponentModel.DataAnnotations;

namespace ADOModel
{
    class ProductCategory
    {
        [Required]
        public int CategoryId { set; get; }
        [Required]
        public string CategoryName { set; get; }
        [Required]
        public int IsActive { set; get; }

    }
}
