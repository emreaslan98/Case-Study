using Microsoft.AspNetCore.Mvc;
using Project.Entity;
using Project.UI.Models;
using Project.Uow;
using ProjectUI.Helpers;

namespace Project.UI.Controllers
{
    public class PersonelController : Controller
    {
        PersonelModel _model;
        private readonly IUow _uow;
        public PersonelController(IUow uow, PersonelModel model)
        {
            _uow = uow;
            _model = model;
        }

        public IActionResult List()
        {
            return View(_uow._personelRep.List());
        }
        [HttpGet]
        public IActionResult Create()
        {
            _model.Text = "Create";
            _model.Head = "New Personel";
            _model.Class = "btn btn-primary";
            _model.Personel = new Personel();
            _model.Universities = UniversityHelper.GetUniversities();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(PersonelModel m)
        {
            _uow._personelRep.Add(m.Personel);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int Id)
        {
            _model.Text = "Update";
            _model.Head = "Update Personel";
            _model.Class = "btn btn-success";
            _model.Personel = _uow._personelRep.Find(Id);
            _model.Universities = UniversityHelper.GetUniversities();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(PersonelModel m)
        {
            _uow._personelRep.Update(m.Personel);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            _model.Text = "Delete";
            _model.Head = "Delete Personel";
            _model.Class = "btn btn-danger";
            _model.Personel = _uow._personelRep.Find(Id);
            _model.Universities = UniversityHelper.GetUniversities();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(PersonelModel m)
        {

            _uow._personelRep.Delete(m.Personel);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
