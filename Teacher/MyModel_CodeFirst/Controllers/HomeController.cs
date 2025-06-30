using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyModel_CodeFirst.Models;

namespace MyModel_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


//MyModel_CodeFirst�M�׶i��B�J

//1. �ϥ�Code First�إ�Model�θ�Ʈw

//1.1   �bModels��Ƨ��̫إ�Book��ReBook������O�����ҫ�
//1.1.1 �bModels��Ƨ��W���k����[�J�����O�A�ɦW���W��Book.cs�A���U�u�s�W�v�s
//1.1.2 �]�pBook���O���U�ݩʡA�]�A�W�١B��������Ψ���������ҳW�h����ܦW��(Display)
//1.1.3 �bModels��Ƨ��W���k����[�J�����O�A�ɦW���W��ReBook.cs�A���U�u�s�W�v�s
//1.1.4 �]�pReBook���O���U�ݩʡA�]�A�W�١B��������Ψ���������ҳW�h����ܦW��(Display)
//1.1.5 ���g������O�������p�ݩʰ������Ӹ�ƪ��������p
//1.1.6 �إ�MeataData���O�A��Book��ReBook���O���ۤv�ҲK�[���{���X���Ӧ�MetaData���O��
//1.1.7 �ϥ�Partial Class���S�ʡA�NMeataData���O�е��������Book��ReBook���O�W
//���Q��MeataData���O�i�H�B��Partial Class���S�ʡA�N�쥻�y�N�b��class�����{���X�����X�ӡA�F����n���{���[�c�A�ϭ�Ӫ��{���X�O����l���A��
//���o�ӹ�@�ޥ��bDBFirst���׬����n�A�]���u�n���s����DBFirst�A�N�|���Ӫ��ҫ����e�л\���A�Ӽg�b�ҫ����O�����W�h�N�������s���g��
