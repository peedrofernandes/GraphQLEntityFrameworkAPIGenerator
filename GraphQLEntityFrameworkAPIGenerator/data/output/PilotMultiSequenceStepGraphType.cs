
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
    public partial class PilotMultiSequenceStepGraphType : ObjectGraphType<PilotMultiSequenceStep>
    {
        public PilotMultiSequenceStepGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StepDuration, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PilotStatesId0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotStatesId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotStatesId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotStatesId3, type: typeof(ByteGraphType), nullable: True);
            
                Field<PilotMultiSequenceDetailsStepGraphType, PilotMultiSequenceDetailsStep>("PilotMultiSequenceDetailsSteps")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceDetailsStepGraphType>>(
                            "{ Name = EntityName "PilotMultiSequenceStep"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotMultiSequenceStep"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Short
                                                        Name = "StepDuration"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "PilotStatesId0"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PilotStatesId1"
                                                       IsNullable = true };
         Primitive { Type = Byte
                     Name = "PilotStatesId2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "PilotStatesId3"
                                                      IsNullable = true };
         Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                      Name = "PilotMultiSequenceDetailsSteps"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "StepDuration"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "PilotStatesId0"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "PilotStatesId1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "PilotStatesId2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "PilotStatesId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "PilotMultiSequenceDetailsStep"
        TargetTable =
         { Name = TableName "PilotMultiSequenceDetailsStep"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "PilotMultiSequenceDetailsStep"
        KeyType = Guid }] }-PilotMultiSequenceDetailsStep-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceDetailsSteps
                                    .Where(x => x.PilotMultiSequenceDetailsStep != null && ids.Contains((Guid)x.PilotMultiSequenceDetailsStep))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceDetailsStep!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceDetailsSteps);
                    });
            
        }
    }
}
            