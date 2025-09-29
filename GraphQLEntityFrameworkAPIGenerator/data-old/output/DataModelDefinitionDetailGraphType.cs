
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
    public partial class DataModelDefinitionDetailGraphType : ObjectGraphType<DataModelDefinitionDetail>
    {
        public DataModelDefinitionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DataModelDefinitionDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelIndex, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Sort, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelNamespace, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Entity, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Instance, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AttributeName, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AttributeDisplayName, type: typeof(StringGraphType), nullable: True);
			Field(t => t.PayloadDataType, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DataDefinition, type: typeof(LongGraphType), nullable: True);
			Field(t => t.IsGlobal, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsHardware, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsPersistence, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsTimeSeries, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.DefaultValue, type: typeof(LongGraphType), nullable: True);
			Field(t => t.KeyValue, type: typeof(LongGraphType), nullable: True);
			Field(t => t.IsGet, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsSet, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.PayloadFromCloud, type: typeof(StringGraphType), nullable: True);
			Field(t => t.OnRequest, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OnChange, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OnFrequency, type: typeof(LongGraphType), nullable: True);
			Field(t => t.PayloadFromAppliance, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SetCmdEcho, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ApplianceState, type: typeof(BoolGraphType), nullable: True);
            
                Field<DataModelDefinitionConfigurationsDataModelDefinitionDetailGraphType, DataModelDefinitionConfigurationsDataModelDefinitionDetail>("DataModelDefinitionConfigurationsDataModelDefinitionDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DataModelDefinitionConfigurationsDataModelDefinitionDetailGraphType>>(
                            "{ Name = EntityName "DataModelDefinitionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DataModelDefinitionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DataModelDefinitionDetailId"
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
                                                      Name = "DataModelIndex"
                                                      IsNullable = true };
         Primitive { Type = String
                     Name = "Sort"
                     IsNullable = true };
         Primitive { Type = String
                     Name = "DataModelNamespace"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "Entity"
                                                      IsNullable = true };
         Primitive { Type = String
                     Name = "Instance"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "AttributeName"
                                                      IsNullable = true };
         Primitive { Type = String
                     Name = "AttributeDisplayName"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "PayloadDataType"
                                                      IsNullable = true };
         Primitive { Type = Long
                     Name = "DataDefinition"
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "IsGlobal"
                                                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "IsHardware"
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "IsPersistence"
                                                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "IsTimeSeries"
                     IsNullable = true }; Primitive { Type = Long
                                                      Name = "DefaultValue"
                                                      IsNullable = true };
         Primitive { Type = Long
                     Name = "KeyValue"
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "IsGet"
                                                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "IsSet"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "PayloadFromCloud"
                                                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "OnRequest"
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "OnChange"
                                                      IsNullable = true };
         Primitive { Type = Long
                     Name = "OnFrequency"
                     IsNullable = true };
         Primitive { Type = String
                     Name = "PayloadFromAppliance"
                     IsNullable = true };
         Primitive { Type = String
                     Name = "DataModelDescription"
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "SetCmdEcho"
                                                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "ApplianceState"
                     IsNullable = true };
         Navigation
           { Type =
              TableName
                "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
             Name =
              "DataModelDefinitionConfigurationsDataModelDefinitionDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "DataModelDefinitionDetailId"
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
    { Name = "DataModelIndex"
      Type = Primitive Int
      IsNullable = true }; { Name = "Sort"
                             Type = Primitive String
                             IsNullable = true }; { Name = "DataModelNamespace"
                                                    Type = Primitive String
                                                    IsNullable = true };
    { Name = "Entity"
      Type = Primitive String
      IsNullable = true }; { Name = "Instance"
                             Type = Primitive String
                             IsNullable = true }; { Name = "AttributeName"
                                                    Type = Primitive String
                                                    IsNullable = true };
    { Name = "AttributeDisplayName"
      Type = Primitive String
      IsNullable = true }; { Name = "PayloadDataType"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "DataDefinition"
                                                    Type = Primitive Long
                                                    IsNullable = true };
    { Name = "IsGlobal"
      Type = Primitive Bool
      IsNullable = true }; { Name = "IsHardware"
                             Type = Primitive Bool
                             IsNullable = true }; { Name = "IsPersistence"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "IsTimeSeries"
      Type = Primitive Bool
      IsNullable = true }; { Name = "DefaultValue"
                             Type = Primitive Long
                             IsNullable = true }; { Name = "KeyValue"
                                                    Type = Primitive Long
                                                    IsNullable = true };
    { Name = "IsGet"
      Type = Primitive Bool
      IsNullable = true }; { Name = "IsSet"
                             Type = Primitive Bool
                             IsNullable = true }; { Name = "PayloadFromCloud"
                                                    Type = Primitive String
                                                    IsNullable = true };
    { Name = "OnRequest"
      Type = Primitive Bool
      IsNullable = true }; { Name = "OnChange"
                             Type = Primitive Bool
                             IsNullable = true }; { Name = "OnFrequency"
                                                    Type = Primitive Long
                                                    IsNullable = true };
    { Name = "PayloadFromAppliance"
      Type = Primitive String
      IsNullable = true }; { Name = "DataModelDescription"
                             Type = Primitive String
                             IsNullable = true }; { Name = "SetCmdEcho"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "ApplianceState"
      Type = Primitive Bool
      IsNullable = true }]
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
            