namespace GraphQLEntityFrameworkAPIGenerator.Interfaces

open GraphQLEntityFrameworkAPIGenerator.Types

type ITableParser =
    abstract member ParseTable: fileContent: string -> Table