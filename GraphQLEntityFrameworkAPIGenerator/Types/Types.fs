namespace GraphQLEntityFrameworkAPIGenerator.Types

// These are the types and utilities that are used throughout the project.

module StringUtils =
    let pluralize (name: string) : string =
        // Check if already pluralized
        if name.EndsWith("ies") || name.EndsWith("es") || name.EndsWith("ves") then
            name
        elif name.EndsWith("s") && name.Length > 1 && not (name.EndsWith("ss")) then
            // Already ends with 's' but not 'ss' - likely already plural
            name
        elif name.EndsWith("Data") || name.EndsWith("data") then
            name
        // Handle pluralization rules
        elif name.EndsWith("s") || name.EndsWith("x") || name.EndsWith("z") || name.EndsWith("ss") then
            name + "es"
        elif name.EndsWith("ch") || name.EndsWith("sh") then
            name + "es"
        elif name.EndsWith("Datum") then
            name.Substring(0, name.Length - 5) + "Data"
        elif name.EndsWith("datum") then
            name.Substring(0, name.Length - 5) + "data"
        elif name.Length >= 2 && name.[name.Length - 1] = 'y' then
            let secondLastChar = name.[name.Length - 2]
            // Check if the character before 'y' is a consonant (not a vowel)
            if not (secondLastChar = 'a' || secondLastChar = 'e' || secondLastChar = 'i' || secondLastChar = 'o' || secondLastChar = 'u' ||
                    secondLastChar = 'A' || secondLastChar = 'E' || secondLastChar = 'I' || secondLastChar = 'O' || secondLastChar = 'U') then
                name.Substring(0, name.Length - 1) + "ies"
            else
                name + "s"
        elif name.ToLower().EndsWith("if") then
            name + "s"
        elif name.ToLower().EndsWith("f") then
            name.Substring(0, name.Length - 1) + "ves"
        elif name.ToLower().EndsWith("fe") then
            name.Substring(0, name.Length - 2) + "ves"
        else
            name + "s"

type Category =
    | Cooking
    | Dishwasher
    | Dryer
    | HAWasher
    | Refrigeration
    | VAWasher

type PrimitiveType =
    | Int
    | Byte
    | ByteArr
    | String
    | Guid
    | Decimal
    | Double
    | Float
    | Long
    | Short
    | Ushort
    | Uint
    | Ulong
    | Sbyte
    | Char
    | DateTime
    | DateTimeOffset
    | TimeSpan
    | Bool
with
    override this.ToString() : string =
        match this with
        | Int -> "int"
        | Byte -> "byte"
        | ByteArr -> "byte[]"
        | String -> "string"
        | Guid -> "Guid"
        | Decimal -> "decimal"
        | Double -> "double"
        | Float -> "float"
        | Long -> "long"
        | Short -> "short"
        | Ushort -> "ushort"
        | Uint -> "uint"
        | Ulong -> "ulong"
        | Sbyte -> "sbyte"
        | Char -> "char"
        | DateTime -> "DateTime"
        | DateTimeOffset -> "DateTimeOffset"
        | TimeSpan -> "TimeSpan"
        | Bool -> "bool"
type SingleIdType =
    | Int
    | Byte
    | String
    | Guid
    | Short
    | Bool
    | Float
with
    override this.ToString() : string =
        match this with
            | Int -> "int"
            | Byte -> "byte"
            | String -> "string"
            | Guid -> "Guid"
            | Short -> "short"
            | Bool -> "bool"
            | Float -> "float"
type CompositeIdType = {
    Ids: SingleIdType list
}
with
    override this.ToString() : string =
        this.Ids
        |> List.map (fun id -> id.ToString()) 
        |> String.concat ", " 
        |> (fun str -> $"({str})")
type IdType =
    | Single of SingleIdType
    | Composite of CompositeIdType
with
    override this.ToString() : string =
        match this with
        | Single s -> s.ToString()
        | Composite c -> c.ToString()
type Type =
    | Primitive of PrimitiveType
    | Id of IdType
with
    override this.ToString() : string =
        match this with
        | Primitive p -> p.ToString()
        | Id i -> i.ToString()

