using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class HelloWorldModel : PageModel
    {
        public HelloWorldModel(IHostingEnvironment env)
        {
            EnvName = env.EnvironmentName;
            PhysicalPath = env.ContentRootPath;
        }

        public string EnvName { get; set; }

        public string PhysicalPath { get; set; }

        public DateTime ServerTime { get; set; }

        public void OnGet(){
            ServerTime = DateTime.Now;
        }
    }
}