using Ardalis.Specification;
using clar.Core.ProjectAggregate;

namespace clar.Core.ProjectAggregate.Specifications;

public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification {
  public ProjectByIdWithItemsSpec(int projectId) {
    Query
      .Where(project => project.Id == projectId)
      .Include(project => project.Items);
  }
}
