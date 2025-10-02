namespace GraphQLEntityFrameworkAPIGenerator.Types

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

    //KeyType: IdType

    NavProp: SingleNavigationProperty
    BackwardsNavProp: SingleNavigationProperty
    
    SourceTable: RegularTable
    TargetTable : RegularTable

    Destination: EntityName

    IsNullable: bool
}
type ManyToOneRelation = {
    Name: RelationName

    //KeyType: IdType

    NavProp: SingleNavigationProperty
    BackwardsNavProp: CollectionNavigationProperty

    SourceTable: RegularTable
    TargetTable: RegularTable

    Destination: EntityName

    IsNullable: bool
}
// type MultipleManyToOneRelation = {
//     Names: RelationName list

//     KeyType: IdType

//     NavProps: SingleNavigationProperty list
//     BackwardsNavProps: CollectionNavigationProperty list

//     SourceTable: RegularTable
//     TargetTable : RegularTable

//     Destination: EntityName

//     IsNullable: bool
// }
type OneToManyRelation = {
    Name: RelationName

    // KeyType: IdType
    NavProp: CollectionNavigationProperty
    BackwardsNavProp: SingleNavigationProperty

    SourceTable: RegularTable
    TargetTable : RegularTable

    Destination: EntityName

    IsNullable: bool
}
// type MultipleOneToManyRelation = { // This should map to multiple OR statements and a single property.
//     Names: RelationName list

//     KeyType: IdType
//     NavProps: CollectionNavigationProperty list
//     BackwardsNavProps: SingleNavigationProperty list

//     SourceTable: RegularTable
//     TargetTable: RegularTable

//     Destination: EntityName

//     IsNullable: bool
// }
type ManyToManyRelationWithJoinTable = {
    Name: RelationName

    // KeyType: IdType
    NavProp: CollectionNavigationProperty
    JoinTableBackwardsNavProp: SingleNavigationProperty
    JoinTableNavProp: SingleNavigationProperty
    //TargetTableBackwardsNavProp: CollectionNavigationProperty

    SourceTable: RegularTable
    JoinTable: JoinTable
    TargetTable : RegularTable

    Destination: EntityName

    IsNullable: bool
}
type ManyToManyRelation = {
    Name: RelationName

    // KeyType: IdType
    NavProp: CollectionNavigationProperty
    BackwardsNavProp: CollectionNavigationProperty

    SourceTable: RegularTable
    TargetTable : RegularTable

    Destination: EntityName
}

type Relation =
    | OneToOne of OneToOneRelation
    | ManyToOne of ManyToOneRelation
    // | MultipleManyToOne of MultipleManyToOneRelation
    | OneToMany of OneToManyRelation
    // | MultipleOneToMany of MultipleOneToManyRelation
    | ManyToManyWithJoinTable of ManyToManyRelationWithJoinTable
    | ManyToMany of ManyToManyRelation
// with
    // member this.KeyType : IdType =
    //     match this with
    //     | OneToOne(r) -> r.KeyType
    //     | ManyToOne(r) -> r.KeyType
    //     // | MultipleManyToOne(r) -> r.KeyType
    //     | OneToMany(r) -> r.KeyType
    //     // | MultipleOneToMany(r) -> r.KeyType
    //     | ManyToManyWithJoinTable(r) -> r.KeyType
    //     | ManyToMany(r) -> r.KeyType

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
