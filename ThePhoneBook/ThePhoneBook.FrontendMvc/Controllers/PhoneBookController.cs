using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThePhoneBook.FrontendMvc.Features;
using ThePhoneBook.FrontendMvc.Mappers;
using ThePhoneBook.FrontendMvc.Models;

namespace ThePhoneBook.FrontendMvc.Controllers
{
    public class PhoneBookController : Controller
    {
        private readonly IFetchContactsQueryFeature _fetchContactsFeature;
        private readonly ICustomMapper<ContactDto, VmContact> _customMapper;

        public PhoneBookController(IFetchContactsQueryFeature fetchContactsFeature, ICustomMapper<ContactDto, VmContact> customMapper)
        {
            _fetchContactsFeature = fetchContactsFeature;
            _customMapper = customMapper;
        }

        // GET: PhoneBook
        public ActionResult Index()
        {
            var contacts = _fetchContactsFeature.Execute();
            var viewModel = new VmDashboard
            {
                Contacts = _customMapper.Map(contacts)
            };

            return View(viewModel);
        }

        // GET: PhoneBook/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhoneBook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhoneBook/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhoneBook/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBook/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhoneBook/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
