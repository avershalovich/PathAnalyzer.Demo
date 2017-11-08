using Sitecore.Analytics;
using Sitecore.Analytics.Tracking;
using Sitecore.Diagnostics;
using Sitecore.PathAnalyzer.Rules.Conditions;
using Sitecore.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Rules
{
    public class MatchingAnyVisitGroupCondition<T> : BaseMapCondition<T> where T : RuleContext
    {
        public MatchingAnyVisitGroupCondition()
        {

        }

        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull((object)ruleContext, "ruleContext");
            Assert.IsNotNull((object)Tracker.Current, "Tracker.Current is not initialized");
            Assert.IsNotNull((object)Tracker.Current.Session, "Tracker.Current.Session is not initialized");
            Assert.IsNotNull((object)Tracker.Current.Session.Interaction, "Tracker.Current.Session.Interaction is not initialized");
            CurrentInteraction interaction = Tracker.Current.Session.Interaction;

            return base.Execute(ruleContext);
        }
    }
}
