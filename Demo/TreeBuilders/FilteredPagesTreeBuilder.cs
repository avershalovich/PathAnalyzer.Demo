using Sitecore.Analytics.Aggregation.Data.Model;
using Sitecore.Analytics.Model;
using Sitecore.Diagnostics;
using Sitecore.PathAnalyzer.Construction;
using Sitecore.PathAnalyzer.Data.Models;
using Sitecore.SequenceAnalyzer;
using System.Collections.Generic;
using System.Linq;

namespace Demo.TreeBuilders
{
    public class FilteredPagesTreeBuilder : PageTreeBuilder
    {
        public FilteredPagesTreeBuilder(TreeDefinition definition) : base(definition)
        {

        }

        protected override IEnumerable<Record> BuildSequence(IVisitAggregationContext context, IEnumerable<PageData> filteredPages)
        {
            var updatedPages = FilterPages(filteredPages);

            return base.BuildSequence(context, updatedPages);
        }

        protected IEnumerable<PageData> FilterPages(IEnumerable<PageData> filteredPages)
        {
            Log.Debug("Processing Filter option value : " + FilterOptionValue);

            return filteredPages.Where(page => !page.Url.Path.Contains(FilterOptionValue));
        }

        protected string FilterOptionValue
        {
            get {
                return this.Definition.GetStringOption(Constants.MapOptionKeys.Filter);
            }
        }
    }
}
