using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public Team TGetByd(int id)
        {
            return _teamDal.GetByd(id);
        }

        public List<Team> TGetList()
        {
           return _teamDal.GetList();
        }

        public void TInsert(Team t)
        {
            _teamDal.Insert(t);
        }

        public void TUpdate(Team t)
        {
            _teamDal.Update(t); 
        }
    }
}
