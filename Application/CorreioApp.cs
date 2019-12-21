using Domain.Args;
using Domain.Interfaces.Application;
using Domain.Interfaces.Services;

namespace Application
{
    public class CorreioApp : App<ICorreiosSvc>, ICorreiosApp
    {

        public CorreioResponse RetornaEndereco(string cep)
        {
            var obj = _svc.RetornaEndereco(cep);
            AddNotifications(_svc.Notifications);
            return obj;
        }
    }
}
