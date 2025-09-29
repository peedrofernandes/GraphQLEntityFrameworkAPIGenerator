
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
    public partial class FaultPrmRelayLoadFailureGraphType : ObjectGraphType<FaultPrmRelayLoadFailure>
    {
        public FaultPrmRelayLoadFailureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultPrmRelayLoadFailureId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberofGis, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Gi1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Gi2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load3, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load4, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load5, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load6, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load7, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load8, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load9, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load10, type: typeof(ShortGraphType), nullable: False);
            
                Field<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditionGraphType, FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition>("FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditionGraphType>>(
                            "{ Name = EntityName "FaultPrmRelayLoadFailure"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "FaultPrmRelayLoadFailureId"
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
      IsNullable = false }; { Name = "NumberOfLoads"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NumberofGis"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Gi1"
      Type = Primitive Short
      IsNullable = false }; { Name = "Gi2"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Load1"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "Load2"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load3"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Load4"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "Load5"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load6"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Load7"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "Load8"
      Type = Primitive Short
      IsNullable = false }; { Name = "Load9"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Load10"
                                                      Type = Primitive Short
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
            