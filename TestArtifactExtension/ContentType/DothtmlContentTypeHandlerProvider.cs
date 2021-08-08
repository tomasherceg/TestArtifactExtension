using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.ContentType.Def;

namespace TestArtifactExtension.ContentType
{
    [Export(typeof(IContentTypeHandlerProvider))]
    [ContentType(DothtmlContentTypeDefinition.ContentTypeName)]
    public class DothtmlContentTypeHandlerProvider : IContentTypeHandlerProvider
    {
        public IContentTypeHandler GetContentTypeHandler()
        {
            return new DothtmlContentTypeHandler();
        }
    }
}