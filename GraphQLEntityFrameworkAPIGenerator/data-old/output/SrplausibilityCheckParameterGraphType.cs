
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
    public partial class SrplausibilityCheckParameterGraphType : ObjectGraphType<SrplausibilityCheckParameter>
    {
        public SrplausibilityCheckParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrPlausibilityCheckParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfPlausibilityChecks, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AdcminThresholdForPlausibilityCheck1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AdcmaxThresholdForPlausibilityCheck1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PlausibilityCheckGiindex1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PlausibilityCheckTemperatureGiindex1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AdcminThresholdForPlausibilityCheck2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AdcmaxThresholdForPlausibilityCheck2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PlausibilityCheckGiindex2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PlausibilityCheckTemperatureGiindex2, type: typeof(ByteGraphType), nullable: False);
            
                Field<SrsafetyRelevantParameterGraphType, SrsafetyRelevantParameter>("SrsafetyRelevantParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SrsafetyRelevantParameterGraphType>>(
                            "{ Name = EntityName "SrplausibilityCheckParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "SrplausibilityCheckParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SrPlausibilityCheckParamsId"
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
         Primitive { Type = Byte
                     Name = "NumberOfPlausibilityChecks"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "AdcminThresholdForPlausibilityCheck1"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "AdcmaxThresholdForPlausibilityCheck1"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "PlausibilityCheckGiindex1"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "PlausibilityCheckTemperatureGiindex1"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "AdcminThresholdForPlausibilityCheck2"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "AdcmaxThresholdForPlausibilityCheck2"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "PlausibilityCheckGiindex2"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "PlausibilityCheckTemperatureGiindex2"
                     IsNullable = false };
         Navigation { Type = TableName "SrsafetyRelevantParameter"
                      Name = "SrsafetyRelevantParameters"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "SrPlausibilityCheckParamsId"
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
      IsNullable = false }; { Name = "NumberOfPlausibilityChecks"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "AdcminThresholdForPlausibilityCheck1"
      Type = Primitive Short
      IsNullable = false }; { Name = "AdcmaxThresholdForPlausibilityCheck1"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "PlausibilityCheckGiindex1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PlausibilityCheckTemperatureGiindex1"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "AdcminThresholdForPlausibilityCheck2"
      Type = Primitive Short
      IsNullable = false }; { Name = "AdcmaxThresholdForPlausibilityCheck2"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "PlausibilityCheckGiindex2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PlausibilityCheckTemperatureGiindex2"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "SrsafetyRelevantParameter"
        TargetTable =
         { Name = TableName "SrsafetyRelevantParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SrsafetyParametersId"
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
                          Name = "SroverTempCheckId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrFanSpeedCheckParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrStuckProbeCheckParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrhmieventCheckParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrPlausibilityCheckParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrpcbcheckParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrboilerOverTempCheckParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrPinShortCheckParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrexpansionConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SrfanSpeedCheckParameter"
                          Name = "SrFanSpeedCheckParams"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SrpinShortCheckParameter"
                          Name = "SrPinShortCheckParams"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SrplausibilityCheckParameter"
                          Name = "SrPlausibilityCheckParams"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SrstuckProbeCheckParameter"
                          Name = "SrStuckProbeCheckParams"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SrboilerOverTempCheckParameter"
                          Name = "SrboilerOverTempCheckParams"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SrexpansionConfiguration"
                          Name = "SrexpansionConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SrhmieventCheckParameter"
                          Name = "SrhmieventCheckParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SroverTempCheckParameter"
                          Name = "SroverTempCheck"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SrpcbcheckParameter"
                          Name = "SrpcbcheckParams"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SrsafetyRelevantParameter"
        KeyType = Guid }] }-SrsafetyRelevantParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.SrsafetyRelevantParameters
                                    .Where(x => x.SrsafetyRelevantParameter != null && ids.Contains((Guid)x.SrsafetyRelevantParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SrsafetyRelevantParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.SrsafetyRelevantParameters);
                    });
            
        }
    }
}
            