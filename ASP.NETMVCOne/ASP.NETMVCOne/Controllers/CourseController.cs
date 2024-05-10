using ASP.NETMVCOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETMVCOne.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<CourseModel> showCourse()
        {

            List<CourseModel> courseModels = new List<CourseModel>();

            CourseModel course = new CourseModel { 
             courseId=1,
             courseName="java",
             courseprice=123
            };
            CourseModel course2 = new CourseModel
            {
                courseId = 1,
                courseName = "java",
                courseprice = 123
            };

            courseModels.Add(course);
            courseModels.Add(course2);
            return courseModels;

            
        }

        public ViewResult ShowCourse()
        {
            List<CourseModel> moib = showCourse();
            return View(moib);
        }
    }
}
