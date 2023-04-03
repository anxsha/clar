﻿using Ardalis.Specification;

namespace clar.Core.ContributorAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification {
  public ContributorByIdSpec(int contributorId) {
    Query
      .Where(contributor => contributor.Id == contributorId);
  }
}
