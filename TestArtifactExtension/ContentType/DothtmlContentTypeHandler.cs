using Microsoft.WebTools.Languages.Html.Artifacts;
using Microsoft.WebTools.Languages.Html.Editor.ContentType.Handlers;
using TestArtifactExtension.Artifacts;

namespace TestArtifactExtension.ContentType
{
    public class DothtmlContentTypeHandler : HtmlContentTypeHandler
    {
        public override ArtifactCollection CreateArtifactCollection()
        {
            return new DothtmlArtifactCollection(new DothtmlBindingProcessor());
        }
    }
}