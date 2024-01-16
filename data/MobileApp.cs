using System.ComponentModel.DataAnnotations;

namespace DevTimeSolution.data
{
        public class MobileApp
        {
            [Key]
            public int AppId { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public decimal Price { get; set; }

            public string Developer { get; set; }

            public string Platform { get; set; }

            public DateTime ReleaseDate { get; set; }

            public string ImageUrl { get; set; }
        }
}
