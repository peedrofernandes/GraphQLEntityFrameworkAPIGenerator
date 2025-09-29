
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
    public partial class ThermalConfigDatumGraphType : ObjectGraphType<ThermalConfigDatum>
    {
        public ThermalConfigDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ThermalConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.MaxDeratingFactor, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MinDeratingFactor, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InitialValueDeratingFactor, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ToleranceFromOverHeatingToWarm, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HysteresysBandwidthHotIndicator, type: typeof(IdGraphType), nullable: False);
            
                Field<IpcControllerIpcConfigurationGraphType, IpcControllerIpcConfiguration>("IpcControllerIpcConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerIpcConfigurationGraphType>>(
                            "{ Name = EntityName "ThermalConfigDatum"
  CorrespondingTable =
   Regular
     { Name = TableName "ThermalConfigDatum"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ThermalConfigId"
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
                                                      Name = "MaxDeratingFactor"
                                                      IsNullable = false };
         Primitive { Type = Float
                     Name = "MinDeratingFactor"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "InitialValueDeratingFactor"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "ToleranceFromOverHeatingToWarm"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "HysteresysBandwidthHotIndicator"
                     IsNullable = false };
         Navigation { Type = TableName "IpcControllerIpcConfiguration"
                      Name = "IpcControllerIpcConfigurations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ThermalConfigId"
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
    { Name = "MaxDeratingFactor"
      Type = Primitive Float
      IsNullable = false }; { Name = "MinDeratingFactor"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "InitialValueDeratingFactor"
      Type = Primitive Float
      IsNullable = false }; { Name = "ToleranceFromOverHeatingToWarm"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "HysteresysBandwidthHotIndicator"
      Type = Primitive Int
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
            