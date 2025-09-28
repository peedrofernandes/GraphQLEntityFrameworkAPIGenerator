
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
    public partial class FaultRelayLoadFailureFaultConditionGraphType : ObjectGraphType<FaultRelayLoadFailureFaultCondition>
    {
        public FaultRelayLoadFailureFaultConditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultConditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Gi1MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Gi2MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load1MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load2MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load3MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load4MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load5MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load6MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load7MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load8MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load9MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load10MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Gi1Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Gi2Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load1Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load2Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load3Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load4Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load5Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load6Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load7Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load8Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load9Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load10Ignore, type: typeof(BoolGraphType), nullable: False);
            
                Field<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditionGraphType, FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition>("FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditionGraphType>>(
                            "{ Name = EntityName "FaultRelayLoadFailureFaultCondition"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultRelayLoadFailureFaultCondition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultConditionId"
                      IsNullable = false };
         Primitive { Type = Short
                     Name = "Gi1MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Gi2MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load1MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load2MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load3MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load4MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load5MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load6MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load7MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load8MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load9MonitoredState"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "Load10MonitoredState"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Gi1Ignore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Gi2Ignore"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Load1Ignore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Load2Ignore"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Load3Ignore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Load4Ignore"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Load5Ignore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Load6Ignore"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Load7Ignore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Load8Ignore"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Load9Ignore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Load10Ignore"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
             Name =
              "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "FaultConditionId"
      Type = Id Guid
      IsNullable = false }; { Name = "Gi1MonitoredState"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Gi2MonitoredState"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "Load1MonitoredState"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load2MonitoredState"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "Load3MonitoredState"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load4MonitoredState"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "Load5MonitoredState"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load6MonitoredState"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "Load7MonitoredState"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load8MonitoredState"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "Load9MonitoredState"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load10MonitoredState"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Gi1Ignore"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Gi2Ignore"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Load1Ignore"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Load2Ignore"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Load3Ignore"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Load4Ignore"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Load5Ignore"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Load6Ignore"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Load7Ignore"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Load8Ignore"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Load9Ignore"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Load10Ignore"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
        TargetTable =
         { Name =
            TableName
              "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultPrmRelayLoadFailureId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "FaultConditionId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "FaultRelayLoadFailureFaultCondition"
                          Name = "FaultCondition"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultPrmRelayLoadFailure"
                          Name = "FaultPrmRelayLoadFailure"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
        KeyType = Guid }] }-FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions
                                    .Where(x => x.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition != null && ids.Contains((Guid)x.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions);
                    });
            
        }
    }
}
            