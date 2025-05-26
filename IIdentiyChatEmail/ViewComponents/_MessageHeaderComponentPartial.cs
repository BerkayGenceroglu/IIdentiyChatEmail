using Microsoft.AspNetCore.Mvc;

namespace IIdentiyChatEmail.ViewComponents
{
    public class _MessageHeaderComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
