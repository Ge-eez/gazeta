using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Companies.Models;
using Microsoft.AspNetCore.Authorization;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace Companies.Controllers
{
    
    public class CompanyController : Controller
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NiJHs8XNpBu49aNEs7cJa1xP6kZL4LyqRsQHoo0E",
            BasePath = "https://digitalgazeta-29045-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegisterCompany()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterCompany(Company company)
        {
            try
            {                
                AddCompanyToFirebase(company);
                ModelState.AddModelError(string.Empty,"Added successfully");
            }
            catch (System.Exception ex)
            {                
                ModelState.AddModelError(string.Empty,ex.Message);
                
            }
            return View();
        }

        private void AddCompanyToFirebase(Company company)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = company;
            PushResponse response = client.Push("Companies/",data);
            data.company_id = response.Result.name;
            SetResponse setResponse = client.Set("Companies/"+data.company_id, data);
        }
    }
}