using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
namespace Unity
{
    public class Factory
    {
        static public IPlayer CreateInstance()
        {
            IUnityContainer _container = new UnityContainer();
            _container.RegisterType(typeof(IPlayer), typeof(Player));
            IPlayer obj = _container.Resolve<IPlayer>();
            return obj;
        }

    }
}
