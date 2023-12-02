using System.ComponentModel.DataAnnotations;


namespace FinalProject.Models
{
    public class State 
    {
        public int StateId {  get; set; }
        [Required(ErrorMessage = "Please enter a State Name.")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
