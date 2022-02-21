using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System.Collections.Generic;

namespace BusinessLogic.Commands
{
    public class MemberReceivableRequest: IWaterCommand
    {
        double WaterPrice = 8.5;
        public void Execute()
        {
            UserReceivableView view = new UserReceivableView();
            InputData data = view.RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);
            
            List<Consumption> memberConsumptions = new ConsumptionRepository().GetConsumptionByMember(entity);
            List<Member> membernames = new MemberRepository().GetNames(entity);

            double cubos = this.CalcualateCubos(memberConsumptions);
            double total = this.CalculateTotalReceivable(memberConsumptions);
            string names = this.MostrarNombres(membernames);
            

            view.ShowResult(entity.ID , names, cubos, total);   
 
        }

        private double CalculateTotalReceivable(List<Consumption> memberConsumptions)
        {
            double total = 0;
            foreach(Consumption item in memberConsumptions)
            {
                total += item.Value * WaterPrice;
            }
            return total;
        }

        private double CalcualateCubos(List<Consumption> memberConsumptions)
        {
            double cubos = 0;
            foreach (Consumption item in memberConsumptions)
            {
                cubos = item.Value;
            }
            return cubos;

        }

        private string MostrarNombres(List<Member> membernames)
        {
            string resp;
            foreach (Member item in membernames)
            {
                resp = item.FirstName + " " + item.SecondName;
            }

            return null;
        }
    }
}
