namespace GraphQLEntityFrameworkAPIGenerator.Types

type PluralizedTableName = PluralizedTableName of string
with
    override this.ToString() : string =
        let (PluralizedTableName name) = this
        name.ToString()

type TableName = TableName of string
with
    member this.Pluralize() : PluralizedTableName = 
        let (TableName name) = this
        PluralizedTableName (StringUtils.pluralize name)
    override this.ToString() : string =
        let (TableName name) = this
        name.ToString()

type PluralizedPropName = PluralizedNavPropName of string
with
    override this.ToString() : string =
        let (PluralizedNavPropName name) = this
        name.ToString()

type PropName = PropName of string
with 
    member this.Pluralize() : PluralizedPropName = 
        let (PropName name) = this
        PluralizedNavPropName (StringUtils.pluralize name)
    override this.ToString() : string =
        let (PropName name) = this
        name.ToString()

type PluralizedColumnName = PluralizedColumnName of string
with
    override this.ToString() : string =
        let (PluralizedColumnName name) = this
        name.ToString()

type ColumnName = ColumnName of string
with 
    member this.Pluralize() : PluralizedColumnName = 
        let (ColumnName name) = this
        PluralizedColumnName (StringUtils.pluralize name)
    override this.ToString() : string =
        let (ColumnName name) = this
        name.ToString()

type PrimitiveProperty = {
    Type: PrimitiveType
    PropName: PropName
    ColumnName: ColumnName
    IsNullable: bool
}
type PrimaryKeyProperty = {
    Type: IdType
    PropName: PropName
    ColumnName: ColumnName
    IsNullable: bool
}
type ForeignKeyProperty = {
    Type: IdType
    PropName: PropName
    ColumnName: ColumnName
    NavPropName: PropName
    IsNullable: bool
}
type SingleNavigationProperty = {
    Type: TableName
    PropName: PropName
    ColumnName: ColumnName
    FKeyName: PropName
    InverseName: PropName
    IsNullable: bool
}
type CollectionNavigationProperty = {
    Type: TableName
    PropName: PropName
    ColumnName: ColumnName
    InverseName: PropName
    IsNullable: bool
}
type NavigationProperty =
    | Single of SingleNavigationProperty
    | Collection of CollectionNavigationProperty
with
    member this.Type =
        match this with
        | Single(s) -> s.Type
        | Collection(c) -> c.Type
    member this.Name =
        match this with
        | Single(s) -> s.PropName
        | Collection(c) -> c.PropName
    member this.InverseName =
        match this with
        | Single(s) -> s.InverseName
        | Collection(c) -> c.InverseName
    member this.IsNullable =
        match this with
        | Single(s) -> s.IsNullable
        | Collection(c) -> c.IsNullable

type Property =
    | Primitive of PrimitiveProperty
    | PrimaryKey of PrimaryKeyProperty
    | ForeignKey of ForeignKeyProperty
    | Navigation of NavigationProperty
with
    member this.Name =
        match this with
        | Primitive(p) -> p.PropName
        | PrimaryKey(pk) -> pk.PropName
        | ForeignKey(fk) -> fk.PropName
        | Navigation(n) -> n.Name

type RegularTable = {
    Name: TableName
    PrimaryKey: PrimaryKeyProperty
    PrimitiveProperties: PrimitiveProperty list 
    ForeignKeys: ForeignKeyProperty list
    NavigationProperties: NavigationProperty list
}
with
    member this.Properties : Property list =
        [PrimaryKey this.PrimaryKey]
            @ (this.PrimitiveProperties |> List.map Primitive)
            @ (this.ForeignKeys |> List.map ForeignKey)
            @ (this.NavigationProperties |> List.map Navigation)

type JoinTable = {
    Name: TableName
    PrimaryKey: Option<PrimaryKeyProperty>
    ForeignKeys: ForeignKeyProperty list
    NavigationProperties: NavigationProperty list
}
with
    member this.Properties : Property list =
        (match this.PrimaryKey with | Some pk -> [PrimaryKey pk] | None -> [])
            @ (this.ForeignKeys |> List.map ForeignKey)
            @ (this.NavigationProperties |> List.map Navigation)

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

    member this.ForeignKeys : ForeignKeyProperty list =
        match this with
        | Regular(r) -> r.ForeignKeys
        | Join(j) -> j.ForeignKeys
        | View(v) -> []

    member this.PrimitiveProperties =
        match this with
        | Regular(r) -> r.PrimitiveProperties
        | Join(_) -> []
        | View(v) -> v.PrimitiveProperties

    member this.NavigationProperties =
        match this with
        | Regular(r) -> r.NavigationProperties
        | Join(j) -> j.NavigationProperties
        | View(v) -> []


