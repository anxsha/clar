using Autofac;
using clar.Core.Interfaces;
using clar.Core.Services;

namespace clar.Core;

public class DefaultCoreModule : Module {
  protected override void Load(ContainerBuilder builder) {
    builder.RegisterType<ToDoItemSearchService>()
      .As<IToDoItemSearchService>().InstancePerLifetimeScope();

    builder.RegisterType<DeleteContributorService>()
      .As<IDeleteContributorService>().InstancePerLifetimeScope();
  }
}
