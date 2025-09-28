
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
    public partial class CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetailGraphType : ObjectGraphType<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail>
    {
        public CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsPrmStepsConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleOptionsStepDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<CycleOptionsPrmStepsConfigurationGraphType, CycleOptionsPrmStepsConfiguration>("CycleOptionsPrmStepsConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleOptionsPrmStepsConfigurationGraphType>(
                            "{ Name = EntityName "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsPrmStepsConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleOptionsStepDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "CycleOptionsPrmStepsConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleOptionsStepDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleOptionsPrmStepsConfiguration"
        TargetTable =
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
             Navigation
               { Type =
                  TableName
                    "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
                 Name =
                  "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsPrmStepsConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleOptionsStepDetail"
        TargetTable =
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
             ForeignKey { Type = Int
                          Name = "UserPhaseNameId"
                          IsNullable = false };
             ForeignKey { Type = Short
                          Name = "InstructionId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "TableTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Time1"
                                                          IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId1"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time2"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId2"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time3"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId3"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time4"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId4"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time5"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient5"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId5"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time6"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId6"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time7"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId7"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time8"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId8"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
                 Name =
                  "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsStepDetail"
        IsNullable = false
        KeyType = Guid }] }-CycleOptionsPrmStepsConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsPrmStepsConfigurations
                                    .Where(x => x.CycleOptionsPrmStepsConfiguration != null && ids.Contains((Guid)x.CycleOptionsPrmStepsConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsPrmStepsConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsPrmStepsConfiguration);
                });
            
			
                Field<CycleOptionsStepDetailGraphType, CycleOptionsStepDetail>("CycleOptionsStepDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleOptionsStepDetailGraphType>(
                            "{ Name = EntityName "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsPrmStepsConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleOptionsStepDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "CycleOptionsPrmStepsConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleOptionsStepDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleOptionsPrmStepsConfiguration"
        TargetTable =
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
             Navigation
               { Type =
                  TableName
                    "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
                 Name =
                  "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsPrmStepsConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleOptionsStepDetail"
        TargetTable =
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
             ForeignKey { Type = Int
                          Name = "UserPhaseNameId"
                          IsNullable = false };
             ForeignKey { Type = Short
                          Name = "InstructionId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "TableTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Time1"
                                                          IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId1"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time2"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId2"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time3"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId3"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time4"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId4"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time5"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient5"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId5"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time6"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId6"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time7"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId7"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Time8"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLevelId8"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail"
                 Name =
                  "CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsStepDetail"
        IsNullable = false
        KeyType = Guid }] }-CycleOptionsStepDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsStepDetails
                                    .Where(x => x.CycleOptionsStepDetail != null && ids.Contains((Guid)x.CycleOptionsStepDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsStepDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsStepDetail);
                });
            
        }
    }
}
            