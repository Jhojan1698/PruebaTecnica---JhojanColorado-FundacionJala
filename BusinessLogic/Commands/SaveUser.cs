using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    public class SaveUser : IWaterCommand
    {
        public void Execute()
        {
            InputData data = new SaveUserView().RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);
            entity.FirstName = data.fields["FirstName"];
            entity.SecondName = data.fields["SecodName"];
            new MemberRepository().Save(entity);
        }
    }
}
