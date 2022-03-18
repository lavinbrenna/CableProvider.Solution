using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CableProvider.Models;
using System.Linq;

namespace CableProvider.Controllers
{
  public class ShowsController : Controller
  {
    private readonly CableProviderContext _db;
    public ShowsController(CableProviderContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Shows.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.ChannelId = new SelectList(_db.Channels, "ChannelId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Show show, int ChannelId)
    {
      _db.Shows.Add(show);
      _db.SaveChanges();
      if(ChannelId != 0)
      {
        _db.ChannelShows.Add(new ChannelShow(){ChannelId = ChannelId, ShowId = show.ShowId});
        _db.SaveChanges();
      }
      return RedirectToAction("Index");

    }
    public ActionResult Details(int id)
    {
      Show thisShow = _db.Shows.FirstOrDefault(show => show.ShowId == id);
      return View(thisShow);
    }

    public ActionResult AddChannel(int id)
    {
      Show thisShow = _db.Shows.FirstOrDefault(show => show.ShowId == id);
      ViewBag.ChannelId = new SelectList(_db.Channels, "ChannelId", "Name");
      return View(thisShow);
    }

    [HttpPost]
    public ActionResult AddChannel(Show show, int ChannelId)
    {
      if(ChannelId != 0)
      {
        _db.ChannelShows.Add(new ChannelShow() {ChannelId = ChannelId, ShowId = show.ShowId });
        _db.SaveChanges();
      }
    return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisShow = _db.Shows.FirstOrDefault(show => show.ShowId == id);
      ViewBag.ChannelId = new SelectList(_db.Channels, "ChannelId", "Name");
      return View(thisShow);
    }

    [HttpPost]
    public ActionResult Edit(Show show, int ChannelId)
    {
      if (ChannelId != 0)
      {
        _db.ChannelShows.Add(new ChannelShow() { ChannelId = ChannelId, ShowId = show.ShowId });
      }
      _db.Entry(show).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
// create show show1 channel2
// channelshow1
// show1 channel5
// channelshow2

    //     [HttpPost]
    // public ActionResult AddCategory(Item item, int CategoryId)
    // {
    //   if (CategoryId != 0)
    //   {
    //     _db.CategoryItem.Add(new CategoryItem() { CategoryId = CategoryId, ItemId = item.ItemId });
    //     _db.SaveChanges();
    //   }
    //   return RedirectToAction("Index");
    // }



  }
}
