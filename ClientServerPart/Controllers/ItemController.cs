using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClientServerPart.Models;

namespace ClientServerPart.Controllers
{
    public class ItemController : Controller
    {
        private IItemRepository repository;
        public ItemController(IItemRepository repo)
        {
            repository = repo;
        }
        //Calling the View method like this (without specifying a view name) tells MVC to render the default view for the action method.
        public ViewResult List() => View(repository.CleverItems);
        //public ViewResult ItemOn_Off()
        //{

        //}
    }
}