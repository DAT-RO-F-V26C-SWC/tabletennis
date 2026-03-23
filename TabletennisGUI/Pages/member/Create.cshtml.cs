using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tabletennisLib.model;

namespace TabletennisGUI.Pages.member
{
    public class CreateModel : PageModel
    {
        private MemberRegister _register;

        public CreateModel(MemberRegister register)
        {
            _register = register;
        }

        public MemberRegister Register
        {
            get { return _register; }
            set { _register = value; }
        }


        /*
         * Til det nye medlem
         */
        private int _memberNo;
        private string _name;
        private string _phone;
        private int _yearOfBirth;

        [BindProperty]
        public int MemberNo
        {
            get { return _memberNo; }
            set { _memberNo = value; }
        }
        [BindProperty]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [BindProperty]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        [BindProperty]
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value; }
        }



        public void OnGet()
        {
        }

        public IActionResult OnPostOK()
        {
            Member newMember = new Member(MemberNo, Name, Phone, YearOfBirth);  
            _register.AddMember(newMember);

            return RedirectToPage("/member/Index");
        }
        public IActionResult OnPostCancel()
        {
            return RedirectToPage("/member/Index");
        }
    }
}
