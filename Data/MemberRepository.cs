using System;
using Data.DB;
using Data.Entities;
using System.Collections.Generic;

namespace Data
{
    public class MemberRepository
    {
        public MemberRepository()
        {
            this.GenerateFakeData();
        }

        public void Save(Member entity)
        {
            LocalMemoryDB.MembersContext.Add(entity);
        }

        private void GenerateFakeData()
        {            
            LocalMemoryDB.MembersContext.Add(new Member() { ID = 5000, FirstName = "Juan", SecondName = "Perez" });
            LocalMemoryDB.MembersContext.Add(new Member() { ID = 5001, FirstName = "Pedro", SecondName = "Flores" });
        }

        public Member GetMember(int id)
        {
            foreach(Member item in LocalMemoryDB.MembersContext)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public List<Member> GetNames(Member id)
        {
            List<Member> resultado = new List<Member>();
            foreach (Member item in LocalMemoryDB.MembersContext)
            {
                if (item.ID == id.ID)
                {
                    resultado.Add(item);
                }
            }

            return resultado;
        }

    }
}
