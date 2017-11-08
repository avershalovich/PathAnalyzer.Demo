using Sitecore.Data.Items;
using Sitecore.PathAnalyzer.Data.Maps;
using System.Collections.Generic;

namespace Demo.Maps
{
    public class FilteredPageMapItem : MapItem
    {
        public FilteredPageMapItem(Item innerItem) : base(innerItem)
        {

        }
        protected override Dictionary<string, string> GetMapOptions()
        {
            Dictionary<string, string> mapOptions = base.GetMapOptions();
            string key = Constants.MapOptionKeys.Filter;
            string str = this.InnerItem[Constants.FieldIDs.FilteredPageMap.FilterMapFieldID];
            mapOptions.Add(key, str);

            return mapOptions;
        }
    }
}
