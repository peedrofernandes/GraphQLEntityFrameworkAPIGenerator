
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
    public partial class PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration>
    {
        public PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerMagnetronUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerMagnetronConfigurationGraphType, PrtimerMagnetronConfiguration>("PrtimerMagnetronConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronUserPhaseNameConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                      Name = "PrtimerMagnetronConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
             Name = "PrtimerMagnetronUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerMagnetronConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerMagnetronUserPhaseNameConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
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
             Primitive { Type = Short
                         Name = "UserPhaseName"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
                 Name =
                  "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid }] }-PrtimerMagnetronConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronConfigurations
                                    .Where(x => x.PrtimerMagnetronConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronConfiguration);
                });
            
			
                Field<PrtimerMagnetronUserPhaseNameConfigurationGraphType, PrtimerMagnetronUserPhaseNameConfiguration>("PrtimerMagnetronUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronUserPhaseNameConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronUserPhaseNameConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                      Name = "PrtimerMagnetronConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
             Name = "PrtimerMagnetronUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerMagnetronConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerMagnetronUserPhaseNameConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
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
             Primitive { Type = Short
                         Name = "UserPhaseName"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
                 Name =
                  "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid }] }-PrtimerMagnetronUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerMagnetronUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameConfiguration);
                });
            
        }
    }
}
            