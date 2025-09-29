namespace GraphQLEntityFrameworkAPIGenerator.Interfaces

open GraphQLEntityFrameworkAPIGenerator.Types

type ITableParser =
    abstract member ParseTable: fileContent: Map<TableName, string list> * string -> Table