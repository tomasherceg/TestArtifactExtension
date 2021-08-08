using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.WebTools.Languages.Html.Artifacts;
using Microsoft.WebTools.Languages.Shared.Text;

namespace TestArtifactExtension.Artifacts
{
    public class DothtmlBindingProcessor : IArtifactProcessor
    {
        public bool IsReady => true;

        public string LeftCommentSeparator => "<%--";

        public string LeftSeparator => "";

        public string RightCommentSeparator => "--%>";

        public string RightSeparator => "";


        public void GetArtifacts(ITextProvider text, ArtifactCollection artifactCollection)
        {
            var allText = text.GetText(0, text.Length);

            foreach (var match in Regex.Matches(allText, "\\{[^}]*\\}").OfType<Match>())
            {
                artifactCollection.Add(new Artifact(ArtifactTreatAs.Code, new TextRange(match.Index, match.Length), 1, 1, "RazorCode", true));
            }
        }
    }
}
