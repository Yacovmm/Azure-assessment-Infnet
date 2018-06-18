using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using Web.Models.Dto;

namespace Web.Controllers
{
    public class AmigoController : Controller
    {

        HttpClient client = new HttpClient();

        public AmigoController()
        {
            client.BaseAddress = new Uri("http://localhost:56895");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));           
        }

        // GET: Amigo
        public ActionResult Index()
        {
            List<AmigoDto> amigos = new List<AmigoDto>();
            HttpResponseMessage response = client.GetAsync("/api/Amigos").Result;
            if (response.IsSuccessStatusCode)
                amigos = response.Content.ReadAsAsync<List<AmigoDto>>().Result;

            return View(amigos);
        }

        // GET: Amigo/Details/5
        public ActionResult Details(int id)
        {
            HttpResponseMessage response = client.GetAsync($"/api/amigos/{id}").Result;
            AmigoDto amigo = response.Content.ReadAsAsync<AmigoDto>().Result;
            if (amigo != null)
                return View(amigo);

            return HttpNotFound();
        }

        // GET: Amigo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Amigo/Create
        [HttpPost]
        public ActionResult Create(AmigoDto amigoDto)
        {
            try
            {
                HttpResponseMessage response = client.PostAsJsonAsync<AmigoDto>("/api/amigos", amigoDto).Result;
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Error while creating";
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Amigo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Amigo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Amigo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Amigo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
