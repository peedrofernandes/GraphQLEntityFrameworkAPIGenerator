
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
    public partial class MainsLineConfigDatumGraphType : ObjectGraphType<MainsLineConfigDatum>
    {
        public MainsLineConfigDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MainsLineConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NominalPower, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.NominalCurrent, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IntegralGainCurrentAndPower, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CurrentFaultTreshold, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerFaultThreshold, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.RestartLineVoltageThresholdAfterSurgeFault, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.RestartWaitingTimeAfterSurgeFault, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ReclosingWaitingTimeAfter400VdetectionFaultIsCleared, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.OpeningWaitingTimeAfter400VdetectionFault, type: typeof(FloatGraphType), nullable: False);
            
                Field<IpcControllerIpcConfigurationGraphType, IpcControllerIpcConfiguration>("IpcControllerIpcConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerIpcConfigurationGraphType>>(
                            "{ Name = EntityName "MainsLineConfigDatum"
  CorrespondingTable =
   Regular
     { Name = TableName "MainsLineConfigDatum"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MainsLineConfigId"
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
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "NominalPower"
                                                      IsNullable = false };
         Primitive { Type = Float
                     Name = "NominalCurrent"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "IntegralGainCurrentAndPower"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "CurrentFaultTreshold"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "PowerFaultThreshold"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "RestartLineVoltageThresholdAfterSurgeFault"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "RestartWaitingTimeAfterSurgeFault"
                     IsNullable = false };
         Primitive
           { Type = Float
             Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
             IsNullable = false };
         Primitive { Type = Float
                     Name = "OpeningWaitingTimeAfter400VdetectionFault"
                     IsNullable = false };
         Navigation { Type = TableName "IpcControllerIpcConfiguration"
                      Name = "IpcControllerIpcConfigurations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MainsLineConfigId"
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
    { Name = "NominalPower"
      Type = Primitive Float
      IsNullable = false }; { Name = "NominalCurrent"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "IntegralGainCurrentAndPower"
      Type = Primitive Float
      IsNullable = false }; { Name = "CurrentFaultTreshold"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "PowerFaultThreshold"
      Type = Primitive Float
      IsNullable = false };
    { Name = "RestartLineVoltageThresholdAfterSurgeFault"
      Type = Primitive Float
      IsNullable = false }; { Name = "RestartWaitingTimeAfterSurgeFault"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
      Type = Primitive Float
      IsNullable = false }; { Name = "OpeningWaitingTimeAfter400VdetectionFault"
                              Type = Primitive Float
                              IsNullable = false }]
  Relations =
   [OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.IpcControllerIpcConfigurations);
                    });
            
        }
    }
}
            