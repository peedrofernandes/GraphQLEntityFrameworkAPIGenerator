
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
    public partial class PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetailGraphType : ObjectGraphType<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail>
    {
        public PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerMagnetronTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerMagnetronTimerLimitConfigurationGraphType, PrtimerMagnetronTimerLimitConfiguration>("PrtimerMagnetronTimerLimitConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronTimerLimitConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronTimerLimitConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronTimerLimitDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                      Name = "PrtimerMagnetronTimerLimitConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerMagnetronTimerLimitDetail"
                      Name = "PrtimerMagnetronTimerLimitDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerMagnetronTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerMagnetronTimerLimitDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
                 Name =
                  "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerLimitConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerLimitDetail"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "TimerLimit"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
                 Name =
                  "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerLimitDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerMagnetronTimerLimitConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronTimerLimitConfigurations
                                    .Where(x => x.PrtimerMagnetronTimerLimitConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronTimerLimitConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronTimerLimitConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronTimerLimitConfiguration);
                });
            
			
                Field<PrtimerMagnetronTimerLimitDetailGraphType, PrtimerMagnetronTimerLimitDetail>("PrtimerMagnetronTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronTimerLimitDetailGraphType>(
                            "{ Name =
   EntityName
     "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronTimerLimitConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronTimerLimitDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                      Name = "PrtimerMagnetronTimerLimitConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerMagnetronTimerLimitDetail"
                      Name = "PrtimerMagnetronTimerLimitDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerMagnetronTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerMagnetronTimerLimitDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
                 Name =
                  "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerLimitConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerLimitDetail"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "TimerLimit"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
                 Name =
                  "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerLimitDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerMagnetronTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronTimerLimitDetails
                                    .Where(x => x.PrtimerMagnetronTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerMagnetronTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronTimerLimitDetail);
                });
            
        }
    }
}
            