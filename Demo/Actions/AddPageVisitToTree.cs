using Sitecore.PathAnalyzer.Rules.Actions;
using Sitecore.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Actions
{
    public class AddPageVisitToTreeFiltered<T> : AddPageVisitToTree<T> where T : RuleContext
    {
        public override void Apply(T ruleContext)
        {
            //ruleContext.
            base.Apply(ruleContext);
        }
    }
}
