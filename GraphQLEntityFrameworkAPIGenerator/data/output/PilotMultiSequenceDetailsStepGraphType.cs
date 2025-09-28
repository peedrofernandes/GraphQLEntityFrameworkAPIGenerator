
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
    public partial class PilotMultiSequenceDetailsStepGraphType : ObjectGraphType<PilotMultiSequenceDetailsStep>
    {
        public PilotMultiSequenceDetailsStepGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PilotMultiSequenceDetailGraphType, PilotMultiSequenceDetail>("PilotMultiSequenceDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PilotMultiSequenceDetailGraphType>(
                            "{ Name = EntityName "PilotMultiSequenceDetailsStep"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotMultiSequenceDetailsStep"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DetailsId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "Id"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "PilotMultiSequenceDetail"
                      Name = "Details"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PilotMultiSequenceStep"
                      Name = "IdNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Id"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PilotMultiSequenceDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DetailsId"
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
                         Name = "NumberOfSteps"
                         IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                          Name = "PilotMultiSequenceConfigDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                          Name = "PilotMultiSequenceDetailsSteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PilotMultiSequenceStep"
        TargetTable =
         { Name = TableName "PilotMultiSequenceStep"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Short
                         Name = "StepDuration"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PilotStatesId0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PilotStatesId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "PilotStatesId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "PilotStatesId3"
                         IsNullable = true };
             Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                          Name = "PilotMultiSequenceDetailsSteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceStep"
        IsNullable = false
        KeyType = Guid }] }-PilotMultiSequenceDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceDetails
                                    .Where(x => x.PilotMultiSequenceDetail != null && ids.Contains((Guid)x.PilotMultiSequenceDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceDetail);
                });
            
			
                Field<PilotMultiSequenceStepGraphType, PilotMultiSequenceStep>("PilotMultiSequenceSteps")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PilotMultiSequenceStepGraphType>(
                            "{ Name = EntityName "PilotMultiSequenceDetailsStep"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotMultiSequenceDetailsStep"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DetailsId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "Id"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "PilotMultiSequenceDetail"
                      Name = "Details"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PilotMultiSequenceStep"
                      Name = "IdNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Id"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PilotMultiSequenceDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DetailsId"
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
                         Name = "NumberOfSteps"
                         IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                          Name = "PilotMultiSequenceConfigDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                          Name = "PilotMultiSequenceDetailsSteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PilotMultiSequenceStep"
        TargetTable =
         { Name = TableName "PilotMultiSequenceStep"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Short
                         Name = "StepDuration"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PilotStatesId0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PilotStatesId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "PilotStatesId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "PilotStatesId3"
                         IsNullable = true };
             Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                          Name = "PilotMultiSequenceDetailsSteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceStep"
        IsNullable = false
        KeyType = Guid }] }-PilotMultiSequenceStep-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceSteps
                                    .Where(x => x.PilotMultiSequenceStep != null && ids.Contains((Guid)x.PilotMultiSequenceStep))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceStep!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceStep);
                });
            
        }
    }
}
            