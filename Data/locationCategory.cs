using SQLite;
using System.ComponentModel.DataAnnotations;


namespace SampleProject1.Data
{
    public class locationCategory
    {
       

        [Required]
        public string Name { get; set; }
        public string Image { get; set; }


        public locationCategory(string name, string image)
        {
            Name = name;
            Image = image;
        }

        public locationCategory()
        {
        }

    }
}
