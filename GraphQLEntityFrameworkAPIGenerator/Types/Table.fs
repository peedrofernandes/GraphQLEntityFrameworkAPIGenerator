namespace GraphQLEntityFrameworkAPIGenerator.Types

type PluralizedTableName = PluralizedTableName of string
with
    override this.ToString() : string =
        let (PluralizedTableName name) = this
        name

type TableName = TableName of string
with
    member this.Pluralize() : PluralizedTableName = 
        let (TableName name) = this
        PluralizedTableName (name + "s")
    override this.ToString() : string =
        let (TableName name) = this
        name

type PrimitiveProperty = {
    Type: PrimitiveType
    Name: string
    IsNullable: bool
}
type PrimaryKeyProperty = {
    Type: IdType
    Name: string
    IsNullable: bool
}
type ForeignKeyProperty = {
    Type: IdType
    Name: string
    IsNullable: bool
}
type NavigationProperty = {
    Type: TableName
    Name: string
    IsNullable: bool
    IsCollection: bool
}
type Property =
    | Primitive of PrimitiveProperty
    | PrimaryKey of PrimaryKeyProperty
    | ForeignKey of ForeignKeyProperty
    | Navigation of NavigationProperty

type RegularTable = {
    Name: TableName
    PrimaryKey: PrimaryKeyProperty
    ForeignKeys: ForeignKeyProperty list
    NavigationProperties: NavigationProperty list
    PrimitiveProperties: PrimitiveProperty list 
}
with
    member this.Properties : Property list =
        PrimaryKey this.PrimaryKey 
            :: (this.ForeignKeys |> List.map ForeignKey) 
            @ (this.NavigationProperties |> List.map Navigation) 
            @ (this.PrimitiveProperties |> List.map Primitive)

// type JoinTable<T1 : RegularTable, T2 : RegularTable> = {

type JoinTable = {
    Name: TableName
    PrimaryKey: Option<PrimaryKeyProperty>
    ForeignKeyT1: ForeignKeyProperty
    ForeignKeyT2: ForeignKeyProperty
    NavigationPropertyT1: NavigationProperty
    NavigationPropertyT2: NavigationProperty
}
with
    member this.Properties : Property list =
        match this.PrimaryKey with
        | Some pk -> [PrimaryKey pk; ForeignKey this.ForeignKeyT1; ForeignKey this.ForeignKeyT2; Navigation this.NavigationPropertyT1; Navigation this.NavigationPropertyT2]
        | None -> [ForeignKey this.ForeignKeyT1; ForeignKey this.ForeignKeyT2; Navigation this.NavigationPropertyT1; Navigation this.NavigationPropertyT2]  

    member this.ForeignKeys : ForeignKeyProperty list =
        [this.ForeignKeyT1; this.ForeignKeyT2]

    member this.PrimitiveProperties : PrimitiveProperty list =
        []
    member this.NavigationProperties : NavigationProperty list =
        [this.NavigationPropertyT1; this.NavigationPropertyT2]

type ViewTable = {
    Name: TableName
    PrimitiveProperties: PrimitiveProperty list
}

type Table =
    | Regular of RegularTable
    | Join of JoinTable
    | View of ViewTable
with    
    member this.Name =
        match this with
        | Regular(r) -> r.Name
        | Join(j) -> j.Name
        | View(v) -> v.Name

    member this.Properties =
        match this with
        | Regular(r) -> r.Properties
        | Join(j) -> j.Properties
        | View(v) -> v.PrimitiveProperties |> List.map Primitive

    member this.ForeignKeys =
        match this with
        | Regular(r) -> r.ForeignKeys
        | Join(j) -> j.ForeignKeys
        | View(v) -> []

    member this.PrimitiveProperties =
        match this with
        | Regular(r) -> r.PrimitiveProperties
        | Join(j) -> j.PrimitiveProperties
        | View(v) -> v.PrimitiveProperties

    member this.NavigationProperties =
        match this with
        | Regular(r) -> r.NavigationProperties
        | Join(j) -> j.NavigationProperties
        | View(v) -> []


