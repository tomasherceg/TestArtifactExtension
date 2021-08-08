using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WebTools.Languages.Html.Artifacts;
using Microsoft.WebTools.Languages.Shared.Text;

namespace TestArtifactExtension.Artifacts
{
    public class DothtmlArtifactCollection : ArtifactCollection
    {
        public DothtmlArtifactCollection(IArtifactProcessor artifactProcessor) : base(artifactProcessor)
        {
        }

        public DothtmlArtifactCollection(IEnumerable<IArtifactProcessor> artifactProcessors) : base(artifactProcessors)
        {
        }

        public override bool IsDestructiveChange(int start, int oldLength, int newLength, ITextProvider oldText, ITextProvider newText)
        {
            var baseResult = base.IsDestructiveChange(start, oldLength, newLength, oldText, newText);
            if (baseResult)
            {
                return true;
            }

            var newTextValue = newText.GetText(0, newText.Length);
            var oldTextValue = oldText.GetText(0, oldText.Length);
            if (newTextValue.Contains("{") || newTextValue.Contains("}") || oldTextValue.Contains("{") || oldTextValue.Contains("}"))
            {
                return true;
            }

            return false;
        }
    }
}
