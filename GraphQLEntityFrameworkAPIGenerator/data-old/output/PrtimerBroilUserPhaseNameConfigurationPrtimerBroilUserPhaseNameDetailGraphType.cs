
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
    public partial class PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail>
    {
        public PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerBroilUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerBroilUserPhaseNameConfigurationGraphType, PrtimerBroilUserPhaseNameConfiguration>("PrtimerBroilUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilUserPhaseNameConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                      Name = "PrtimerBroilUserPhaseNameConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerBroilUserPhaseNameDetail"
                      Name = "PrtimerBroilUserPhaseNameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilUserPhaseNameConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerBroilUserPhaseNameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
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
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
                 Name =
                  "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilUserPhaseNameDetail"
        TargetTable =
         { Name = TableName "PrtimerBroilUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "TimerIncrement"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PowerLimit"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
                 Name =
                  "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilUserPhaseNameDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerBroilUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerBroilUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerBroilUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameConfiguration);
                });
            
			
                Field<PrtimerBroilUserPhaseNameDetailGraphType, PrtimerBroilUserPhaseNameDetail>("PrtimerBroilUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilUserPhaseNameDetailGraphType>(
                            "{ Name =
   EntityName
     "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                      Name = "PrtimerBroilUserPhaseNameConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerBroilUserPhaseNameDetail"
                      Name = "PrtimerBroilUserPhaseNameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilUserPhaseNameConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerBroilUserPhaseNameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
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
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
                 Name =
                  "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilUserPhaseNameDetail"
        TargetTable =
         { Name = TableName "PrtimerBroilUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "TimerIncrement"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PowerLimit"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
                 Name =
                  "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilUserPhaseNameDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerBroilUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilUserPhaseNameDetails
                                    .Where(x => x.PrtimerBroilUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerBroilUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameDetail);
                });
            
        }
    }
}
            