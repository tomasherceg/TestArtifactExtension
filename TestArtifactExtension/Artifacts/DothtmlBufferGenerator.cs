using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Common;
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Generators;
using Microsoft.WebTools.Languages.Html.Editor.Tree;

namespace TestArtifactExtension.Artifacts
{
    public class DothtmlBufferGenerator : ArtifactBasedBufferGenerator
    {
        public DothtmlBufferGenerator(HtmlEditorTree editorTree, LanguageBlockCollection languageBlocks, IContentType contentType) : base(editorTree, languageBlocks, contentType)
        {
        }

        public DothtmlBufferGenerator(HtmlEditorTree editorTree, LanguageBlockCollection languageBlocks) : base(editorTree, languageBlocks)
        {
        }

        protected override void RegenerateBuffer()
        {
            var collection = this.EditorTree.ArtifactCollection;

            base.RegenerateBuffer();
        }
    }
}
