using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CableProvider.Models
{
  public class ChannelsController : Controller
  {
    private readonly CableProviderContext _db;

    public ChannelsController( CableProviderContext db )
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Channel> model = _db.Channels.ToList();
      return View(model);
    }

    
  }

}