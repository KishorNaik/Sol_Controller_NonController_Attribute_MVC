using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Demo.Controllers
{
    [NonController] // Define Non Controller attribute, it will not become as Controller.
    public class TrafficController
    {

        // Run the following action in browser, it will execute becuase of "Controller" suffix in a class.
        // http://localhost:26213/Traffic/Index

        public String Index()
        {
            return "Hello";
        }
    }
}