﻿using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class MasterCategoryMap : BaseMap<MasterCategory>
    {
        public MasterCategoryMap()
        {
            ToTable("MasterCategories");

        }
    }
}
