
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
    public partial class PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetailGraphType : ObjectGraphType<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail>
    {
        public PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerConvectTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerConvectTimerLimitConfigurationGraphType, PrtimerConvectTimerLimitConfiguration>("PrtimerConvectTimerLimitConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectTimerLimitConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerLimitConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerLimitDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                      Name = "PrtimerConvectTimerLimitConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerConvectTimerLimitDetail"
                      Name = "PrtimerConvectTimerLimitDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerConvectTimerLimitDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
                 Name =
                  "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerLimitConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerLimitDetail"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "TimerLimit"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
                 Name =
                  "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerLimitDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerConvectTimerLimitConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectTimerLimitConfigurations
                                    .Where(x => x.PrtimerConvectTimerLimitConfiguration != null && ids.Contains((Guid)x.PrtimerConvectTimerLimitConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectTimerLimitConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectTimerLimitConfiguration);
                });
            
			
                Field<PrtimerConvectTimerLimitDetailGraphType, PrtimerConvectTimerLimitDetail>("PrtimerConvectTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectTimerLimitDetailGraphType>(
                            "{ Name =
   EntityName
     "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerLimitConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerLimitDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                      Name = "PrtimerConvectTimerLimitConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerConvectTimerLimitDetail"
                      Name = "PrtimerConvectTimerLimitDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerConvectTimerLimitDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
                 Name =
                  "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerLimitConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerLimitDetail"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "TimerLimit"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
                 Name =
                  "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerLimitDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerConvectTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectTimerLimitDetails
                                    .Where(x => x.PrtimerConvectTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerConvectTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectTimerLimitDetail);
                });
            
        }
    }
}
            