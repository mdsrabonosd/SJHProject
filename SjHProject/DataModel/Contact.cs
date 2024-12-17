using System.ComponentModel.DataAnnotations;

namespace SjHProject.DataModel
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string?Name { get; set; }
        public string?Phone{ get; set; }
        public string?Email{ get; set; }
        public string?Massage{ get; set; }
    }
}
