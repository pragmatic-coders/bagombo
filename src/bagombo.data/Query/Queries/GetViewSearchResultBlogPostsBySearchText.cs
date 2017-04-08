﻿using Bagombo.Models.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bagombo.Data.Query.Queries
{

  public class GetViewSearchResultBlogPostsBySearchText : IQuery<IList<ViewSearchResultBlogPostViewModel>>
  {
    public string searchText { get; set; }
  }

}
