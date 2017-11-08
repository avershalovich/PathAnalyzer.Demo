using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class Constants
    {
        public static class FieldIDs
        {
            public static class FilteredPageMap
            {
                public static readonly ID FilterMapFieldID = ID.Parse("{B853E529-B136-4F1A-BF52-F6A9DC9ED45A}");
            }

        }

        public static class MapOptionKeys
        {
            public static readonly string Filter = "filter";
        }
    }
}
