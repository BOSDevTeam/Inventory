using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory.Models;
using Inventory.Common;

namespace Inventory.Controllers
{
    public class TownshipController : MyController
    {
        InventoryDBEntities Entities = new InventoryDBEntities();
        TownshipModels.TownshipModel model = new TownshipModels.TownshipModel();
        static List<TownshipModels.TownshipModel> lstTownshipList = new List<TownshipModels.TownshipModel>();
        static int editTownshipID;

        public ActionResult TownshipEntry(int townshipId)
        {
            if (townshipId != 0)
            {
                Session["IsEdit"] = 1;
                editTownshipID = townshipId;
                var editTownship = lstTownshipList.Where(c => c.TownshipID == townshipId);
                foreach (var e in editTownship)
                {
                    Session["EditTownshipName"] = e.TownshipName;
                    Session["EditCode"] = e.Code;
                    break;
                }
            }
            else
            {
                Session["IsEdit"] = 0;
            }
            return View(model);
        }

        public ActionResult TownshipList()
        {
            TownshipModels.TownshipModel townshipModel = new TownshipModels.TownshipModel();
            model.LstTownship = new List<TownshipModels.TownshipModel>();
            lstTownshipList = new List<TownshipModels.TownshipModel>();

            foreach (var town in Entities.S_Township.OrderBy(m => m.Code))
            {
                townshipModel = new TownshipModels.TownshipModel();
                townshipModel.TownshipID = town.TownshipID;
                townshipModel.TownshipName = town.TownshipName;
                townshipModel.Code = town.Code;
                townshipModel.IsDefault = town.IsDefault;

                model.LstTownship.Add(townshipModel);
                lstTownshipList.Add(townshipModel);
            }

            return View(model);
        }

        [HttpGet]
        public JsonResult SaveAction(string townshipName, string code)
        {
            string message;
            int saveOk;
            var towns = (from town in Entities.S_Township where town.Code == code select town).ToList();
            if (towns.Count() == 0)
            {
                Entities.PrcInsertTownship(townshipName, code);
                message = "Saved Successfully!";
                saveOk = 1;
            }
            else
            {
                message = "Code Duplicate!";
                saveOk = 0;
            }

            var Result = new
            {
                MESSAGE = message,
                SAVEOK = saveOk
            };
            return Json(Result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult EditAction(string townshipName, string code)
        {
            string message;
            int editOk;
            var towns = (from town in Entities.S_Township where town.Code == code where town.TownshipID != editTownshipID select town).ToList();
            if (towns.Count() == 0)
            {
                Entities.PrcUpdateTownship(editTownshipID, townshipName, code);
                message = "Edited Successfully!";
                editOk = 1;
            }
            else
            {
                message = "Code Duplicate!";
                editOk = 0;
            }

            var Result = new
            {
                MESSAGE = message,
                EDITOK = editOk
            };

            return Json(Result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult SearchAction(string keyword)
        {
            TownshipModels.TownshipModel townshipModel = new TownshipModels.TownshipModel();
            model.LstTownship = new List<TownshipModels.TownshipModel>();
            lstTownshipList = new List<TownshipModels.TownshipModel>();

            foreach (var town in Entities.PrcSearchTownship(keyword))
            {
                townshipModel = new TownshipModels.TownshipModel();
                townshipModel.TownshipID = town.TownshipID;
                townshipModel.TownshipName = town.TownshipName;
                townshipModel.Code = town.Code;
                townshipModel.IsDefault = town.IsDefault;

                model.LstTownship.Add(townshipModel);
                lstTownshipList.Add(townshipModel);
            }

            return Json(model.LstTownship, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult DeleteAction(int townshipId)
        {
            S_Township town = Entities.S_Township.Where(x => x.TownshipID == townshipId).Single<S_Township>();
            Entities.S_Township.Remove(town);
            Entities.SaveChanges();

            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}