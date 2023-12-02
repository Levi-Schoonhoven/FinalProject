using System.ComponentModel.DataAnnotations;


namespace FinalProject.Models
{
    public class State 
    {
        public int StateId {  get; set; }
        [Required(ErrorMessage = "Please enter a State Name.")]
        public string Name { get; set; }
        public string Description { get; set; }
        
        public string DirectionId { get; set; }
        public Direction ?Direction { get; set; }

        public string Slug =>
        Name?.Replace(' ', '-').ToLower() + '-' + Description?.ToString();
    }
}
 

