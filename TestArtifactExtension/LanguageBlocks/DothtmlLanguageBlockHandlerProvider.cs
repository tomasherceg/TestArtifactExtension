using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Def;
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Handlers;
using Microsoft.WebTools.Languages.Html.Editor.ContentType;
using Microsoft.WebTools.Languages.Html.Editor.Tree;

namespace TestArtifactExtension.LanguageBlocks
{
    [Export(typeof(ILanguageBlockHandlerProvider))]
    public class DothtmlLanguageBlockHandlerProvider : ILanguageBlockHandlerProvider
    {
        public IEnumerable<LanguageBlockHandler> GetLanguageBlockHandlers(HtmlEditorTree tree)
        {
            yield return new DothtmlLanguageBlockHandler(tree, ContentTypeManager.GetContentType("htmlex"));
        }
    }
}
