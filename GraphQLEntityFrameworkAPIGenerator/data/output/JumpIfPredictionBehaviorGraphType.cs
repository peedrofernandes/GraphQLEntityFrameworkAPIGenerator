
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
    public partial class JumpIfPredictionBehaviorGraphType : ObjectGraphType<JumpIfPredictionBehavior>
    {
        public JumpIfPredictionBehaviorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.JumpIfPredictionBehaviorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.JumpIfPredictionBehaviorDescription, type: typeof(StringGraphType), nullable: False);
            
                Field<StmJumpIfGraphType, StmJumpIf>("StmJumpIfs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmJumpIfGraphType>>(
                            "{ Name = EntityName "JumpIfPredictionBehavior"
  CorrespondingTable =
   Regular
     { Name = TableName "JumpIfPredictionBehavior"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "JumpIfPredictionBehaviorId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "JumpIfPredictionBehaviorDescription"
                     IsNullable = false };
         Navigation { Type = TableName "StmJumpIf"
                      Name = "StmJumpIfs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "JumpIfPredictionBehaviorId"
      Type = Id Byte
      IsNullable = false }; { Name = "JumpIfPredictionBehaviorDescription"
                              Type = Primitive String
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "StmJumpIf"
        TargetTable =
         { Name = TableName "StmJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "DestinationCycle"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationCycleLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationPhase"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationPhaseLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationStep"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ConditionId"
                                                            IsNullable = true };
             Primitive { Type = Bool
                         Name = "WithReturn"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DestinationStepLabel"
                         IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "JumpIfPredictionBehavior"
                          Name = "JumpIfPredictionBehavior"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmJumpIf"
        KeyType = Guid }] }-StmJumpIf-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmJumpIfs
                                    .Where(x => x.StmJumpIf != null && ids.Contains((Guid)x.StmJumpIf))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmJumpIf!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmJumpIfs);
                    });
            
        }
    }
}
            