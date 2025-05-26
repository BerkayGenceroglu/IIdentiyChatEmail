using Microsoft.AspNetCore.Mvc;

namespace IIdentiyChatEmail.ViewComponents
{
    public class _MessageHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
