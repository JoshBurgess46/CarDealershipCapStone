using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CarCapstoneAPIMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCapstoneAPIMVC.Controllers
{
    public class CarInformationController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327");

            var response = await client.GetAsync("api/car");
            var result = await response.Content.ReadAsAsync<List<CarInfo>>();

            return View(result);
        }

        public async Task<IActionResult> GetCarById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327");

            var response = await client.GetAsync("api/car");
            var result = await response.Content.ReadAsAsync<CarInfo>();
            return View(result);
        }

        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCarAsync(CarInfo car)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327");

            var postCar = await client.PostAsJsonAsync<CarInfo>("api/car", car);
            if (postCar.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "This did not work");
            return View(car);
        }

        public async Task<IActionResult> EditCar(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327");

            var response = await client.GetAsync($"api/car/{id}");
            var result = await response.Content.ReadAsAsync<CarInfo>();

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> EditCar(CarInfo car)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327");

            var putCar = await client.PutAsJsonAsync<CarInfo>($"api/car/{car.id}", car);
            if (putCar.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditCar", car.id);
        }

        public async Task<IActionResult> DeleteCar(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327");

            var deleteCar = await client.DeleteAsync($"api/car/{id}");
            return RedirectToAction("Index");
        }
    }
}