using MVc_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace MVc_2.Controllers
{
    public class HomeController : Controller
    {
        SnacksDB db = new SnacksDB();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Admin()
        {
            try
            {
                if (Session["Permission"].ToString() == "Admin")
                {

                    return View(db.Invoices.ToList());
                }
                else
                {
                    ViewBag.Message = "You are not Authorized to view this page";
                    return View("Index");
                }
            }
            catch (NullReferenceException)
            {
                ViewBag.MEssage = "Invalid Request";
                return View("Index");
            }
           
        }
        
        public ActionResult AddToInvoice()
        {
            db.Invoices.Add(new Invoice {
                Location = Session["Location"].ToString(),
                UserID   = Session["Username"].ToString(),
                InvoiceID= Session["InvoiceID"].ToString(),
                Name     = Session["Name"].ToString()
            });
            db.SaveChanges();
            ViewBag.Message = "Purchase Accepted";
            return View("Index");
        }
        
        public ActionResult Cart()
        {
            if (Session["Username"] == null)
            {
                ViewBag.Message = "You need to log in to see fruits in your cart.";
                return View("Index");
            }
            else
            {
                Session["InvoiceID"] = Session["Username"] + DateTime.Now.Day.ToString();
                ViewBag.Message = "Invoice Number : " + Session["InvoiceID"].ToString();
                
                List<SnackList> lists = new List<SnackList>();
                
                foreach (var item in db.SnackLists.ToList())
                {
                    if (item.AccountID == Session["Username"].ToString())
                    {
                        lists.Add(item);
                    }
                }
                return View(lists);
                
            }
        }

        public ActionResult Delete(int? id)
        {
            try
            {
                if (db.SnackLists.Find(id) != null)
                {
                    SnackList snackList = db.SnackLists.Find(id);
                    db.SnackLists.Remove(snackList);
                    db.SaveChanges();
                    ViewBag.Message = "Item Deleted";
                    return RedirectToAction("Cart");
                }
                else
                {
                    ViewBag.Message = "Item Not Deleted.";
                }

            } catch (Exception) { 
                throw; }


            return View("Cart");
        }
        
        public ActionResult AddToCart(int? ID,string Name, int? Price)
        {
            ViewBag.Message = ID;
            if (Session["Username"] == null)
            {
                ViewBag.Message = "You need to log in to add fruits to your cart.";
                return View("Index");
            }
            else
            {
               
                try
                {
                    db.SnackLists.Add(new SnackList
                    {
                        AccountID = Session["Username"].ToString(),
                        SnackID = ID.ToString(),
                        InvoiceID = Session["InvoiceID"].ToString(),
                        name = Name,
                        price = Price                    
                    });
                    db.SaveChanges();
                    ViewBag.Message = "Your item has been added to the cart.";

                    return View("Index");

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password,string location,string name)
        {
            try
            {
                if (Username == null || Password == null || location == null || name == null)
                {

                    ViewBag.Message = "All the information is required.";
                    return View("Login");
                }
                else
                {
                    SnacksDB User = new SnacksDB();
                    Account account = User.Accounts.Find(Convert.ToInt32(Username));
                    if (account != null)
                    {
                        Session["Location"] = location;
                        Session["Name"] = name;
                        Session["Username"] = account.ID;
                        Session["Permission"] = account.Permissions;
                        Session["InvoiceID"] = Session["Username"] + DateTime.Now.ToString();
                        ViewBag.Message = "Logged in " + Session["Name"] + " " + Session["Permission"];
                        return View("Index");
                    }
                    else
                    {
                        ViewBag.Message = "User does not exsist.";
                        return View("Login");
                    }
                }
            }
            catch (FormatException)
            {
                ViewBag.Message = "Invalid Data entry";
                return View("Login");
            }
            catch (Exception)
            {
                throw;
            }
          
        }
    }
}