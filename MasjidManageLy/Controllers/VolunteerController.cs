using MasjidManageLyModel.Entities;
using MasjidManageLyService.InterfaceService;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManageLy.Controllers
{
	public class VolunteerController : Controller
	{
		private readonly IVolunteerService _VolunteerService;

		public VolunteerController(IVolunteerService VolunteerService)
		{
			_VolunteerService = VolunteerService;
		}

		public async Task<IActionResult> Index()
		{
			var books = await _VolunteerService.GetAllVolunAsync();
			return View(books);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Volunteer volunteer)
		{
			await _VolunteerService.AddAsync(volunteer);

			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Delete(int id)
		{
			await _VolunteerService.DeleteAsync(id);

			return RedirectToAction("Index");

		}

		public async Task<IActionResult> Update(int id)
		{
			var volunteer = await _VolunteerService.GetByIdAsync(id);
			return View(volunteer);
		}
		[HttpPost]
		public async Task<IActionResult> Update(Volunteer volunteer)
		{
			if (volunteer.Id > 0)
			{
				await _VolunteerService.UpdateAsync(volunteer);
			}

			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Details(int id)
		{
			var volunteer = await _VolunteerService.GetByIdAsync(id);
			return View(volunteer);
		}

	}
}
