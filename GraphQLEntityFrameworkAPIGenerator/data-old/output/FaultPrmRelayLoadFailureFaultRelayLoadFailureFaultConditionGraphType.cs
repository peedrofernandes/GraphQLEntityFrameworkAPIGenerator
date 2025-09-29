
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
    public partial class FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditionGraphType : ObjectGraphType<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition>
    {
        public FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultPrmRelayLoadFailureId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.FaultConditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<FaultRelayLoadFailureFaultConditionGraphType, FaultRelayLoadFailureFaultCondition>("FaultRelayLoadFailureFaultConditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, FaultRelayLoadFailureFaultConditionGraphType>(
                            "{ Name =
   EntityName "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
  CorrespondingTable =
   Regular
     { Name =
        TableName "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultPrmRelayLoadFailureId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "FaultConditionId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "FaultPrmRelayLoadFailureId"
      Type = Id Guid
      IsNullable = false }; { Name = "FaultConditionId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FaultRelayLoadFailureFaultCondition"
        TargetTable =
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
        Destination = EntityName "FaultRelayLoadFailureFaultCondition"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "FaultPrmRelayLoadFailure"
        TargetTable =
         { Name = TableName "FaultPrmRelayLoadFailure"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultPrmRelayLoadFailureId"
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
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumberofGis"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Gi1"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Gi2"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load1"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load2"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load3"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load4"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load5"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load6"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load7"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load8"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load9"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load10"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
                 Name =
                  "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "FaultPrmRelayLoadFailure"
        IsNullable = false
        KeyType = Guid }] }-FaultRelayLoadFailureFaultCondition-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultRelayLoadFailureFaultConditions
                                    .Where(x => x.FaultRelayLoadFailureFaultCondition != null && ids.Contains((Guid)x.FaultRelayLoadFailureFaultCondition))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FaultRelayLoadFailureFaultCondition!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.FaultRelayLoadFailureFaultCondition);
                });
            
			
                Field<FaultPrmRelayLoadFailureGraphType, FaultPrmRelayLoadFailure>("FaultPrmRelayLoadFailures")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, FaultPrmRelayLoadFailureGraphType>(
                            "{ Name =
   EntityName "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
  CorrespondingTable =
   Regular
     { Name =
        TableName "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultPrmRelayLoadFailureId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "FaultConditionId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "FaultPrmRelayLoadFailureId"
      Type = Id Guid
      IsNullable = false }; { Name = "FaultConditionId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FaultRelayLoadFailureFaultCondition"
        TargetTable =
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
        Destination = EntityName "FaultRelayLoadFailureFaultCondition"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "FaultPrmRelayLoadFailure"
        TargetTable =
         { Name = TableName "FaultPrmRelayLoadFailure"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultPrmRelayLoadFailureId"
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
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumberofGis"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Gi1"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Gi2"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load1"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load2"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load3"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load4"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load5"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load6"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load7"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load8"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "Load9"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Load10"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition"
                 Name =
                  "FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "FaultPrmRelayLoadFailure"
        IsNullable = false
        KeyType = Guid }] }-FaultPrmRelayLoadFailure-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultPrmRelayLoadFailures
                                    .Where(x => x.FaultPrmRelayLoadFailure != null && ids.Contains((Guid)x.FaultPrmRelayLoadFailure))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FaultPrmRelayLoadFailure!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.FaultPrmRelayLoadFailure);
                });
            
        }
    }
}
            