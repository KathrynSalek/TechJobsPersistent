using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;  //TO DO: Part 2 Controllers #1 - Set up a private DbContext variable so you can perform CRUD operations on the database. 
        public EmployerController(JobDbContext dbcontext)
        {
            context = dbcontext;
        }

        // GET: /<controller>/
        public IActionResult Index() //TO DO: Part 2 Controllers #2 - Complete Index() so that it passes all of the Employer objects in the database to the view.
        {
            List<Employer> employers = context.Employers.ToList(); // TO DO: Part 2 Controllers #1 - Pass the private DbContext variable into a EmployerController constructor.
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel viewModel = new AddEmployerViewModel(); // TO DO: Part 2 Controllers #3 - Create an instance of AddEmployerViewModel inside of the Add() method 
            return View(viewModel); //TO DO: Part 2 Controllers #3 - and pass the instance into the View() return method.
        }


        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel viewModel)
        {
            if (ModelState.IsValid)  //TO DO: Part 2 Controllers #4 - Make sure that only valid Employer objects are being saved to the database
            {
                Employer employer = new Employer
                {
                    Name = viewModel.Name,
                    Location = viewModel.Location
                };

                context.Employers.Add(employer);  //TO DO: Part 2 Controllers #4 - Add the appropriate code to ProcessAddEmployerForm() so that it will process form submissions
                context.SaveChanges();
                return Redirect("/Home/");
            }
            return View("Add", viewModel);
        }

        public IActionResult About(int id)
        {          
            Employer employer = context.Employers.Find(id); //TO DO: Part 2 Controllers #5 - About() currently returns a view with vital information about each employer such as their name and location.
            return View(employer); //TO DO Part 2 Controllers #5 - Make sure that the method is actually passing an Employer object to the view for display.
        }
    }
}