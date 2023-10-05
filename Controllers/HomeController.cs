using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Kyla Gaiser", StudentId = "21-2205", StudentAge = "20" },
            new StudentInfoModel { Name = "Nj Ferrer", StudentId = "21-2206", StudentAge = "22" },
            new StudentInfoModel { Name = "Trisha Labaco", StudentId = "21-2207", StudentAge = "21" },
            new StudentInfoModel { Name = "Kert Delos Santos", StudentId = "21-2208", StudentAge = "28" },
            new StudentInfoModel { Name = "Khel Camandona", StudentId = "21-2209", StudentAge = "22" }


        };

        return View(studentInfoArray);
    }
}
