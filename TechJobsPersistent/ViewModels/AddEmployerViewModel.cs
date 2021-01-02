using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")] //TO DO: Part 2 View Models #2  Add validation to both properties in the ViewModel so that both properties are required
        public string Name { get; set; } //TO DO: Part 2 View Models #1 Create a new ViewModel called AddEmployerViewModel that has 2 properties: Name and Location.

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {

        }
    }
}
