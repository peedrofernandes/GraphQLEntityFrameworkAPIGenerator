namespace GraphQLEntityFrameworkAPIGenerator.Types

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
type IdType =
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
type Type =
    | Primitive of PrimitiveType
    | Id of IdType

