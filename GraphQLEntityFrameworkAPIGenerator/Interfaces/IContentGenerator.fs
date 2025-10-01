namespace GraphQLEntityFrameworkAPIGenerator.Interfaces

open GraphQLEntityFrameworkAPIGenerator.Types

type GeneratedContent = {
    GeneratedFile: string
    SourceFile: string
}

type IContentGenerator =
    abstract member Category : Category
    abstract member GenerateContent : Entity -> GeneratedContent