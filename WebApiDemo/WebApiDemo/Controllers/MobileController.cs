using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {


        private List<MobileModel> MobileList()
        {
            List<MobileModel> mobileModals = new List<MobileModel>();
            MobileModel mobileModal = new MobileModel
            {

                mobileId = 1,
                mobileName = "vivo",
                mobileprice = 1232,
            };
            MobileModel mobileModal2 = new MobileModel
            {

                mobileId = 2,
                mobileName = "m1",
                mobileprice = 123332,
            };
            mobileModals.Add(mobileModal);
            mobileModals.Add(mobileModal2);

            return mobileModals;

        }

        [HttpGet("/displaymobiles")]
        public IEnumerable<MobileModel> Get()
        {
        return MobileList();

        }







    }
}
