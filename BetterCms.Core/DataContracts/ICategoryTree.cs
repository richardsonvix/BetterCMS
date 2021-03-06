﻿using System.Collections.Generic;

namespace BetterCms.Core.DataContracts
{
    public interface ICategoryTree : IEntity
    {
        string Title { get; set; }

        IList<ICategory> Categories { get; set; }

        string Macro { get; set; }

        IList<ICategoryTreeCategorizableItem> AvailableFor { get; set; }
    }
}
