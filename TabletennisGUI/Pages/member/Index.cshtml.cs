using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tabletennisLib.model;

namespace TabletennisGUI.Pages.member
{
    public class IndexModel : PageModel
    {
        private MemberRegister _register;

        public IndexModel(MemberRegister register)
        {
            _register = register;
        }


        // poroperty
        public MemberRegister Register
        {
            get { return _register; }
            set { _register = value; }
        }


        public void OnGet()
        {
        }
    }
}
