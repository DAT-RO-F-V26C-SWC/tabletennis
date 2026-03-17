using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace tabletennisLib.model
{
    public class Member
    {
        // instans felter
        private int _memberNo;
        private string _name;
        private string _phone;
        private int _yearOfBirth;

        // konstruktør
        public Member()
        {
            _memberNo = -1;
            _name = "";
            _phone = "";
            _yearOfBirth = 0;
        }
        public Member(int memberNo, string name, string phone, int yearOfBirth)
        {
            _memberNo = memberNo;
            _name = name;
            _phone = phone;
            _yearOfBirth = yearOfBirth;
        }

        // properties
        public int MemberNo
        {
            get { return _memberNo; }
            set { _memberNo = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value; }
        }


        public override string ToString()
        {
            return "No= " + MemberNo + ", Name= " + Name + ", Phone= " +
                Phone + ", YearOfBirth= " + YearOfBirth;
        }
    }
}
