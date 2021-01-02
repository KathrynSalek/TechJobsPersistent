using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel //TO DO: Part 2 Adding a Job #1 - Create a new ViewModel called AddJobViewModel. 
    {
        public string Name { get; set; } //You will need properties for the job’s name
        public int EmployerId { get; set; } //the selected employer’s ID
        public List<SelectListItem> AllEmployers { get; set; } //and a list of all employers as SelectListItem.

        public List<Skill> AllSkills { get; set; } //TO DO:  Part 3 Updating AddJobViewModel #1 - Add a property for a list of each Skill object in the database.
        public string[] SelectedSkills { get; set; }  //TO DO:  Part 3 Updating AddJobViewModel #2 -  Pass another parameter of a list of Skill objects. Set the List<Skill> property equal to the parameter you have just passed in
       
        public AddJobViewModel() { }


        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            AllEmployers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                AllEmployers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

            AllSkills = skills;
        }
    }
}
