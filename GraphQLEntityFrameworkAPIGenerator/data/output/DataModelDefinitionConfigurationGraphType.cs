
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
    public partial class DataModelDefinitionConfigurationGraphType : ObjectGraphType<DataModelDefinitionConfiguration>
    {
        public DataModelDefinitionConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DataModelDefinitionConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelVersion, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DataModelApi, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DataModelCategory, type: typeof(IdGraphType), nullable: False);
            
                Field<DataModelDefinitionConfigurationsDataModelDefinitionDetailGraphType, DataModelDefinitionConfigurationsDataModelDefinitionDetail>("DataModelDefinitionConfigurationsDataModelDefinitionDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DataModelDefinitionConfigurationsDataModelDefinitionDetailGraphType>>(
                            "{ Name = EntityName "DataModelDefinitionConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "DataModelDefinitionConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DataModelDefinitionConfigurationId"
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "DataModelVersion"
                                                      IsNullable = false };
         Primitive { Type = Int
                     Name = "DataModelApi"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "DataModelCategory"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
             Name =
              "DataModelDefinitionConfigurationsDataModelDefinitionDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "DataModelDefinitionConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "DataModelVersion"
      Type = Primitive Int
      IsNullable = false }; { Name = "DataModelApi"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "DataModelCategory"
                                                      Type = Primitive Int
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
        TargetTable =
         { Name =
            TableName
              "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DataModelDefinitionConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DataModelDefinitionDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DataModelDefinitionConfiguration"
                          Name = "DataModelDefinitionConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DataModelDefinitionDetail"
                          Name = "DataModelDefinitionDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
        KeyType = Guid }] }-DataModelDefinitionConfigurationsDataModelDefinitionDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.DataModelDefinitionConfigurationsDataModelDefinitionDetails
                                    .Where(x => x.DataModelDefinitionConfigurationsDataModelDefinitionDetail != null && ids.Contains((Guid)x.DataModelDefinitionConfigurationsDataModelDefinitionDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DataModelDefinitionConfigurationsDataModelDefinitionDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.DataModelDefinitionConfigurationsDataModelDefinitionDetails);
                    });
            
        }
    }
}
            