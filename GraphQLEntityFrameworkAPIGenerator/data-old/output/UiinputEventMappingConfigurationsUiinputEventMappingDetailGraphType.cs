
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
    public partial class UiinputEventMappingConfigurationsUiinputEventMappingDetailGraphType : ObjectGraphType<UiinputEventMappingConfigurationsUiinputEventMappingDetail>
    {
        public UiinputEventMappingConfigurationsUiinputEventMappingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiinputEventMappingConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiinputEventMappingDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiinputEventMappingConfigurationGraphType, UiinputEventMappingConfiguration>("UiinputEventMappingConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiinputEventMappingConfigurationGraphType>(
                            "{ Name = EntityName "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiinputEventMappingConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiinputEventMappingDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiinputEventMappingConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiinputEventMappingDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiinputEventMappingConfiguration"
        TargetTable =
         { Name = TableName "UiinputEventMappingConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingConfigurationId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
                 Name =
                  "UiinputEventMappingConfigurationsUiinputEventMappingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiinputEventMappingConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiinputEventMappingDetail"
        TargetTable =
         { Name = TableName "UiinputEventMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingDetailsId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
                         IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "UiinputEventMappingDetail"
        IsNullable = false
        KeyType = Guid }] }-UiinputEventMappingConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiinputEventMappingConfigurations
                                    .Where(x => x.UiinputEventMappingConfiguration != null && ids.Contains((Guid)x.UiinputEventMappingConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiinputEventMappingConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiinputEventMappingConfiguration);
                });
            
			
                Field<UiinputEventMappingDetailGraphType, UiinputEventMappingDetail>("UiinputEventMappingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiinputEventMappingDetailGraphType>(
                            "{ Name = EntityName "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiinputEventMappingConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiinputEventMappingDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiinputEventMappingConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiinputEventMappingDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiinputEventMappingConfiguration"
        TargetTable =
         { Name = TableName "UiinputEventMappingConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingConfigurationId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
                 Name =
                  "UiinputEventMappingConfigurationsUiinputEventMappingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiinputEventMappingConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiinputEventMappingDetail"
        TargetTable =
         { Name = TableName "UiinputEventMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingDetailsId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
                         IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "UiinputEventMappingDetail"
        IsNullable = false
        KeyType = Guid }] }-UiinputEventMappingDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiinputEventMappingDetails
                                    .Where(x => x.UiinputEventMappingDetail != null && ids.Contains((Guid)x.UiinputEventMappingDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiinputEventMappingDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiinputEventMappingDetail);
                });
            
        }
    }
}
            