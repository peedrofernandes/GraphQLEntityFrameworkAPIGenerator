namespace GraphQLEntityFrameworkAPIGenerator.Types

// These are the Entity types. They represent actual relations on the database, with necessary details for generating the GraphQL schema.
// They are generated from the Table types.

type PluralizedEntityName = PluralizedEntityName of string
    with
        override this.ToString() : string =
            let (PluralizedEntityName name) = this
            name.ToString()
type EntityName = EntityName of string
    with
        member this.Pluralize() : PluralizedEntityName = 
            let (EntityName name) = this
            PluralizedEntityName (StringUtils.pluralize name)
        override this.ToString() : string =
            let (EntityName name) = this
            name.ToString()

type RelationName = RelationName of string
    with
        override this.ToString() : string =
            let (RelationName name) = this
            name.ToString()

type OneToOneRelation = {
    Name: RelationName
    NavProp: SingleNavigationProperty
    BackwardsNavProp: SingleNavigationProperty
    SourceTable: RegularTable
    TargetTable : RegularTable
    Destination: EntityName
    IsNullable: bool
}
type ManyToOneRelation = {
    Name: RelationName

    NavProp: SingleNavigationProperty
    BackwardsNavProp: CollectionNavigationProperty

    SourceTable: RegularTable
    TargetTable: RegularTable

    Destination: EntityName

    IsNullable: bool
}
type OneToManyRelation = {
    Name: RelationName
    NavProp: CollectionNavigationProperty
    BackwardsNavProp: SingleNavigationProperty
    SourceTable: RegularTable
    TargetTable : RegularTable
    Destination: EntityName
    IsNullable: bool
}
type ManyToManyRelationWithJoinTable = {
    Name: RelationName
    NavProp: CollectionNavigationProperty
    JoinTableBackwardsNavProp: SingleNavigationProperty
    JoinTableNavProp: SingleNavigationProperty
    SourceTable: RegularTable
    JoinTable: JoinTable
    TargetTable : RegularTable
    Destination: EntityName
    IsNullable: bool
}
type ManyToManyRelation = {
    Name: RelationName
    NavProp: CollectionNavigationProperty
    BackwardsNavProp: CollectionNavigationProperty
    SourceTable: RegularTable
    TargetTable : RegularTable
    Destination: EntityName
}

type Relation =
    | OneToOne of OneToOneRelation
    | ManyToOne of ManyToOneRelation
    | OneToMany of OneToManyRelation
    | ManyToManyWithJoinTable of ManyToManyRelationWithJoinTable
    | ManyToMany of ManyToManyRelation

type FieldType =
    | Primitive of PrimitiveType
    | Id of SingleIdType

type Field = {
    PropName: PropName
    ColumnName: ColumnName
    Type: FieldType
    IsNullable: bool
}

type Entity = {
    Name: EntityName
    CorrespondingTable: Table
    Fields: Field list
    Relations: Relation list
}
