using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                            "<h2>Coding Skills to Learn</h2>" +
                            "<ol style='list-style: none'> <li>JavaScript</li>" +
                            "<li>TypeScript</li>" +
                            "<li>C#</li></ol>";
            return Content(html, "text/html");
        }

        [HttpGet("/skills/form")]
        public IActionResult Form()
        {
            string html = "<form method='post'>" +
                            "<label for='date'> Date: </label>" +
                            "<br>" +
                            "<input type='date' name='date'>" +
                            "<br>" +
                            "<label for='javascript'>JavaScript</label>" +
                            "<br>" +
                            "<select name='JavaScript'>" +
                            "<option value='noob'>Noob</option>" +
                            "<option value='master coder'>Intermediate</option>" +
                            "<option value='master coder'>Master</option>" +
                            "</select>" +
                            "<br>" +

                            "<br>" +
                            "<br>" +
                            "<label for='typescript'>TypeScript</label>" +
                            "<br>" +
                            "<select name='TypeScript'>" +
                            "<option value='noob'>Noob</option>" +
                            "<option value='master coder'>Intermediate</option>" +
                            "<option value='master coder'>Master</option>" +
                            "</select>" +
                            "<br>" +

                            "<br>" +
                            "<br>" +
                            "<label for='csharp'>C#</label>" +
                            "<br>" +
                            "<select name='Csharp'>" +
                            "<option value='noob'>Noob</option>" +
                            "<option value='master coder'>Intermediate</option>" +
                            "<option value='master coder'>Master</option>" +
                            "</select>" +
                            "<br>"+
                            "<input type='submit' value='submit' />"+
                            "</form>";
            return Content(html, "text/html");
        }

        [HttpPost("skills/form")]
        public IActionResult SkillFormPost(string date, string JavaScript, string TypeScript, string Csharp)
        {
            string html = $"<h1>Skills Tracker</h1>" +
                            $"{date}"+
                            "<h2>Coding Skills to Learn</h2>" +
                            $"<ol style='list-style: none'> <li>JS Skills Level: {JavaScript}</li>" +
                            $"<li>TypeScript Skills Level: {TypeScript}</li>" +
                            $"<li>C# Skill Level: {Csharp}</li></ol>"; ;
            return Content(html, "text/html");
        } 

    }
}
