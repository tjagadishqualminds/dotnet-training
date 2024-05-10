using ASP.NETMVCOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETMVCOne.Controllers
{
    public class TwoMethodController : Controller
    {
        public List<MobileModal> MobileList()
        {
            List<MobileModal> mobileModals = new List<MobileModal>();
            MobileModal mobileModal = new MobileModal
            {

                mobileId = 1,
                mobileName = "vivo",
                mobileprice = 1232,
            };
            MobileModal mobileModal2 = new MobileModal
            {

                mobileId = 2,
                mobileName = "m1",
                mobileprice = 123332,
            };
            mobileModals.Add(mobileModal);
            mobileModals.Add(mobileModal2);

            return mobileModals;

        }

        public ViewResult ShowMobile()
        {
            List<MobileModal> moib = MobileList();
            return View(moib);
        }

        public ViewResult DisplayMobile()
        {
            List<MobileModal> moib = MobileList();
            ViewBag.MobileOne = moib;
            return View();

        }

        public ViewResult DisplayMobileCourse()
        {
            List <MobileModal> moib = MobileList();
            List<CourseModel> course = showCourse();

            CommanClass commanClass = new CommanClass
            {
             
                
                courselist=course,
                mobilelist=moib,

            };
            

            return View(commanClass);
        }
        public List<CourseModel> showCourse()
        {

            List<CourseModel> courseModels = new List<CourseModel>();

            CourseModel course = new CourseModel
            {
                courseId = 1,
                courseName = "java",
                courseprice = 123
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
