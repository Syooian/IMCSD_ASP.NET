using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyModel_DBFirst.Models;

namespace MyModel_DBFirst.Controllers
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


//MyModel_DBFirst�M�׶i��B�J

//1.�ϥ�DB First�إ� Model

//1.1 �bSSMS������dbStudents.sql�{���X�A�إ߽d�Ҹ�ƮwdbStudents�A���t�@��tStudent��ƪ�

//1.2 �إ߱M�׻P��Ʈw���s�u
//1.2.1 �ϥ�NuGet(�M�צW�٤W���k����޲zNuGet�M��)�w�ˤU�C�M��
//      (1) Microsoft.EntityFrameworkCore.SqlServer
//      (2) Microsoft.EntityFrameworkCore.Tools

//1.2.2 ��SSMS�]�w�n�JSQL Server���ϥΪ�(�������ճs�u���\)

//1.2.3 ��M��޲z���D���x(�˵� > ��L���� > �M��޲z���D���x)�U���O
//      Scaffold-DbContext "Data Source=���A����};Database=��Ʈw�W��;TrustServerCertificate=True;User ID=�b��;Password=�K�X" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -NoOnConfiguring -UseDatabaseNames -NoPluralize -Force
//      �Y���\���ܡA�|�ݨ�Build succeeded.�r���A�æbModels��Ƨ��̬ݨ�dbStudentsContext.cs(�y�z��Ʈw)��tStudent.cs(�y�z��ƪ�)

//1.2.4 �bdbStudentsContext.cs�̼��g�s�u���Ʈw���{��
//      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//              => optionsBuilder.UseSqlServer("Data Source=���A����};Database=��Ʈw�W��;TrustServerCertificate=True;User ID=�b��;Password=�K�X");

//1.2.5 �bdbStudentsContext.cs�̼��g�@�ӪŪ��غc�l
//      public dbStudentsContext()
//      {
//      }
///////////////////////////////////////////////////////