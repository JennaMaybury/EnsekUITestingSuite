using System.ComponentModel.DataAnnotations;

namespace EnsekUITestingSuite.Helpers
{
    public class TestDataProperties
    {
        [Required]
        public string? Url { get; set; }

        public string? UserName { get; set; }
        public string? Password { get; set; }


    }
}
