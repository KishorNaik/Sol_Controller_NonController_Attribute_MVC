using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Demo.Controllers
{


    [Controller] // Define Controller Attribute, Now it become Controller action without Controller class inheritance.
    public class ControllerDemo
    {
        // http://localhost:26213/ControllerDemo/Index
        public string Index()
        {
            return "Hello";
        }

    }
}