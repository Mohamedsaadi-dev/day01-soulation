using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using project01_structure.Properties.models;
using System.Security.Cryptography.X509Certificates;

namespace project01_structure.Properties.controllers
{
    public class MoviesControllers : Controller
    {
        [NonAction]
        public void DeleteMovie()
        {

        }
        public string index()
        {
            return "helow from index";
        }
        #region
        [HttpGet]
        // public ContentResult GetMovie(int? id,string name) { 

        //ContentResult result = new ContentResult();
        // result.Content = $"Movie with name={name} </br> and id={id}";
        // result = ContentType = "text/html";
        //result = StatusCode = 700;
        //return result;
        //return $"Movie with name={name} and id={id}";
        //
        // return Content($"movie with name{name} and id= {id}","text/html");
        #endregion
        #region
        // public  IActionResult    GetMovie(int? id, string name)
        // {
        // if (id == 0)

        // return BadRequest();
        //else if (id < 10)
        //     return NotFound();
        // else
        // return Content($"movie with name {name}and id{id}", "text/html");

        // }
        #endregion
        // public IActionResult TestRedirectAction()
        //  {
        //   return RedirectToAction("Get movie","movies", new  {id= 10,name="test"});
        //}
        [HttpPost]
        public IActionResult TestModelBinding ([FromQuery]int id, string name)
        {
            return Content($"hello {name} your id{id}");   
        }
        [HttpGet]
        public IActionResult AddMovie(string title,Movie movie,int id, int[]arr) 
        {
           // if (movie is null)
           //  return BadRequest();
          //  else
                return Content($"");
            
        }






    }
}


