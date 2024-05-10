using ASP.NETMVCOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETMVCOne.Controllers
{
    public class MobileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      public List<MobileModal> MobileList()
        {
            List<MobileModal> mobileModals = new List<MobileModal>();
            MobileModal mobileModal = new MobileModal { 
            
                mobileId = 1,
                mobileName="vivo",
                mobileprice=1232,
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
            List <MobileModal> moib = MobileList();
            ViewBag.MobileOne= moib;
            return View();

        }


    }
}
