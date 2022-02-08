using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserAppService _userApp;

        public UsersController(IUserAppService UserApp)
        {
            _userApp = UserApp;
        }

        public ActionResult Index()
        {
            var UserViewModel = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userApp.GetAll());
            return View(UserViewModel);
        }

        public ActionResult Especiais()
        {
            var UserViewModel = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userApp.ObterUsersEspeciais());

            return View(UserViewModel);
        }

        public ActionResult Details(int id)
        {
            var User = _userApp.GetById(id);
            var UserViewModel = Mapper.Map<User, UserViewModel>(User);

            return View(UserViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel User)
        {
            if (ModelState.IsValid)
            {
                var UserDomain = Mapper.Map<UserViewModel, User>(User);
                _userApp.Add(UserDomain);

                return RedirectToAction("Index");
            }

            return View(User);
        }

        public ActionResult Edit(int id)
        {
            var User = _userApp.GetById(id);
            var UserViewModel = Mapper.Map<User, UserViewModel>(User);

            return View(UserViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel User)
        {
            if (ModelState.IsValid)
            {
                var UserDomain = Mapper.Map<UserViewModel, User>(User);
                _userApp.Update(UserDomain);

                return RedirectToAction("Index");
            }

            return View(User);
        }

        public ActionResult Delete(int id)
        {
            var User = _userApp.GetById(id);
            var UserViewModel = Mapper.Map<User, UserViewModel>(User);

            return View(UserViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var User = _userApp.GetById(id);
            _userApp.Remove(User);

            return RedirectToAction("Index");
        }
    }
}