
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
    public partial class CycleTimeOptionsDisplayBehaviorLabelGraphType : ObjectGraphType<CycleTimeOptionsDisplayBehaviorLabel>
    {
        public CycleTimeOptionsDisplayBehaviorLabelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Behavior, type: typeof(StringGraphType), nullable: False);
            
                Field<CycleOptionsPrmTimeGraphType, CycleOptionsPrmTime>("CycleOptionsPrmTimes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsPrmTimeGraphType>>(
                            "{ Name = EntityName "CycleTimeOptionsDisplayBehaviorLabel"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleTimeOptionsDisplayBehaviorLabel"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Behavior"
                                                        IsNullable = false };
         Navigation { Type = TableName "CycleOptionsPrmTime"
                      Name = "CycleOptionsPrmTimes"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "Id"
              Type = Id Byte
              IsNullable = false }; { Name = "Behavior"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleOptionsPrmTime"
        TargetTable =
         { Name = TableName "CycleOptionsPrmTime"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeOptionsId"
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
                         Name = "NumberOfSelections"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "UserCookTimeSelectionBehavior"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "UserCookTimeDisplayBehavior"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "UserCookTime1"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "UserCookTime2"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "UserCookTime3"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "UserCookTime4"
                         IsNullable = true }; Primitive { Type = Int
                                                          Name = "UserCookTime5"
                                                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserCookTime6"
                         IsNullable = true }; Primitive { Type = Int
                                                          Name = "Step"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "Units"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "UserCookTimeDefaultSelection"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Name1"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Name2"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Name3"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Name4"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Name5"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Name6"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NameDefault"
                                                           IsNullable = false };
             Navigation
               { Type = TableName "CycleTimeOptionsDisplayBehaviorLabel"
                 Name = "UserCookTimeDisplayBehaviorNavigation"
                 IsNullable = false
                 IsCollection = false };
             Navigation
               { Type = TableName "CycleTimeOptionsSelectionBehaviorLabel"
                 Name = "UserCookTimeSelectionBehaviorNavigation"
                 IsNullable = false
                 IsCollection = false }] }
        Destination = EntityName "CycleOptionsPrmTime"
        KeyType = Guid }] }-CycleOptionsPrmTime-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsPrmTimes
                                    .Where(x => x.CycleOptionsPrmTime != null && ids.Contains((Guid)x.CycleOptionsPrmTime))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsPrmTime!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsPrmTimes);
                    });
            
        }
    }
}
            