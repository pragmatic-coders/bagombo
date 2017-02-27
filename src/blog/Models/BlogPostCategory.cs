﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
  public class BlogPostCategory
  {
    public int BlogPostId { get; set; }
    public BlogPost BlogPost { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
  }
}
