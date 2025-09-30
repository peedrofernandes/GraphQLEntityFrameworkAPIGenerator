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
            PluralizedEntityName (name + "s")
        override this.ToString() : string =
            let (EntityName name) = this
            name.ToString()

type RelationName = RelationName of string
    with
        override this.ToString() : string =
            let (RelationName name) = this
            name.ToString()

// For each table (excluding join tables):
//     For each navigation property;
//         1. If here is a single (doesn't repeat) and there is a collection, then it's a single many-to-one relation;
//         2. If here is a single but has more than one, then it's a multiple many-to-one relation;
//         3. If here is a collection and there is a single:
//             - If there is not a join table, then it's a one-to-many relation;
//             - If there is a join table, then it's a many-to-many relation with join table;
//         4. If here is a collection and there is a collection, then it's a many-to-many relation;

type OneToOneRelation = {
    Name: RelationName

    KeyType: IdType

    NavProp: SingleNavigationProperty
    BackwardsNavProp: SingleNavigationProperty
    
    SourceTable: RegularTable
    TargetTable : RegularTable

    Destination: EntityName

    IsNullable: bool
}
type SingleManyToOneRelation = {
    Name: RelationName

    KeyType: IdType

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
type SingleOneToManyRelation = {
    Name: RelationName

    KeyType: IdType
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

    KeyType: IdType
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

    KeyType: IdType
    NavProp: CollectionNavigationProperty
    BackwardsNavProp: CollectionNavigationProperty

    SourceTable: RegularTable
    TargetTable : RegularTable

    Destination: EntityName
}

type Relation =
    | OneToOne of OneToOneRelation
    | SingleManyToOne of SingleManyToOneRelation
    // | MultipleManyToOne of MultipleManyToOneRelation
    | SingleOneToMany of SingleOneToManyRelation
    // | MultipleOneToMany of MultipleOneToManyRelation
    | ManyToManyWithJoinTable of ManyToManyRelationWithJoinTable
    | ManyToMany of ManyToManyRelation
with
    member this.KeyType : IdType =
        match this with
        | OneToOne(r) -> r.KeyType
        | SingleManyToOne(r) -> r.KeyType
        // | MultipleManyToOne(r) -> r.KeyType
        | SingleOneToMany(r) -> r.KeyType
        // | MultipleOneToMany(r) -> r.KeyType
        | ManyToManyWithJoinTable(r) -> r.KeyType
        | ManyToMany(r) -> r.KeyType

type Field = {
    Name: string
    Type: Type
    IsNullable: bool
}

type Entity = {
    Name: EntityName
    CorrespondingTable: Table
    Fields: Field list
    Relations: Relation list
}
