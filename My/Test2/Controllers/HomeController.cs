using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test2.Models;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            Debug.WriteLine("HomeController");

            /*
             * _Layout.cshtml
             * �Ҧ�view�@�ɦP�@Layout�A�B���i��W�s�b�A�ݨ̪��O��script
             * 
             * _partialView.cshtml
             * ����View�A�ݨ̪���L��View�~�����
             * */
        }

        /// <summary>
        /// Guest
        /// </summary>
        /// <returns></returns>
        public IActionResult IndexRWD()
        {
            return View(NightMarketData());
        }

        /// <summary>
        /// �]���D���
        /// </summary>
        List<NightMarket> NightMarketData()
        {
            string[] id = { "A01", "A02", "A03", "A04", "A05", "A06", "A07" };
            string[] name = { "���ש]��", "�sԳ���Ӱ�", "���X�]��", "�C�~�]��", "���]��", "�j�F�]��", "�Z�t�]��" };
            string[] address = { "813����������ϸθ۸�", "800�������s���ϥɿŨ�", "800�x�W�������s���Ϥ��X�G��",
                "80652�������e��ϳͱۥ|��758��", "�x�n���_�Ϯ��w���T�q533��", "�x�n���F�ϪL�˸��@�q276��",
                "�x�n������ϪZ�t��69��42��" };

            var NightMarketData = new List<NightMarket>();

            for (int a = 0; a < id.Length; a++)
            {
                NightMarketData.Add(new NightMarket(id[a], name[a], address[a]));
            }

            return NightMarketData;
        }

        public IActionResult Index()
        {
            Debug.WriteLine("Index");

            return View(NightMarketData());
        }

        /// <summary>
        /// �s�W���
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Razor()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IActionResult Details(string ID)
        {
            // Home/Details?ID=A01
            // Home/Details/A01

            var List = NightMarketData();

            //Linq�g�k
            //var Result = (from N in List where N.ID == ID select N).FirstOrDefault();

            //�@��For�j��
            //NightMarket Result = null;
            //for (int a = 0; a < List.Count; a++)
            //{
            //    if (List[a].ID == ID)
            //    {
            //        Result = List[a];
            //        break;
            //    }
            //}

            //Lambda�g�k1
            //var Result = List.Where(List => List.ID == ID).FirstOrDefault();

            //Lambda�g�k2 (List.Find)
            var Result = List.Find(N => N.ID == ID);

            return View(Result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IActionResult IndexList(string ID)
        {
            // Home/IndexList?ID=A01
            // Home/IndexList/A01

            var List = NightMarketData();

            VMNightMarket vmn = new VMNightMarket()
            {
                NightMarkets = List,
                NightMarket = List.Find(N => N.ID == ID)
            };

            return View(vmn);
        }
    }
}
