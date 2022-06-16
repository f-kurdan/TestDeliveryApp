﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDeliveryApp.Data;
using TestDeliveryApp.Models;

namespace TestDeliveryApp.Controllers
{
    public class PanelController : Controller
    {
        private readonly AppDbContext _context;

        public PanelController(AppDbContext context)
        {
            _context = context;
        }
        // GET: PanelController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: PanelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PanelController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: PanelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Order order)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var vm = new OrderViewModel
            {
                OrderID = order.ID,
                SenderCity = order.SenderCity,
                SenderAdress = order.SenderAdress,
                RecipientCity = order.RecipientCity,
                RecipientAdress = order.RecipientAdress,
                CargoWeight = order.CargoWeight,
                CargoPickUpDate = order.CargoPickUpDate,
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            try
            {
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: PanelController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var order = await _context.Orders.FirstOrDefaultAsync(x => x.ID == id);

            if (order == null)
                return NotFound();

            var vm = new OrderViewModel
            {
                OrderID=order.ID,
                SenderCity =order.SenderCity,
                SenderAdress = order.SenderAdress,
                RecipientCity = order.RecipientCity,
                RecipientAdress = order.RecipientAdress,
                CargoWeight = order.CargoWeight,
                CargoPickUpDate = order.CargoPickUpDate
            };

            return View(vm);
        }

        // POST: PanelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(OrderViewModel vm)
        {
            var order = new Order
            {
                ID = vm.OrderID,
                SenderCity = vm.SenderCity,
                SenderAdress = vm.SenderAdress,
                RecipientCity =vm.RecipientCity,
                RecipientAdress = vm.RecipientAdress,
                CargoWeight = vm.CargoWeight,
                CargoPickUpDate = vm.CargoPickUpDate
            };

            _context.Update(order);
            await _context.SaveChangesAsync();

            try
            {
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: PanelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PanelController/Delete/5
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
