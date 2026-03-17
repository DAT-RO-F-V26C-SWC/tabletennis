using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace tabletennisLib.model
{
    public class MemberRegister
    {
        // ingen dirrekta instans felter

        // en aggregering
        private List<Member> _members;

        // koskruktør
        public MemberRegister()
        {
            _members = new List<Member>();
        }

        public MemberRegister(List<Member> members)
        {
            _members = members;
        }

        // properties
        public List<Member> Members
        {
            get { return _members; }
            set { _members = value; }
        }


        /*
         * Metoder
         */
        public void AddMember(Member newMember)
        {
            _members.Add(newMember);
        }
        public void RemoveMember(int memberToRemove)
        {
            Member member = GetMember(memberToRemove);
            if (member != null)
            {
                _members.Remove(member);
            }
        }
        public List<Member> ListAll()
        {
            return new List<Member>(_members);
        }
        public Member GetMember(int no)
        {
            Member resMember = null; // if not found
            foreach (Member m in _members)
            {
                if (m.MemberNo == no)
                {
                    return m; // found eg. return value
                }
            }

            return resMember;
        }

        public Member GetMember(string phone)
        {
            Member resMember = null; // if not found
            foreach (Member m in _members)
            {
                if (m.Phone == phone)
                {
                    return m; // found eg. return value
                }
            }

            return resMember;

        }
        public Member UpdateMember(int no, Member updatedMember)
        {
            Member member = GetMember(no);
            if (member != null)
            {
                member.MemberNo = updatedMember.MemberNo;
                member.Name = updatedMember.Name;
                member.Phone = updatedMember.Phone;
                member.YearOfBirth = updatedMember.YearOfBirth;
            }

            return member;
        }








        public override string ToString()
        {
            string resStr = "[";
            foreach (Member m in _members)
            {
                resStr = resStr + m + ", ";
            }
            resStr = resStr + "]";

            return "Members= " + resStr;
        }
    }
}
