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
    Properties: Property list 
}
with
    member this.PrimaryKey: PrimaryKeyProperty = 
        this.Properties 
        |> Seq.choose (fun property ->
            match property with
            | PrimaryKey(pk) -> Some pk
            | _ -> None)
        |> Seq.tryHead 
        |> function
            | Some pk -> pk
            | None -> failwith $"RegularTable '{this.Name}' does not have a primary key"
    member this.ForeignKeys =
        this.Properties
        |> Seq.choose (fun property ->
            match property with
            | ForeignKey(fk) -> Some fk
            | _ -> None)
        |> List.ofSeq
    member this.PrimitiveProperties =
        this.Properties
        |> Seq.choose (fun property ->
            match property with
            | Primitive(p) -> Some p
            | _ -> None)
        |> List.ofSeq
    member this.NavigationProperties =
        this.Properties
        |> Seq.choose (fun property ->
            match property with
            | Navigation(np) -> Some np
            | _ -> None)
        |> List.ofSeq

type JoinTable = {
    Name: TableName
    Properties: Property list
}
with
    member this.ForeignKeys =
        this.Properties
        |> Seq.choose (fun property ->
            match property with
            | ForeignKey(fk) -> Some fk
            | _ -> None)
        |> List.ofSeq
    member this.PrimitiveProperties =
        this.Properties
        |> Seq.choose (fun property ->
            match property with
            | Primitive(p) -> Some p
            | _ -> None)
        |> List.ofSeq
    member this.NavigationProperties =
        this.Properties
        |> Seq.choose (fun property ->
            match property with
            | Navigation(np) -> Some np
            | _ -> None)
        |> List.ofSeq

type ViewTable = {
    Name: TableName
    Properties: PrimitiveProperty list
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
        | View(v) -> v.Properties |> List.map (fun p -> Primitive p)

    member this.ForeignKeys =
        match this with
        | Regular(r) -> r.ForeignKeys
        | Join(j) -> j.ForeignKeys
        | View(v) -> []

    member this.PrimitiveProperties =
        match this with
        | Regular(r) -> r.PrimitiveProperties
        | Join(j) -> j.PrimitiveProperties
        | View(v) -> v.Properties

    member this.NavigationProperties =
        match this with
        | Regular(r) -> r.NavigationProperties
        | Join(j) -> j.NavigationProperties
        | View(v) -> []


