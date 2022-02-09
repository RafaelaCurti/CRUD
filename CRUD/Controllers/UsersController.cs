using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Domain.Entities;
using Presentation.ViewModels;
using Application.Interface;

namespace Presentation.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserAppService _userApp;

        public UsersController(IUserAppService usereApp)
        {
            _userApp = usereApp;
        }

        public ActionResult Index()
        {
            var userViewModel = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userApp.GetAll());
            return View(userViewModel);
        }

        public ActionResult Details(int id)
        {
            var user = _userApp.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);

            return View(userViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDomain = Mapper.Map<UserViewModel, User>(user);
                _userApp.Add(userDomain);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult Edit(int id)
        {
            var user = _userApp.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);

            return View(userViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDomain = Mapper.Map<UserViewModel, User>(user);
                _userApp.Update(userDomain);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult Delete(int id)
        {
            var user = _userApp.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);

            return View(userViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var user = _userApp.GetById(id);
            _userApp.Remove(user);

            return RedirectToAction("Index");
        }
    }
}