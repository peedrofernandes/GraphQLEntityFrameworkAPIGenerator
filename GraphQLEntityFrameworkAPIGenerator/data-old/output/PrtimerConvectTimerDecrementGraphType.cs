
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
    public partial class PrtimerConvectTimerDecrementGraphType : ObjectGraphType<PrtimerConvectTimerDecrement>
    {
        public PrtimerConvectTimerDecrementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectTimerDecrementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfFanSpeeds, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed6, type: typeof(ByteGraphType), nullable: False);
            
                Field<PowerReductionTimerConfigurationGraphType, PowerReductionTimerConfiguration>("PowerReductionTimerConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PowerReductionTimerConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerConvectTimerDecrement"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectTimerDecrement"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerDecrementId"
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
                                                      Name = "NumberOfFanSpeeds"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "FanSpeed0"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "FanSpeed1"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "FanSpeed2"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "FanSpeed3"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "FanSpeed4"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "FanSpeed5"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "FanSpeed6"
                     IsNullable = false };
         Navigation { Type = TableName "PowerReductionTimerConfiguration"
                      Name = "PowerReductionTimerConfigurations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerConvectTimerDecrementId"
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
    { Name = "NumberOfFanSpeeds"
      Type = Primitive Byte
      IsNullable = false }; { Name = "FanSpeed0"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "FanSpeed1"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "FanSpeed2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "FanSpeed3"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "FanSpeed4"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "FanSpeed5"
      Type = Primitive Byte
      IsNullable = false }; { Name = "FanSpeed6"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PowerReductionTimerConfiguration"
        TargetTable =
         { Name = TableName "PowerReductionTimerConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
                          IsNullable = true }; Primitive { Type = String
                                                           Name = "Compartment"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
                          IsNullable = true };
             Navigation { Type = TableName "MonitorPowerReduction"
                          Name = "MonitorPowerReductions"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilTimerDecrement"
                          Name = "PrtimerBroilTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectTimerDecrement"
                          Name = "PrtimerConvectTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronTimerDecrement"
                          Name = "PrtimerMagnetronTimerDecrement"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PowerReductionTimerConfiguration"
        KeyType = Guid }] }-PowerReductionTimerConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PowerReductionTimerConfigurations
                                    .Where(x => x.PowerReductionTimerConfiguration != null && ids.Contains((Guid)x.PowerReductionTimerConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PowerReductionTimerConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PowerReductionTimerConfigurations);
                    });
            
        }
    }
}
            