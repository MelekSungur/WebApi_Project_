using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApi_Project_.DAL;
using WebApi_Project_.DAL.Entities;

namespace WebApi_Project_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        Context context=new Context();

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = context.Categories.Find(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values=context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            return Ok();
        }
        //Güncelleme
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            var values = context.Categories.Find(category.CategoryId);
            values.Name = category.Name;
            values.Description = category.Description;
            values.Status= category.Status;
            context.SaveChanges();
            return Ok();
            

        }
    }
}
