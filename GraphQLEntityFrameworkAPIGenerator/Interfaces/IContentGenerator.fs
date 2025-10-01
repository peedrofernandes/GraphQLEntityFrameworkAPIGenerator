namespace GraphQLEntityFrameworkAPIGenerator.Interfaces

open GraphQLEntityFrameworkAPIGenerator.Types

type GeneratedContent = {
    GeneratedFile: string
    SourceFile: string
}

type IContentGenerator =
    abstract member GenerateContent : entity: Entity -> GeneratedContent