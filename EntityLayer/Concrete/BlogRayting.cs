﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class BlogRayting
    {
        public int BlogRaytingID { get; set; }
        public int BlogId { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRaytingCount { get; set; }

        public int BlogRaytingOrt { get; set; }
    }
}