
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
    public partial class IpcControllerCoilConfigurationsIpcControllerCoilDetailGraphType : ObjectGraphType<IpcControllerCoilConfigurationsIpcControllerCoilDetail>
    {
        public IpcControllerCoilConfigurationsIpcControllerCoilDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerCoilConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.IpcControllerCoilDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcControllerCoilConfigurationGraphType>(
                            "{ Name = EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "IpcControllerCoilConfiguration"
                      Name = "IpcControllerCoilConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "IpcControllerCoilDetail"
                      Name = "IpcControllerCoilDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerCoilConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "IpcControllerCoilDetailsId"
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
      { Name = RelationName "IpcControllerCoilDetail"
        TargetTable =
         { Name = TableName "IpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
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
                          Name = "InverterConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilSpecificConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "IgbtThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilGapThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilCenterThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EmptyPotDetectionCoilConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "CoilCenterThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "CoilGapThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CoilSpecificConfigDatum"
                          Name = "CoilSpecificConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "EmptyPotDetectionCoilConfig"
                          Name = "EmptyPotDetectionCoilConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "IgbtThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InverterConfigDatum"
                          Name = "InverterConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "IpcControllerCoilDetail"
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
            
			
                Field<IpcControllerCoilDetailGraphType, IpcControllerCoilDetail>("IpcControllerCoilDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcControllerCoilDetailGraphType>(
                            "{ Name = EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "IpcControllerCoilConfiguration"
                      Name = "IpcControllerCoilConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "IpcControllerCoilDetail"
                      Name = "IpcControllerCoilDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerCoilConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "IpcControllerCoilDetailsId"
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
      { Name = RelationName "IpcControllerCoilDetail"
        TargetTable =
         { Name = TableName "IpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
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
                          Name = "InverterConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilSpecificConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "IgbtThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilGapThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilCenterThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EmptyPotDetectionCoilConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "CoilCenterThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "CoilGapThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CoilSpecificConfigDatum"
                          Name = "CoilSpecificConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "EmptyPotDetectionCoilConfig"
                          Name = "EmptyPotDetectionCoilConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "IgbtThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InverterConfigDatum"
                          Name = "InverterConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "IpcControllerCoilDetail"
        IsNullable = false
        KeyType = Guid }] }-IpcControllerCoilDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerCoilDetails
                                    .Where(x => x.IpcControllerCoilDetail != null && ids.Contains((Guid)x.IpcControllerCoilDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerCoilDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilDetail);
                });
            
        }
    }
}
            