using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Bll.Concreate;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.MvcUi.Helpers.CsharpHelpers;
namespace DellaViaAutomation.MvcUi.Areas.Admin.Controllers
{
    public class UsersController : AdminControllerBase
    {

        // GET: Admin/Users
        public async Task<ActionResult> Index()
        {
            List<User> users = await ApiCenter<List<User>>.GetAsync("Users") as List<User>;
            ViewBag.usersimages = Functions.GetFiles(Server.MapPath("~/Uploads/Photos/users"));
            return View(users);
        }

        // GET: Admin/Users/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = await ApiCenter<User>.GetAsync("Users/" + id) as User;
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Admin/Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user, HttpPostedFileBase uploadFile)
        {
            if (ModelState.IsValid)
            {
                var originalFilename = Path.GetFileName(uploadFile.FileName);
                var Extension = Path.GetExtension(uploadFile.FileName);
                string fileId = Guid.NewGuid().ToString().Replace("-", "");

                System.IO.Directory.CreateDirectory(Server.MapPath("~/Uploads/Photos/users/system"));
                var path = Path.Combine(Server.MapPath("~/Uploads/Photos/users/system"), fileId) + Extension;
                uploadFile.SaveAs(path);

                user.ImageId = fileId;
                user.OriginalFilename = originalFilename;

                await ApiCenter<User>.CreateAsync(user, "Users");
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Admin/Users/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = await ApiCenter<User>.GetAsync("Users/" + id) as User;
            if (user == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(user.OriginalFilename))
                {
                    ViewBag.img = Helpers.CsharpHelpers.Functions.GetFile(Server.MapPath("~/Uploads/Photos/users"),user.ImageId);
                }
            }
            TempData["editusertemp"] = user;
            return View(user);
        }

        // POST: Admin/Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(User user, HttpPostedFileBase uploadFile)
        {
            if (ModelState.IsValid)
            {
                if (uploadFile != null)
                {
                    var originalFilename = Path.GetFileName(uploadFile.FileName);
                    var Extension = Path.GetExtension(uploadFile.FileName);
                    string fileId = Guid.NewGuid().ToString().Replace("-", "");

                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Uploads/Photos/users/system"));
                    var path = Path.Combine(Server.MapPath("~/Uploads/Photos/users/system"), fileId) + Extension;
                    uploadFile.SaveAs(path);

                    user.ImageId = fileId;
                    user.OriginalFilename = originalFilename;
                }
                else
                {
                    user.ImageId = (TempData["editusertemp"] as User).ImageId;
                    user.OriginalFilename = (TempData["editusertemp"] as User).OriginalFilename;
                    TempData.Keep();
                }
                user.UpdateDate = DateTime.Now;
                user.UpdateUserid = loginUser.id;
                await ApiCenter<User>.UpdateAsync(user, "Users");
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Admin/Users/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = await ApiCenter<User>.GetAsync("Users/" + id) as User;
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            User user = await ApiCenter<User>.GetAsync("Users/" + id) as User;
            await ApiCenter<User>.DeleteAsync(id.ToString(), "Users");
            return RedirectToAction("Index");
        }
    }
}
