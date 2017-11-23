using ProjetoModeloDDD.Aplicacao;
using ProjetoModeloDDD.Aplicacao.Interface;
using ProjetoModeloDDD.ApresentacaoWeb.AutoMapper;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;
using ProjetoModeloDDD.Dominio.Services;
using ProjetoModeloDDD.Infra.Dados.Repositorios;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetoModeloDDD.ApresentacaoWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();

            var container = new Container();

            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Singleton);
            container.Register<IAreaAppService, AreaAppService>(Lifestyle.Singleton);
            container.Register<IComentarioAppService, ComentarioAppService>(Lifestyle.Singleton);
            container.Register<IPostAppService, PostAppService>(Lifestyle.Singleton);

            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Singleton);
            container.Register<IAreaService, AreaService>(Lifestyle.Singleton);
            container.Register<IComentarioService, ComentarioService>(Lifestyle.Singleton);
            container.Register<IPostService, PostService>(Lifestyle.Singleton);

            container.Register<IUsuarioRepositorio, UsuarioRepositorio>(Lifestyle.Singleton);
            container.Register<IAreaRepositorio, AreaRepositorio>(Lifestyle.Singleton);
            container.Register<IComentarioRepositorio, ComentarioRepositorio>(Lifestyle.Singleton);
            container.Register<IPostRepositorio, PostRepositorio>(Lifestyle.Singleton);

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
    }
}
