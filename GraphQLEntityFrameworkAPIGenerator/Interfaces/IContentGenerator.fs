namespace GraphQLEntityFrameworkAPIGenerator.Interfaces

open GraphQLEntityFrameworkAPIGenerator.Types

type IContentGenerator =
    abstract member GenerateContent : entity: Entity -> string