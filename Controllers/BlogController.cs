using Bloglist.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bloglist.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        var blog = new Blog();
        blog.Id = 1;
        blog.Title = "Teknoloji";
        blog.Content = "Html nin Açılımı Hyper text markup Languagetir";
        blog.Images = "1.jpg";
        return View(blog);
    }
    public IActionResult List()
    {

        return View(Repisotory.Blog);
    }
    public IActionResult Details(int id)
    {
        
        return View(Repisotory.GetById(id));

    }
}