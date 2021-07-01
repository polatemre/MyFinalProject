using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
    //Uygulama seviyesindeki servis bağımlılıklarımızı çözümleyeceğimiz yer
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //Http istekten cevaba kadar gecen surede takibi yapacak
        }
    }
}
