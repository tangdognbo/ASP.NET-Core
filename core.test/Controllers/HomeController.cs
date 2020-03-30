using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core.test.Models;

namespace core.test.Controllers
{
    public class HomeController : Controller
    {

        private readonly Context _contest;
        //定义一个委托
       // public delegate void Collecthomework();

        public HomeController(Context contest)
        {
            _contest = contest;
        }

        public IActionResult Index()
        {
            //int kk = 0;
            //int fdfd = 10 / kk;
            //Singleton sdfsd = new Singleton();


            var ser=  _contest.SysUser.ToList();

            //_contest.SysUser.AddAsync(); 


            Logger.Info("11111111111111");
            return View();
        }

        public IActionResult About()
        {
            //Singleton sdfsd =  Singleton.CreateInstance();

            //delegate1.SayChinese("ta");

            //delegate1.SayAll("1", delegate1.SayChinese);

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }

    //public class LazySingleton
    //{
    //    private static volatile LazySingleton instance = null;    //保证 instance 在所有线程中同步
    //    private LazySingleton() { }    //private 避免类在外部被实例化
    //    public static  LazySingleton getInstance()
    //    {
    //        //getInstance 方法前加同步
    //        if (instance == null)
    //        {
    //            instance = new LazySingleton();
    //        }
    //        return instance;
    //    }
    //}
    //public class HungrySingleton
    //{
    //    private static final HungrySingleton instance=new HungrySingleton();
    //    private HungrySingleton() { }
    //    public static HungrySingleton getInstance()
    //    {
    //        return instance;
    //    }
    //}



}
