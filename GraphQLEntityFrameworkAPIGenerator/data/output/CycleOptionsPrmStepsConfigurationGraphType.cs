
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
    public partial class CycleOptionsPrmStepsConfigurationGraphType : ObjectGraphType<CycleOptionsPrmStepsConfiguration>
    {
        public CycleOptionsPrmStepsConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsPrmStepsConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetailGraphType, CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail>("CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetailGraphType>>(
                            "{ Name = EntityName "CycleOptionsPrmStepsConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsPrmStepsConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsPrmStepsConfigId"
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
         Navigation
           { Type =
              TableName
                "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
             Name = "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "CycleOptionsPrmStepsConfigId"
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
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name =
         RelationName "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
        TargetTable =
         { Name =
            TableName "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsPrmStepsConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleOptionsStepDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CycleOptionsPrmStepsConfiguration"
                          Name = "CycleOptionsPrmStepsConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleOptionsStepDetail"
                          Name = "CycleOptionsStepDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
        KeyType = Guid }] }-CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails
                                    .Where(x => x.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail != null && ids.Contains((Guid)x.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails);
                    });
            
        }
    }
}
            