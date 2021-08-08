using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Generators;
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Handlers;
using Microsoft.WebTools.Languages.Html.Editor.Tree;
using TestArtifactExtension.Artifacts;

namespace TestArtifactExtension.LanguageBlocks
{
    public class DothtmlLanguageBlockHandler : ArtifactBasedBlockHandler
    {
        public DothtmlLanguageBlockHandler(HtmlEditorTree editorTree, IContentType contentType) : base(editorTree, contentType)
        {
        }

        protected override BufferGenerator CreateBufferGenerator()
        {
            return new DothtmlBufferGenerator(EditorTree, LanguageBlocks, ContentType);
        }
    }
}