using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using IIdentiyChatEmail.Entities;
using IIdentiyChatEmail.Context;
using IIdentiyChatEmail.Models;

namespace IIdentiyChatEmail.ViewComponents
{
    public class _MessageContentBodyComponentPartial : ViewComponent
    {
        private readonly ContextEmail _context;
        private readonly UserManager<AppUser> _userManager;

        public _MessageContentBodyComponentPartial(ContextEmail context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            var model = new MessageViewModel
            {
                ReceiveMessage = _context.messages.Count(x => x.ReceiverMail == user.Email && x.Isread == true),
                SendMessage = _context.messages.Count(x => x.SenderMail == user.Email && x.Isread == true),
                DeleteMessage = _context.messages.Count(x => x.Isread == false && (x.ReceiverMail == user.Email || x.SenderMail == user.Email))
            };

            return View(model);
        }
    }
}
