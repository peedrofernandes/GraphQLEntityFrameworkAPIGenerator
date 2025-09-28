namespace GraphQLEntityFrameworkAPIGenerator.Interfaces

open GraphQLEntityFrameworkAPIGenerator.Types

type IRelationParser =
    abstract member ParseEntities: tables: Map<TableName, Table> -> Entity list