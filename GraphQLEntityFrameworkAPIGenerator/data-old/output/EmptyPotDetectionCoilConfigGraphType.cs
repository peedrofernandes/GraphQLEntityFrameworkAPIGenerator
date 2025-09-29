
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
    public partial class EmptyPotDetectionCoilConfigGraphType : ObjectGraphType<EmptyPotDetectionCoilConfig>
    {
        public EmptyPotDetectionCoilConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.EmptyPotDetectionCoilConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UseGapTempSensorForEmptyPotHandling, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.KiTemperatureControl, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.KpTemperatureControl, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.FixedDeratingFactor, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureControlSetpointSlope, type: typeof(FloatGraphType), nullable: False);
            
                Field<IpcControllerCoilDetailGraphType, IpcControllerCoilDetail>("IpcControllerCoilDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilDetailGraphType>>(
                            "{ Name = EntityName "EmptyPotDetectionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "EmptyPotDetectionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "EmptyPotDetectionCoilConfigId"
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
                     IsNullable = true };
         Primitive { Type = Bool
                     Name = "UseGapTempSensorForEmptyPotHandling"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "KiTemperatureControl"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "KpTemperatureControl"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "FixedDeratingFactor"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureControlSetpointSlope"
                     IsNullable = false };
         Navigation { Type = TableName "IpcControllerCoilDetail"
                      Name = "IpcControllerCoilDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "EmptyPotDetectionCoilConfigId"
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
    { Name = "UseGapTempSensorForEmptyPotHandling"
      Type = Primitive Bool
      IsNullable = false }; { Name = "KiTemperatureControl"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "KpTemperatureControl"
      Type = Primitive Float
      IsNullable = false }; { Name = "FixedDeratingFactor"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TemperatureControlSetpointSlope"
      Type = Primitive Float
      IsNullable = false }]
  Relations =
   [OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilDetails);
                    });
            
        }
    }
}
            