using BookStore.Business.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Dependency_Injection
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAddressRepository>().To<AddressRepository>().InSingletonScope();
            Bind<IApplicationUserRepository>().To<ApplicationUserRepository>().InSingletonScope();
            Bind<ICategoryRepository>().To<CategoryRepository>().InSingletonScope();
            Bind<IDetailRepository>().To<DetailRepository>().InSingletonScope();
            Bind<IMasterCategoryRepository>().To<MasterCategoryRepository>().InSingletonScope();
            Bind<IModuleRepository>().To<ModuleRepository>().InSingletonScope();
            Bind<IOrderItemRepository>().To<OrderItemRepository>().InSingletonScope();
            Bind<IOrderRepository>().To<OrderRepository>().InSingletonScope();
            Bind<IProductImageRepository>().To<ProductImageRepository>().InSingletonScope();
            Bind<IProductRepository>().To<ProductRepository>().InSingletonScope();
            Bind<IPublishingHouseRepository>().To<PublishingHouseRepository>().InSingletonScope();
            Bind<IRoleRepository>().To<RoleRepository>().InSingletonScope();
            Bind<ISpesificCategoryRepository>().To<SpesificCategoryRepository>().InSingletonScope();
            Bind<ITicketRepository>().To<TicketRepository>().InSingletonScope();
            Bind<ITicketResponseRepository>().To<TicketResponseRepository>().InSingletonScope();
            

        }
    }
}
