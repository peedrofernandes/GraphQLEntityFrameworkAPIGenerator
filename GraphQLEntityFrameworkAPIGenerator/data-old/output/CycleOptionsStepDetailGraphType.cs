
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
    public partial class CycleOptionsStepDetailGraphType : ObjectGraphType<CycleOptionsStepDetail>
    {
        public CycleOptionsStepDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsStepDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Time1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time6, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time7, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time8, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId8, type: typeof(ByteGraphType), nullable: False);
            
                Field<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetailGraphType, CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail>("CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetailGraphType>>(
                            "{ Name = EntityName "CycleOptionsStepDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsStepDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsStepDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Int
                                                       Name = "UserPhaseNameId"
                                                       IsNullable = false };
         ForeignKey { Type = Short
                      Name = "InstructionId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "TableTypeId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumberOfLevels"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "Time1"
                                                      IsNullable = false };
         Primitive { Type = Float
                     Name = "Coefficient1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLevelId1"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Time2"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Coefficient2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLevelId2"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Time3"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Coefficient3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLevelId3"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Time4"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Coefficient4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLevelId4"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Time5"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Coefficient5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLevelId5"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Time6"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLevelId6"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Time7"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLevelId7"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Time8"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLevelId8"
                                                       IsNullable = false };
         Navigation
           { Type =
              TableName
                "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
             Name = "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "CycleOptionsStepDetailsId"
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
    { Name = "NumberOfLevels"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Time1"
                             Type = Primitive Float
                             IsNullable = false }; { Name = "Coefficient1"
                                                     Type = Primitive Float
                                                     IsNullable = false };
    { Name = "PowerLevelId1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Time2"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "Coefficient2"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "PowerLevelId2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Time3"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "Coefficient3"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "PowerLevelId3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Time4"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "Coefficient4"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "PowerLevelId4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Time5"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "Coefficient5"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "PowerLevelId5"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Time6"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "PowerLevelId6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Time7"
      Type = Primitive Float
      IsNullable = false }; { Name = "PowerLevelId7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Time8"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "PowerLevelId8"
      Type = Primitive Byte
      IsNullable = false }]
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
            