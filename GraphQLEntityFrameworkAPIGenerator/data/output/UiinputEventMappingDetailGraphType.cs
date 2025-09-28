
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WP.Cooking.GESE.WebAPI.Models;
using GraphQL.DataLoader;
using WP.Cooking.GESE.WebAPI.Repositories; 


namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
{
    public partial class UiinputEventMappingDetailGraphType : ObjectGraphType<UiinputEventMappingDetail>
    {
        public UiinputEventMappingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiinputEventMappingDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LlireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfInputEvents, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Value1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent6, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent7, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value8, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent8, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value9, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent9, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value10, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent10, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UigireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Value11, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent11, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value12, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent12, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value13, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent13, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value14, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent14, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value15, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent15, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value16, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent16, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value17, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent17, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value18, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent18, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value19, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent19, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value20, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent20, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value21, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent21, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value22, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent22, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value23, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent23, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value24, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent24, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value25, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent25, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value26, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent26, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value27, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent27, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value28, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent28, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value29, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent29, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value30, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent30, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value31, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent31, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value32, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent32, type: typeof(IdGraphType), nullable: False);
            
                Field<UiinputEventMappingConfigurationsUiinputEventMappingDetailGraphType, UiinputEventMappingConfigurationsUiinputEventMappingDetail>("UiinputEventMappingConfigurationsUiinputEventMappingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiinputEventMappingConfigurationsUiinputEventMappingDetailGraphType>>(
                            "{ Name = EntityName "UiinputEventMappingDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiinputEventMappingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiinputEventMappingDetailsId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "LlireadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "LlireadTypePosition"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumberOfInputEvents"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value1"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value2"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent2"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value3"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value4"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent4"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value5"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value6"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent6"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value7"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent7"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value8"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent8"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value9"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent9"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value10"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent10"
                     IsNullable = false }; ForeignKey { Type = Byte
                                                        Name = "UigireadTypeId"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "UigireadTypePosition"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value11"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent11"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value12"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent12"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value13"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent13"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value14"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent14"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value15"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent15"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value16"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent16"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value17"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent17"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value18"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent18"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value19"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent19"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value20"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent20"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value21"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent21"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value22"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent22"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value23"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent23"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value24"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent24"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value25"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent25"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value26"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent26"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value27"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent27"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value28"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent28"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value29"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent29"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value30"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent30"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value31"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent31"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Value32"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "InputEvent32"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
             Name =
              "UiinputEventMappingConfigurationsUiinputEventMappingDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiinputEventMappingDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "LlireadTypePosition"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumberOfInputEvents"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Value1"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent1"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent2"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent3"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent4"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value5"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent5"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent6"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent7"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value8"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent8"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value9"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent9"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value10"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent10"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "UigireadTypePosition"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Value11"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent11"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value12"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent12"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value13"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent13"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value14"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent14"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value15"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent15"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value16"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent16"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value17"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent17"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value18"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent18"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value19"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent19"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value20"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent20"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value21"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent21"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value22"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent22"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value23"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent23"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value24"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent24"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value25"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent25"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value26"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent26"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value27"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent27"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value28"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent28"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value29"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent29"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "Value30"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputEvent30"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value31"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "InputEvent31"
      Type = Primitive Int
      IsNullable = false }; { Name = "Value32"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputEvent32"
                                                      Type = Primitive Int
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
        TargetTable =
         { Name =
            TableName
              "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiinputEventMappingConfiguration"
                          Name = "UiinputEventMappingConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiinputEventMappingDetail"
                          Name = "UiinputEventMappingDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
        KeyType = Guid }] }-UiinputEventMappingConfigurationsUiinputEventMappingDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiinputEventMappingConfigurationsUiinputEventMappingDetails
                                    .Where(x => x.UiinputEventMappingConfigurationsUiinputEventMappingDetail != null && ids.Contains((Guid)x.UiinputEventMappingConfigurationsUiinputEventMappingDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiinputEventMappingConfigurationsUiinputEventMappingDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiinputEventMappingConfigurationsUiinputEventMappingDetails);
                    });
            
        }
    }
}
            