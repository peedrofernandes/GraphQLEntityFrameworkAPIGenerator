
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
    public partial class IpcFanConfigDatumGraphType : ObjectGraphType<IpcFanConfigDatum>
    {
        public IpcFanConfigDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcFanConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanMaximumSpeed, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FanMinimumSpeed, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FanActivationTempThresholdNotDelivering, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxTempForSpeedLinearInterpolation, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MinTempForSpeedLinearInterpolation, type: typeof(FloatGraphType), nullable: False);
            
                Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationGraphType>>(
                            "{ Name = EntityName "IpcFanConfigDatum"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcFanConfigDatum"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcFanConfigId"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Version"
                                                      IsNullable = false };
         Primitive { Type = Int
                     Name = "FanMaximumSpeed"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "FanMinimumSpeed"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "FanActivationTempThresholdNotDelivering"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "MaxTempForSpeedLinearInterpolation"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "MinTempForSpeedLinearInterpolation"
                     IsNullable = false };
         Navigation { Type = TableName "IpcControllerCoilConfiguration"
                      Name = "IpcControllerCoilConfigurations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "IpcFanConfigId"
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
    { Name = "Version"
      Type = Primitive Byte
      IsNullable = false }; { Name = "FanMaximumSpeed"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "FanMinimumSpeed"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "FanActivationTempThresholdNotDelivering"
      Type = Primitive Float
      IsNullable = false }; { Name = "MaxTempForSpeedLinearInterpolation"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "MinTempForSpeedLinearInterpolation"
      Type = Primitive Float
      IsNullable = false }]
  Relations =
   [OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilConfigurations);
                    });
            
        }
    }
}
            