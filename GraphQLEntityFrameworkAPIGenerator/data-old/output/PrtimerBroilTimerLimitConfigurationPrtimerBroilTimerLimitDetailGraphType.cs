
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
    public partial class PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetailGraphType : ObjectGraphType<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail>
    {
        public PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerBroilTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerBroilTimerLimitConfigurationGraphType, PrtimerBroilTimerLimitConfiguration>("PrtimerBroilTimerLimitConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilTimerLimitConfigurationGraphType>(
                            "{ Name =
   EntityName "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                      Name = "PrtimerBroilTimerLimitConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerBroilTimerLimitDetail"
                      Name = "PrtimerBroilTimerLimitDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerBroilTimerLimitDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
                 Name =
                  "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerLimitConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerLimitDetail"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "TimerLimit"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
                 Name =
                  "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerLimitDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerBroilTimerLimitConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilTimerLimitConfigurations
                                    .Where(x => x.PrtimerBroilTimerLimitConfiguration != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilTimerLimitConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitConfiguration);
                });
            
			
                Field<PrtimerBroilTimerLimitDetailGraphType, PrtimerBroilTimerLimitDetail>("PrtimerBroilTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilTimerLimitDetailGraphType>(
                            "{ Name =
   EntityName "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                      Name = "PrtimerBroilTimerLimitConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerBroilTimerLimitDetail"
                      Name = "PrtimerBroilTimerLimitDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerBroilTimerLimitDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
                 Name =
                  "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerLimitConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerLimitDetail"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "TimerLimit"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
                 Name =
                  "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerLimitDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerBroilTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilTimerLimitDetails
                                    .Where(x => x.PrtimerBroilTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitDetail);
                });
            
        }
    }
}
            