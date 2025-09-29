
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
    public partial class IpcControllerIpcConfigurationsIpcControllerCoilConfigurationGraphType : ObjectGraphType<IpcControllerIpcConfigurationsIpcControllerCoilConfiguration>
    {
        public IpcControllerIpcConfigurationsIpcControllerCoilConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerIpcConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.IpcControllerCoilConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcControllerCoilConfigurationGraphType>(
                            "{ Name =
   EntityName "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "IpcControllerCoilConfiguration"
                      Name = "IpcControllerCoilConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "IpcControllerIpcConfiguration"
                      Name = "IpcControllerIpcConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "IpcControllerCoilConfigurationsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "IpcControllerCoilConfiguration"
        TargetTable =
         { Name = TableName "IpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
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
             ForeignKey { Type = Guid
                          Name = "IpcFanConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HeatsinkThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MicroThermalNodeConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "HeatsinkThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcFanConfigDatum"
                          Name = "IpcFanConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "MicroThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "IpcControllerCoilConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcControllerIpcConfiguration"
        TargetTable =
         { Name = TableName "IpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
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
             ForeignKey { Type = Guid
                          Name = "MainsLineConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ThermalConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilOperationConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "AssistedCookingConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "AssistedCookingConfigDatum"
                          Name = "AssistedCookingConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CoilOperationConfigDatum"
                          Name = "CoilOperationConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "EmptyPotDetectionConfig"
                          Name = "EmptyPotDetectionConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerConfigurationsIpcControllerIpcConfiguration"
                 Name =
                  "IpcControllerConfigurationsIpcControllerIpcConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MainsLineConfigDatum"
                          Name = "MainsLineConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PowerDeliveryConfigDatum"
                          Name = "PowerDeliveryConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ThermalConfigDatum"
                          Name = "ThermalConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "IpcControllerIpcConfiguration"
        IsNullable = false
        KeyType = Guid }] }-IpcControllerCoilConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerCoilConfigurations
                                    .Where(x => x.IpcControllerCoilConfiguration != null && ids.Contains((Guid)x.IpcControllerCoilConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerCoilConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilConfiguration);
                });
            
			
                Field<IpcControllerIpcConfigurationGraphType, IpcControllerIpcConfiguration>("IpcControllerIpcConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcControllerIpcConfigurationGraphType>(
                            "{ Name =
   EntityName "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "IpcControllerCoilConfiguration"
                      Name = "IpcControllerCoilConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "IpcControllerIpcConfiguration"
                      Name = "IpcControllerIpcConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "IpcControllerCoilConfigurationsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "IpcControllerCoilConfiguration"
        TargetTable =
         { Name = TableName "IpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
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
             ForeignKey { Type = Guid
                          Name = "IpcFanConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HeatsinkThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MicroThermalNodeConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "HeatsinkThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcFanConfigDatum"
                          Name = "IpcFanConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "MicroThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "IpcControllerCoilConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcControllerIpcConfiguration"
        TargetTable =
         { Name = TableName "IpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
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
             ForeignKey { Type = Guid
                          Name = "MainsLineConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ThermalConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilOperationConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "AssistedCookingConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "AssistedCookingConfigDatum"
                          Name = "AssistedCookingConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CoilOperationConfigDatum"
                          Name = "CoilOperationConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "EmptyPotDetectionConfig"
                          Name = "EmptyPotDetectionConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerConfigurationsIpcControllerIpcConfiguration"
                 Name =
                  "IpcControllerConfigurationsIpcControllerIpcConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MainsLineConfigDatum"
                          Name = "MainsLineConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PowerDeliveryConfigDatum"
                          Name = "PowerDeliveryConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ThermalConfigDatum"
                          Name = "ThermalConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "IpcControllerIpcConfiguration"
        IsNullable = false
        KeyType = Guid }] }-IpcControllerIpcConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerIpcConfigurations
                                    .Where(x => x.IpcControllerIpcConfiguration != null && ids.Contains((Guid)x.IpcControllerIpcConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerIpcConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.IpcControllerIpcConfiguration);
                });
            
        }
    }
}
            