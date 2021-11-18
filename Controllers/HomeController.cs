
using System.Collections.Generic;

namespace DockerMySql.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var getDataFromDb = await _context.Persons
            .Include(x => x.Location)
            .ToListAsync();

        IEnumerable<PersonLocationViewModel> model = null;

        foreach (var item in getDataFromDb)
        {
            var loopModel = new PersonLocationViewModel
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                Age = item.Age,
                LocationName = item.Location.LocationName
            };
            model.Append(loopModel);
        }


        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}