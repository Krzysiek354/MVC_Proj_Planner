using Microsoft.AspNetCore.Mvc;
using Projekt_MVC.Models;
using System.Diagnostics;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Projekt_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DB_Context contextt;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            contextt = new DB_Context();
        }

        public IActionResult Index()
        {
            

            var joinedData = from person in contextt.Persons
                             join school in contextt.Schools on person.Id equals school.IdKid
                             select new { Person = person, School = school };

            var joinedData_enjoy = from person in contextt.Persons
                             join enjoy in contextt.Enjoys on person.Id equals enjoy.IdKid
                             select new { Person = person, Enjoy = enjoy };

            var joinedData_shop = from person in contextt.Persons
                                   join shop in contextt.Shops on person.Id equals shop.IdKid
                                   select new { Person = person, Shop = shop };


            var joinedData_work = from person in contextt.Persons
                                  join work in contextt.Works on person.Id equals work.IdKid
                                  select new { Person = person, Work = work };

            var joinedData_mess = from person in contextt.Persons
                                  join mess in contextt.Messages on person.Id equals mess.IdKid
                                  select new { Person = person, Message = mess };


            ViewBag.data = joinedData.ToList();
            ViewBag.data1 = joinedData_enjoy.ToList();
            ViewBag.data2 = joinedData_shop.ToList();
            ViewBag.data3 = joinedData_work.ToList();
            ViewBag.data4 = joinedData_mess.ToList();
            return View();
        }

        [Route("~/Home/Person_Add")]
        public IActionResult Person_Add()
        {
            return View();
        }

        [HttpPost]
        [Route("~/Home/Person_Add")]
        public IActionResult Person_Add(Person p)
        {
            contextt.Add<Person>(p);
            contextt.SaveChanges();
            return View();
        }


        [HttpGet]
        [Route("~/Home/Housers")]

        public IActionResult Housers()
        {
            ViewBag.pers = contextt.Persons.ToList();
            return View("Housers");
        }

        [HttpPost]
        [Route("~/Home/Person_Delete")]

        public IActionResult Person_Delete(Person del)
        {
            var item = contextt.Persons.FirstOrDefault(x => x.Id == del.Id);
            contextt.Persons.Remove(item);
            contextt.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("~/Home/School_Add")]
        public IActionResult School_Add()
        {
            return View();
        }

        [HttpPost]
        [Route("~/Home/School_Add")]
        public IActionResult School_add(string name, School schooll)
        {
            try
            {


                var per = contextt.Persons.FirstOrDefault(x => x.Name == name);

                var sch = new School() { Homework = schooll.Homework, IdKid = per.Id, When = schooll.When };

                contextt.Add<School>(sch);
                contextt.SaveChanges();

                return View();
            }

            catch
            {
                return View();
            }
        }

        [HttpPost]
        [Route("~/Home/School_Delete")]

        public IActionResult School_Delete(School del)
        {
            var item = contextt.Schools.FirstOrDefault(x=>x.Id==del.Id);
            contextt.Schools.Remove(item);
            contextt.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("~/Home/Enjoy_Add")]
        public IActionResult Enjoy_Add()
        {
            return View();
        }

        [HttpPost]
        [Route("~/Home/Enjoy_Add")]
        public IActionResult Enjoy_add(string name, Enjoy enjoy)
        {
            try
            {
                var en = contextt.Persons.FirstOrDefault(x => x.Name == name);

                var sch = new Enjoy() { Idea = enjoy.Idea, IdKid = en.Id, When = enjoy.When };
                contextt.Add<Enjoy>(sch);
                contextt.SaveChanges();

                return View();
            }


            catch
            {

                return View();
            }
        }

        [HttpPost]
        [Route("~/Home/Enjoy_Delete")]

        public IActionResult Enjoy_Delete(Enjoy del)
        {
            var item = contextt.Enjoy.FirstOrDefault(x => x.Id == del.Id);
            contextt.Enjoys.Remove(item);
            contextt.SaveChanges();
            return RedirectToAction("Index");
        }


        [Route("~/Home/Shop_Add")]
        public IActionResult Shop_Add()
        {
            return View();
        }

        [HttpPost]
        [Route("~/Home/Shop_Add")]
        public IActionResult Shop_add(string name, Shop sh)
        {
            try
            {
                var en = contextt.Persons.FirstOrDefault(x => x.Name == name);

                var sch = new Shop() { Thing = sh.Thing, Count = sh.Count, IdKid = en.Id };


                contextt.Add<Shop>(sch);
                contextt.SaveChanges();
                return View();
            }

            catch
            {
                return View();
            }
            
        }


        [HttpPost]
        [Route("~/Home/Shop_Delete")]

        public IActionResult Shop_Delete(Shop del)
        {
            var item = contextt.Shops.FirstOrDefault(x => x.Id == del.Id);
            contextt.Shops.Remove(item);
            contextt.SaveChanges();
            return View();
        }

        [Route("~/Home/Work_Add")]
        public IActionResult Work_Add()
        {
            return View();
        }

        [HttpPost]
        [Route("~/Home/Work_Add")]
        public IActionResult Work_add(string name, Work sh)
        {
            try
            {
                var en = contextt.Persons.FirstOrDefault(x => x.Name == name);

                var sch = new Work() { Task=sh.Task, When = sh.When ,IdKid = en.Id };


                contextt.Add<Work>(sch);
                contextt.SaveChanges();
                return View();
            }

            catch
            {
                return View();
            }

        }

        [Route("~/Home/Message_Add")]
        public IActionResult Message_Add()
        {
            return View();
        }

        [HttpPost]
        [Route("~/Home/Message_Add")]
        public IActionResult Message_add(string name, Message sh)
        {
            try
            {
                var en = contextt.Persons.FirstOrDefault(x => x.Name == name);

                var sch = new Message() { Messag = sh.Messag,IdKid = en.Id };


                contextt.Add<Message>(sch);
                contextt.SaveChanges();
                return View();
            }

            catch
            {
                return View();
            }

        }

        [HttpPost]
        [Route("~/Home/Message_Delete")]

        public IActionResult Message_Delete(Message del)
        {
            var item = contextt.Messages.FirstOrDefault(x => x.Id == del.Id);
            contextt.Messages.Remove(item);
            contextt.SaveChanges();
            return RedirectToAction("Index");
        }




        [HttpPost]
        [Route("~/Home/Work_Delete")]

        public IActionResult Work_Delete(Work del)
        {
            var item = contextt.Works.FirstOrDefault(x => x.Id == del.Id);
            contextt.Works.Remove(item);
            contextt.SaveChanges();
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}