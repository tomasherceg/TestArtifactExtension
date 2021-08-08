using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;

namespace TestArtifactExtension.ContentType
{
    public class DothtmlContentTypeDefinition
    {
        public const string ContentTypeName = "htmlex";

        [Export(typeof(ContentTypeDefinition))]
        [Name(ContentTypeName)]
        [BaseDefinition("htmlx")]
        public ContentTypeDefinition DothtmlContentType { get; set; }

        [Export(typeof(FileExtensionToContentTypeDefinition))]
        [FileExtension(".htmlex")]
        [ContentType(ContentTypeName)]
        public FileExtensionToContentTypeDefinition DothtmlFileExtensionDefinition { get; set; }
    }
}